using DapperContrib.Gen.CodeDOM;
using DapperContrib.Gen.Entity;
using DapperContrib.Gen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DapperContrib.Gen.frm
{
    public partial class frmSetup : Form
    {

        private Connection Connection { get; set; }

        private List<Table> Tables { get; set; } = new List<Table>();

        private Table TableSelected { get; set; } = new Table();


        public frmSetup()
        {
            InitializeComponent();


        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Connection = new Connection
            {
                InitialCatalog = txInitialCatalog.Text,
                Password = txPass.Text,
                Server = txServer.Text,
                User = txUser.Text
            };

            try
            {
                var sqlRepository = new SqlServerRepository(Connection._ConnectionString);
                Tables = sqlRepository.GetDataBaseObjects(Connection.InitialCatalog);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao obter os objetos de banco. {ex.Message}.");
            }


            dgvTables.DataSource = Tables;

        }

        private void dgvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var row = dgvTables.Rows[rowIndex];
            var tableName = row.Cells[1].Value;

            TableSelected = Tables.FirstOrDefault(x => x.Name.Equals(tableName));
            var columns = TableSelected.Columns;
            dgvCollumn.DataSource = columns;
        }

        private void btGen_Click(object sender, EventArgs e)
        {
            try
            {
                var codeGen = new CodeGen();
                codeGen.Gen(TableSelected);
                MessageBox.Show(@"Classes geradas em c:\temp");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar as classes. {ex.Message}.");
            }
        }
    }
}
