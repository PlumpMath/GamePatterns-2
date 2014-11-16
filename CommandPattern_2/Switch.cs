using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_2
{
    // invoker class
    class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();
        private ICommand _previousCommand;

        public ICommand PreviousCommand
        {
            get
            {
                if (_previousCommand != null)
                    return _previousCommand;
                else
                {
                    Console.WriteLine("Nothing to undo!");
                    return _commands[0];
                }

            }

        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        /*public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            Console.WriteLine(_commands.Count());
            command.Execute();
        }*/

        public ICommand GetCommand(string name)
        {
            foreach (var item in _commands)
            {
                ICommand objCmd = (ICommand)item;

                if (objCmd.Name == name)
                {
                    if (!objCmd.Light.HasExploded)
                    {
                        _previousCommand = objCmd;
                        return objCmd;
                    }
                }
            }
            Console.WriteLine("Invalid command! Please try again.");
            return null;
        }

    }
}
