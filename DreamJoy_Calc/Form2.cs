using System;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    public partial class Form2 : Form
    {
        static private string naam;

        private Mens mens = new Mens(naam);
        private Papegaai papegaai = new Papegaai(naam);
        private Kat kat = new Kat(naam);

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButtonKat_CheckedChanged(object sender, EventArgs e)
        {
            kat.Naam = naam;
            if (radioButtonKat.Checked)
            {
                listBox1.Enabled = true;
                buttonEten.Enabled = true;
                buttonPraten.Enabled = true;
                buttonStrel.Enabled = true;
            }
        }

        private void buttonAanmaken_Click(object sender, EventArgs e)
        {
            if (textBoxDier.Text != string.Empty)
            {
                naam = textBoxDier.Text;
                radioButtonKat.Enabled = true;
                radioButtonMen.Enabled = true;
                radioButtonPape.Enabled = true;
            }
            else
            {
                MessageBox.Show("Text box cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDier_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonPape_CheckedChanged(object sender, EventArgs e)
        {
            papegaai.Naam = naam;
            if (radioButtonPape.Checked)
            {
                listBox1.Enabled = true;
                buttonEten.Enabled = true;
                buttonPraten.Enabled = true;
                buttonStrel.Enabled = true;
            }
        }

        private void radioButtonMen_CheckedChanged(object sender, EventArgs e)
        {
            mens.Naam = naam;
            if (radioButtonMen.Checked)
            {
                listBox1.Enabled = true;
                buttonEten.Enabled = true;
                buttonPraten.Enabled = true;
                buttonStrel.Enabled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonPraten_Click(object sender, EventArgs e)
        {
            if (radioButtonMen.Checked)
            {
                MessageBox.Show(mens.Praten(Convert.ToString(listBox1.SelectedItem)));
            }
            else if (radioButtonKat.Checked)
            {
                MessageBox.Show(kat.Praten(Convert.ToString(listBox1.SelectedItem)));
            }
            else
            {
                MessageBox.Show(papegaai.Praten(Convert.ToString(listBox1.SelectedItem)));
            }
        }

        private void buttonStrel_Click(object sender, EventArgs e)
        {
            if (radioButtonMen.Checked)
            {
                MessageBox.Show(mens.Strelen());
            }
            else if (radioButtonKat.Checked)
            {
                MessageBox.Show(kat.Strelen());
            }
            else
            {
                MessageBox.Show(papegaai.Strelen());
            }
        }

        private void buttonEten_Click(object sender, EventArgs e)
        {
            if (radioButtonMen.Checked)
            {
                MessageBox.Show(mens.Eten());
            }
        }

        private void buttonSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonKat_Click(object sender, EventArgs e)
        {

        }
    }
}