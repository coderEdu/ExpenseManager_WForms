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
    public partial class ViewNotes : Form
    {
        public ViewNotes()
        {
            InitializeComponent();
        }

        private void ViewNotes_Load(object sender, EventArgs e)
        {
            this.notasTableAdapter.FillByUserNotes(eXPENSE_MANAGERDSNotes.notas, Auxiliar.id_logged);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {

        }
    }
}
