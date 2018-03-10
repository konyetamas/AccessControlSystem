//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Permissions;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;

//namespace TestProject
//{
//    class entryManagement6
//    {
//        [System.Runtime.InteropServices.DllImport("user32.dll")]
//        public static extern int GetAsyncKeyState(Int32 i);

//        [System.Runtime.InteropServices.DllImport("user32.dll")]
//        extern static uint GetRawInputDeviceInfo(IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);


//        [System.Runtime.InteropServices.DllImport("user32.dll")]
//        public static extern int GetRawInputData(LParam, DataCommand.RID_INPUT, IntPtr.Zero, ref dwSize, Marshal.SizeOf(typeof(RawInputHeader)));       

//        [System.Runtime.InteropServices.DllImport("user32.dll")]
//        internal static extern uint GetRawInputDeviceList(IntPtr pRawInputDeviceList, ref uint numberDevices, uint size);

//        //[System.Runtime.InteropServices.DllImport("user32.dll")]
//        //public static extern int GetRawInputData(IntPtr hRawInput, RawInputCommand uiCommand, out RAWINPUT pData, ref int pcbSize, int cbSizeHeader);

//        //[System.Runtime.InteropServices.DllImport("user32.dll")]
//        //private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
//        public void Process()
//        {
//            //uint deviceCount = 0;
//            //uint dwSize = 0;
//            //var pRawInputDeviceList = Marshal.AllocHGlobal((int)(dwSize * deviceCount));
//            //GetRawInputDeviceList(pRawInputDeviceList, ref deviceCount, (uint)dwSize);

//            while (true)
//            {
//                for (int i = 0; i < 255; i++)
//                {
//                    uint pcbSize = 100;
//                    int key = GetAsyncKeyState(i);
//                    IntPtr hDevice = new IntPtr();
//                    IntPtr hDevice1 = new IntPtr();
//                    uint dwSize = 0;
//                   // LParam 
//                    if (key == -32767)
//                    {
//                        //786495 ez a kódja a HID devicenak
//                        var res = GetRawInputData(LParam, DataCommand.RID_INPUT, IntPtr.Zero, ref dwSize, Marshal.SizeOf(typeof(RawInputHeader)));
//                        uint valami = GetRawInputDeviceInfo(hDevice, 0x20000007, hDevice1,ref pcbSize);

//                        //uint valami = GetRawInputDeviceInfo(hDevice, 0x20000007, hDevice1, 100);
//                        Console.WriteLine(i);
//                    }

//                }
//            }



        
//            Console.ReadLine();
//        }


//    //    [SecurityPermissionAttribute(SecurityAction.InheritanceDemand,
//    //Flags = SecurityPermissionFlag.UnmanagedCode)]
//    //    [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
//    //    protected override void WndProc(ref Message m)
//    //    {
//    //        if (m.Msg == 0x0312)
//    //        {
//    //            MessageBox.Show("wow");
//    //        }
//    //        base.WndProc(ref m);
//    //    }
//    }
//}
