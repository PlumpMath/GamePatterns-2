using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command pattern example
            CInvoker cmdInvoker = new CInvoker();
            ICommand cmd1 = cmdInvoker.GetCommand("open");
            cmd1.Run();
            cmdInvoker.GetCommand("update").Run();
            //or
            new CInvoker().GetCommand("close").Run();

            Console.ReadLine();
        }
    }
}
