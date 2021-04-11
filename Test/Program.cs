using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAJGen;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGen rnd = new RandomGen(Option.IncludeCapitalAndSpecial);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Gen());
            }
            Console.ReadLine();
        }
    }
}
