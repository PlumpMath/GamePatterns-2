using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_2
{
    class FlipUpCommand : ICommand
    {
        private string _name = "ON";

        public string Name { get { return _name; } set { _name = value; } }
        public Light Light { get; set; }


        public FlipUpCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.ChangeState(true);
        }

        public void Undo()
        {
            Console.WriteLine("Undoing...");
            Light.ChangeState(Light.PreviousState);
        }
    }
}
