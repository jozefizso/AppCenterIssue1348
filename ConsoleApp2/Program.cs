using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            AppCenter.Configure("secret");
            AppCenter.Start(typeof(Analytics));


            Console.ReadKey();
        }
    }
}
