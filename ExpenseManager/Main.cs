﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ExpenseManager
{
    public partial class Main : Form
    {
        static int increase;
        private int accountCount; 
        private int accountBalance;
        public double opacity = 0.9;
        public double WinOpacity { get; set; }
        private int Notes { get; set; }
        private int Accounts { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void ActivOrDeactivButtBar()
        {
            bool activate_accounts = Accounts != 0;
            bool activate_notes = Notes != 0;

            // deposits, withdrawals, etc
            this.tStrip_deposito.Enabled = activate_accounts;
            this.tStrip_extraccion.Enabled = activate_accounts;
            this.tStrip_transfer.Enabled = activate_accounts;
            this.tStrip_ver_registro.Enabled = activate_accounts;

            // account actions ...
            this.tStrip_ver_cuentas.Enabled = activate_accounts;
            this.tStrip_borrar_cuenta.Enabled = activate_accounts;


            if (Notes == 0)
            {
                this.tStrip_edit_nota.Enabled = activate_notes;
                this.tStrip_delete_nota.Enabled = activate_notes;
                this.tStrip_ver_notas.Enabled = activate_notes;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS1.movi' table. You can move, or remove it, as needed.
            try { this.moviTableAdapter.Fill(this.c_AHORRO_NEW_DS1.movimientos); }
            catch (Exception) { }
            this.Text = Auxiliar.getAppName() + " Usuario logueado => ";
            this.loginTableAdapter1.FillByIdLogged(this.c_AHORRO_NEW_DS1.usuarios, Auxiliar.id_logged);
            // capturo el nombre del usuario logueado y lo adjunto al texto del form
            Auxiliar.LoggUserName = this.c_AHORRO_NEW_DS1.Tables["usuarios"].Rows[0].Field<string>(1).ToString();
            //Auxiliar.LoggUserName = Auxiliar.LoggUserName.Replace(" ", "");   // quito los espacios en blanco del final
            this.Text = this.Text + " [ " + Auxiliar.LoggUserName.ToUpper() + " ]";
            //this.creadoTableAdapter1.FillByFecCrea(c_AHORRO_NEW_DS1.creado, Auxiliar.id_logged);  * Must fill will the user creation date 
            //DateTime dateTime = new DateTime();

            this.lbl_saldo.Text = "";
            ConnectToDB();

            // ********************* some test lines ***************

            //lbl_dios_desmolde.Text = "ISMA - EL DIOS DEL DESMOLDE"; //**** este texto tenía originalmente ****
            DateTime dT;
            dT = DateTime.Now;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.Enabled = true;
            increase = 0;
        }

        public void GetLastNotes()
        {
            int count = this.notasTableAdapter.FillByNotasById_log_desc(this.c_AHORRO_NEW_DS1.notas, Auxiliar.id_logged);
            this.Notes = count;
            for (int i = 0; i < count; i++)
            {
                if (this.flp_note.Controls.Count < 8)
                {
                    Nota nota = new Nota();
                    string note_title;
                    if (this.c_AHORRO_NEW_DS1.Tables["notas"].Rows[i].Field<string>(1).Length > 8)
                    {
                        note_title = this.c_AHORRO_NEW_DS1.Tables["notas"].Rows[i].Field<string>(1).Substring(0, 8) + "...";
                    }
                    else
                    {
                        note_title = this.c_AHORRO_NEW_DS1.Tables["notas"].Rows[i].Field<string>(1);
                    }

                    Button button = new Button();
                    button = nota.CreateNewNoteWithAttrib(note_title);
                    button.Name = this.c_AHORRO_NEW_DS1.Tables["notas"].Rows[i].Field<int>(0).ToString();
                    button.BackColor = Color.White;
                    button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
                    button.FlatAppearance.BorderSize = 3;
                    this.flp_note.Controls.Add(button);
                }
            }
            ActivOrDeactivButtBar();
        }

        private void Flp_note_ControlAdded(object sender, ControlEventArgs e)
        {
            Button btn = (Button)this.flp_note.Controls[increase];
            btn.Click += Btn_note_click;
            ++increase;
        }

        private void Btn_note_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Auxiliar.id_note = Convert.ToInt32(button.Name);

            this.WinOpacity = this.opacity;
            DetNota detNota = new DetNota();
            detNota.StartPosition = FormStartPosition.CenterScreen;
            detNota.ShowDialog(this);
        }

        private void ConsultingSelectedAccountProps()
        {
            int selectedIdx = this.cbx_accounts.SelectedIndex;
            int id_selected_account = Convert.ToInt32(this.cbx_accounts.SelectedValue);
            try
            {
                //this.lbl_saldo.Text = "$ " + this.c_AHORRO_NEW_DS1.Tables["cuentas"].Rows[selectedIdx].Field<decimal>(2).ToString();
                this.lbl_saldo.Text = "$ " + Auxiliar.GetSaldoAccount(this.moviTableAdapter, id_selected_account);
                //MessageBox.Show(this.cbx_accounts.SelectedValue.ToString());
                //decimal d = Convert.ToDecimal(this.cbx_accounts.SelectedValue);
                //this.Text = d.ToString();
            }
            catch (Exception) { }
        }

        private void ConnectToDB()      // modificar todo este método
        {
            // 11/11/2024
            //Auxiliar.id_logged = 1;
            //lbl_fecha_portada.Text = dateTimePicker1.Text;
            // capturo el valor caja del row del usuario logueado
            //this.lbl_caja_valor.Text = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3).ToString();
            // capturo el nombre del usuario logueado y lo adjunto al texto del form
            //this.Text = "  CAJA DE AHORRO - USUARIO ACTIVO = " + this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<string>(1).ToString();
            // capturo el valor de caja del usuario activo
            //this.lbl_caja_valor.Text = "$" + IfItHasAPointWithParam(this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3).ToString());
            // capturo el valor de caja del usuario activo y lo guardo en Auxiliar
            //Auxiliar.dineroEnCaja = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3);

            // getting the Accounts
            try
            {
                this.accountCount = this.cuentasTableAdapter.FillByAccountSaldoDesc(this.c_AHORRO_NEW_DS1.cuentas, ((int)(System.Convert.ChangeType(Auxiliar.id_logged, typeof(int)))));
                if (accountCount > 0)
                {
                    ConsultingSelectedAccountProps();
                }
                else
                {
                    this.Accounts = accountCount;
                }
                
            }
            catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }

            // getting the last five movements of the user
            try
            {
                this.moviTableAdapter.FillByLastFiveMovs(this.c_AHORRO_NEW_DS1.movimientos, Auxiliar.id_logged);
            }
            catch (Exception) { }

            // getting the last eight notes of the user
            increase = 0;
            this.flp_note.Controls.Clear();
            GetLastNotes();
        }

        public static String IfItHasAPointWithParam(String caja)
        {
            double s = double.Parse(caja);
            return String.Format("{0:N2}", s);
        }

        private void btn_extraccion_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            MostrarVentTrans(sender);
        }

        public void MostrarVentTrans(object sender)
        {
            Transaccion transaccion = new Transaccion();
            ToolStripButton ts_btn = (ToolStripButton)sender;
            if (ts_btn.Equals(tStrip_deposito))
                transaccion.Text = Auxiliar.getAppName() + " Realizar un depósito";
            else if (ts_btn.Equals(tStrip_extraccion))
                transaccion.Text = Auxiliar.getAppName() + " Realizar una extracción";
            transaccion.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Auxiliar.main.Hide();
            Auxiliar.login.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.WinOpacity = 1;
            ConnectToDB();
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            if (this.WinOpacity < 1)
                this.Opacity = WinOpacity;
        }

        private void btn_ver_notas_Click(object sender, EventArgs e)
        {

        }

        private void cbx_accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultingSelectedAccountProps();
        }

        private void tStrip_close_sesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tStrip_ver_registro_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            Log log = new Log();
            log.LoggedUserName = Auxiliar.LoggUserName;
            log.ShowDialog();
        }

        private void tStrip_deposito_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            MostrarVentTrans(sender);
        }

        private void tStrip_extraccion_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            MostrarVentTrans(sender);
        }

        private void tStrip_new_nota_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            Notas notas = new Notas();
            notas.ShowDialog();
        }

        private void tStrip_edit_nota_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            Notas notas = new Notas();
            notas.EditarTab = true;
            notas.Show(this);
        }

        private void tStrip_delete_nota_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            Notas notas = new Notas();
            notas.EliminTab = true;
            notas.Show(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            CreateAccount newAccount = new CreateAccount();
            newAccount.ShowDialog(this);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            DeleteAccount deleteAccount = new DeleteAccount();
            deleteAccount.ShowDialog(this);
        }
    }
}
