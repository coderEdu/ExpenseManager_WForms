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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.moviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS1 = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.loginTableAdapter1 = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.usuariosTableAdapter();
            this.moviTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter();
            this.notasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.notasTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tStrip_deposito = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator2,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1312, 49);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tStrip_deposito
            // 
            this.tStrip_deposito.Image = global::ExpenseManager.Properties.Resources._1889199_coins_hand_loan_loan_money_money_icon__1_;
            this.tStrip_deposito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_deposito.Name = "tStrip_deposito";
            this.tStrip_deposito.Size = new System.Drawing.Size(74, 46);
            this.tStrip_deposito.Text = "Depósito";
            this.tStrip_deposito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::ExpenseManager.Properties.Resources._1889200_bag_coins_finance_saving_bank_icon__1_;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(81, 46);
            this.toolStripButton2.Text = "Extracción";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::ExpenseManager.Properties.Resources.Fatcow_Farm_Fresh_Outlook_change_view_32;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 46);
            this.toolStripButton3.Text = "Transferencia";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::ExpenseManager.Properties.Resources._17368_add_file_icon;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(82, 46);
            this.toolStripButton4.Text = "Crear nota";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::ExpenseManager.Properties.Resources._17369_edit_file_icon;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(86, 46);
            this.toolStripButton5.Text = "Editar nota";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::ExpenseManager.Properties.Resources._17371_file_remove_icon__1_;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(88, 46);
            this.toolStripButton6.Text = "Borrar nota";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::ExpenseManager.Properties.Resources._17367_file_icon__1_;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(74, 46);
            this.toolStripButton7.Text = "Ver notas";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::ExpenseManager.Properties.Resources.Lock_PadLock_icon;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(98, 46);
            this.toolStripButton8.Text = "Cerrar sesión";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cuentasBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 26);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "id";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
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
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
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
            this.saldocuentaDataGridViewTextBoxColumn.HeaderText = "saldo";
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
            this.lbl_last_movs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.lbl_last_notes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_last_notes.Location = new System.Drawing.Point(20, 237);
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
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1312, 733);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldocuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_last_movs;
        private System.Windows.Forms.Label lbl_last_notes;
        private System.Windows.Forms.FlowLayoutPanel flp_note;
    }
}