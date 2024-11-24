using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void BtnNewAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realmente eliminar esta cuenta?", "Expense manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)this.cbxSelectAccount.SelectedValue;
                try
                {
                    if (this.cuentasTableAdapter1.DeleteQuery(id) == 1)
                    {
                        MessageBox.Show("Cuenta eliminada correctamente!", "Expense manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }

                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.ToString(),"Error: No se pudo eliminar la cuenta");
                }
            }
        }

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            this.cuentasTableAdapter1.FillByAccountName(this.expensE_MANAGERDataSet1.cuentas, Auxiliar.id_logged);
        }
    }
}
