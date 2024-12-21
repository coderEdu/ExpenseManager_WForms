namespace ExpenseManager
{
    partial class CreateAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxCoinPlus = new System.Windows.Forms.PictureBox();
            this.lbl_account_readme = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_account_name = new System.Windows.Forms.Label();
            this.BtnNewAccount = new System.Windows.Forms.Button();
            this.cuentasTableAdapter1 = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter();
            this.expensE_MANAGERDataSet1 = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.Pbx_check = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoinPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensE_MANAGERDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_check)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Pbx_check);
            this.panel1.Controls.Add(this.pbxCoinPlus);
            this.panel1.Controls.Add(this.lbl_account_readme);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lbl_account_name);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 193);
            this.panel1.TabIndex = 0;
            // 
            // pbxCoinPlus
            // 
            this.pbxCoinPlus.Image = global::ExpenseManager.Properties.Resources.Awicons_Vista_Artistic_Coin_add_48;
            this.pbxCoinPlus.Location = new System.Drawing.Point(265, 3);
            this.pbxCoinPlus.Name = "pbxCoinPlus";
            this.pbxCoinPlus.Size = new System.Drawing.Size(49, 57);
            this.pbxCoinPlus.TabIndex = 5;
            this.pbxCoinPlus.TabStop = false;
            // 
            // lbl_account_readme
            // 
            this.lbl_account_readme.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_account_readme.Font = new System.Drawing.Font("Segoe UI Emoji", 9.333333F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account_readme.ForeColor = System.Drawing.Color.Gray;
            this.lbl_account_readme.Location = new System.Drawing.Point(3, 113);
            this.lbl_account_readme.Name = "lbl_account_readme";
            this.lbl_account_readme.Size = new System.Drawing.Size(311, 76);
            this.lbl_account_readme.TabIndex = 4;
            this.lbl_account_readme.Text = "** Recuerde que toda cuenta se crea por defecto con saldo en 0 (cero pesos). Para" +
    " agregarle dinero a dicha cuenta, debe hacerlo efectuando depósitos.";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(17, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbl_account_name
            // 
            this.lbl_account_name.AutoSize = true;
            this.lbl_account_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account_name.Location = new System.Drawing.Point(14, 34);
            this.lbl_account_name.Name = "lbl_account_name";
            this.lbl_account_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_account_name.TabIndex = 2;
            this.lbl_account_name.Text = "Nombre";
            // 
            // BtnNewAccount
            // 
            this.BtnNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewAccount.Location = new System.Drawing.Point(253, 210);
            this.BtnNewAccount.Name = "BtnNewAccount";
            this.BtnNewAccount.Size = new System.Drawing.Size(75, 25);
            this.BtnNewAccount.TabIndex = 1;
            this.BtnNewAccount.Text = "Crear";
            this.BtnNewAccount.UseVisualStyleBackColor = true;
            this.BtnNewAccount.Click += new System.EventHandler(this.BtnNewAccount_Click);
            // 
            // cuentasTableAdapter1
            // 
            this.cuentasTableAdapter1.ClearBeforeFill = true;
            // 
            // expensE_MANAGERDataSet1
            // 
            this.expensE_MANAGERDataSet1.DataSetName = "EXPENSE_MANAGERDataSet";
            this.expensE_MANAGERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pbx_check
            // 
            this.Pbx_check.Image = global::ExpenseManager.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_48;
            this.Pbx_check.Location = new System.Drawing.Point(196, 53);
            this.Pbx_check.Name = "Pbx_check";
            this.Pbx_check.Size = new System.Drawing.Size(27, 25);
            this.Pbx_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_check.TabIndex = 7;
            this.Pbx_check.TabStop = false;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 247);
            this.Controls.Add(this.BtnNewAccount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva cuenta";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoinPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensE_MANAGERDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_check)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNewAccount;
        private System.Windows.Forms.Label lbl_account_name;
        private System.Windows.Forms.Label lbl_account_readme;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pbxCoinPlus;
        private EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter1;
        private EXPENSE_MANAGERDataSet expensE_MANAGERDataSet1;
        private System.Windows.Forms.PictureBox Pbx_check;
    }
}