using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_2
{
    interface ICommand
    {
        string Name { get; set; }
        Light Light { get; set; }

        void Execute();
        void Undo();
    }
}
