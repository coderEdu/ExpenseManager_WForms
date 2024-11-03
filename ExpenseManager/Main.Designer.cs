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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_search = new System.Windows.Forms.Button();
            this.movimientosTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter();
            this.tableAdapterManager = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.TableAdapterManager();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter();
            this.lbl_records = new System.Windows.Forms.Label();
            this.lbl_cant_records = new System.Windows.Forms.Label();
            this.btn_show_query = new System.Windows.Forms.Button();
            this.lbl_concept_text = new System.Windows.Forms.Label();
            this.group_filters = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_date2 = new System.Windows.Forms.CheckBox();
            this.check_date1 = new System.Windows.Forms.CheckBox();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date1 = new System.Windows.Forms.Label();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.cbx_accounts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_date2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSE_MANAGERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            this.group_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movimientosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.movimientosDataGridView.ColumnHeadersHeight = 26;
            this.movimientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.movimientosDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.movimientosDataGridView.EnableHeadersVisualStyles = false;
            this.movimientosDataGridView.Location = new System.Drawing.Point(15, 261);
            this.movimientosDataGridView.Name = "movimientosDataGridView";
            this.movimientosDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movimientosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.movimientosDataGridView.RowHeadersVisible = false;
            this.movimientosDataGridView.RowHeadersWidth = 45;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.movimientosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movimientosDataGridView.Size = new System.Drawing.Size(603, 292);
            this.movimientosDataGridView.TabIndex = 1;
            this.movimientosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movimientosDataGridView_CellClick);
            this.movimientosDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.movimientosDataGridView_CellEnter);
            this.movimientosDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.movimientosDataGridView_RowPostPaint);
            this.movimientosDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.movimientosDataGridView_RowStateChanged);
            this.movimientosDataGridView.Enter += new System.EventHandler(this.movimientosDataGridView_Enter);
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
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 55;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "monto";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 112;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "saldo_cuenta";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "saldo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 112;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "concepto";
            this.dataGridViewTextBoxColumn6.HeaderText = "concepto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
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
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search.Location = new System.Drawing.Point(757, 114);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(136, 42);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.lbl_records.Location = new System.Drawing.Point(12, 240);
            this.lbl_records.Name = "lbl_records";
            this.lbl_records.Size = new System.Drawing.Size(54, 13);
            this.lbl_records.TabIndex = 19;
            this.lbl_records.Text = "Registros:";
            // 
            // lbl_cant_records
            // 
            this.lbl_cant_records.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant_records.ForeColor = System.Drawing.Color.Red;
            this.lbl_cant_records.Location = new System.Drawing.Point(69, 239);
            this.lbl_cant_records.Name = "lbl_cant_records";
            this.lbl_cant_records.Size = new System.Drawing.Size(54, 17);
            this.lbl_cant_records.TabIndex = 20;
            this.lbl_cant_records.Text = "0";
            // 
            // btn_show_query
            // 
            this.btn_show_query.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_query.Location = new System.Drawing.Point(15, 7);
            this.btn_show_query.Name = "btn_show_query";
            this.btn_show_query.Size = new System.Drawing.Size(163, 37);
            this.btn_show_query.TabIndex = 21;
            this.btn_show_query.Text = "Mostrar Consulta";
            this.btn_show_query.UseVisualStyleBackColor = true;
            this.btn_show_query.Click += new System.EventHandler(this.btn_show_query_Click);
            // 
            // lbl_concept_text
            // 
            this.lbl_concept_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_concept_text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_concept_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_concept_text.Location = new System.Drawing.Point(624, 261);
            this.lbl_concept_text.Name = "lbl_concept_text";
            this.lbl_concept_text.Size = new System.Drawing.Size(290, 292);
            this.lbl_concept_text.TabIndex = 22;
            this.lbl_concept_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_filters
            // 
            this.group_filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.group_filters.Controls.Add(this.pictureBox1);
            this.group_filters.Controls.Add(this.check_date2);
            this.group_filters.Controls.Add(this.check_date1);
            this.group_filters.Controls.Add(this.dTP2);
            this.group_filters.Controls.Add(this.lbl_date1);
            this.group_filters.Controls.Add(this.btn_search);
            this.group_filters.Controls.Add(this.dTP1);
            this.group_filters.Controls.Add(this.cbx_accounts);
            this.group_filters.Controls.Add(this.label5);
            this.group_filters.Controls.Add(this.cbx_tipo);
            this.group_filters.Controls.Add(this.txt_concepto);
            this.group_filters.Controls.Add(this.label4);
            this.group_filters.Controls.Add(this.txt_monto);
            this.group_filters.Controls.Add(this.label3);
            this.group_filters.Controls.Add(this.label2);
            this.group_filters.Controls.Add(this.lbl_date2);
            this.group_filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_filters.Location = new System.Drawing.Point(15, 58);
            this.group_filters.Name = "group_filters";
            this.group_filters.Size = new System.Drawing.Size(899, 166);
            this.group_filters.TabIndex = 23;
            this.group_filters.TabStop = false;
            this.group_filters.Text = "Filtros de búsqueda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExpenseManager.Properties.Resources.Loupe_icon;
            this.pictureBox1.Location = new System.Drawing.Point(842, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // check_date2
            // 
            this.check_date2.AutoSize = true;
            this.check_date2.Location = new System.Drawing.Point(680, 101);
            this.check_date2.Name = "check_date2";
            this.check_date2.Size = new System.Drawing.Size(15, 14);
            this.check_date2.TabIndex = 32;
            this.check_date2.UseVisualStyleBackColor = true;
            this.check_date2.CheckedChanged += new System.EventHandler(this.check_date2_CheckedChanged);
            // 
            // check_date1
            // 
            this.check_date1.AutoSize = true;
            this.check_date1.Location = new System.Drawing.Point(682, 23);
            this.check_date1.Name = "check_date1";
            this.check_date1.Size = new System.Drawing.Size(15, 14);
            this.check_date1.TabIndex = 31;
            this.check_date1.UseVisualStyleBackColor = true;
            this.check_date1.CheckedChanged += new System.EventHandler(this.check_date1_CheckedChanged);
            // 
            // dTP2
            // 
            this.dTP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP2.Location = new System.Drawing.Point(427, 116);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(266, 23);
            this.dTP2.TabIndex = 30;
            // 
            // lbl_date1
            // 
            this.lbl_date1.AutoSize = true;
            this.lbl_date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date1.Location = new System.Drawing.Point(424, 22);
            this.lbl_date1.Name = "lbl_date1";
            this.lbl_date1.Size = new System.Drawing.Size(51, 15);
            this.lbl_date1.TabIndex = 29;
            this.lbl_date1.Text = "Fecha 1";
            // 
            // dTP1
            // 
            this.dTP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP1.Location = new System.Drawing.Point(427, 38);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(268, 23);
            this.dTP1.TabIndex = 28;
            // 
            // cbx_accounts
            // 
            this.cbx_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_accounts.FormattingEnabled = true;
            this.cbx_accounts.Location = new System.Drawing.Point(24, 49);
            this.cbx_accounts.Name = "cbx_accounts";
            this.cbx_accounts.Size = new System.Drawing.Size(228, 25);
            this.cbx_accounts.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cuenta";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "dep",
            "ext",
            "tra",
            "rec"});
            this.cbx_tipo.Location = new System.Drawing.Point(300, 49);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(68, 25);
            this.cbx_tipo.TabIndex = 25;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_concepto.Location = new System.Drawing.Point(178, 114);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(190, 23);
            this.txt_concepto.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Concepto";
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(24, 114);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(101, 23);
            this.txt_monto.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipo";
            // 
            // lbl_date2
            // 
            this.lbl_date2.AutoSize = true;
            this.lbl_date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date2.Location = new System.Drawing.Point(427, 101);
            this.lbl_date2.Name = "lbl_date2";
            this.lbl_date2.Size = new System.Drawing.Size(51, 15);
            this.lbl_date2.TabIndex = 19;
            this.lbl_date2.Text = "Fecha 2";
            // 
            // Main
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 568);
            this.Controls.Add(this.lbl_concept_text);
            this.Controls.Add(this.btn_show_query);
            this.Controls.Add(this.lbl_cant_records);
            this.Controls.Add(this.lbl_records);
            this.Controls.Add(this.movimientosDataGridView);
            this.Controls.Add(this.group_filters);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSE_MANAGERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            this.group_filters.ResumeLayout(false);
            this.group_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EXPENSE_MANAGERDataSet eXPENSE_MANAGERDataSet;
        private System.Windows.Forms.BindingSource movimientosBindingSource;
        private EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter movimientosTableAdapter;
        private EXPENSE_MANAGERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView movimientosDataGridView;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_records;
        private System.Windows.Forms.Label lbl_cant_records;
        private System.Windows.Forms.Button btn_show_query;
        private System.Windows.Forms.Label lbl_concept_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox group_filters;
        private System.Windows.Forms.CheckBox check_date2;
        private System.Windows.Forms.CheckBox check_date1;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.Label lbl_date1;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.ComboBox cbx_accounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_date2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}