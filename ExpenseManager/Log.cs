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
    public partial class Log : Form
    {
        public string QueryString { get; set; }
        public DateTime Dtp2Date { get; set; }
        public string LoggedUserName { get; set; }
        List<string> fields = new List<string>();

        public Log()
        {
            InitializeComponent();
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

            // set color to lbl_records_count
            this.lbl_cant_records.ForeColor = System.Drawing.Color.FromArgb(17, 122, 101);

            // adjust dgv fields
            AdjustFieldsmovimientosDataGridView();

            // checking text length of the current concept
            //CheckConceptTextLength();

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

        public void AdjustFieldsmovimientosDataGridView()
        {
            if (this.movimientosDataGridView.RowCount > 12)
            {
                this.movimientosDataGridView.Columns[1].Width = 300;    // fecha
                this.movimientosDataGridView.Columns[2].Width = 55;     // tipo
                this.movimientosDataGridView.Columns[3].Width = 112;    // monto
                this.movimientosDataGridView.Columns[4].Width = 112;    // saldo
            }
            else
            {
                this.movimientosDataGridView.Columns[1].Width = 311;    // fecha
                this.movimientosDataGridView.Columns[2].Width = 59;     // tipo
                this.movimientosDataGridView.Columns[3].Width = 115;    // monto
                this.movimientosDataGridView.Columns[4].Width = 115;    // saldo
            }
        }

        private string SearchByDate(string p)   // param values: s => single | r => range
        {
            object dateSwitcher = (p == "r") ? $"{dTP2.Value.Year}-{dTP2.Value.Month}-{dTP2.Value.Day}" : $"{dTP1.Value.Year}-{dTP1.Value.Month}-{dTP1.Value.Day}";
            return $" AND fecha BETWEEN '{dTP1.Value.Year}-{dTP1.Value.Month}-{dTP1.Value.Day} 00:00:00:000' AND '{dateSwitcher} 23:59:59:999'";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string queryText = "SELECT * FROM movimientos WHERE id_cuenta = '" + cbx_accounts.SelectedValue.ToString() + "'";

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

            if (cbx_tipo.SelectedItem != null) queryText += " AND tipo = '" + cbx_tipo.SelectedItem.ToString() + "'";

            if (txt_monto.Text.Length > 0) queryText += " AND monto = " + txt_monto.Text;

            if (txt_concepto.Text.Length > 0) queryText += " AND concepto LIKE '%" + txt_concepto.Text + "%'";

            queryText += " ORDER BY fecha DESC";

            SqlConnection MyConnection = new SqlConnection(ExpenseManager.Properties.Settings.Default.EXPENSE_MANAGERConnectionString);

            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(queryText, MyConnection);
            SqlCommandBuilder MyCmd = new SqlCommandBuilder(MyDataAdapter);
            DataSet MyDataSet = new DataSet();

            MyDataAdapter.Fill(MyDataSet);

            // MessageBox.Show(MyDataSet.Tables[0].Rows.Count.ToString()); // the query retrieves 361 rows 👍

            this.movimientosDataGridView.DataSource = MyDataSet.Tables[0];

            this.lbl_cant_records.Text = this.movimientosDataGridView.RowCount.ToString();

            //MessageBox.Show(queryText);
            this.QueryString = queryText;

            AdjustFieldsmovimientosDataGridView();

            DataTable dt = new DataTable();
            dt = movimientosTableAdapter.GetDataByCorrectivo(Convert.ToInt32(cbx_accounts.SelectedValue), 1);
            fields.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string id = row["id"].ToString();
                fields.Add(id);
            }
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
                this.dTP2.Value = this.dTP1.Value.AddMonths(1);
            }
            else
            {
                this.dTP2.Enabled = false;
                this.lbl_date2.Enabled = false;
            }
        }

        private void btn_show_query_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.QueryString);
        }

        private void movimientosDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CheckConceptTextLength();
        }

        private void movimientosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckConceptTextLength();
        }

        private void movimientosDataGridView_Enter(object sender, EventArgs e)
        {
            CheckConceptTextLength();
        }

        private void movimientosDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            int correctivo = 0;

            try { correctivo = this.movimientosTableAdapter.FillByCorrectivo(eXPENSE_MANAGERDataSet.movimientos, Convert.ToInt32(cbx_accounts.SelectedValue), 1); }
            catch (Exception) { }

            if (correctivo > 0)
            {
                for (int i = 0; i < movimientosDataGridView.RowCount; i++)
                {
                    if (fields.Contains(movimientosDataGridView.Rows[i].Cells[0].Value.ToString()))
                    {
                        movimientosDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
                    }
                }
            }
        }

        private void CheckConceptTextLength()
        {
            if (this.movimientosDataGridView.CurrentRow != null)
            {
                if (movimientosDataGridView.CurrentRow.Cells[5].Value.ToString().Length > 0)
                {
                    this.lbl_concept_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.lbl_concept_text.Text = movimientosDataGridView.CurrentRow.Cells[5].Value.ToString();
                }
                else
                {
                    LblConceptGrayBg();
                }
            }
            else
            {
                LblConceptGrayBg();
            }
        }

        private void movimientosDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (this.movimientosDataGridView.RowCount == 0)
            {
                LblConceptGrayBg();
            }
        }

        private void LblConceptGrayBg()
        {
            this.lbl_concept_text.BackColor = Color.FromArgb(210, 210, 210);
            this.lbl_concept_text.Text = "";
        }

    }
}
