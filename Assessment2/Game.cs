using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public abstract class Game
    {
        public virtual void Play()
        {
            Console.WriteLine("Game can't be played right now.");
        }
    }
}
