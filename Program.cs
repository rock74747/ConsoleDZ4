using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Playr;
using Morze;

namespace ConsoleDZ4

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1,2");
            // Два игрока
            PlaerPlayr.Main1(args);
            // С компьютером
            Thread.Sleep(4000);
            Console.Clear();
            PlaerComp.Main2(args);

            Console.WriteLine("Задача 3,4");
            Morzesimbol.Main3(args);





        }

    }
}
