using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvProv_2020_01_27
{
    class Tank : Hero
    {
        public Tankstates()
        {
            hp = generator.Next(10, 20);
            intlegens = generator.Next(5, 10);
            attack = generator.Next(10, 20);
            speed = generator.Next(5, 10);

            Console.WriteLine("Dinna states är hp " + hp + " intelegens " + intlegens + " attack "+ attack+ " speed "+ speed);
        }//skulle randomiza fram statsen och seda skriva ut dem

    }
}
