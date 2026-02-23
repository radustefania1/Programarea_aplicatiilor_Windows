using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Client c = new Client("Radu", "Stefania", "stefi.radu@yahoo.com", "0712335678");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
   
    }
}
