using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidLibrary;

namespace TestProject
{
    class test26
    {

        HidDevice _myDevice;
        bool attached = false;
        public void Process()
        {
            //_myDevice = HidDevices.Enumerate(1, 0005).FirstOrDefault();
            IEnumerable<string>devices = HidDevices.Enumerate().Select(x => x.DevicePath).ToList();
            HidDevice _myDevice = HidDevices.GetDevice("\\\\?\\hid#vid_1bcf&pid_0005#6&e3d5557&1&0000#{4d1e55b2-f16f-11cf-88cb-001111000030}");
            //            foreach (var item in HidDevices.GetDevice("PCIROOT(0)#PCI(1400)#USBROOT(0)#USB(1)"
            //"))
            //            {

            //            }

           
            
            if (_myDevice != null)
            {
                _myDevice.OpenDevice();

                _myDevice.Inserted += DeviceAttachedHandler;
                _myDevice.Removed += DeviceRemovedHandler;
               // _myDevice.ReadReportSync
                _myDevice.MonitorDeviceEvents = true;
                _myDevice.Read();
                // this is where we start listening for data

                //while (true)
                //{
                    _myDevice.ReadReport(OnReport);
             //   }
                    //System.Threading.Thread.Sleep(100);
                
            }
        }
        private void DeviceRemovedHandler()
        {
            throw new NotImplementedException();
        }

        private void DeviceAttachedHandler()
        {
            attached = true;
        }


        private void OnReport(HidReport report)
        {
            if (attached == false) { return; }

            // process your data here
            for (int i = 0; i < report.Data.Length; i++)
            {
                if(report.Data[i]>0)
                {
                    Console.WriteLine("oké");
                }
            }
           // var byteFromMyDevice = report.Data[0];

            // we need to start listening again for more data
           // _myDevice.ReadReport(OnReport);
        }
    }
}
