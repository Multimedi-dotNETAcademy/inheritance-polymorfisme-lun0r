using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
           
            Form form1 = new Form1();
            form1.Show();

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {

            Form form3 = new Form3();
            form3.Show();
        }

      
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
        }
    }
}
