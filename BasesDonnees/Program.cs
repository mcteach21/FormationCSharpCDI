using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesDonnees
{
    class Program
    {
        static void Main(string[] args)
        {
            Connections.CreateConnection();

            Connections.LireDonnees();

            Connections.FermerConnection();
            Console.ReadKey();
        }
    }
}
