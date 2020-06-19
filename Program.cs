using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top10EstadosBrasileiros
{
    class Program
    {
        static void Main(string[] args)
        {
            var states = new Country();
            var tops = states.Top10StatesByArea();

            int cont = 0;
            foreach(var top in tops)
            {
                Console.WriteLine($"{cont}: {top.Acronym}");
                cont++;
            }

            Console.ReadLine();
            
        }
    }
}
