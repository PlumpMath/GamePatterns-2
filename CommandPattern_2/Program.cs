using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// command pattern c#
namespace CommandPattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);
            ICommand switchExploding = new ExplodeCommand(lamp);

            Switch mySwitch = new Switch();

            Console.WriteLine("Posible commands:\n- [ON]\n- [OFF]\n- [EXPLODE]\n");
            
            mySwitch.AddCommand(switchUp);
            mySwitch.AddCommand(switchDown);
            mySwitch.AddCommand(switchExploding);

            while (true)
            {
                Console.Write(">");
                string s = Console.ReadLine().ToUpper();

                Console.WriteLine("\nYour command: [" + s + "]\n");

                if (s == "STATUS")
                    lamp.GetStatus();
                else if (s == "UNDO")
                    mySwitch.PreviousCommand.Undo();
                else
                {
                    var command = mySwitch.GetCommand(s);
                    
                    if (command != null)
                        command.Execute();
                }


                /*string text = Console.ReadLine();

                if (text == "on")
                {
                    s.StoreAndExecute(switchUp);
                }
                else if (text == "off")
                {
                    s.StoreAndExecute(switchDown);
                }
                else
                {
                    Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
                }*/
            }
            Console.ReadLine();
        }
    }
}
