using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War_project.classes;

namespace War_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDF idf = IDF.GetIDF("hilh", "hiuhi");

            Console.WriteLine(idf.firePower.Brigades[0].weapon[2].name);
            Console.WriteLine(idf.aman.reports[0].Area);

        }
    }
}
