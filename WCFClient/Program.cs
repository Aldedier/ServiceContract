using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClient.Servicios;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteServicio cliente = new ClienteServicio();
            cliente.TestFaultService();
            Console.WriteLine("Terminado");

            Console.ReadKey();
        }
    }
}
