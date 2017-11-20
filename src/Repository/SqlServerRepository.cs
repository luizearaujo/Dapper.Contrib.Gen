using DapperContrib.Gen.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DapperContrib.Gen.Repository
{
    public class SqlServerRepository
    {
        private string _ConnectionString { get; set; }

        public SqlServerRepository(string _connectionString)
        {
            _ConnectionString = _connectionString;
        }

        public List<Table> GetDataBaseObjects(string initialCatalog)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(_ConnectionString))
            {

                var result = new List<Table>();

                var query = $@"SELECT 
	upper(c.COLUMN_NAME) as Name, 
	case c.IS_NULLABLE 
		when 'YES' then 1 
		else 0 
	end as IsNullable, 
	upper(c.DATA_TYPE) as DataType, 
	cast(ISNULL(c.NUMERIC_PRECISION,0) as numeric) as Size, 
	cast(ISNULL(c.NUMERIC_SCALE,0) as numeric) as Precision, 
	upper(c.TABLE_NAME) as TableName,
	c.TABLE_SCHEMA as TableSchema,
	case OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA + '.' + QUOTENAME(CONSTRAINT_NAME)), 'IsPrimaryKey')
	when 1 then 1 else 0 end as PrimaryKey
FROM information_schema.columns c
left join INFORMATION_SCHEMA.KEY_COLUMN_USAGE p
on c.TABLE_NAME = p.TABLE_NAME 
and c.COLUMN_NAME = p.COLUMN_NAME
where c.table_catalog = '{initialCatalog}'
order by c.ordinal_position";


                var cmd = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlDataReader reader;

                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();

                var columns = new List<Entity.Column>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var c = new Column
                        {
                            Name = reader.GetString(0),
                            IsNullable = Convert.ToBoolean(reader.GetInt32(1)),
                            DataType = reader.GetString(2),
                            Size = (int)reader.GetDecimal(3),
                            Precision = (int)reader.GetDecimal(4),
                            TableName = reader.GetString(5),
                            Schema = reader.GetString(6),
                            PrimaryKey = Convert.ToBoolean(reader.GetInt32(7))
                        };

                        columns.Add(c);
                    }
                }

                conn.Close();
                conn.Open();
                for (int i = 0; i < conn.GetSchema("Tables").Rows.Count; i++)
                {
                    var tableName = conn.GetSchema("Tables").Rows[i][2].ToString().ToUpper();
                    var filteredColumns = columns.Where(x => x.TableName.Equals(tableName)).ToList();
                    result.Add(new Entity.Table
                    {
                        Schema = conn.GetSchema("Tables").Rows[i][1].ToString(),
                        Name = tableName,
                        Columns = filteredColumns
                    });
                }

                return result;
            }

        }

    }
}
