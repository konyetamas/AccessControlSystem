using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardverControl
{
    class Program
    {
        static void Main(string[] args)
        {
            HardverComponent t = new HardverComponent();
            t.Process();
            Console.ReadLine();
        }
    }
}
