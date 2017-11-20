namespace DapperContrib.Gen.frm
{
    partial class frmSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
            this.gbDataBase = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCollumn = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.txUser = new System.Windows.Forms.TextBox();
            this.txInitialCatalog = new System.Windows.Forms.TextBox();
            this.txServer = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGen = new System.Windows.Forms.Button();
            this.gbDataBase.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollumn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDataBase
            // 
            this.gbDataBase.Controls.Add(this.groupBox3);
            this.gbDataBase.Controls.Add(this.groupBox2);
            this.gbDataBase.Controls.Add(this.groupBox1);
            this.gbDataBase.Location = new System.Drawing.Point(12, 12);
            this.gbDataBase.Name = "gbDataBase";
            this.gbDataBase.Size = new System.Drawing.Size(1091, 523);
            this.gbDataBase.TabIndex = 0;
            this.gbDataBase.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btGen);
            this.groupBox3.Controls.Add(this.dgvCollumn);
            this.groupBox3.Location = new System.Drawing.Point(356, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 498);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colunas";
            // 
            // dgvCollumn
            // 
            this.dgvCollumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollumn.Location = new System.Drawing.Point(6, 19);
            this.dgvCollumn.Name = "dgvCollumn";
            this.dgvCollumn.Size = new System.Drawing.Size(723, 444);
            this.dgvCollumn.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTables);
            this.groupBox2.Location = new System.Drawing.Point(7, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabelas";
            // 
            // dgvTables
            // 
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new System.Drawing.Point(6, 19);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.Size = new System.Drawing.Size(331, 267);
            this.dgvTables.TabIndex = 0;
            this.dgvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTables_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txPass);
            this.groupBox1.Controls.Add(this.txUser);
            this.groupBox1.Controls.Add(this.txInitialCatalog);
            this.groupBox1.Controls.Add(this.txServer);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server";
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(80, 121);
            this.txPass.Name = "txPass";
            this.txPass.Size = new System.Drawing.Size(231, 20);
            this.txPass.TabIndex = 8;
            this.txPass.Text = "usr_banco_teste";
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(80, 86);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(231, 20);
            this.txUser.TabIndex = 7;
            this.txUser.Text = "usr_banco_teste";
            // 
            // txInitialCatalog
            // 
            this.txInitialCatalog.Location = new System.Drawing.Point(80, 56);
            this.txInitialCatalog.Name = "txInitialCatalog";
            this.txInitialCatalog.Size = new System.Drawing.Size(231, 20);
            this.txInitialCatalog.TabIndex = 6;
            this.txInitialCatalog.Text = "banco_teste";
            // 
            // txServer
            // 
            this.txServer.Location = new System.Drawing.Point(80, 27);
            this.txServer.Name = "txServer";
            this.txServer.Size = new System.Drawing.Size(231, 20);
            this.txServer.TabIndex = 5;
            this.txServer.Text = "localhost\\SQLEXPRESS";
            // 
            // btnConectar
            // 
            this.btnConectar.AutoEllipsis = true;
            this.btnConectar.Location = new System.Drawing.Point(125, 154);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Catalog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // btGen
            // 
            this.btGen.Location = new System.Drawing.Point(654, 469);
            this.btGen.Name = "btGen";
            this.btGen.Size = new System.Drawing.Size(75, 23);
            this.btGen.TabIndex = 1;
            this.btGen.Text = "Generate";
            this.btGen.UseVisualStyleBackColor = true;
            this.btGen.Click += new System.EventHandler(this.btGen_Click);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 547);
            this.Controls.Add(this.gbDataBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetup";
            this.Text = "DapperContrib Gen";
            this.gbDataBase.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollumn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.TextBox txInitialCatalog;
        private System.Windows.Forms.TextBox txServer;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCollumn;
        private System.Windows.Forms.Button btGen;
    }
}