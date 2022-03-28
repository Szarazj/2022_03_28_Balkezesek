using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<sportoló> sportolók = new List<sportoló>();
            foreach (var sor in File.ReadAllLines("balkezesek.csv").Skip(1))
            {
                sportolók.Add(new sportoló(sor));
            }


            //3. feladat
            Console.WriteLine($"3. feladat: {sportolók.Count}");

            Console.ReadKey();
        }
    }
}
