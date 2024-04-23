using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    internal class Die
    {

        public Die() {
            // Create a new instance of the Random class
            Random rnd = new Random();

            // Generate a random number between 1 and 6
            Roll = rnd.Next(1, 7);
        }

        public int Roll;
    }
}
