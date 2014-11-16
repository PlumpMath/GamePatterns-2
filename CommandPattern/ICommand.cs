using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    interface ICommand
    {
        string Name { get; set; }
        string Description { get; set; }
        void Run();
    }
}
