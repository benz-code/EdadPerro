using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadPerro
{
    class Program
    {
        static void Main(string[] args)
        {
            //EdadDePerro
            Console.WriteLine("Ingrese año de nacimiento de perro: ");
            int año_nacimiento = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año actual: ");
            int año_actual = int.Parse(Console.ReadLine());
            int edad = (año_actual - año_nacimiento) * 15;
            Console.Write("Su perro tiene " + edad + "años.");
            Console.ReadKey();


        }
    }
}
