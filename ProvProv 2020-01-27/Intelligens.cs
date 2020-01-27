using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvProv_2020_01_27
{
    class Intelligens : Hero
    {
        public intelligenss()
        {
            hp = generator.Next(5, 10);
            intlegens = generator.Next(10, 20);
            attack = generator.Next(5, 10);
            speed = generator.Next(10, 20);

            Console.WriteLine("Dinna states är hp " + hp + " intelegens " + intlegens + " attack " + attack + " speed " + speed);
        }//skulle randomiza fram statsen och seda skriva ut dem
    }
}
