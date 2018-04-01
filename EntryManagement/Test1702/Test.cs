using DataBase;
using Test1702.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1702.Model;
using OKHOSTING.Core.Net4.Net;
using System.IO;
using System.Net.Sockets;
using System.Net.Http;
using System.Net;

namespace Test1702
{
    public class Test
    {

        public event EventHandler UpdateEntriesListEvent;

        public event EventHandler UpdateEntryWindow;


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
            int counter = 0;
            string CardNumber = "";
            while (true)
            {



                for (int i = 0; i < 255; i++)
                {
                    //  uint pcbSize = 100;
                    int key = GetAsyncKeyState(i);
                    if (key == -32767)
                    {
                        if (i > 48 && i < 58)
                        {

                            if (counter < 8)
                            {
                                CardNumber += FromAsciiToString(i);
                                counter++;
                            }
                            else
                            {
                                counter = 0;
                                //EventArgs e = new EventArgs();
                                //UpdateEntriesListEvent(CardNumber, e);
                                Autenthication(CardNumber);
                                CardNumber = "";
                                break;
                            }
                        }
                    }
                    //786495 ez a kódja a HID devicenak


                    //EventArgs e = new EventArgs();
                    //DataBaseLayer dl = new DataBaseLayer();
                    //if (dl.MemberManagement(CardNumber))
                    //{
                    //    UpdateEntriesListEvent(CardNumber, e);
                    //}

                    //uint valami = GetRawInputDeviceInfo(IntPtr.Zero, 0x20000007, IntPtr.Zero, ref pcbSize);
                    //Console.WriteLine("kiírkiír");
                    ////uint valami = GetRawInputDeviceInfo(hDevice, 0x20000007, hDevice1, 100);
                    //Console.WriteLine(i);
                }


            }






            // Console.ReadLine();
        }

        private void Autenthication(string CardNumber)
        {
            
                DataBaseLayer db = new DataBaseLayer();         
                MemberModel actualMember = db.CheckMemberByCardNumber(CardNumber);
            if (actualMember != null)
            {                
                db.AddNewEntryToDataBase(actualMember.Id);
                EventArgs e = new EventArgs();
                AnswerFromHardverModel model = new AnswerFromHardverModel();
                model.ActualMember = actualMember;
                model.Enable = true;
                DoorManagement(true);
                UpdateEntryWindow(model, e);

            }
            else
            {
                EventArgs e = new EventArgs();
                AnswerFromHardverModel model = new AnswerFromHardverModel();
                model.ActualMember = new MemberModel();
                model.Enable = false;
                DoorManagement(false);
                UpdateEntryWindow(model, e);

            }
            // db.MemberManagement(CardNumber);

        }

        private string ReadCardNumber()
        {
            string result = "";
            int counter = 0;
            while (counter < 6)
            {
                for (int i = 0; i < 255; i++)
                {
                    int key = GetAsyncKeyState(i);
                    if (key == -32767)
                    {
                        result += FromAsciiToString(key);
                        counter++;
                    }
                }

            }

            return result;

        }


        private string FromAsciiToString(int Key)
        {
            //49-57

            List<AsciiString> list = new List<AsciiString>()
            {
                new AsciiString(49, "1"),
                 new AsciiString(50, "2"),
                 new AsciiString(51, "3"),
                 new AsciiString(52, "4"),
                 new AsciiString(53, "5"),
                 new AsciiString(54, "6"),
                 new AsciiString(55, "7"),
                 new AsciiString(56, "8"),
                 new AsciiString(57, "9"),

            };

            return list.Where(x => x.Ascii == Key).Select(x => x.Number).FirstOrDefault();
        }
        

        private static readonly HttpClient client = new HttpClient();

        public void DoorManagement(bool openDoor)
        {
            string ip = "http://192.168.4.1";
            string message = openDoor == true ? "/ledsw?granted=1" : "/ledsw?granted=0";
            string url = ip + message;
            WebRequest request = WebRequest.Create(url);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

        }


    }

    class AsciiString
    {
        public int Ascii { get; set; }
        public string Number { get; set; }

        public AsciiString(int ascii, string Number)
        {
            this.Ascii = ascii;
            this.Number = Number;
        }
    }


}
