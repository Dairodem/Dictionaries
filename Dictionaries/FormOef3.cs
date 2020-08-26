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

    public partial class FormOef3 : Form
    {
        Dictionary<string, List<string>> extendedWb = new Dictionary<string, List<string>>();
        string[] Talen = new string[] {"Engels: ","Frans: ","Duits: ","Spaans: ","Pools: " };

        public FormOef3()
        {
            InitializeComponent();
        }

        private void FormOef3_Load(object sender, EventArgs e)
        {
            List<string> autoList = new List<string>() { "Car", "Voiture", "Auto", "Coche", "Samochód" };

            extendedWb.Add("Auto", new List<string>() { "Car", "Voiture", "Auto", "Coche", "Samochód" });
            extendedWb.Add("Bril", new List<string>() { "Glasses", "Des Lunettes", "Brille", "Lentes", "Okulary" });
            extendedWb.Add("Donder", new List<string>() { "Thunder", "Tonnerre", "Donner", "Trueno", "Grzmot" });
            extendedWb.Add("Donderdag", new List<string>() { "Thursday", "Jeudi", "Donnerstag", "Jueves", "Czwartek" });
            extendedWb.Add("Kast", new List<string>() { "Closet", "Armoire", "Wandschrank", "Armario", "Gabinet" });
            extendedWb.Add("Stoel", new List<string>() { "Chair", "Chaisse", "Stuhl", "Silla", "Krzesło" });
            extendedWb.Add("Tafel", new List<string>() { "Table", "Table", "Tabelle", "Mesa", "Stół" });
            extendedWb.Add("Vuur", new List<string>() { "Fire", "Feu", "Feuer", "Fuego", "Ogień" });

            LoadComboBox();

        }

        private void cbWoorden_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbWoorden.SelectedIndex >= 0)
            {
                lblVertalng.Text = "";
                KeyValuePair<string, List<string>> pair = (KeyValuePair<string, List<string>>)cbWoorden.SelectedItem;
                int teller = 0;

                foreach (string vertaling in pair.Value)
                {

                    lblVertalng.Text += Talen[teller] + vertaling + "\n";

                    teller++;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormVoegToe formVoegToe = new FormVoegToe();
            formVoegToe.ShowDialog();

            if (formVoegToe.DialogResult == DialogResult.OK)
            {
                bool isSame = false;

                foreach (KeyValuePair<string, List<string>> pair in extendedWb)
                {
                    if (pair.Key == formVoegToe.Ned)
                    {
                        isSame = true;
                        MessageBox.Show($"{formVoegToe.Ned} bestaat al!");
                        break;
                    }
                }
                if (!isSame)
                {
                    extendedWb.Add(formVoegToe.Ned, new List<string>() { formVoegToe.Eng,formVoegToe.Fr,formVoegToe.Dui,formVoegToe.Esp,formVoegToe.Pol });

                }
            }

            LoadComboBox();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            KeyValuePair<string, List<string>> selected = (KeyValuePair<string, List<string>>)cbWoorden.SelectedItem;
            extendedWb.Remove(selected.Key);
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbWoorden.DataSource = null;
            cbWoorden.DataSource = new BindingSource(extendedWb, null);
            cbWoorden.DisplayMember = "Key";
        }
    }
}
