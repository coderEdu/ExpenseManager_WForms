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
        public double opacity = 0.3;
        public double WinOpacity { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS1.cuentas' table. You can move, or remove it, as needed.
            this.cuentasTableAdapter.Fill(this.c_AHORRO_NEW_DS1.cuentas);
            //MessageBox.Show("Hi");
            // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS1.movi' table. You can move, or remove it, as needed.
            try { this.moviTableAdapter.Fill(this.c_AHORRO_NEW_DS1.movimientos); }
            catch (Exception) { }

            this.Text = Auxiliar.getAppName() + " Sesión Activa";
            //this.creadoTableAdapter1.FillByFecCrea(c_AHORRO_NEW_DS1.creado, Auxiliar.id_logged);  * Must fill will the user creation date 
            DateTime dateTime = new DateTime();


            ConnectToDB();

            // ********************* some test lines ***************

            //lbl_dios_desmolde.Text = "ISMA - EL DIOS DEL DESMOLDE"; //**** este texto tenía originalmente ****
            DateTime dT;
            dT = DateTime.Now;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.Enabled = true;
            increase = 0;
            GetLastNotes();

        }

        public void GetLastNotes()
        {
            int count = this.notasTableAdapter.FillByNotasById_log(this.c_AHORRO_NEW_DS1.notas, Auxiliar.id_logged); //MessageBox.Show(count.ToString());
            this.loginTableAdapter1.Fill(this.c_AHORRO_NEW_DS1.usuarios);  // ay q llenar el ds p/poder obt los datos
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
        }

        private void ConnectToDB()      // modificar todo este método
        {
            // 11/11/2024
            Auxiliar.id_logged = 1;
            // código nuevo 24/6/2021 - desde el nuevo dataset
            //this.loginTableAdapter1.FillByIdLogged(this.c_AHORRO_NEW_DS1.usuarios, Auxiliar.id_logged);
            // capturo el nombre del usuario logueado y lo adjunto al texto del lbl_dios_desmolde
            //Auxiliar.LoggUserName = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<string>(1).ToString();
            //Auxiliar.LoggUserName = Auxiliar.LoggUserName.Replace(" ", "");   // quito los espacios en blanco del final
            //lbl_dios_desmolde.Text = "usuario activo [ " + Auxiliar.LoggUserName + " ]";
            //lbl_fecha_portada.Text = dateTimePicker1.Text;
            // capturo el valor caja del row del usuario logueado
            //this.lbl_caja_valor.Text = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3).ToString();
            // capturo el nombre del usuario logueado y lo adjunto al texto del form
            //this.Text = "  CAJA DE AHORRO - USUARIO ACTIVO = " + this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<string>(1).ToString();
            // capturo el valor de caja del usuario activo
            //this.lbl_caja_valor.Text = "$" + IfItHasAPointWithParam(this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3).ToString());
            // capturo el valor de caja del usuario activo y lo guardo en Auxiliar
            //Auxiliar.dineroEnCaja = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3);

            try
            {
                this.cuentasTableAdapter.FillByAccountName(this.c_AHORRO_NEW_DS1.cuentas, ((int)(System.Convert.ChangeType(Auxiliar.id_logged, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.moviTableAdapter.FillByLastFiveMovs(this.c_AHORRO_NEW_DS1.movimientos, Auxiliar.id_logged);
            }
            catch (Exception)
            { }

            // cambio el color de "Saldo diponible" según el saldo disponible jeje
            //if (Auxiliar.dineroEnCaja > 25000)
            //    this.lbl_caja_valor.ForeColor = Color.Blue;
            //else if (Auxiliar.dineroEnCaja > 5000)
            //    this.lbl_caja_valor.ForeColor = Color.Green;
            //else if (Auxiliar.dineroEnCaja > 1000)
            //    this.lbl_caja_valor.ForeColor = Color.Gold;
            //else if (Auxiliar.dineroEnCaja > 100)
            //    this.lbl_caja_valor.ForeColor = Color.Orange;
            //else
            //    this.lbl_caja_valor.ForeColor = Color.Red;

            increase = 0;
            this.flp_note.Controls.Clear();
            GetLastNotes();
        }

        public static String IfItHasAPointWithParam(String caja)
        {
            double s = double.Parse(caja);
            return String.Format("{0:N2}", s);
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            MostrarVentTrans(sender);
        }

        private void btn_extraccion_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            MostrarVentTrans(sender);
        }

        public void MostrarVentTrans(object sender)
        {
            //Transaccion transaccion = new Transaccion();
            //Button button = (Button)sender;
            //if (button.Equals(btn_deposito))
            //    transaccion.Text = Auxiliar.getAppName() + " Realizar un depósito";
            //else
            //    transaccion.Text = Auxiliar.getAppName() + " Realizar una extracción";
            //transaccion.ShowDialog();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.LoggedUserName = Auxiliar.LoggUserName;
            log.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //Auxiliar.main.Hide();
            //Auxiliar.login.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.WinOpacity = 1;
            ConnectToDB();
        }

        private void flp_note_ControlAdded(object sender, ControlEventArgs e)
        {
            Button btn = (Button)this.flp_note.Controls[increase];
            btn.Click += Btn_note_click;
            ++increase;
        }

        private void Btn_note_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Auxiliar.id_note = Convert.ToInt32(button.Name);

            Point location = new Point(0, 0);
            //int sysScreenWidth = Convert.ToInt32(System.Windows.SystemParameters.PrimaryScreenWidth);
            //int sysScreenHeight = Convert.ToInt32(System.Windows.SystemParameters.PrimaryScreenHeight);
            //MessageBox.Show(sysScreenWidth.ToString()+","+sysScreenHeight.ToString());

            //if (sysScreenWidth < 1600)
            //{
            //    location = new Point(this.Location.X + this.Width - 343, this.Location.Y);
            //}
            //else
            //{
            //    if (this.Location.X >= sysScreenWidth / 3)
            //        location = new Point(this.Location.X - 333, this.Location.Y);
            //    else
            //        location = new Point(this.Location.X + this.Width - 10, this.Location.Y);
            //}

            //DetNota detNota = new DetNota();
            //detNota.WinLocation = location;
            //detNota.Show(this);
        }

        private void btn_crear_nota_Click(object sender, EventArgs e)
        {
            //this.WinOpacity = this.opacity;
            //Notas notas = new Notas();
            //notas.ShowDialog();
        }

        private void btn_editar_nota_Click(object sender, EventArgs e)
        {
            //this.WinOpacity = this.opacity;
            //Notas notas = new Notas();
            //notas.EditarTab = true;
            //notas.Show(this);
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            if (this.WinOpacity < 1)
                this.Opacity = WinOpacity;
        }

        private void btn_exit_sess_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_remove_note_Click(object sender, EventArgs e)
        {
            //this.WinOpacity = this.opacity;
            //Notas notas = new Notas();
            //notas.EliminTab = true;
            //notas.Show(this);
        }

        private void btn_ver_notas_Click(object sender, EventArgs e)
        {

        }
    }
}
