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

            this.lbl_notes_count.Text = Dgv_all_notes.Rows.Count.ToString();
            
            if (Dgv_all_notes.Rows.Count < 13)
            {
                this.Dgv_all_notes.Columns[6].Width = this.Dgv_all_notes.Columns[6].Width + 19;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            this.notasTableAdapter.FillByValueSearch(eXPENSE_MANAGERDSNotes.notas, Auxiliar.id_logged, this.txt_search.Text);

            this.lbl_notes_count.Text = Dgv_all_notes.Rows.Count.ToString();

            this.Dgv_all_notes.Columns[6].Width = 245;
            
            if (Dgv_all_notes.Rows.Count < 13)
            {
                this.Dgv_all_notes.Columns[6].Width = 245 + 19;
            }
        }
    }
}
