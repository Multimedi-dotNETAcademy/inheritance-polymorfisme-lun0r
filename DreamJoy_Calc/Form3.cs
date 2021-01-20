using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    public partial class Form3 : Form
    {
        Punt punt = new Punt(3, 4);
        Cirkel cirkel = new Cirkel(3,4,5);
        Cilinder cilinder = new Cilinder(3, 4, 5, 2);
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonPunt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(punt.Gegevens(), "Coordinaten van het punt.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void buttonCirkel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cirkel.Gegevens(), "Coordinaten van de cirkel.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCilinder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cilinder.Gegevens(), "Gegevens van de cilinder.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
