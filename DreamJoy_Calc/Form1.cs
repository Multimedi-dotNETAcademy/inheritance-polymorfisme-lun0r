using System;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    public partial class Form1 : Form
    {
        public Rekening rekening;
        private Spaarrekening spaarRekening;
        private Zichtrekening zichtRekening;

        public Form1()
        {
            rekening = new Rekening("BE651435846REK", 0);

            spaarRekening = new Spaarrekening("BE6514358468SP", 0, 5);

            zichtRekening = new Zichtrekening("BE6514358468ZI", 0);

            InitializeComponent();
            labelRekToString.Text = rekening.ToString();
            labelZichtToString.Text = zichtRekening.ToString();
            labelSpaarToString.Text = spaarRekening.ToString();
        }

        private void buttonRekPlus_Click(object sender, EventArgs e)
        {
            rekening.Storten(Convert.ToDouble(numRek.Value));
            labelRekToString.Text = rekening.ToString();
        }

        private void buttonRekMin_Click(object sender, EventArgs e)
        {
            rekening.Afhalen(Convert.ToDouble(numRek.Value));
            labelRekToString.Text = rekening.ToString();
        }

        private void buttonSpaarPlus_Click(object sender, EventArgs e)
        {
            spaarRekening.Storten(Convert.ToDouble(numSpaar.Value));
            labelSpaarToString.Text = spaarRekening.ToString();
        }

        private void buttonZichtPlus_Click(object sender, EventArgs e)
        {
            zichtRekening.Storten(Convert.ToDouble(numZicht.Value));
            labelZichtToString.Text = zichtRekening.ToString();
        }

        private void buttonSpaarMin_Click(object sender, EventArgs e)
        {
            spaarRekening.Afhalen(Convert.ToDouble(numSpaar.Value));
            labelSpaarToString.Text = spaarRekening.ToString();
        }

        private void buttonZichtMin_Click(object sender, EventArgs e)
        {
            zichtRekening.Afhalen(Convert.ToDouble(numZicht.Value));
            labelZichtToString.Text = zichtRekening.ToString();
        }

        private void buttonRente_Click(object sender, EventArgs e)
        {
            double rente = ((spaarRekening.Saldo * 5) / 100);
            spaarRekening.Saldo += rente;
            labelSpaarToString.Text = spaarRekening.ToString();
        }
    }
}