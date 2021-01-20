using System;

namespace DreamJoy_Calc
{
    internal abstract class Dier
    {
        private string _naam;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        protected Dier(string naam)
        {
            Naam = naam;
        }

        public virtual string Eten()
        {
            return "";
        }

        public virtual string Praten(string input)
        {
            return "";
        }

        public virtual string Strelen()
        {
            return "";
        }
    }

    internal class Mens : Dier
    {
        public Mens(string naam) //constructor
            : base(naam)   //wordt enkel aangeroepen in de base constructor Dier
        {
        }

        public override string Eten()
        {
            return "Lekker!";
        }

        public override string Praten(string input)
        {
            string output = "";
            switch (input)
            {
                case "Goedemorgen":
                    output = "Ook een goedemorgen";
                    break;

                case "Hallo":
                    output = $"Hallo, ik ben {Naam}.";
                    break;

                case "How are you?":
                    output = "Ook een goedemorgen";
                    break;

                case "Hey Felicia":
                    output = "Bye Felicia";
                    break;

                case "Yeet":
                    output = "Yooo";
                    break;

                case "Laat mij slapen":
                    output = "Groot gelijk";
                    break;

                case "Today is gonna be the day":
                    output = "that they're all gonna .. ";
                    break;

                case "Ik wil naar huis":
                    output = "Vertrek dan";
                    break;

                case "Be zen":
                    output = "Zen life";
                    break;

                case "Hello V":
                    output = "Hey Panam";
                    break;

                default:
                    output = "Wrong Input";
                    break;
            }
            return output;
        }

        public override string Strelen()
        {
            return "Blijf van mijn lijf. Arrh.";
        }
    }

    internal class Papegaai : Dier
    {
        public Papegaai(string naam)
         : base(naam)
        {
        }

        public override string Praten(string input)
        {
            Random rand = new Random();
            int rnd = rand.Next(1, 5);

            return (rnd == 1) ? "Koko kopke krabben" : input; //If random number is 1 return koko otherwise return input
        }

        public override string Strelen()
        {
            return "Koko";
        }
    }

    internal class Kat : Dier
    {
        public Kat(string naam)
         : base(naam)
        {
        }

        public override string Praten(string input)
        {
            Random rand = new Random();
            int rnd = rand.Next(1, 3);

            return (rnd == 1) ? "MiauwMiauw" : "...";
        }

        public override string Strelen()
        {
            return "RrRrRrR";
        }
    }
}