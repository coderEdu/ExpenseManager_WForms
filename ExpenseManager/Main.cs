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

    }
}
