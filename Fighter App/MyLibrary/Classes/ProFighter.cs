using MyLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Classes
{
    public class ProFighter: Fighter,IStreet,IBox
    {
        public ProFighter(double health, double powerPunch, double speed,double experience):base(health,powerPunch,speed)
        {
            Experience = experience;
        }
        public double Experience { get; set; }

        public void DoBoxing(Fighter opponent)
        {
            double dmg = Speed + PowerPunch + Experience;
            opponent.TakeDamage(dmg);

        }


        public void DoStreet(Fighter opponent)
        {
            double dmg = Speed + PowerPunch + Experience;
            FightMethod(opponent, dmg);
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("You hit him with karlicno,expected recovery 5 weeks");
        }
      
    }
}
