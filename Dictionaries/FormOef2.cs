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
    public partial class FormOef2 : Form
    {
        Dictionary<string, string> Woordenboek = new Dictionary<string, string>();

        public FormOef2()
        {
            InitializeComponent();
        }

        private void FormOef2_Load(object sender, EventArgs e)
        {
            Woordenboek.Add("Auto", "Car");
            Woordenboek.Add("Bril", "Glasses");
            Woordenboek.Add("Donder", "Thunder");
            Woordenboek.Add("Donderdag", "Thursday");
            Woordenboek.Add("Kast", "Closet");
            Woordenboek.Add("Stoel", "Chair");
            Woordenboek.Add("Tafel", "Table");
            Woordenboek.Add("Vuur", "Fire");

            LoadComboBox();
            cbWoorden_SelectedIndexChanged(sender,e);

        }

        private void cbWoorden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWoorden.SelectedIndex >= 0)
            {
                lblEngels.Text = cbWoorden.SelectedValue.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormToevoegen formToevoegen = new FormToevoegen();
            formToevoegen.ShowDialog();

            if (formToevoegen.DialogResult == DialogResult.OK)
            {
                bool isSame = false;

                foreach (KeyValuePair<string,string> pair in Woordenboek)
                {
                    if (pair.Key == formToevoegen.Ned)
                    {
                        isSame = true;
                        MessageBox.Show($"{formToevoegen.Ned} bestaat al!");
                        break;
                    }
                }
                if (!isSame)
                {
                    Woordenboek.Add(formToevoegen.Ned, formToevoegen.Eng);

                }
            }

            LoadComboBox();

        }

        private void LoadComboBox()
        {
            cbWoorden.DataSource = null;
            cbWoorden.DataSource = new BindingSource(Woordenboek, null);
            cbWoorden.DisplayMember = "Key";
            cbWoorden.ValueMember = "Value";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            KeyValuePair<string , string> selected = (KeyValuePair<string, string>)cbWoorden.SelectedItem;
            Woordenboek.Remove(selected.Key);
            LoadComboBox();
        }
    }
}
