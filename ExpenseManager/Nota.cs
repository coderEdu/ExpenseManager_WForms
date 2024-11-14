using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    internal class Nota             // creates note buttos
    {
        static int c = 0;   // increase note-name by 1
        public Button CreateNewNoteWithAttrib(string note_title)
        {
            return new Button
            {
                FlatStyle = FlatStyle.Standard,
                Image = global::ExpenseManager.Properties.Resources._17367_file_icon,
                Name = "Note" + ++c,
                Size = new Size(90, 100),
                Text = note_title,
                TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText,
                UseVisualStyleBackColor = true
            };
        }
    }
}
