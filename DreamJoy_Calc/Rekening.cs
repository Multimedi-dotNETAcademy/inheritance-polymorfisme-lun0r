using System.Windows.Forms;

namespace DreamJoy_Calc
{
    public class Rekening
    {
        private double _minimum;

        public double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        private string _rekeningnummer;

        public string Rekeningnummer
        {
            get { return _rekeningnummer; }
            set { _rekeningnummer = value; }
        }

        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    MessageBox.Show($"Saldo kan niet minder zijn dan {Minimum}.");
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public Rekening(string rekeningnummer, double saldo)
        {
            Rekeningnummer = rekeningnummer;

            Saldo = saldo;
        }

        public void Afhalen(double bedrag)
        {
            Saldo -= bedrag;
        }

        public void Storten(double bedrag)
        {
            Saldo += bedrag;
        }

        public override string ToString()
        {
            string result = "Rekeningnummer: " + Rekeningnummer + " | Saldo:" + Saldo;
            return result;
        }
    }

    public class Spaarrekening : Rekening

    {
        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public Spaarrekening(string rekeningnummer, double saldo, double percentage)
         : base(rekeningnummer, saldo)
        {
            Minimum = 0;
            Percentage = percentage;
        }

        public void SchrijfRenteBij()
        { }

        public override string ToString()
        {
            return base.ToString() + " | Percentage: " + Percentage;
        }
    }

    public class Zichtrekening : Rekening
    {
        public Zichtrekening(string rekeningnummer, double saldo)
        : base(rekeningnummer, saldo)
        {
            Minimum = -100;
        }
    }
}