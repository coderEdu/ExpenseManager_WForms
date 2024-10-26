namespace ExpenseManager
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.movimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPENSE_MANAGERDataSet = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.movimientosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_date2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.cbx_accounts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date1 = new System.Windows.Forms.Label();
            this.check_date1 = new System.Windows.Forms.CheckBox();
            this.check_date2 = new System.Windows.Forms.CheckBox();
            this.movimientosTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter();
            this.tableAdapterManager = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.TableAdapterManager();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter();
            this.lbl_records = new System.Windows.Forms.Label();
            this.lbl_cant_records = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSE_MANAGERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // movimientosBindingSource
            // 
            this.movimientosBindingSource.DataMember = "movimientos";
            this.movimientosBindingSource.DataSource = this.eXPENSE_MANAGERDataSet;
            // 
            // eXPENSE_MANAGERDataSet
            // 
            this.eXPENSE_MANAGERDataSet.DataSetName = "EXPENSE_MANAGERDataSet";
            this.eXPENSE_MANAGERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movimientosDataGridView
            // 
            this.movimientosDataGridView.AllowUserToAddRows = false;
            this.movimientosDataGridView.AllowUserToDeleteRows = false;
            this.movimientosDataGridView.AutoGenerateColumns = false;
            this.movimientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movimientosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.movimientosDataGridView.DataSource = this.movimientosBindingSource;
            this.movimientosDataGridView.Location = new System.Drawing.Point(12, 209);
            this.movimientosDataGridView.Name = "movimientosDataGridView";
            this.movimientosDataGridView.ReadOnly = true;
            this.movimientosDataGridView.RowHeadersVisible = false;
            this.movimientosDataGridView.RowHeadersWidth = 45;
            this.movimientosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movimientosDataGridView.Size = new System.Drawing.Size(692, 266);
            this.movimientosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Format = "F";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn4.HeaderText = "monto";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "saldo_cuenta";
            this.dataGridViewTextBoxColumn5.HeaderText = "saldo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "concepto";
            this.dataGridViewTextBoxColumn6.HeaderText = "concepto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 230;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_usuario";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_usuario";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_cuenta";
            this.dataGridViewTextBoxColumn8.HeaderText = "id_cuenta";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // lbl_date2
            // 
            this.lbl_date2.AutoSize = true;
            this.lbl_date2.Location = new System.Drawing.Point(486, 51);
            this.lbl_date2.Name = "lbl_date2";
            this.lbl_date2.Size = new System.Drawing.Size(46, 13);
            this.lbl_date2.TabIndex = 2;
            this.lbl_date2.Text = "Fecha 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(141, 136);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(65, 20);
            this.txt_monto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto";
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(266, 136);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(148, 20);
            this.txt_concepto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Concepto";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "dep",
            "ext",
            "tra"});
            this.cbx_tipo.Location = new System.Drawing.Point(17, 136);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(46, 21);
            this.cbx_tipo.TabIndex = 10;
            // 
            // cbx_accounts
            // 
            this.cbx_accounts.FormattingEnabled = true;
            this.cbx_accounts.Location = new System.Drawing.Point(14, 66);
            this.cbx_accounts.Name = "cbx_accounts";
            this.cbx_accounts.Size = new System.Drawing.Size(155, 21);
            this.cbx_accounts.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cuenta";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(629, 176);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 27);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dTP1
            // 
            this.dTP1.Location = new System.Drawing.Point(215, 66);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(213, 20);
            this.dTP1.TabIndex = 14;
            // 
            // dTP2
            // 
            this.dTP2.Location = new System.Drawing.Point(489, 66);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(213, 20);
            this.dTP2.TabIndex = 16;
            // 
            // lbl_date1
            // 
            this.lbl_date1.AutoSize = true;
            this.lbl_date1.Location = new System.Drawing.Point(214, 51);
            this.lbl_date1.Name = "lbl_date1";
            this.lbl_date1.Size = new System.Drawing.Size(46, 13);
            this.lbl_date1.TabIndex = 15;
            this.lbl_date1.Text = "Fecha 1";
            // 
            // check_date1
            // 
            this.check_date1.AutoSize = true;
            this.check_date1.Location = new System.Drawing.Point(414, 51);
            this.check_date1.Name = "check_date1";
            this.check_date1.Size = new System.Drawing.Size(15, 14);
            this.check_date1.TabIndex = 17;
            this.check_date1.UseVisualStyleBackColor = true;
            this.check_date1.CheckedChanged += new System.EventHandler(this.check_date1_CheckedChanged);
            // 
            // check_date2
            // 
            this.check_date2.AutoSize = true;
            this.check_date2.Location = new System.Drawing.Point(689, 51);
            this.check_date2.Name = "check_date2";
            this.check_date2.Size = new System.Drawing.Size(15, 14);
            this.check_date2.TabIndex = 18;
            this.check_date2.UseVisualStyleBackColor = true;
            this.check_date2.CheckedChanged += new System.EventHandler(this.check_date2_CheckedChanged);
            // 
            // movimientosTableAdapter
            // 
            this.movimientosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cuentasTableAdapter = null;
            this.tableAdapterManager.movimientosTableAdapter = this.movimientosTableAdapter;
            this.tableAdapterManager.notasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataMember = "cuentas";
            this.cuentasBindingSource.DataSource = this.eXPENSE_MANAGERDataSet;
            // 
            // cuentasTableAdapter
            // 
            this.cuentasTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_records
            // 
            this.lbl_records.AutoSize = true;
            this.lbl_records.Location = new System.Drawing.Point(9, 189);
            this.lbl_records.Name = "lbl_records";
            this.lbl_records.Size = new System.Drawing.Size(54, 13);
            this.lbl_records.TabIndex = 19;
            this.lbl_records.Text = "Registros:";
            // 
            // lbl_cant_records
            // 
            this.lbl_cant_records.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant_records.ForeColor = System.Drawing.Color.Red;
            this.lbl_cant_records.Location = new System.Drawing.Point(66, 189);
            this.lbl_cant_records.Name = "lbl_cant_records";
            this.lbl_cant_records.Size = new System.Drawing.Size(54, 13);
            this.lbl_cant_records.TabIndex = 20;
            this.lbl_cant_records.Text = "0";
            // 
            // Main
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 487);
            this.Controls.Add(this.lbl_cant_records);
            this.Controls.Add(this.lbl_records);
            this.Controls.Add(this.check_date2);
            this.Controls.Add(this.check_date1);
            this.Controls.Add(this.dTP2);
            this.Controls.Add(this.lbl_date1);
            this.Controls.Add(this.dTP1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cbx_accounts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.txt_concepto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_date2);
            this.Controls.Add(this.movimientosDataGridView);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSE_MANAGERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EXPENSE_MANAGERDataSet eXPENSE_MANAGERDataSet;
        private System.Windows.Forms.BindingSource movimientosBindingSource;
        private EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter movimientosTableAdapter;
        private EXPENSE_MANAGERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView movimientosDataGridView;
        private System.Windows.Forms.Label lbl_date2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.ComboBox cbx_accounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.Label lbl_date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.CheckBox check_date1;
        private System.Windows.Forms.CheckBox check_date2;
        private System.Windows.Forms.Label lbl_records;
        private System.Windows.Forms.Label lbl_cant_records;
    }
}