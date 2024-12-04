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
            this.notaTextBox = new System.Windows.Forms.Label();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPENSE_MANAGERDSNotes = new ExpenseManager.EXPENSE_MANAGERDSNotes();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_mod = new System.Windows.Forms.Label();
            this.lbl_crea = new System.Windows.Forms.Label();
            this.lbl_fec_crea = new System.Windows.Forms.Label();
            this.lbl_fec_modif = new System.Windows.Forms.Label();
            this.notasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDSNotesTableAdapters.notasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSE_MANAGERDSNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // notaTextBox
            // 
            this.notaTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "nota", true));
            this.notaTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaTextBox.Location = new System.Drawing.Point(0, 71);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(800, 308);
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.notasBindingSource;
            this.comboBox1.DisplayMember = "titulo";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(405, 25);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "id";
            // 
            // lbl_mod
            // 
            this.lbl_mod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "fec_modif", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lbl_mod.Location = new System.Drawing.Point(189, 417);
            this.lbl_mod.Name = "lbl_mod";
            this.lbl_mod.Size = new System.Drawing.Size(333, 18);
            this.lbl_mod.TabIndex = 37;
            this.lbl_mod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_crea
            // 
            this.lbl_crea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "fec_crea", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lbl_crea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crea.Location = new System.Drawing.Point(189, 390);
            this.lbl_crea.Name = "lbl_crea";
            this.lbl_crea.Size = new System.Drawing.Size(333, 18);
            this.lbl_crea.TabIndex = 36;
            this.lbl_crea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_fec_crea
            // 
            this.lbl_fec_crea.AutoSize = true;
            this.lbl_fec_crea.Font = new System.Drawing.Font("Comic Sans MS", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fec_crea.Location = new System.Drawing.Point(9, 392);
            this.lbl_fec_crea.Name = "lbl_fec_crea";
            this.lbl_fec_crea.Size = new System.Drawing.Size(129, 19);
            this.lbl_fec_crea.TabIndex = 34;
            this.lbl_fec_crea.Text = "Fecha de creación:";
            // 
            // lbl_fec_modif
            // 
            this.lbl_fec_modif.AutoSize = true;
            this.lbl_fec_modif.Font = new System.Drawing.Font("Comic Sans MS", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fec_modif.Location = new System.Drawing.Point(9, 418);
            this.lbl_fec_modif.Name = "lbl_fec_modif";
            this.lbl_fec_modif.Size = new System.Drawing.Size(155, 19);
            this.lbl_fec_modif.TabIndex = 35;
            this.lbl_fec_modif.Text = "Fecha de modificación:";
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // ViewNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.lbl_mod);
            this.Controls.Add(this.lbl_crea);
            this.Controls.Add(this.lbl_fec_crea);
            this.Controls.Add(this.lbl_fec_modif);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.notaTextBox);
            this.Name = "ViewNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todas tus notas";
            this.Load += new System.EventHandler(this.ViewNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSE_MANAGERDSNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label notaTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_mod;
        private System.Windows.Forms.Label lbl_crea;
        private System.Windows.Forms.Label lbl_fec_crea;
        private System.Windows.Forms.Label lbl_fec_modif;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private EXPENSE_MANAGERDSNotes eXPENSE_MANAGERDSNotes;
        private EXPENSE_MANAGERDSNotesTableAdapters.notasTableAdapter notasTableAdapter;
    }
}