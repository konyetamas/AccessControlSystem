using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input.Manipulations;
using System.Windows.Input;
using WindowsInput;
using System.Runtime.Remoting.Messaging;
using Microsoft.Win32;
using System.IO.Ports;
using System;
using System.Collections.Generic;
using System.Management;

namespace TestProject
{

    public class EntryManagement
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        //static extern bool BlockInput(bool blockInput);




        public void GetDetails()
        {
            var usbDevices = GetUSBDevices();

            foreach (var usbDevice in usbDevices)
            {
                Console.WriteLine("Device ID: {0}, PNP Device ID: {1}, Description: {2}",
                    usbDevice.DeviceID, usbDevice.PnpDeviceID, usbDevice.Description);
            }

            Console.Read();
        }

        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("PNPDeviceID"),
                (string)device.GetPropertyValue("Description")
                ));
            }

            collection.Dispose();
            return devices;
        }
    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
    }
}




//public void Process()
//{
//    string[] ports = SerialPort.GetPortNames();
//    SerialPort sp = new SerialPort("0006", 9600, Parity.None, 8, StopBits.One);
//    sp.Open();



//    for (int i = 0; i < ports.Length; i++)
//    {
//        Console.WriteLine(ports[i]);
//    }

//    //byte[] keys = new byte[255];
//    while (true)
//    {
//        for (int i = 0; i < 255; i++)
//        {
//            int key = GetAsyncKeyState(i);

//            if (key == -32767)
//            {
//                Console.WriteLine(i);
//            }

//        }
//    }



//    //while (true)
//    //{
//    //    int state=GetKeyboardState(keys);
//    //    Console.WriteLine(state);
//    //    if(state!=1)
//    //    {
//    //        int a = state;
//    //    }

//    //    if (keys[49] == 129)
//    //    {
//    //        Console.WriteLine("Up Arrow key and Right Arrow key down.");
//    //    }
//    //}



//    //int i = 0;
//    //BlockInput(true);
//    //while (i < 100)
//    //{
//    //    System.Threading.Thread.Sleep(100);
//    //    i++;

//    //}
//    //BlockInput(false);
//    Console.ReadLine();
//}


//        //static List<USBDeviceInfo> GetUSBDevices()
//        //{
//        //    List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

//        //    ManagementObjectCollection collection;
//        //    using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
//        //        collection = searcher.Get();

//        //    foreach (var device in collection)
//        //    {
//        //        devices.Add(new USBDeviceInfo(
//        //        (string)device.GetPropertyValue("DeviceID"),
//        //        (string)device.GetPropertyValue("PNPDeviceID"),
//        //        (string)device.GetPropertyValue("Description")
//        //        ));
//        //    }

//        //    collection.Dispose();
//        //    return devices;
//        //}


//        class USBDeviceInfo
//        {
//            public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
//            {
//                this.DeviceID = deviceID;
//                this.PnpDeviceID = pnpDeviceID;
//                this.Description = description;
//            }
//            public string DeviceID { get; private set; }
//            public string PnpDeviceID { get; private set; }
//            public string Description { get; private set; }
//        }


//        [DllImport("user32.dll", SetLastError = true)]
//        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);



//        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
//        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
//        public const int VK_LCONTROL = 0xA2; //Left Control key code
//        public const int A = 0x41; //A key code
//        public const int C = 0x43; //C key code

//        public static void PressKeys()
//        {
//            // Hold Control down and press A
//           // keybd_event(VK_LCONTROL, 0, KEYEVENTF_EXTENDEDKEY, 0);
//            keybd_event(A, 0, KEYEVENTF_EXTENDEDKEY, 0);
//            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
//          //  keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

//            // Hold Control down and press C
//           // keybd_event(VK_LCONTROL, 0, KEYEVENTF_EXTENDEDKEY, 0);
//           // keybd_event(C, 0, KEYEVENTF_EXTENDEDKEY, 0);
//           // keybd_event(C, 0, KEYEVENTF_KEYUP, 0);
//           // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
//        }

//        private void SystemEvents_UserPreferenceChanging(object sender, UserPreferenceChangingEventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_TimerElapsed(object sender, TimerElapsedEventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_TimeChanged(object sender, EventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_SessionEnded(object sender, SessionEndedEventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_PaletteChanged(object sender, EventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_InstalledFontsChanged(object sender, EventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_EventsThreadShutdown(object sender, EventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_DisplaySettingsChanging(object sender, EventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
