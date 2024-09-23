using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieksztalty
{
    internal class Prostokat
    {
        public int BokA {  get; set; }  = 0;
        public int BokB { get; set;} = 0;

        public void Wyzuc()
        {
            Console.WriteLine("Pole prostokatu wynosi " + BokA * BokB);
        }
    }
}
