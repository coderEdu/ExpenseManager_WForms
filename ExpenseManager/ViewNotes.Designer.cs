namespace ExpenseManager
{
    partial class ViewNotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notaTextBox = new System.Windows.Forms.Label();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPENSE_MANAGERDSNotes = new ExpenseManager.EXPENSE_MANAGERDSNotes();
            this.lbl_mod = new System.Windows.Forms.Label();
            this.lbl_crea = new System.Windows.Forms.Label();
            this.lbl_fec_crea = new System.Windows.Forms.Label();
            this.lbl_fec_modif = new System.Windows.Forms.Label();
            this.notasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDSNotesTableAdapters.notasTableAdapter();
            this.Dgv_all_notes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feccreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecmodifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSE_MANAGERDSNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_all_notes)).BeginInit();
            this.SuspendLayout();
            // 
            // notaTextBox
            // 
            this.notaTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "nota", true));
            this.notaTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaTextBox.Location = new System.Drawing.Point(287, 77);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(696, 311);
            this.notaTextBox.TabIndex = 31;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.eXPENSE_MANAGERDSNotes;
            // 
            // eXPENSE_MANAGERDSNotes
            // 
            this.eXPENSE_MANAGERDSNotes.DataSetName = "EXPENSE_MANAGERDSNotes";
            this.eXPENSE_MANAGERDSNotes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_mod
            // 
            this.lbl_mod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "fec_modif", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lbl_mod.Location = new System.Drawing.Point(190, 428);
            this.lbl_mod.Name = "lbl_mod";
            this.lbl_mod.Size = new System.Drawing.Size(333, 23);
            this.lbl_mod.TabIndex = 37;
            this.lbl_mod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_crea
            // 
            this.lbl_crea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "fec_crea", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lbl_crea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crea.Location = new System.Drawing.Point(190, 401);
            this.lbl_crea.Name = "lbl_crea";
            this.lbl_crea.Size = new System.Drawing.Size(333, 23);
            this.lbl_crea.TabIndex = 36;
            this.lbl_crea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_fec_crea
            // 
            this.lbl_fec_crea.AutoSize = true;
            this.lbl_fec_crea.Font = new System.Drawing.Font("Comic Sans MS", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fec_crea.Location = new System.Drawing.Point(10, 403);
            this.lbl_fec_crea.Name = "lbl_fec_crea";
            this.lbl_fec_crea.Size = new System.Drawing.Size(129, 19);
            this.lbl_fec_crea.TabIndex = 34;
            this.lbl_fec_crea.Text = "Fecha de creación:";
            // 
            // lbl_fec_modif
            // 
            this.lbl_fec_modif.AutoSize = true;
            this.lbl_fec_modif.Font = new System.Drawing.Font("Comic Sans MS", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fec_modif.Location = new System.Drawing.Point(10, 429);
            this.lbl_fec_modif.Name = "lbl_fec_modif";
            this.lbl_fec_modif.Size = new System.Drawing.Size(155, 19);
            this.lbl_fec_modif.TabIndex = 35;
            this.lbl_fec_modif.Text = "Fecha de modificación:";
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // Dgv_all_notes
            // 
            this.Dgv_all_notes.AllowUserToAddRows = false;
            this.Dgv_all_notes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgv_all_notes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Dgv_all_notes.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_all_notes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Dgv_all_notes.ColumnHeadersHeight = 25;
            this.Dgv_all_notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_all_notes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.feccreaDataGridViewTextBoxColumn,
            this.fecmodifDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.idcuentaDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn});
            this.Dgv_all_notes.DataSource = this.notasBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_all_notes.DefaultCellStyle = dataGridViewCellStyle11;
            this.Dgv_all_notes.EnableHeadersVisualStyles = false;
            this.Dgv_all_notes.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dgv_all_notes.Location = new System.Drawing.Point(14, 77);
            this.Dgv_all_notes.Name = "Dgv_all_notes";
            this.Dgv_all_notes.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_all_notes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_all_notes.RowHeadersVisible = false;
            this.Dgv_all_notes.RowHeadersWidth = 45;
            this.Dgv_all_notes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_all_notes.Size = new System.Drawing.Size(267, 311);
            this.Dgv_all_notes.TabIndex = 38;
            this.Dgv_all_notes.TabStop = false;
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
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "nota";
            this.notaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Visible = false;
            this.notaDataGridViewTextBoxColumn.Width = 112;
            // 
            // feccreaDataGridViewTextBoxColumn
            // 
            this.feccreaDataGridViewTextBoxColumn.DataPropertyName = "fec_crea";
            this.feccreaDataGridViewTextBoxColumn.HeaderText = "fec_crea";
            this.feccreaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feccreaDataGridViewTextBoxColumn.Name = "feccreaDataGridViewTextBoxColumn";
            this.feccreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.feccreaDataGridViewTextBoxColumn.Visible = false;
            this.feccreaDataGridViewTextBoxColumn.Width = 112;
            // 
            // fecmodifDataGridViewTextBoxColumn
            // 
            this.fecmodifDataGridViewTextBoxColumn.DataPropertyName = "fec_modif";
            this.fecmodifDataGridViewTextBoxColumn.HeaderText = "fec_modif";
            this.fecmodifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fecmodifDataGridViewTextBoxColumn.Name = "fecmodifDataGridViewTextBoxColumn";
            this.fecmodifDataGridViewTextBoxColumn.ReadOnly = true;
            this.fecmodifDataGridViewTextBoxColumn.Visible = false;
            this.fecmodifDataGridViewTextBoxColumn.Width = 112;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iduserDataGridViewTextBoxColumn.Visible = false;
            this.iduserDataGridViewTextBoxColumn.Width = 112;
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
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo de la nota";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 245;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(716, 27);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(267, 25);
            this.txt_search.TabIndex = 39;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(654, 32);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(56, 17);
            this.lbl_search.TabIndex = 40;
            this.lbl_search.Text = "Buscar:";
            // 
            // ViewNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 463);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.Dgv_all_notes);
            this.Controls.Add(this.lbl_mod);
            this.Controls.Add(this.lbl_crea);
            this.Controls.Add(this.lbl_fec_crea);
            this.Controls.Add(this.lbl_fec_modif);
            this.Controls.Add(this.notaTextBox);
            this.Name = "ViewNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todas tus notas 📜";
            this.Load += new System.EventHandler(this.ViewNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSE_MANAGERDSNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_all_notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label notaTextBox;
        private System.Windows.Forms.Label lbl_mod;
        private System.Windows.Forms.Label lbl_crea;
        private System.Windows.Forms.Label lbl_fec_crea;
        private System.Windows.Forms.Label lbl_fec_modif;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private EXPENSE_MANAGERDSNotes eXPENSE_MANAGERDSNotes;
        private EXPENSE_MANAGERDSNotesTableAdapters.notasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DataGridView Dgv_all_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feccreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecmodifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
    }
}