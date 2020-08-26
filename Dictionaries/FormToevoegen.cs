using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionaries
{
    public partial class FormToevoegen : Form
    {
        public string Ned;
        public string Eng;
        public FormToevoegen()
        {
            InitializeComponent();
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            Ned = txtNed.Text;
            Eng = txtEng.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
