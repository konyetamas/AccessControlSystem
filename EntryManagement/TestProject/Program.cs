using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;


namespace TestProject
{
    class Program
    {

      //InputSimulator.
        static void Main(string[] args)
        {
            //    SerialPort port;
            //    port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);

            //        port.Open();

            //    Console.ReadLine();


            //entrymanagement3 em = new entrymanagement3();
            //em.Process();



            //EntryManagement em = new EntryManagement();
            //em.GetDetails();
            //  ReadPolling.Process();

            entrymanagement4 em4 = new entrymanagement4();
            em4.Process();

            //test26 test = new test26();
            //test.Process();
            //  emw.Process();

            //Microsoft.Win32.SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
            //Microsoft.Win32.SystemEvents.SessionEnding += SystemEvents_SessionEnding;
            
            entryManagement4 test = new entryManagement4();
            test.Process();
            Console.ReadLine();
        }

        private static void SystemEvents_SessionEnding(object sender, Microsoft.Win32.SessionEndingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
