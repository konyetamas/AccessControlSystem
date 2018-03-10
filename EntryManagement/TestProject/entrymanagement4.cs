using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrHouse.Telnet;
using OKHOSTING.Core.Net4.Net;

namespace TestProject
{
   public class entrymanagement4
    {

        public void Process()
        {
            TelnetConnection tc = new TelnetConnection("192.168.4.1", 80);

            //login with user "root",password "rootpassword", using a timeout of 100ms, 
            //and show server output
            //string s = tc.Login("", "", 100);
            //Console.Write(s);

            // server output should end with "$" or ">", otherwise the connection failed
            //string prompt = s.TrimEnd();
            //prompt = s.Substring(prompt.Length - 1, 1);
            //if (prompt != "$" && prompt != ">")
            //    throw new Exception("Connection failed");

            //prompt = "";

            string valami = "del";

            // while connected
            while (tc.IsConnected)
            {
                // display server output
                Console.Write(tc.Read());

                // send client input to server
               // prompt = Console.ReadLine();
                tc.WriteLine(valami);
              
                // display server output
                Console.Write(tc.Read());

                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine("***DISCONNECTED");
            Console.ReadLine();
        }
    }
}
