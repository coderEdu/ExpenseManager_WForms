﻿namespace ExpenseManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.moviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS1 = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.loginTableAdapter1 = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.usuariosTableAdapter();
            this.moviTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter();
            this.notasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.notasTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tStrip_deposito = new System.Windows.Forms.ToolStripButton();
            this.tStrip_extraccion = new System.Windows.Forms.ToolStripButton();
            this.tStrip_transfer = new System.Windows.Forms.ToolStripButton();
            this.tStrip_ver_registro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tStrip_new_nota = new System.Windows.Forms.ToolStripButton();
            this.tStrip_edit_nota = new System.Windows.Forms.ToolStripButton();
            this.tStrip_delete_nota = new System.Windows.Forms.ToolStripButton();
            this.tStrip_ver_notas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tStrip_close_sesion = new System.Windows.Forms.ToolStripButton();
            this.cbx_accounts = new System.Windows.Forms.ComboBox();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_for_saldo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldocuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_last_movs = new System.Windows.Forms.Label();
            this.lbl_last_notes = new System.Windows.Forms.Label();
            this.flp_note = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1092, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // moviBindingSource
            // 
            this.moviBindingSource.DataMember = "movimientos";
            this.moviBindingSource.DataSource = this.c_AHORRO_NEW_DS1;
            // 
            // c_AHORRO_NEW_DS1
            // 
            this.c_AHORRO_NEW_DS1.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // moviTableAdapter
            // 
            this.moviTableAdapter.ClearBeforeFill = true;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_deposito,
            this.tStrip_extraccion,
            this.tStrip_transfer,
            this.tStrip_ver_registro,
            this.toolStripSeparator1,
            this.tStrip_new_nota,
            this.tStrip_edit_nota,
            this.tStrip_delete_nota,
            this.tStrip_ver_notas,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.tStrip_close_sesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1312, 52);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tStrip_deposito
            // 
            this.tStrip_deposito.Image = global::ExpenseManager.Properties.Resources._1889199_coins_hand_loan_loan_money_money_icon__1_;
            this.tStrip_deposito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_deposito.Name = "tStrip_deposito";
            this.tStrip_deposito.Size = new System.Drawing.Size(74, 49);
            this.tStrip_deposito.Text = "Depósito";
            this.tStrip_deposito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tStrip_deposito.Click += new System.EventHandler(this.tStrip_deposito_Click);
            // 
            // tStrip_extraccion
            // 
            this.tStrip_extraccion.Image = global::ExpenseManager.Properties.Resources._1889200_bag_coins_finance_saving_bank_icon__1_;
            this.tStrip_extraccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_extraccion.Name = "tStrip_extraccion";
            this.tStrip_extraccion.Size = new System.Drawing.Size(81, 49);
            this.tStrip_extraccion.Text = "Extracción";
            this.tStrip_extraccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tStrip_extraccion.Click += new System.EventHandler(this.tStrip_extraccion_Click);
            // 
            // tStrip_transfer
            // 
            this.tStrip_transfer.Image = global::ExpenseManager.Properties.Resources.Fatcow_Farm_Fresh_Outlook_change_view_32;
            this.tStrip_transfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_transfer.Name = "tStrip_transfer";
            this.tStrip_transfer.Size = new System.Drawing.Size(100, 49);
            this.tStrip_transfer.Text = "Transferencia";
            this.tStrip_transfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tStrip_ver_registro
            // 
            this.tStrip_ver_registro.Image = global::ExpenseManager.Properties.Resources.Database_Active_icon;
            this.tStrip_ver_registro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_ver_registro.Name = "tStrip_ver_registro";
            this.tStrip_ver_registro.Size = new System.Drawing.Size(68, 49);
            this.tStrip_ver_registro.Text = "Registro";
            this.tStrip_ver_registro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tStrip_ver_registro.Click += new System.EventHandler(this.tStrip_ver_registro_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // tStrip_new_nota
            // 
            this.tStrip_new_nota.Image = global::ExpenseManager.Properties.Resources._17368_add_file_icon;
            this.tStrip_new_nota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_new_nota.Name = "tStrip_new_nota";
            this.tStrip_new_nota.Size = new System.Drawing.Size(82, 49);
            this.tStrip_new_nota.Text = "Crear nota";
            this.tStrip_new_nota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tStrip_new_nota.Click += new System.EventHandler(this.tStrip_new_nota_Click);
            // 
            // tStrip_edit_nota
            // 
            this.tStrip_edit_nota.Image = global::ExpenseManager.Properties.Resources._17369_edit_file_icon;
            this.tStrip_edit_nota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_edit_nota.Name = "tStrip_edit_nota";
            this.tStrip_edit_nota.Size = new System.Drawing.Size(86, 49);
            this.tStrip_edit_nota.Text = "Editar nota";
            this.tStrip_edit_nota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tStrip_edit_nota.Click += new System.EventHandler(this.tStrip_edit_nota_Click);
            // 
            // tStrip_delete_nota
            // 
            this.tStrip_delete_nota.Image = global::ExpenseManager.Properties.Resources._17371_file_remove_icon__1_;
            this.tStrip_delete_nota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_delete_nota.Name = "tStrip_delete_nota";
            this.tStrip_delete_nota.Size = new System.Drawing.Size(88, 49);
            this.tStrip_delete_nota.Text = "Borrar nota";
            this.tStrip_delete_nota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tStrip_delete_nota.Click += new System.EventHandler(this.tStrip_delete_nota_Click);
            // 
            // tStrip_ver_notas
            // 
            this.tStrip_ver_notas.Image = global::ExpenseManager.Properties.Resources._17367_file_icon__1_;
            this.tStrip_ver_notas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_ver_notas.Name = "tStrip_ver_notas";
            this.tStrip_ver_notas.Size = new System.Drawing.Size(74, 49);
            this.tStrip_ver_notas.Text = "Ver notas";
            this.tStrip_ver_notas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ExpenseManager.Properties.Resources.Awicons_Vista_Artistic_Coin_add_48;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(96, 49);
            this.toolStripButton1.Text = "Crear cuenta";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::ExpenseManager.Properties.Resources.Awicons_Vista_Artistic_Coin_delete_48;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(102, 49);
            this.toolStripButton2.Text = "Borrar cuenta";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::ExpenseManager.Properties.Resources.Awicons_Vista_Artistic_Coin_48;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(88, 49);
            this.toolStripButton3.Text = "Ver cuentas";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::ExpenseManager.Properties.Resources.Fatcow_Farm_Fresh_Set_password_32;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(107, 49);
            this.toolStripButton4.Text = "Cambiar clave";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tStrip_close_sesion
            // 
            this.tStrip_close_sesion.Image = global::ExpenseManager.Properties.Resources.Lock_PadLock_icon;
            this.tStrip_close_sesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_close_sesion.Name = "tStrip_close_sesion";
            this.tStrip_close_sesion.Size = new System.Drawing.Size(98, 49);
            this.tStrip_close_sesion.Text = "Cerrar sesión";
            this.tStrip_close_sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tStrip_close_sesion.Click += new System.EventHandler(this.tStrip_close_sesion_Click);
            // 
            // cbx_accounts
            // 
            this.cbx_accounts.DataSource = this.cuentasBindingSource;
            this.cbx_accounts.DisplayMember = "nombre";
            this.cbx_accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_accounts.FormattingEnabled = true;
            this.cbx_accounts.Location = new System.Drawing.Point(19, 102);
            this.cbx_accounts.Name = "cbx_accounts";
            this.cbx_accounts.Size = new System.Drawing.Size(196, 26);
            this.cbx_accounts.TabIndex = 26;
            this.cbx_accounts.ValueMember = "id";
            this.cbx_accounts.SelectedIndexChanged += new System.EventHandler(this.cbx_accounts_SelectedIndexChanged);
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataMember = "cuentas";
            this.cuentasBindingSource.DataSource = this.c_AHORRO_NEW_DS1;
            // 
            // cuentasTableAdapter
            // 
            this.cuentasTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(19, 145);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.lbl_saldo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_for_saldo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_last_movs);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_last_notes);
            this.splitContainer1.Panel2.Controls.Add(this.flp_note);
            this.splitContainer1.Size = new System.Drawing.Size(1273, 542);
            this.splitContainer1.SplitterDistance = 836;
            this.splitContainer1.TabIndex = 27;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.Font = new System.Drawing.Font("Caladea", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(63, 63);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(725, 72);
            this.lbl_saldo.TabIndex = 1;
            this.lbl_saldo.Text = "$ 50.000";
            // 
            // lbl_for_saldo
            // 
            this.lbl_for_saldo.AutoSize = true;
            this.lbl_for_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_for_saldo.Location = new System.Drawing.Point(19, 37);
            this.lbl_for_saldo.Name = "lbl_for_saldo";
            this.lbl_for_saldo.Size = new System.Drawing.Size(112, 15);
            this.lbl_for_saldo.TabIndex = 0;
            this.lbl_for_saldo.Text = "Saldo de la cuenta:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.saldocuentaDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn,
            this.idusuarioDataGridViewTextBoxColumn,
            this.idcuentaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moviBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(389, 139);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 112;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 112;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 50;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Width = 112;
            // 
            // saldocuentaDataGridViewTextBoxColumn
            // 
            this.saldocuentaDataGridViewTextBoxColumn.DataPropertyName = "saldo_cuenta";
            this.saldocuentaDataGridViewTextBoxColumn.HeaderText = "saldo_ant";
            this.saldocuentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saldocuentaDataGridViewTextBoxColumn.Name = "saldocuentaDataGridViewTextBoxColumn";
            this.saldocuentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldocuentaDataGridViewTextBoxColumn.Width = 112;
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "concepto";
            this.conceptoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            this.conceptoDataGridViewTextBoxColumn.Visible = false;
            this.conceptoDataGridViewTextBoxColumn.Width = 112;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idusuarioDataGridViewTextBoxColumn.Visible = false;
            this.idusuarioDataGridViewTextBoxColumn.Width = 112;
            // 
            // idcuentaDataGridViewTextBoxColumn
            // 
            this.idcuentaDataGridViewTextBoxColumn.DataPropertyName = "id_cuenta";
            this.idcuentaDataGridViewTextBoxColumn.HeaderText = "id_cuenta";
            this.idcuentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcuentaDataGridViewTextBoxColumn.Name = "idcuentaDataGridViewTextBoxColumn";
            this.idcuentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcuentaDataGridViewTextBoxColumn.Visible = false;
            this.idcuentaDataGridViewTextBoxColumn.Width = 112;
            // 
            // lbl_last_movs
            // 
            this.lbl_last_movs.AutoSize = true;
            this.lbl_last_movs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_last_movs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_movs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_last_movs.Location = new System.Drawing.Point(20, 37);
            this.lbl_last_movs.Name = "lbl_last_movs";
            this.lbl_last_movs.Size = new System.Drawing.Size(165, 20);
            this.lbl_last_movs.TabIndex = 25;
            this.lbl_last_movs.Text = "Últimos Movimientos";
            // 
            // lbl_last_notes
            // 
            this.lbl_last_notes.AutoSize = true;
            this.lbl_last_notes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_last_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_notes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_last_notes.Location = new System.Drawing.Point(20, 251);
            this.lbl_last_notes.Name = "lbl_last_notes";
            this.lbl_last_notes.Size = new System.Drawing.Size(115, 20);
            this.lbl_last_notes.TabIndex = 28;
            this.lbl_last_notes.Text = "Últimas Notas";
            // 
            // flp_note
            // 
            this.flp_note.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flp_note.Location = new System.Drawing.Point(24, 276);
            this.flp_note.Name = "flp_note";
            this.flp_note.Size = new System.Drawing.Size(389, 232);
            this.flp_note.TabIndex = 27;
            this.flp_note.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Flp_note_ControlAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tus cuentas:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1312, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cbx_accounts);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Manager --";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private EXPENSE_MANAGERDataSet c_AHORRO_NEW_DS1;
        private EXPENSE_MANAGERDataSetTableAdapters.usuariosTableAdapter loginTableAdapter1;
        private System.Windows.Forms.BindingSource moviBindingSource;
        private EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter moviTableAdapter;
        private EXPENSE_MANAGERDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tStrip_deposito;
        private System.Windows.Forms.ToolStripButton tStrip_extraccion;
        private System.Windows.Forms.ToolStripButton tStrip_transfer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tStrip_new_nota;
        private System.Windows.Forms.ToolStripButton tStrip_edit_nota;
        private System.Windows.Forms.ToolStripButton tStrip_delete_nota;
        private System.Windows.Forms.ToolStripButton tStrip_ver_notas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tStrip_close_sesion;
        private System.Windows.Forms.ComboBox cbx_accounts;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_last_movs;
        private System.Windows.Forms.Label lbl_last_notes;
        private System.Windows.Forms.FlowLayoutPanel flp_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tStrip_ver_registro;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_for_saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldocuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}