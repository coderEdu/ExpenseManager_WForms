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
        private int decimalCounter;
        public Transaccion()
        {
            InitializeComponent();
        }

        private void Transaccion_Load(object sender, EventArgs e)
        {
            dateTime = this.dtp.Value;
            decimalCounter = 0;
            // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS1.cuentas' table. You can move, or remove it, as needed.
            //this.cuentasTableAdapter.Fill(this.c_AHORRO_NEW_DS1.cuentas);
            c_AHORRO_NEW_DS1.Clear();
            try
            {
                this.moviTableAdapter2.Fill(this.c_AHORRO_NEW_DS1.movimientos);  // cargo el dataset con info
            }
            catch (Exception) { }

            try
            {
                this.cuentasTableAdapter.FillByAccountName(this.c_AHORRO_NEW_DS1.cuentas, ((int)(System.Convert.ChangeType(Auxiliar.id_logged, typeof(int)))));
                this.cbx_accounts.SelectedValue = (object)Main.GlobalCurrentAccount;
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

        private void Deposit(decimal montoIngresado)
        {
            try   // making a deposit
            {
                // nuevo registro de transacción de depósito
                int id = Convert.ToInt32(this.moviTableAdapter2.MaxIdScalarQuery()) + 1;
                int selectedIdx = this.cbx_accounts.SelectedIndex;
                int accountIdx = (int)this.cbx_accounts.SelectedValue;  // id of the account
                decimal? saldo = Auxiliar.GetSaldoAccount(this.moviTableAdapter2, accountIdx);

                string message = "DATOS DEL DEPOSITO 💲\n=======================================\n\n" +
                                 "CUENTA => " + Auxiliar.LoggUserName + "." + this.cbx_accounts.GetItemText(this.cbx_accounts.SelectedItem) + "\n" +
                                 "MONTO  => " + string.Format("{0:C}", Convert.ToDecimal(this.Txt_display.Text)) + "\n" +
                                 "FECHA  => " + dateTime + "\n" +
                                 "CONCEPTO  => " + this.txt_concepto.Text + "\n\n" +
                                 "¿Confirma la transacción?";

                if (MessageBox.Show(message, "Expense Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.txt_concepto.Text == "$correctivo")
                    {
                        this.txt_concepto.Text = Auxiliar.getTextCorrective();
                    }
                    int insert_result = this.moviTableAdapter2.InsertQuery(id, dateTime, "dep", Convert.ToDecimal(montoIngresado), (decimal)saldo, txt_concepto.Text, Auxiliar.id_logged, accountIdx);
                    if (insert_result > 0)
                    {
                        MessageBox.Show("Depósito realizado con éxito!.", "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saldo += Convert.ToDecimal(montoIngresado);
                        this.cuentasTableAdapter.UpdateQuery((decimal)saldo, (int)this.cbx_accounts.SelectedValue, Auxiliar.id_logged);
                        FileManager.WriteFile("Updated.txt", "1");
                    }
                } 

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }

        private void Withdraw(decimal montoIngresado)
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
                    string message = "DATOS DE LA EXTRACCION 💲\n=======================================\n\n" +
                                     "CUENTA => " + Auxiliar.LoggUserName + "." + this.cbx_accounts.GetItemText(this.cbx_accounts.SelectedItem) + "\n" +
                                     "MONTO  => " + string.Format("{0:C}", Convert.ToDecimal(this.Txt_display.Text)) + "\n" +
                                     "FECHA  => " + dateTime + "\n" +
                                     "CONCEPTO  => " + this.txt_concepto.Text + "\n\n" +
                                     "¿Confirma la transacción?";
                    if (MessageBox.Show(message, "Expense Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (this.txt_concepto.Text == "$correctivo")
                        {
                            this.txt_concepto.Text = Auxiliar.getTextCorrective();
                        }
                        int insert_result = this.moviTableAdapter2.InsertQuery(id, dateTime, "ext", Convert.ToDecimal(montoIngresado), (decimal)saldo, txt_concepto.Text, Auxiliar.id_logged, accountIdx);
                        if (insert_result > 0)
                        {
                            MessageBox.Show("Extracción realizada con éxito!.", "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            saldo -= Convert.ToDecimal(montoIngresado);
                            this.cuentasTableAdapter.UpdateQuery((decimal)saldo, (int)this.cbx_accounts.SelectedValue, Auxiliar.id_logged);
                            FileManager.WriteFile("Updated.txt", "1");
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void Btn_trans_Click(object sender, EventArgs e)
        {
            if (Txt_display.Text == "" || Txt_display.Text == null)
            {
                return;
            }

            decimal montoIngresado = Convert.ToDecimal(this.Txt_display.Text);

            if (montoIngresado <= 0)
                return;

            if (this.Text.EndsWith("ito"))
            {
                Deposit(montoIngresado);
            }
            else
            {
                Withdraw(montoIngresado);
            }
            //MessageBox.Show(montoIngresado.ToString());
            this.Close();
        }

        private void Txt_trans_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.btn_trans.PerformClick();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (this.Txt_display.Text.Length == 0)
            {
                if (button.Text == ",")
                {
                    this.Txt_display.Text = "0,";                   
                }
                else
                {
                    this.Txt_display.Text += button.Text;
                }
            }
            else
            {
                if (this.Txt_display.Text.Contains(","))
                {
                    if (this.decimalCounter < 2)
                    {
                        decimalCounter++;
                        this.Txt_display.Text += button.Text;
                    }
                }
                else
                {
                    this.Txt_display.Text += button.Text;
                }
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.Txt_display.Text.Length > 0)
            {
                this.Txt_display.Text = this.Txt_display.Text.Remove(this.Txt_display.Text.Length - 1);
                if (decimalCounter > 0)
                {
                    this.decimalCounter--;
                }
            }
        }

        private void Btn_correctivo_Click(object sender, EventArgs e)
        {
            this.txt_concepto.Text = "$correctivo";
        }

        private void Btn_point_Click(object sender, EventArgs e)
        {
            if (this.Txt_display.Text.Length > 0)
            {
                if (!this.Txt_display.Text.Contains(","))
                {
                    this.Txt_display.Text += ",";
                }
            }
        }

        private void Txt_display_TextChanged(object sender, EventArgs e)
        {
            if (this.Txt_display.Text.Length == 0)
            {
                this.decimalCounter = 0;
            }
        }
    }
}
