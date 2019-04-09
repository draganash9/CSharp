using MyLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Classes
{
    public class StreetFighter : Fighter , IStreet
    {
        public StreetFighter(double health, double powerPunch, double speed,double streetCredit) : base(health, powerPunch, speed)
        {
            StreetCredit = streetCredit;
        }

        public double StreetCredit { get; set; }


        public void DoStreet(Fighter opponent)
        {
            double dmg = Speed + PowerPunch + StreetCredit;
            FightMethod(opponent, dmg);
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("You hit him with mayageri,expected recovery 2 weeks" );
        }
        


    }
}
