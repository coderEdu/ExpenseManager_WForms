﻿using System;
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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void BtnNewAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea crear esta cuenta?", "Expense manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int? id = this.cuentasTableAdapter1.MaxIdScalarQuery() + 1;
                if (this.cuentasTableAdapter1.InsertQuery((int)id, this.txtName.Text, (decimal)0, DateTime.Now, Auxiliar.id_logged) == 1)
                {
                    MessageBox.Show("Cuenta creada correctamente!","Expense manager",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (this.cuentasTableAdapter1.FillByExistence(this.expensE_MANAGERDataSet1.cuentas,this.txtName.Text) == 1)
            {
                this.BtnCheck.BackgroundImage = global::ExpenseManager.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_48;
            }
            else
            {
                this.BtnCheck.BackgroundImage = global::ExpenseManager.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_48;
            }
        }
    }
}