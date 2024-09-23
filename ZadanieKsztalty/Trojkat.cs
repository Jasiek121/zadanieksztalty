using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieksztalty
{
    internal class Trojkat
    {
        public int Wysokosc { get; set; } = 0;

        public int BokA { get; set; } = 0;

        public void Wyzuc()
        {
            Console.WriteLine("Pole trojkata wynosi " + (BokA * Wysokosc) / 2);
        }
    }
}
