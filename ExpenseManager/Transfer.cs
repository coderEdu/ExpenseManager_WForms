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
    public partial class Transfer : Form
    {
        private DateTime dateTime;
        private int decimalCounter;
        private int transfered, received;
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transaccion_Load(object sender, EventArgs e)
        {
            dateTime = this.dtp.Value;
            decimalCounter = 0;
            // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS1.cuentas' table. You can move, or remove it, as needed.
            //this.cuentasTableAdapter.Fill(this.c_AHORRO_NEW_DS1.cuentas);
            this.Text = Auxiliar.getAppName() + " Realizar una transferencia";

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
        }

        private void Deposit(int id, decimal montoIngresado, int selectedIdx, int selectedValue, decimal? accountBalance)
        {
            try   // depositing the received transfer
            {
                string source_account_name = this.cbx_source_accounts.GetItemText(this.cbx_source_accounts.SelectedItem);
                string tra_concept = txt_concepto.Text + $"\n(Transferencia de '{source_account_name}' recibida 👍).";
                int insert_result = this.moviTableAdapter2.InsertQuery(id, dateTime, "rec", Convert.ToDecimal(montoIngresado), (decimal)accountBalance, tra_concept, Auxiliar.id_logged, selectedValue);
                if (insert_result > 0)
                {
                    ++received;
                    //MessageBox.Show("Depósito realizado con éxito!.", "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    accountBalance += Convert.ToDecimal(montoIngresado);
                    this.cuentasTableAdapter.UpdateQuery((decimal)accountBalance, selectedValue, Auxiliar.id_logged);
                    //FileManager.WriteFile("Updated.txt", ",");
                }

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }

        private void Withdrawal(int id, decimal montoIngresado, int selectedIdx, int selectedValue, decimal? accountBalance)
        {
            try   // making a transfer
            {
                if (montoIngresado > accountBalance)
                {
                    if (accountBalance == 0)
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
                    string destination_account_name = this.cbx_destination_accounts.GetItemText(this.cbx_destination_accounts.SelectedItem);
                    string tra_concept = txt_concepto.Text + $"\n(Transferencia a '{destination_account_name}' con éxito 👍).";
                    int insert_result = this.moviTableAdapter2.InsertQuery(id, dateTime, "tra", Convert.ToDecimal(montoIngresado), (decimal)accountBalance, tra_concept, Auxiliar.id_logged, selectedValue);
                    if (insert_result > 0)
                    {
                        ++transfered;
                        //MessageBox.Show("Extracción realizada con éxito!.", "Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accountBalance -= Convert.ToDecimal(montoIngresado);
                        this.cuentasTableAdapter.UpdateQuery((decimal)accountBalance, selectedValue, Auxiliar.id_logged);
                        //FileManager.WriteFile("Updated.txt", ",");
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

            Transferring(montoIngresado);

            this.Close();
        }

        private void Transferring(decimal montoIngresado)
        {
            int id = Convert.ToInt32(this.moviTableAdapter2.MaxIdScalarQuery()) + 1; // for both

            // withdrawal
            int selectedSourceIdx = this.cbx_source_accounts.SelectedIndex;
            int selectedSourceAccountIdx = (int)this.cbx_source_accounts.SelectedValue;  // id of the selected source account
            decimal? saldoSelectedSrcAcc = Auxiliar.GetSaldoAccount(this.moviTableAdapter2, selectedSourceAccountIdx);

            // deposit
            int selectedDestinationIdx = this.cbx_destination_accounts.SelectedIndex;
            int selectedDestinationAccountIdx = (int)this.cbx_destination_accounts.SelectedValue;  // id of the selected destination account
            decimal? saldoSelectedDestAcc = Auxiliar.GetSaldoAccount(this.moviTableAdapter2, selectedDestinationAccountIdx);

            // transfer details
            string message = "DATOS DE LA TRANSFERENCIA A EFECTUAR 💲\n=======================================\n\n" +
                             "CUENTA ORIGEN  => " + Auxiliar.LoggUserName + "." + this.cbx_source_accounts.GetItemText(this.cbx_source_accounts.SelectedItem) + "\n" +
                             "CUENTA DESTINO => " + Auxiliar.LoggUserName + "." + this.cbx_destination_accounts.GetItemText(this.cbx_destination_accounts.SelectedItem) + "\n" +
                             "MONTO          => " + string.Format("{0:C}", Convert.ToDecimal(this.Txt_display.Text)) + "\n" +
                             "FECHA          => " + dateTime + "\n" +
                             "CONCEPTO       => " + this.txt_concepto.Text + "\n\n" +
                             "¿Confirma la transacción?";

            if (MessageBox.Show(message, "Expense Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Withdrawal(id, montoIngresado, selectedSourceIdx, selectedSourceAccountIdx, saldoSelectedSrcAcc);
                Deposit(++id, montoIngresado, selectedDestinationIdx, selectedDestinationAccountIdx, saldoSelectedDestAcc);

                if (transfered + received == 2)
                {
                    MessageBox.Show("Transferencia exitosa!","Expense Manager 😊",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    FileManager.WriteFile("Updated.txt", "1");
                }
                else
                {
                    MessageBox.Show("Ops! algo anduvo mal...", "Expense Manager 😒",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Deposit(++id, montoIngresado, selectedSourceIdx, selectedSourceAccountIdx, saldoSelectedSrcAcc);
                }
            }
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
