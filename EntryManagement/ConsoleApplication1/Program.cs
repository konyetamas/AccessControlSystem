using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKHOSTING.Core.Net4.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            TelnetConnection tc = new TelnetConnection("192.168.4.1", 80);
            bool openDoor = false;

            string message = openDoor == true ? "del" : "led";
            if (tc.IsConnected)
            {
                Console.Write(tc.Read());
                tc.WriteLine(message);
                Console.Write(tc.Read());
            }
        }
    }
}
