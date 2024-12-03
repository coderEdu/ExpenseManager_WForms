namespace ExpenseManager
{
    partial class Transfer
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
            this.btn_trans = new System.Windows.Forms.Button();
            this.lbl_trans = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.c_AHORRO_NEW_DS1 = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.moviTableAdapter2 = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTableAdapter1 = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.usuariosTableAdapter();
            this.pnl_amount = new System.Windows.Forms.Panel();
            this.btn_point = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.Txt_display = new System.Windows.Forms.Label();
            this.lbl_source_account = new System.Windows.Forms.Label();
            this.cbx_source_accounts = new System.Windows.Forms.ComboBox();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasTableAdapter = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter();
            this.pnl_accounts = new System.Windows.Forms.Panel();
            this.cbx_destination_accounts = new System.Windows.Forms.ComboBox();
            this.lbl_destination_account = new System.Windows.Forms.Label();
            this.pnl_concept = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.pnl_amount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            this.pnl_accounts.SuspendLayout();
            this.pnl_concept.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_trans
            // 
            this.btn_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btn_trans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(51)))));
            this.btn_trans.FlatAppearance.BorderSize = 2;
            this.btn_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_trans.Location = new System.Drawing.Point(303, 386);
            this.btn_trans.Name = "btn_trans";
            this.btn_trans.Size = new System.Drawing.Size(86, 29);
            this.btn_trans.TabIndex = 2;
            this.btn_trans.Text = "Efectuar";
            this.btn_trans.UseVisualStyleBackColor = false;
            this.btn_trans.Click += new System.EventHandler(this.Btn_trans_Click);
            // 
            // lbl_trans
            // 
            this.lbl_trans.BackColor = System.Drawing.Color.White;
            this.lbl_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trans.Location = new System.Drawing.Point(13, 16);
            this.lbl_trans.Name = "lbl_trans";
            this.lbl_trans.Size = new System.Drawing.Size(144, 18);
            this.lbl_trans.TabIndex = 1;
            this.lbl_trans.Text = "Monto a transferir:";
            this.lbl_trans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(12, 395);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 3;
            // 
            // c_AHORRO_NEW_DS1
            // 
            this.c_AHORRO_NEW_DS1.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviTableAdapter2
            // 
            this.moviTableAdapter2.ClearBeforeFill = true;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_concepto.Location = new System.Drawing.Point(15, 43);
            this.txt_concepto.MaxLength = 148;
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(170, 186);
            this.txt_concepto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "En concepto de:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // pnl_amount
            // 
            this.pnl_amount.BackColor = System.Drawing.Color.White;
            this.pnl_amount.Controls.Add(this.btn_point);
            this.pnl_amount.Controls.Add(this.btnDel);
            this.pnl_amount.Controls.Add(this.btn0);
            this.pnl_amount.Controls.Add(this.btn3);
            this.pnl_amount.Controls.Add(this.btn2);
            this.pnl_amount.Controls.Add(this.btn1);
            this.pnl_amount.Controls.Add(this.btn6);
            this.pnl_amount.Controls.Add(this.btn5);
            this.pnl_amount.Controls.Add(this.btn4);
            this.pnl_amount.Controls.Add(this.btn9);
            this.pnl_amount.Controls.Add(this.btn8);
            this.pnl_amount.Controls.Add(this.btn7);
            this.pnl_amount.Controls.Add(this.Txt_display);
            this.pnl_amount.Controls.Add(this.lbl_trans);
            this.pnl_amount.Location = new System.Drawing.Point(13, 125);
            this.pnl_amount.Name = "pnl_amount";
            this.pnl_amount.Size = new System.Drawing.Size(170, 244);
            this.pnl_amount.TabIndex = 0;
            // 
            // btn_point
            // 
            this.btn_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.Location = new System.Drawing.Point(64, 198);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(44, 32);
            this.btn_point.TabIndex = 21;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.Btn_point_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(113, 198);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(44, 32);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "←";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(14, 197);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(44, 32);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(113, 160);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(44, 32);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(64, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(44, 32);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(14, 159);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(44, 32);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(113, 122);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(44, 32);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(64, 122);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(44, 32);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(14, 121);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(44, 32);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(114, 83);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(44, 32);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(64, 83);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(44, 32);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(14, 83);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(44, 32);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Txt_display
            // 
            this.Txt_display.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_display.Location = new System.Drawing.Point(14, 43);
            this.Txt_display.Name = "Txt_display";
            this.Txt_display.Size = new System.Drawing.Size(143, 28);
            this.Txt_display.TabIndex = 7;
            this.Txt_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Txt_display.TextChanged += new System.EventHandler(this.Txt_display_TextChanged);
            // 
            // lbl_source_account
            // 
            this.lbl_source_account.AutoSize = true;
            this.lbl_source_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_source_account.Location = new System.Drawing.Point(16, 20);
            this.lbl_source_account.Name = "lbl_source_account";
            this.lbl_source_account.Size = new System.Drawing.Size(104, 18);
            this.lbl_source_account.TabIndex = 30;
            this.lbl_source_account.Text = "Cuenta origen:";
            // 
            // cbx_source_accounts
            // 
            this.cbx_source_accounts.DataSource = this.cuentasBindingSource;
            this.cbx_source_accounts.DisplayMember = "nombre";
            this.cbx_source_accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_source_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_source_accounts.FormattingEnabled = true;
            this.cbx_source_accounts.Location = new System.Drawing.Point(134, 17);
            this.cbx_source_accounts.Name = "cbx_source_accounts";
            this.cbx_source_accounts.Size = new System.Drawing.Size(226, 26);
            this.cbx_source_accounts.TabIndex = 29;
            this.cbx_source_accounts.ValueMember = "id";
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
            // pnl_accounts
            // 
            this.pnl_accounts.BackColor = System.Drawing.Color.White;
            this.pnl_accounts.Controls.Add(this.cbx_destination_accounts);
            this.pnl_accounts.Controls.Add(this.lbl_destination_account);
            this.pnl_accounts.Controls.Add(this.cbx_source_accounts);
            this.pnl_accounts.Controls.Add(this.lbl_source_account);
            this.pnl_accounts.Location = new System.Drawing.Point(11, 10);
            this.pnl_accounts.Name = "pnl_accounts";
            this.pnl_accounts.Size = new System.Drawing.Size(378, 109);
            this.pnl_accounts.TabIndex = 31;
            // 
            // cbx_destination_accounts
            // 
            this.cbx_destination_accounts.DataSource = this.cuentasBindingSource;
            this.cbx_destination_accounts.DisplayMember = "nombre";
            this.cbx_destination_accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_destination_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_destination_accounts.FormattingEnabled = true;
            this.cbx_destination_accounts.Location = new System.Drawing.Point(134, 65);
            this.cbx_destination_accounts.Name = "cbx_destination_accounts";
            this.cbx_destination_accounts.Size = new System.Drawing.Size(226, 26);
            this.cbx_destination_accounts.TabIndex = 31;
            this.cbx_destination_accounts.ValueMember = "id";
            // 
            // lbl_destination_account
            // 
            this.lbl_destination_account.AutoSize = true;
            this.lbl_destination_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destination_account.Location = new System.Drawing.Point(17, 68);
            this.lbl_destination_account.Name = "lbl_destination_account";
            this.lbl_destination_account.Size = new System.Drawing.Size(111, 18);
            this.lbl_destination_account.TabIndex = 32;
            this.lbl_destination_account.Text = "Cuenta destino:";
            // 
            // pnl_concept
            // 
            this.pnl_concept.BackColor = System.Drawing.Color.White;
            this.pnl_concept.Controls.Add(this.label1);
            this.pnl_concept.Controls.Add(this.txt_concepto);
            this.pnl_concept.Location = new System.Drawing.Point(189, 125);
            this.pnl_concept.Name = "pnl_concept";
            this.pnl_concept.Size = new System.Drawing.Size(200, 244);
            this.pnl_concept.TabIndex = 32;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(400, 428);
            this.Controls.Add(this.pnl_concept);
            this.Controls.Add(this.pnl_accounts);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btn_trans);
            this.Controls.Add(this.pnl_amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposito";
            this.Load += new System.EventHandler(this.Transaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            this.pnl_amount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            this.pnl_accounts.ResumeLayout(false);
            this.pnl_accounts.PerformLayout();
            this.pnl_concept.ResumeLayout(false);
            this.pnl_concept.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_trans;
        private System.Windows.Forms.Label lbl_trans;
        private System.Windows.Forms.DateTimePicker dtp;
        private EXPENSE_MANAGERDataSet c_AHORRO_NEW_DS1;
        private EXPENSE_MANAGERDataSetTableAdapters.usuariosTableAdapter loginTableAdapter1;
        private EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter moviTableAdapter2;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_amount;
        private System.Windows.Forms.Label Txt_display;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Label lbl_source_account;
        private System.Windows.Forms.ComboBox cbx_source_accounts;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private EXPENSE_MANAGERDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Panel pnl_accounts;
        private System.Windows.Forms.ComboBox cbx_destination_accounts;
        private System.Windows.Forms.Label lbl_destination_account;
        private System.Windows.Forms.Panel pnl_concept;
    }
}