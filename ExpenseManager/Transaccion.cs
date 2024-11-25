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
        private DateTime dateTime;
        public Transaccion()
        {
            InitializeComponent();
        }

        private void Transaccion_Load(object sender, EventArgs e)
        {
            dateTime = this.dtp.Value;
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
                this.lbl_account.Text = "A la cuenta:";
                this.lbl_trans.Text = "Monto en pesos($):";
                this.btn_trans.Text = "Depositar";
            }
            else
            {
                this.lbl_account.Text = "De la cuenta:";
                this.lbl_trans.Text = "Monto en pesos($):";
                this.btn_trans.Text = "Extraer";
            }
        }

        private void Deposit(int montoIngresado)
        {
            try   // making a deposit
            {
                // nuevo registro de transacción de depósito
                int id = Convert.ToInt32(this.moviTableAdapter2.MaxIdScalarQuery()) + 1;
                int selectedIdx = this.cbx_accounts.SelectedIndex;
                int accountIdx = (int)this.cbx_accounts.SelectedValue;  // id of the account
                decimal? saldo = Auxiliar.GetSaldoAccount(this.moviTableAdapter2, accountIdx);
                int insert_result = this.moviTableAdapter2.InsertQuery(id, dateTime, "dep", Convert.ToDecimal(montoIngresado), (decimal)saldo, txt_concepto.Text, Auxiliar.id_logged, accountIdx);
                if (insert_result > 0)
                {
                    MessageBox.Show("Depósito realizado con éxito!.", "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saldo += Convert.ToDecimal(montoIngresado);
                    this.cuentasTableAdapter.UpdateQuery((decimal)saldo, (int)this.cbx_accounts.SelectedValue, Auxiliar.id_logged);
                    //FileManager.WriteFile("Updated.txt", "1");
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }

        private void Withdraw(int montoIngresado)
        {
            try   // making a withdraw
            {
                // nuevo registro de transacción de extracción
                int id = Convert.ToInt32(this.moviTableAdapter2.MaxIdScalarQuery()) + 1;
                int selectedIdx = this.cbx_accounts.SelectedIndex;
                int accountIdx = (int)this.cbx_accounts.SelectedValue;  // id of the account
                decimal? saldo = Auxiliar.GetSaldoAccount(this.moviTableAdapter2, accountIdx);

                if (montoIngresado > saldo)
                {
                    if (saldo == 0)
                    {
                        MessageBox.Show("Error: no dispone de saldo!", "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error: no dispone de saldo suficiente!", "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    int insert_result = this.moviTableAdapter2.InsertQuery(id, dateTime, "ext", Convert.ToDecimal(montoIngresado), (decimal)saldo, txt_concepto.Text, Auxiliar.id_logged, accountIdx);
                    if (insert_result > 0)
                    {
                        MessageBox.Show("Extracción realizada con éxito!.", "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saldo -= Convert.ToDecimal(montoIngresado);
                        this.cuentasTableAdapter.UpdateQuery((decimal)saldo, (int)this.cbx_accounts.SelectedValue, Auxiliar.id_logged);
                        //FileManager.WriteFile("Updated.txt", "1");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btn_trans_Click(object sender, EventArgs e)
        {
            if (txt_trans_monto.Text == "" || txt_trans_monto.Text == null)
            {
                return;
            }

            int montoIngresado = 0;
            _ = Int32.TryParse(this.txt_trans_monto.Text, out montoIngresado);  // parsing from string to int

            if (montoIngresado <= 0)
                return;

            DialogResult dR;
            dR = MessageBox.Show("Confirma la transacción?", "Expense Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == DialogResult.No)
            {
                this.txt_trans_monto.Text = "";
                return;
            }

            if (this.Text.EndsWith("ito"))
            {
                Deposit(montoIngresado);
            }
            else  
            {
                Withdraw(montoIngresado);
            }

            this.Close();
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
