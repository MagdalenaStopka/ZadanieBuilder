using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wytwórnia Toyoty");
            Director director = new Director(new AvensisBuilder());
            director.Construct();
            Console.WriteLine(director.GetBuildParts());
        }
    }
}
