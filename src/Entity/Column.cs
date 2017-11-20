namespace DapperContrib.Gen.Entity
{
    public class Column
    {
        public string Name { get; set; }

        public bool IsNullable { get; set; }

        public string DataType { get; set; }

        public int Size { get; set; }

        public int Precision { get; set; }

        public bool PrimaryKey { get; set; }

        public string Schema { get; internal set; }
        
        public string TableName { get; set; }
    }
}
