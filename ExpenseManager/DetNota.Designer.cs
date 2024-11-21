namespace ExpenseManager
{
    partial class DetNota
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
            this.lbl_fec_crea = new System.Windows.Forms.Label();
            this.lbl_fec_modif = new System.Windows.Forms.Label();
            this.lbl_mod = new System.Windows.Forms.Label();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.lbl_crea = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.c_AHORRO_NEW_DS1 = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.notasTableAdapter1 = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.notasTableAdapter();
            this.notaTextBox = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fec_crea
            // 
            this.lbl_fec_crea.AutoSize = true;
            this.lbl_fec_crea.Font = new System.Drawing.Font("Comic Sans MS", 9.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fec_crea.Location = new System.Drawing.Point(8, 319);
            this.lbl_fec_crea.Name = "lbl_fec_crea";
            this.lbl_fec_crea.Size = new System.Drawing.Size(63, 19);
            this.lbl_fec_crea.TabIndex = 25;
            this.lbl_fec_crea.Text = "Creada:";
            // 
            // lbl_fec_modif
            // 
            this.lbl_fec_modif.AutoSize = true;
            this.lbl_fec_modif.Font = new System.Drawing.Font("Comic Sans MS", 9.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fec_modif.Location = new System.Drawing.Point(8, 345);
            this.lbl_fec_modif.Name = "lbl_fec_modif";
            this.lbl_fec_modif.Size = new System.Drawing.Size(88, 19);
            this.lbl_fec_modif.TabIndex = 26;
            this.lbl_fec_modif.Text = "Modificada:";
            // 
            // lbl_mod
            // 
            this.lbl_mod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "fec_modif", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lbl_mod.Location = new System.Drawing.Point(104, 346);
            this.lbl_mod.Name = "lbl_mod";
            this.lbl_mod.Size = new System.Drawing.Size(300, 13);
            this.lbl_mod.TabIndex = 28;
            this.lbl_mod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.c_AHORRO_NEW_DS;
            // 
            // c_AHORRO_NEW_DS
            // 
            this.c_AHORRO_NEW_DS.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_crea
            // 
            this.lbl_crea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "fec_crea", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lbl_crea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crea.Location = new System.Drawing.Point(104, 322);
            this.lbl_crea.Name = "lbl_crea";
            this.lbl_crea.Size = new System.Drawing.Size(300, 13);
            this.lbl_crea.TabIndex = 27;
            this.lbl_crea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(702, 339);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 25);
            this.btn_aceptar.TabIndex = 29;
            this.btn_aceptar.Text = "Cerrar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // c_AHORRO_NEW_DS1
            // 
            this.c_AHORRO_NEW_DS1.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasTableAdapter1
            // 
            this.notasTableAdapter1.ClearBeforeFill = true;
            // 
            // notaTextBox
            // 
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "nota", true));
            this.notaTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.notaTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaTextBox.Location = new System.Drawing.Point(0, 0);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(789, 308);
            this.notaTextBox.TabIndex = 30;
            // 
            // lbl_name
            // 
            this.lbl_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "titulo", true));
            this.lbl_name.Location = new System.Drawing.Point(12, 614);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(132, 13);
            this.lbl_name.TabIndex = 31;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DetNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 373);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_mod);
            this.Controls.Add(this.lbl_crea);
            this.Controls.Add(this.lbl_fec_crea);
            this.Controls.Add(this.lbl_fec_modif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DetNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texto de la nota";
            this.Load += new System.EventHandler(this.DetNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mod;
        private System.Windows.Forms.Label lbl_crea;
        private System.Windows.Forms.Button btn_aceptar;
        private EXPENSE_MANAGERDataSet c_AHORRO_NEW_DS1;
        private EXPENSE_MANAGERDataSetTableAdapters.notasTableAdapter notasTableAdapter1;
        private EXPENSE_MANAGERDataSet c_AHORRO_NEW_DS;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_fec_crea;
        private System.Windows.Forms.Label lbl_fec_modif;
        internal System.Windows.Forms.Label notaTextBox;
    }
}