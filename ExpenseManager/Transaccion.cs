using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    public partial class Transaccion : Form
    {
        public Transaccion()
        {
            InitializeComponent();
        }

        private void Transaccion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS1.cuentas' table. You can move, or remove it, as needed.
            this.cuentasTableAdapter.Fill(this.c_AHORRO_NEW_DS1.cuentas);
            c_AHORRO_NEW_DS1.Clear();
            try
            {
                this.moviTableAdapter2.Fill(this.c_AHORRO_NEW_DS1.movimientos);  // cargo el dataset con info
            }
            catch (Exception) { }

            try
            {
                this.cuentasTableAdapter.FillByAccountName(this.c_AHORRO_NEW_DS1.cuentas, ((int)(System.Convert.ChangeType(Auxiliar.id_logged, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            this.dtp.Visible = false;

            if (this.Text.EndsWith("ito"))
            {
                this.lbl_trans.Text = "Monto en pesos($):";
                this.btn_trans.Text = "Depositar";
            }
            else
            {
                this.lbl_trans.Text = "Monto en pesos($):";
                this.btn_trans.Text = "Extraer";
            }
        }

        private void btn_trans_Click(object sender, EventArgs e)
        {
            if (txt_trans_monto.Text == "" || txt_trans_monto.Text == null)
            {
                return;
            }

            DateTime dateTime;
            dateTime = this.dtp.Value;

            int montoFromTextbox = 0;
            _ = Int32.TryParse(this.txt_trans_monto.Text, out montoFromTextbox);

            if (montoFromTextbox <= 0)
                return;

            int dineroEnCaja = Auxiliar.getDineroEnCaja();

            DialogResult dR;
            dR = MessageBox.Show("Confirma la transacción?", "Caja de ahorro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == DialogResult.No)
            {
                this.txt_trans_monto.Text = "";
                return;
            }

            int id = Convert.ToInt32(this.moviTableAdapter2.MaxIdScalarQuery()) + 1;

            if (this.Text.EndsWith("ito"))
            {
                //this.lbl_account.Text = "a la cuenta:";
                //dineroEnCaja += montoFromTextbox;
                try
                {
                    // nuevo registro de transacción de depósito
                    int selectedIdx = this.cbx_accounts.SelectedIndex;
                    int accountIdx = (int)this.cbx_accounts.SelectedValue;  // id of the account
                    decimal saldo = this.c_AHORRO_NEW_DS1.Tables["cuentas"].Rows[selectedIdx].Field<decimal>(2);
                    //MessageBox.Show(saldo.ToString());
                    int insert_result = this.moviTableAdapter2.InsertQuery(id, dateTime, "dep", Convert.ToDecimal(montoFromTextbox), saldo, txt_concepto.Text, Auxiliar.id_logged, accountIdx);
                    if (insert_result > 0)
                    {
                        MessageBox.Show("Depósito realizado con éxito!.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saldo += Convert.ToDecimal(montoFromTextbox);
                        this.cuentasTableAdapter.UpdateQuery(saldo, accountIdx, Auxiliar.id_logged);
                    }
                    //FileManager.WriteFile("Updated.txt", "1");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (montoFromTextbox > dineroEnCaja)
                {
                    if (dineroEnCaja == 0)
                        MessageBox.Show("Error: no dispone de saldo!", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Error: no dispone de saldo suficiente!", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    dineroEnCaja -= montoFromTextbox;
                    MessageBox.Show("Extracción realizada con éxito!.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        // nuevo registro de transacción de extracción
                        //this.moviTableAdapter2.InsertQuery(id, dateTime, "extracción", montoFromTextbox, Auxiliar.id_logged);
                        //FileManager.WriteFile("Updated.txt", "1");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            try
            {
                //this.loginTableAdapter1.UpdateQuery(dineroEnCaja, Auxiliar.id_logged, Auxiliar.id_logged);
                //FileManager.WriteFile("Updated.txt", "1");
            }
            catch (Exception) { }

            // ************************************************************************************************   working here   *************************
            if (this.txt_concepto.TextLength > 0)
            {
                if (this.txt_concepto.Text == "$correctivo")
                {
                    //this.mensajeTableAdapter1.MessageInsertQuery(id, Auxiliar.getTextCorrective());
                }
                else
                {
                    //this.mensajeTableAdapter1.MessageInsertQuery(id, this.txt_concepto.Text);
                }
                //FileManager.WriteFile("Updated.txt", "1");
            }
            this.Close();
            // ************************************************************************************************   working here   *************************
        }

        private void txt_trans_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.btn_trans.PerformClick();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "0")
            {
                if (this.txt_trans_monto.Text.Length > 0)
                {
                    this.txt_trans_monto.Text += button.Text;
                }
            }
            else
            {
                this.txt_trans_monto.Text += button.Text;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.txt_trans_monto.Text.Length > 0)
            {
                this.txt_trans_monto.Text = this.txt_trans_monto.Text.Remove(this.txt_trans_monto.Text.Length - 1);
            }
        }

        private void btn_correctivo_Click(object sender, EventArgs e)
        {
            this.txt_concepto.Text = "$correctivo";
        }

    }
}
