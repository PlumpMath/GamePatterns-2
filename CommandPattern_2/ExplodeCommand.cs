using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_2
{
    class ExplodeCommand : ICommand
    {
        private string _name = "EXPLODE";

        public string Name { get { return _name; } set { _name = value; } }
        public Light Light { get; set; }

        public ExplodeCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.Explode(true);
        }

        public void Undo()
        {
            Console.WriteLine("Undoing explosion...");
            Light.Explode(false);
            Light.GetStatus();
        }
    }
}
