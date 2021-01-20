using System;

namespace DreamJoy_Calc
{
    internal class Punt
    {
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        private double _y;

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Punt(double x, double y)
        {
            Y = y;
            X = x;
        }

        public virtual string Gegevens()
        {
            return $"({X}, {Y})";
        }
    }

    internal class Cirkel : Punt
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Cirkel(double x, double y, double r)
         : base(x, y)
        {
            R = r;
        }
        public virtual double Omtrek()
        {
            return 2 * Math.PI * R ;
        }
        public override string Gegevens()
        {
            return $"({base.Gegevens()} straal {R}";
        }
        public virtual double Oppervlakte()
        {
            return Math.PI * (R * R);
        }



    }

    internal class Cilinder : Cirkel
    {
        private double _h;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        public Cilinder(double x, double y, double r, double h)
            : base(x, y, r)
        {
            H = h;
        }
        public  double Volume()
        {
            return base.Oppervlakte() * H;
        }
        public override double Oppervlakte()
        {
            return base.Oppervlakte() + (base.Omtrek() * H);
        }

        public override string Gegevens()
        {
            return $"({X}, {Y}) straal {R}\n hoogte = {H}\n oppervlakte = {Oppervlakte():0.##}\n volume = {Volume():0.##}";
        }
    }
}