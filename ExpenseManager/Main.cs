using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void movimientosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimientosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eXPENSE_MANAGERDataSet);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eXPENSE_MANAGERDataSet.cuentas' table. You can move, or remove it, as needed.
            try
            {
                //this.cuentasTableAdapter.FillByAccountName(this.eXPENSE_MANAGERDataSet.cuentas, 1);
                this.cbx_accounts.Items.Clear();
                this.cbx_accounts.DataSource = this.cuentasTableAdapter.GetDataByAccountName(1);
                this.cbx_accounts.ValueMember = "id";
                this.cbx_accounts.DisplayMember = "nombre";
            }
            catch (Exception) { }
            // TODO: This line of code loads data into the 'eXPENSE_MANAGERDataSet.movimientos' table. You can move, or remove it, as needed.
            //this.movimientosTableAdapter.Fill(this.eXPENSE_MANAGERDataSet.movimientos);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string selectText = "SELECT * FROM movimientos WHERE id_cuenta = 5";
            string account = string.Empty; // will be managed later
            string type = string.Empty;
            string amount = string.Empty;
            string concept = string.Empty;
            
            if (cbx_tipo.SelectedItem != null)
            {
                type = cbx_tipo.SelectedItem.ToString();
                selectText += " AND tipo = '" + type + "'";
            }

            if (txt_monto.Text.Length > 0)
            {
                amount = txt_monto.Text;
                selectText += " AND monto = " + amount;
            }

            if (txt_concepto.Text.Length > 0)
            {
                concept = txt_concepto.Text;
                selectText += " AND concepto LIKE '%" + concept + "%'";
            }

            SqlConnection MyConnection = new SqlConnection(ExpenseManager.Properties.Settings.Default.EXPENSE_MANAGERConnectionString);
            
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(selectText, MyConnection);
            SqlCommandBuilder MyCmd = new SqlCommandBuilder(MyDataAdapter);
            DataSet MyDataSet = new DataSet();

            MyDataAdapter.Fill(MyDataSet);

            // MessageBox.Show(MyDataSet.Tables[0].Rows.Count.ToString()); // the query retrieves 361 rows 👍

            this.movimientosDataGridView.DataSource = MyDataSet.Tables[0];
            
            // MessageBox.Show(selectText);
            
        }
    }
}
