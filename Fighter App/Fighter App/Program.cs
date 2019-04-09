using MyLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighter_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not mind the red-underline, these classes need to be implemented by you
            StreetFighter mess = new StreetFighter(120, 2, 1, 7);
            ProFighter ryu = new ProFighter(150, 4, 2, 13);
            RockstarFighter blanka = new RockstarFighter(22, 5, 4, 17);

            //ryu.DoBoxing(blanka);
            mess.DoStreet(blanka);
            mess.DoStreet(blanka);
            mess.DoStreet(blanka);
            //blanka.DoBoxing(ryu);
            //blanka.DoMuayThai(ryu);
            blanka.DoStreet(mess);
            blanka.DoStreet(mess);
            Console.WriteLine(blanka.Health);

            Console.ReadLine();
        }
    }
}
