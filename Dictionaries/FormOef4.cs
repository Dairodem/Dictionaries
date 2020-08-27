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
    public partial class FormOef4 : Form
    {
        Dictionary<decimal, string> Nummers = new Dictionary<decimal, string>()
        {
            { 0,"nul" },
            { 1,"één" },
            { 2,"twee" },
            { 3,"drie" },
            { 4,"vier" },
            { 5,"vijf" },
            { 6,"zes" },
            { 7,"zeven" },
            { 8,"acht" },
            { 9,"negen" },
            { 10,"tien" },
            { 11,"elf" },
            { 12,"twaalf" },
            { 13,"dertien" },
            { 14,"veertien" },
            { 20,"twintig" },
            { 30,"dertig" },
            { 40,"veertig" },
            { 50,"vijftig" },
            { 60,"zestig" },
            { 70,"zeventig" },
            { 80,"tachtig" },
            { 90,"negentig" },
            { 100,"honderd" },

            { 200,"" },
            { 300,"duizend" },
            { 400," miljoen " },
            { 500," miljard " },
            { 600," biljoen " },
            { 700," biljard " },
            { 800," triljoen " },
            { 900," triljard " },
            { 1000," quadriljoen " },
            { 1100," quadriljard " },

        };
        Dictionary<char, decimal> ConvertNummers = new Dictionary<char, decimal>() 
        {
            { '0', 0},
            { '1', 1},
            { '2', 2},
            { '3', 3},
            { '4', 4},
            { '5', 5},
            { '6', 6},
            { '7', 7},
            { '8', 8},
            { '9', 9},
        };

        List<decimal> numberHolder = new List<decimal>();
        bool isNul = false;

        decimal[] honderdStuk = new decimal[3];
        decimal atPart = 200;
        string totaal = "";
        string decimalstr = "";
        public FormOef4()
        {
            InitializeComponent();
        }

        private void FormOef4_Load(object sender, EventArgs e)
        {
            numGetal_ValueChanged(sender, e);
        }

        private void numGetal_ValueChanged(object sender, EventArgs e)
        {
            atPart = 200;

            ConvertStringToDec();
            totaal = "";

            while (numberHolder.Count != 0)
            {
                decimal sum = 0;

                FillArray();

                for (int i = 0; i < honderdStuk.Length; i++)
                {
                    sum += honderdStuk[i];

                }
                string woord = NumberPartToString();
                totaal = woord +( sum == 0 ? "" : Nummers[atPart])+ totaal;
                atPart += 100;

            }
            lblGetal.Text = totaal;

        }
        private void FillArray()
        {
            for (int i = 0; i < honderdStuk.Length; i++)
            {

                if (numberHolder.Count > 0)
                {
                    honderdStuk[(honderdStuk.Length - 1) - i] = numberHolder.Last();
                    numberHolder.RemoveAt(numberHolder.Count - 1);

                }
                else
                {
                    honderdStuk[(honderdStuk.Length - 1) - i] = 0;
                }
            }

        }
        private void ConvertStringToDec()
        {
            numberHolder.Clear();
            decimalstr = numGetal.Value.ToString();

            for (int i = 0; i < decimalstr.Length; i++)
            {
                numberHolder.Add(ConvertNummers[decimalstr[i]]);

            }
            if (decimalstr.Length > 1)
            {
                isNul = false;
            }
            else
            {
                isNul = true;
            }
        }
        private string NumberPartToString()
        {
            string thisPart ;

            thisPart = GetHondertal();
            thisPart += GetRestGetal();


            return thisPart;
        }
        private string GetHondertal()
        {
            string part = "";

            if (honderdStuk[0] > 1)
            {
                part += Nummers[honderdStuk[0]];
            }
            if (honderdStuk[0] != 0)
            {
                part += Nummers[100];
            }

            return part;

        }
        private string GetRestGetal()
        {
            string part = "";

            decimal combined = honderdStuk[1] * 10 + honderdStuk[2];

            if (combined < 15)
            {
                if (combined != 0)
                {
                    if (combined == 1)
                    {
                        if (atPart != 300 || honderdStuk[0] > 0)
                        {
                            part += Nummers[combined];
                        }
                    }
                    else
                    {

                        part += Nummers[combined];
                    }
                }
                else if (isNul)
                {
                    part = Nummers[0];
                }
            }
            else if (combined.ToString().Last() == '0')
            {
                part += Nummers[honderdStuk[1] * 10];
            }
            else if (combined > 20)
            {
                part += Nummers[honderdStuk[2]] + (Nummers[honderdStuk[2]].Last() == 'e' ? "ën" : "en") + Nummers[honderdStuk[1] * 10];
            }
            else
            {
                part += Nummers[honderdStuk[2]] + Nummers[honderdStuk[1] * 10];

            }

            return part;

        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            numGetal.Value += 100;

        }

        private void btnAdd1000_Click(object sender, EventArgs e)
        {
            numGetal.Value += 1000;

        }

        private void btnAddMil_Click(object sender, EventArgs e)
        {
            numGetal.Value += 1000000;

        }

        private void btnAddMld_Click(object sender, EventArgs e)
        {
            numGetal.Value += 1000000000;

        }

        private void btnAddBil_Click(object sender, EventArgs e)
        {
            numGetal.Value += 1000000000000;

        }

        private void btnAddBld_Click(object sender, EventArgs e)
        {
            numGetal.Value += 1000000000000000;

        }

        private void btnAddTril_Click(object sender, EventArgs e)
        {
            numGetal.Value += 1000000000000000000;

        }
    }
}
