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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            FormOef1 formOef1 = new FormOef1();
            formOef1.ShowDialog();
        }

        private void btnOef2_Click(object sender, EventArgs e)
        {
            FormOef2 formOef2 = new FormOef2();
            formOef2.ShowDialog();

        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            FormOef3 formOef3 = new FormOef3();
            formOef3.ShowDialog();

        }

        private void btnOef4_Click(object sender, EventArgs e)
        {
            FormOef4 formOef4 = new FormOef4();
            formOef4.ShowDialog();

        }
    }
}
