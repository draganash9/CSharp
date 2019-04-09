using MyLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Classes
{
    public class RockstarFighter: Fighter, IStreet , IMuayThai , IBox
    {
        public RockstarFighter(double health, double powerPunch, double speed,double reputation) : base(health, powerPunch, speed)
        {
            Reputation = reputation;
        }
        public double Reputation { get; set; }

        public void DoBoxing(Fighter opponent)
        {
            double dmg = Speed + PowerPunch + Reputation;
            opponent.TakeDamage(dmg);
        }

        public void DoMuayThai(Fighter opponent)
        {
            double dmg = Speed + PowerPunch + Reputation;
            FightMethod(opponent, dmg);
        }

        public void DoStreet(Fighter opponent)
        {
            double dmg = Speed + PowerPunch + Reputation;
            opponent.TakeDamage(dmg);
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("You hit him with ciganski samar,NO RECOVERY !!!");
        }
       
    }
}
