namespace DapperContrib.Gen.Entity
{
    public class Connection
    {
        public string Server { get; set; }

        public string InitialCatalog { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string _ConnectionString => $@"Password={Password};User ID={User};Initial Catalog={InitialCatalog};Data Source={Server}";
    }
}
