using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// http://gameprogrammingpatterns.com/command.html
// http://en.wikipedia.org/wiki/Command_pattern#A_simpler_example
// http://www.dotnetperls.com/main
namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command pattern example
            CInvoker cmdInvoker = new CInvoker();

            /*ICommand cmd1 = cmdInvoker.GetCommand("open");
            cmd1.Run();
            
            cmdInvoker.GetCommand("update").Run();
            
            //or
            new CInvoker().GetCommand("close").Run();*/

            cmdInvoker.ShowAvailableCommands();


            while (true)
            {
                string s = Console.ReadLine();

                Console.WriteLine("\nYour command: [" + s + "]\n");

                if (s == "help")
                {
                    cmdInvoker.ShowAvailableCommands();
                    continue;
                }
                var command = cmdInvoker.GetCommand(s);
                if (command != null)
                    command.Run();
            }



        }
    }
}
