namespace ExpenseManager
{
    partial class DeleteAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxSelectAccount = new System.Windows.Forms.ComboBox();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensE_MANAGERDataSet1 = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.pbxCoinPlus = new System.Windows.Forms.PictureBox();
            this.lbl_account_list = new System.Windows.Forms.Label();
            this.BtnDeleteAccount = new System.Windows.Forms.Button();
            this.cuentasTableAdapter1 = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensE_MANAGERDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoinPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cbxSelectAccount);
            this.panel1.Controls.Add(this.pbxCoinPlus);
            this.panel1.Controls.Add(this.lbl_account_list);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 143);
            this.panel1.TabIndex = 0;
            // 
            // cbxSelectAccount
            // 
            this.cbxSelectAccount.DataSource = this.cuentasBindingSource;
            this.cbxSelectAccount.DisplayMember = "nombre";
            this.cbxSelectAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectAccount.FormattingEnabled = true;
            this.cbxSelectAccount.Location = new System.Drawing.Point(17, 52);
            this.cbxSelectAccount.Name = "cbxSelectAccount";
            this.cbxSelectAccount.Size = new System.Drawing.Size(215, 25);
            this.cbxSelectAccount.TabIndex = 7;
            this.cbxSelectAccount.ValueMember = "id";
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataMember = "cuentas";
            this.cuentasBindingSource.DataSource = this.expensE_MANAGERDataSet1;
            // 
            // expensE_MANAGERDataSet1
            // 
            this.expensE_MANAGERDataSet1.DataSetName = "EXPENSE_MANAGERDataSet";
            this.expensE_MANAGERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbxCoinPlus
            // 
            this.pbxCoinPlus.Image = global::ExpenseManager.Properties.Resources.Awicons_Vista_Artistic_Coin_delete_48;
            this.pbxCoinPlus.Location = new System.Drawing.Point(265, 3);
            this.pbxCoinPlus.Name = "pbxCoinPlus";
            this.pbxCoinPlus.Size = new System.Drawing.Size(49, 57);
            this.pbxCoinPlus.TabIndex = 5;
            this.pbxCoinPlus.TabStop = false;
            // 
            // lbl_account_list
            // 
            this.lbl_account_list.AutoSize = true;
            this.lbl_account_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account_list.Location = new System.Drawing.Point(14, 34);
            this.lbl_account_list.Name = "lbl_account_list";
            this.lbl_account_list.Size = new System.Drawing.Size(149, 15);
            this.lbl_account_list.TabIndex = 2;
            this.lbl_account_list.Text = "Elija de la lista de cuentas";
            // 
            // BtnDeleteAccount
            // 
            this.BtnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAccount.Location = new System.Drawing.Point(238, 160);
            this.BtnDeleteAccount.Name = "BtnDeleteAccount";
            this.BtnDeleteAccount.Size = new System.Drawing.Size(90, 25);
            this.BtnDeleteAccount.TabIndex = 1;
            this.BtnDeleteAccount.Text = "Eliminar";
            this.BtnDeleteAccount.UseVisualStyleBackColor = true;
            this.BtnDeleteAccount.Click += new System.EventHandler(this.BtnNewAccount_Click);
            // 
            // cuentasTableAdapter1
            // 
            this.cuentasTableAdapter1.ClearBeforeFill = true;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 194);
            this.Controls.Add(this.BtnDeleteAccount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva cuenta";
            this.Load += new System.EventHandler(this.DeleteAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensE_MANAGERDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoinPlus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDeleteAccount;
        private System.Windows.Forms.Label lbl_account_list;
        private System.Windows.Forms.PictureBox pbxCoinPlus;
        private EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter1;
        private EXPENSE_MANAGERDataSet expensE_MANAGERDataSet1;
        private System.Windows.Forms.ComboBox cbxSelectAccount;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
    }
}