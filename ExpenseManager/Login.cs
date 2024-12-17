using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace ExpenseManager
{
    public partial class Login : Form
    {
        private int scrDimH;
        private int scrDimV;
        private int barProgCounter;
        // static vars
        static int increase;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter1.Fill(expensE_MANAGERDataSet1.usuarios);
            string fileName = "Exported.txt";
            //FileManager.WriteFile(fileName, "1");
            //MessageBox.Show(FileManager.ReadFile(fileName));
            //if (FileManager.ReadFile(fileName).Equals("0")) { MessageBox.Show("Es cero"); }

            bool exported = FileManager.ReadFile("Exported.txt").Equals("1");
            if (exported)  // exportada field
            {
                DbTransferingManager.ImportingDBFromCloud();
                //this.pbx_db_state.Image = global::CajaDeAhorro.Properties.Resources.Custom_Icon_Design_Pretty_Office_3_Accept_database_32;

                FileManager.WriteFile("Exported.txt", "0");
                FileManager.WriteFile("Imported.txt", "1");
                FileManager.WriteFile("Updated.txt", "0");
            }
            else
            {
                this.Text += " ( Non-imported Database )";

                try { FileManager.WriteFile("Imported.txt", "0"); }
                catch (Exception) { Console.WriteLine(e); }
            }
            DbTransferingManager.ImportingDBFromCloud();
        }

        public void LoadingModules()
        {
            this.usuariosTableAdapter1.Fill(expensE_MANAGERDataSet1.usuarios);
            Auxiliar.main = new Main();
            Auxiliar.admin = new Administrador();
            Auxiliar.login = this;
            scrDimH = Screen.PrimaryScreen.Bounds.Width;
            scrDimV = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(scrDimH / 2 - this.ClientRectangle.Width / 2, scrDimV / 2 - this.ClientRectangle.Height / 2);
            this.btn_crea_usuario.Visible = false;
            increase = 0;
            this.txt_contrasegna.Clear();
            this.txt_usuario.Focus();
        }

        private void TextBoxes_GotFocus(object sender, EventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            //if (textBox.TextLength > 0)
            //{
            //    textBox.SelectAll();
            //}
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (this.txt_contrasegna.TextLength == 0)
            {
                MessageBox.Show("Debe ingresar una contraseña para poder iniciar sesión","Expense Manager - 🗝️ Login",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (this.txt_usuario.Text == "admin" && this.txt_contrasegna.Text == "12345")
                {
                    //Auxiliar.admin.Show();
                    //Auxiliar.login.Hide();
                    MessageBox.Show("Sorry! the admin panel is under construction yet!");
                }            
                else if (Convert.ToInt32(this.usuariosTableAdapter1.ScalarQuery(this.txt_usuario.Text, this.txt_contrasegna.Text)) == 1)
                {
                    // obtener el valor del id del usuario logueado y guardarlo en Auxiliar
                    this.usuariosTableAdapter1.FillByWhoIsLogged(expensE_MANAGERDataSet1.usuarios, this.txt_usuario.Text, this.txt_contrasegna.Text);
                    Auxiliar.id_logged = expensE_MANAGERDataSet1.Tables["usuarios"].Rows[0].Field<int>(0);
                    this.tmr_exp_contr.Interval = 1;
                    this.tmr_exp_contr.Start();
                    //MessageBox.Show(Auxiliar.id_logged.ToString());
                }
            }
        }

        private void Btn_crea_usuario_Click(object sender, EventArgs e) // botón de arriba (top form)
        {
            this.tmr_exp_contr.Start(); // timer start
            // código movido a tick 
        }

        private void Btn_guardar_nvo_usuario_Click(object sender, EventArgs e)
        {
            // Código para guardar un nuevo usuario en la tabla login
            if (this.txt_nuevo_usuario.TextLength > 0 && this.txt_pass_nuevo_usuario.TextLength > 0)
            {
                DialogResult Dr;
                Dr = MessageBox.Show("Confirma la creación del nuevo usuario?", "Expense Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.No)
                    return;
                if (Convert.ToInt32(this.usuariosTableAdapter1.CheckUserScalarQuery(this.txt_nuevo_usuario.Text)) == 1)
                {
                    MessageBox.Show("Error: ya existe un usuario con el mismo nombre.\nPor favor, ingrese un nombre diferente.",
                        "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_nuevo_usuario.Focus();
                    this.txt_nuevo_usuario.SelectAll();
                }
                else
                {
                    try
                    {
                        int newUserId = Convert.ToInt32(this.usuariosTableAdapter1.BiggestIdScalarQuery()) + 1;    // working here 24/12/2021 05:30
                        this.usuariosTableAdapter1.InsertQuery(newUserId, this.txt_nuevo_usuario.Text, this.txt_pass_nuevo_usuario.Text, DateTime.Now);
                        //FileManager.WriteFile("Updated.txt", "1");
                        if (Convert.ToInt32(this.usuariosTableAdapter1.CheckUserScalarQuery(this.txt_nuevo_usuario.Text)) == 1)
                        {                           
                            MessageBox.Show("Nuevo usuario creado.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //this.tmr_exp_contr.Start();
                        //FileManager.WriteFile("Updated.txt", "1");
                    }
                    catch (Exception) { }
                }
            }
        }

        private void Btn_cancelar_nvo_usuario_Click(object sender, EventArgs e)
        {
            this.txt_nuevo_usuario.Clear();
            this.txt_pass_nuevo_usuario.Clear();
            this.tab_sesion.SelectedTab = this.tab_sesion.TabPages[0];
            //this.tmr_exp_contr.Start();
        }

        private void Tmr_exp_contr_Tick(object sender, EventArgs e)     // timer's tick
        {
            if (this.progress.Value < 100)
            {
                this.progress.Value += 10;
            }

            if (this.progress.Value == 100)
            {
                if (this.barProgCounter == 45)
                {
                    tmr_exp_contr.Stop();
                    this.barProgCounter = 0;
                    this.progress.Value = 0;
                    Auxiliar.main.Show();
                    Auxiliar.login.Hide();
                }
                else
                {
                    barProgCounter++;
                }
            }
        }

        private void Tab_sesion_Selected(object sender, TabControlEventArgs e)
        {
            if (this.tab_sesion.SelectedTab == tabP_nuevo)
            {
                this.pbx_login.Image = global::ExpenseManager.Properties.Resources.Gartoon_Team_Gartoon_Apps_System_users_512;
            }
            else
            {
                this.pbx_login.Image = global::ExpenseManager.Properties.Resources.Gartoon_Team_Gartoon_Apps_Seahorse_key_personal_512;
            }
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            LoadingModules();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FileManager.ReadFile("Updated.txt").Equals("1"))
            {
                MessageBox.Show("No olvide exportar la base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
