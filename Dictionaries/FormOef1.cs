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
    public partial class FormOef1 : Form
    {
        Dictionary<int, string> getallenDict = new Dictionary<int, string>();

        public FormOef1()
        {
            InitializeComponent();
        }

        private void FormOef1_Load(object sender, EventArgs e)
        {

            getallenDict.Add(1, "Een");
            getallenDict.Add(2, "Twee");
            getallenDict.Add(3, "Drie");
            getallenDict.Add(4, "Vier");
            getallenDict.Add(5, "Vijf");
            getallenDict.Add(6, "Zes");
            getallenDict.Add(7, "Zeven");
            getallenDict.Add(8, "Acht");
            getallenDict.Add(9, "Negen");
            getallenDict.Add(10, "Tien");

            for (int i = 0; i < getallenDict.Count; i++)
            {
                cbGetallen.Items.Add(i + 1);
            }
            cbGetallen.SelectedIndex = 0;
        }

        private void cbGetallen_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int,string> getal in getallenDict)
            {
                if (cbGetallen.SelectedIndex+1 == getal.Key)
                {
                    lblGetal.Text = getal.Value;
                }

            }
        }
    }
}
