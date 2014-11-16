using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_2
{
    class FlipDownCommand : ICommand
    {
        private string _name = "OFF";

        public string Name { get { return _name; } set { _name = value; } }
        public Light Light { get; set; }

        public FlipDownCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.ChangeState(false);
        }

        public void Undo()
        {
            Console.WriteLine("Undoing...");
            Light.ChangeState(Light.PreviousState);
        }
    }
}
