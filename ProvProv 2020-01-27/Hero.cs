using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvProv_2020_01_27
{
    class Hero
    {
        protected static Random generator = new Random();

        protected int hp;
        protected int attack;
        protected int intlegens;
        protected int speed;

        public int Heroreandom()
        {
            int result = generator.Next(0, 20) + hp + attack + intlegens + speed;

            if (result > 20)
            {
                return 20;
            }
            else
            {
                return result;
            }
            //Min randomgen för att få det att fungera. 
        }
    }
}
