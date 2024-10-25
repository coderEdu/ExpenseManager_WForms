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
            // it makes a non-editable combobox
            this.cbx_accounts.DropDownStyle = ComboBoxStyle.DropDownList;

            // disabling datetimepickers
            this.dTP2.Enabled = false;
            this.dTP1.Enabled = false;
            this.lbl_date1.Enabled = false;
            this.lbl_date2.Enabled = false;
            this.check_date2.Enabled = false;

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
            // this.movimientosTableAdapter.Fill(this.eXPENSE_MANAGERDataSet.movimientos);
        }

        private string SearchByDate(string p)   // param values: s => single | r => range
        {
            object dateSwitcher = (p == "r") ? $"{dTP2.Value.Year}-{dTP2.Value.Month}-{dTP2.Value.Day}" : $"{dTP1.Value.Year}-{dTP1.Value.Month}-{dTP1.Value.Day}";
            return $" AND fecha BETWEEN '{dTP1.Value.Year}-{dTP1.Value.Month}-{dTP1.Value.Day} 00:00:00:000' AND '{dateSwitcher} 23:59:59:999'";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string queryText = "SELECT * FROM movimientos WHERE id_cuenta = '" + cbx_accounts.SelectedValue.ToString() + "'";
            string type = string.Empty;
            string amount = string.Empty;
            string concept = string.Empty;

            if (dTP1.Enabled && dTP2.Enabled)
            {
                queryText += SearchByDate("r");
            }
            else
            {
                if (dTP1.Enabled)
                {
                    queryText += SearchByDate("s");
                }
            }
            
            if (cbx_tipo.SelectedItem != null)
            {
                type = cbx_tipo.SelectedItem.ToString();
                queryText += " AND tipo = '" + type + "'";
            }

            if (txt_monto.Text.Length > 0)
            {
                amount = txt_monto.Text;
                queryText += " AND monto = " + amount;
            }

            if (txt_concepto.Text.Length > 0)
            {
                concept = txt_concepto.Text;
                queryText += " AND concepto LIKE '%" + concept + "%'";
            }

            SqlConnection MyConnection = new SqlConnection(ExpenseManager.Properties.Settings.Default.EXPENSE_MANAGERConnectionString);
            
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(queryText, MyConnection);
            SqlCommandBuilder MyCmd = new SqlCommandBuilder(MyDataAdapter);
            DataSet MyDataSet = new DataSet();

            MyDataAdapter.Fill(MyDataSet);

            // MessageBox.Show(MyDataSet.Tables[0].Rows.Count.ToString()); // the query retrieves 361 rows 👍

            this.movimientosDataGridView.DataSource = MyDataSet.Tables[0];
            
             //MessageBox.Show(queryText);            
        }

        private void check_date1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_date1.Checked)
            {
                this.dTP1.Enabled = true;
                this.lbl_date1.Enabled = true;
                this.check_date2.Enabled = true;
            }
            else
            {
                if (check_date2.Checked)
                {
                    check_date2.Checked = false;
                    this.dTP2.Enabled = false;
                    this.lbl_date2.Enabled = false;
                }
                this.dTP1.Enabled = false;
                this.lbl_date1.Enabled = false;
                this.check_date2.Enabled = false;
            }
        }

        private void check_date2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_date2.Checked)
            {
                this.dTP2.Enabled = true;
                this.lbl_date2.Enabled = true;
            }
            else
            {
                this.dTP2.Enabled = false;
                this.lbl_date2.Enabled = false;
            }
        }
    }
}
