using System.Collections.Generic;

namespace DapperContrib.Gen.Entity
{
    public class Table
    {
        public string Schema { get; set; }

        public string Name { get; set; }

        public List<Column> Columns { get; set; }
    }
}
