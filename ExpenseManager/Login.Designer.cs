namespace ExpenseManager
{
    partial class Login
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasegna = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_crea_usuario = new System.Windows.Forms.Button();
            this.txt_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nuevo_usuario = new System.Windows.Forms.Label();
            this.lbl_pass_nuevo_usuario = new System.Windows.Forms.Label();
            this.txt_pass_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.btn_guardar_nvo_usuario = new System.Windows.Forms.Button();
            this.btn_cancelar_nvo_usuario = new System.Windows.Forms.Button();
            this.tmr_exp_contr = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_sesion = new System.Windows.Forms.TabControl();
            this.tabP_inicio = new System.Windows.Forms.TabPage();
            this.tabP_nuevo = new System.Windows.Forms.TabPage();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.expensE_MANAGERDataSet1 = new ExpenseManager.EXPENSE_MANAGERDataSet();
            this.usuariosTableAdapter1 = new ExpenseManager.EXPENSE_MANAGERDataSetTableAdapters.usuariosTableAdapter();
            this.pbx_login = new System.Windows.Forms.PictureBox();
            this.tab_sesion.SuspendLayout();
            this.tabP_inicio.SuspendLayout();
            this.tabP_nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensE_MANAGERDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_login)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI Emoji", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(58, 68);
            this.txt_usuario.MaxLength = 25;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(256, 30);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_usuario.GotFocus += new System.EventHandler(this.TextBoxes_GotFocus);
            // 
            // txt_contrasegna
            // 
            this.txt_contrasegna.BackColor = System.Drawing.Color.White;
            this.txt_contrasegna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contrasegna.Font = new System.Drawing.Font("Segoe UI Emoji", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasegna.ForeColor = System.Drawing.Color.Black;
            this.txt_contrasegna.Location = new System.Drawing.Point(58, 135);
            this.txt_contrasegna.MaxLength = 25;
            this.txt_contrasegna.Name = "txt_contrasegna";
            this.txt_contrasegna.PasswordChar = '#';
            this.txt_contrasegna.Size = new System.Drawing.Size(256, 30);
            this.txt_contrasegna.TabIndex = 1;
            this.txt_contrasegna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contrasegna.GotFocus += new System.EventHandler(this.TextBoxes_GotFocus);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Image = global::ExpenseManager.Properties.Resources.Ionic_Ionicons_Log_in_sharp_32;
            this.btn_login.Location = new System.Drawing.Point(0, 289);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(686, 53);
            this.btn_login.TabIndex = 5;
            this.btn_login.TabStop = false;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_crea_usuario
            // 
            this.btn_crea_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.btn_crea_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_crea_usuario.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_crea_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crea_usuario.Location = new System.Drawing.Point(0, 0);
            this.btn_crea_usuario.Name = "btn_crea_usuario";
            this.btn_crea_usuario.Size = new System.Drawing.Size(686, 10);
            this.btn_crea_usuario.TabIndex = 6;
            this.btn_crea_usuario.TabStop = false;
            this.btn_crea_usuario.UseVisualStyleBackColor = false;
            this.btn_crea_usuario.Click += new System.EventHandler(this.bnt_crea_usuario_Click);
            // 
            // txt_nuevo_usuario
            // 
            this.txt_nuevo_usuario.BackColor = System.Drawing.Color.White;
            this.txt_nuevo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nuevo_usuario.Font = new System.Drawing.Font("Segoe UI Emoji", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevo_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_nuevo_usuario.Location = new System.Drawing.Point(58, 69);
            this.txt_nuevo_usuario.MaxLength = 25;
            this.txt_nuevo_usuario.Name = "txt_nuevo_usuario";
            this.txt_nuevo_usuario.Size = new System.Drawing.Size(256, 30);
            this.txt_nuevo_usuario.TabIndex = 8;
            this.txt_nuevo_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nuevo_usuario
            // 
            this.lbl_nuevo_usuario.BackColor = System.Drawing.Color.White;
            this.lbl_nuevo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevo_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nuevo_usuario.Location = new System.Drawing.Point(55, 49);
            this.lbl_nuevo_usuario.Name = "lbl_nuevo_usuario";
            this.lbl_nuevo_usuario.Size = new System.Drawing.Size(73, 16);
            this.lbl_nuevo_usuario.TabIndex = 9;
            this.lbl_nuevo_usuario.Text = "Usuario:";
            this.lbl_nuevo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pass_nuevo_usuario
            // 
            this.lbl_pass_nuevo_usuario.BackColor = System.Drawing.Color.White;
            this.lbl_pass_nuevo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass_nuevo_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_pass_nuevo_usuario.Location = new System.Drawing.Point(55, 116);
            this.lbl_pass_nuevo_usuario.Name = "lbl_pass_nuevo_usuario";
            this.lbl_pass_nuevo_usuario.Size = new System.Drawing.Size(90, 16);
            this.lbl_pass_nuevo_usuario.TabIndex = 11;
            this.lbl_pass_nuevo_usuario.Text = "Contraseña:";
            this.lbl_pass_nuevo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_pass_nuevo_usuario
            // 
            this.txt_pass_nuevo_usuario.BackColor = System.Drawing.Color.White;
            this.txt_pass_nuevo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass_nuevo_usuario.Font = new System.Drawing.Font("Segoe UI Emoji", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_nuevo_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_pass_nuevo_usuario.Location = new System.Drawing.Point(58, 136);
            this.txt_pass_nuevo_usuario.MaxLength = 25;
            this.txt_pass_nuevo_usuario.Name = "txt_pass_nuevo_usuario";
            this.txt_pass_nuevo_usuario.Size = new System.Drawing.Size(256, 30);
            this.txt_pass_nuevo_usuario.TabIndex = 10;
            this.txt_pass_nuevo_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_guardar_nvo_usuario
            // 
            this.btn_guardar_nvo_usuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_guardar_nvo_usuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_guardar_nvo_usuario.FlatAppearance.BorderSize = 2;
            this.btn_guardar_nvo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_nvo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_nvo_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar_nvo_usuario.Location = new System.Drawing.Point(226, 190);
            this.btn_guardar_nvo_usuario.Name = "btn_guardar_nvo_usuario";
            this.btn_guardar_nvo_usuario.Size = new System.Drawing.Size(70, 27);
            this.btn_guardar_nvo_usuario.TabIndex = 12;
            this.btn_guardar_nvo_usuario.Text = "Guardar";
            this.btn_guardar_nvo_usuario.UseVisualStyleBackColor = false;
            this.btn_guardar_nvo_usuario.Click += new System.EventHandler(this.btn_guardar_nvo_usuario_Click);
            // 
            // btn_cancelar_nvo_usuario
            // 
            this.btn_cancelar_nvo_usuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar_nvo_usuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_cancelar_nvo_usuario.FlatAppearance.BorderSize = 2;
            this.btn_cancelar_nvo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_nvo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_nvo_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cancelar_nvo_usuario.Location = new System.Drawing.Point(302, 190);
            this.btn_cancelar_nvo_usuario.Name = "btn_cancelar_nvo_usuario";
            this.btn_cancelar_nvo_usuario.Size = new System.Drawing.Size(70, 27);
            this.btn_cancelar_nvo_usuario.TabIndex = 13;
            this.btn_cancelar_nvo_usuario.Text = "Cancelar";
            this.btn_cancelar_nvo_usuario.UseVisualStyleBackColor = false;
            this.btn_cancelar_nvo_usuario.Click += new System.EventHandler(this.btn_cancelar_nvo_usuario_Click);
            // 
            // tmr_exp_contr
            // 
            this.tmr_exp_contr.Tick += new System.EventHandler(this.tmr_exp_contr_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(60, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Iniciar Sesión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(55, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(55, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Usuario:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(58, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "Datos del nuevo usuario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tab_sesion
            // 
            this.tab_sesion.Controls.Add(this.tabP_inicio);
            this.tab_sesion.Controls.Add(this.tabP_nuevo);
            this.tab_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_sesion.Location = new System.Drawing.Point(287, 21);
            this.tab_sesion.Name = "tab_sesion";
            this.tab_sesion.SelectedIndex = 0;
            this.tab_sesion.Size = new System.Drawing.Size(386, 254);
            this.tab_sesion.TabIndex = 21;
            this.tab_sesion.SelectedIndexChanged += new System.EventHandler(this.tab_sesion_SelectedIndexChanged);
            this.tab_sesion.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_sesion_Selected);
            // 
            // tabP_inicio
            // 
            this.tabP_inicio.BackColor = System.Drawing.Color.White;
            this.tabP_inicio.Controls.Add(this.label1);
            this.tabP_inicio.Controls.Add(this.txt_usuario);
            this.tabP_inicio.Controls.Add(this.txt_contrasegna);
            this.tabP_inicio.Controls.Add(this.lbl_nuevo_usuario);
            this.tabP_inicio.Controls.Add(this.lbl_pass_nuevo_usuario);
            this.tabP_inicio.Location = new System.Drawing.Point(4, 24);
            this.tabP_inicio.Name = "tabP_inicio";
            this.tabP_inicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_inicio.Size = new System.Drawing.Size(378, 226);
            this.tabP_inicio.TabIndex = 0;
            this.tabP_inicio.Text = "Iniciar sesión";
            // 
            // tabP_nuevo
            // 
            this.tabP_nuevo.BackColor = System.Drawing.Color.White;
            this.tabP_nuevo.Controls.Add(this.txt_nuevo_usuario);
            this.tabP_nuevo.Controls.Add(this.label4);
            this.tabP_nuevo.Controls.Add(this.txt_pass_nuevo_usuario);
            this.tabP_nuevo.Controls.Add(this.btn_guardar_nvo_usuario);
            this.tabP_nuevo.Controls.Add(this.btn_cancelar_nvo_usuario);
            this.tabP_nuevo.Controls.Add(this.label2);
            this.tabP_nuevo.Controls.Add(this.label3);
            this.tabP_nuevo.Location = new System.Drawing.Point(4, 24);
            this.tabP_nuevo.Name = "tabP_nuevo";
            this.tabP_nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_nuevo.Size = new System.Drawing.Size(378, 226);
            this.tabP_nuevo.TabIndex = 1;
            this.tabP_nuevo.Text = "Crear nuevo usuario";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 565);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(859, 3);
            this.progress.TabIndex = 22;
            // 
            // expensE_MANAGERDataSet1
            // 
            this.expensE_MANAGERDataSet1.DataSetName = "EXPENSE_MANAGERDataSet";
            this.expensE_MANAGERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // pbx_login
            // 
            this.pbx_login.Image = global::ExpenseManager.Properties.Resources.Gartoon_Team_Gartoon_Apps_Seahorse_key_personal_512;
            this.pbx_login.Location = new System.Drawing.Point(14, 21);
            this.pbx_login.Name = "pbx_login";
            this.pbx_login.Size = new System.Drawing.Size(267, 254);
            this.pbx_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_login.TabIndex = 18;
            this.pbx_login.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(686, 342);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tab_sesion);
            this.Controls.Add(this.pbx_login);
            this.Controls.Add(this.btn_crea_usuario);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Expense Manager - LOGIN";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.tab_sesion.ResumeLayout(false);
            this.tabP_inicio.ResumeLayout(false);
            this.tabP_inicio.PerformLayout();
            this.tabP_nuevo.ResumeLayout(false);
            this.tabP_nuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensE_MANAGERDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrasegna;
        private System.Windows.Forms.Button btn_login;
        private EXPENSE_MANAGERDataSetTableAdapters.usuariosTableAdapter loginTableAdapter1;
        private System.Windows.Forms.Button btn_crea_usuario;
        private System.Windows.Forms.TextBox txt_nuevo_usuario;
        private System.Windows.Forms.Label lbl_nuevo_usuario;
        private System.Windows.Forms.Label lbl_pass_nuevo_usuario;
        private System.Windows.Forms.TextBox txt_pass_nuevo_usuario;
        private System.Windows.Forms.Button btn_guardar_nvo_usuario;
        private System.Windows.Forms.Button btn_cancelar_nvo_usuario;
        private System.Windows.Forms.Timer tmr_exp_contr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbx_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tab_sesion;
        private System.Windows.Forms.TabPage tabP_inicio;
        private System.Windows.Forms.TabPage tabP_nuevo;
        private System.Windows.Forms.ProgressBar progress;
        private EXPENSE_MANAGERDataSet expensE_MANAGERDataSet1;
        private EXPENSE_MANAGERDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter1;
        // ******************************** from Caja_ahorro - It isn't useful in this project, at least at the moment **************************************
        //private C_AHORRO_NEW_DSTableAdapters.creadoTableAdapter creadoTableAdapter1;
        //private C_AHORRO_NEW_DSTableAdapters.estadoTableAdapter estadoTableAdapter1;
    }
}