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
    public partial class FormVoegToe : Form
    {
        public string Ned;
        public string Eng;
        public string Fr;
        public string Dui;
        public string Esp;
        public string Pol;
        public FormVoegToe()
        {
            InitializeComponent();
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {

            Ned = txtNed.Text;
            Eng = txtEng.Text;
            Fr = txtFr.Text;
            Dui = txtDui.Text;
            Esp = txtEsp.Text;
            Pol = txtEsp.Text;


            DialogResult = DialogResult.OK;
        }
    }
}
