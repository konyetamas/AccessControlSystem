using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1702
{
   public class Test
    {

        public event EventHandler UpdateEntriesListEvent;


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        extern static uint GetRawInputDeviceInfo(IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);


        public void Process()
        {
            //uint deviceCount = 0;
            //uint dwSize = 0;
            //var pRawInputDeviceList = Marshal.AllocHGlobal((int)(dwSize * deviceCount));
            //GetRawInputDeviceList(pRawInputDeviceList, ref deviceCount, (uint)dwSize);
            Task t= new Task(() =>
            {
                while (true)
                {
                    for (int i = 0; i < 255; i++)
                    {
                        uint pcbSize = 100;
                        int key = GetAsyncKeyState(i);
                        IntPtr hDevice = new IntPtr();
                        IntPtr hDevice1 = new IntPtr();

                        if (key == -32767)
                        {
                            //786495 ez a kódja a HID devicenak
                            EventArgs e = new EventArgs();

                            string felirat = "oké";
                           
                            UpdateEntriesListEvent(felirat, e);


                            uint valami = GetRawInputDeviceInfo(IntPtr.Zero, 0x20000007, IntPtr.Zero, ref pcbSize);
                            Console.WriteLine("kiírkiír");
                            //uint valami = GetRawInputDeviceInfo(hDevice, 0x20000007, hDevice1, 100);
                            Console.WriteLine(i);
                        }

                    }
                }
            });
            t.Start();




            Console.ReadLine();
        }
    }
            
        
}
