using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CInvoker
    {
        private ArrayList listOfCommands = new ArrayList();

        public CInvoker()
        {
            LoadCommands();
        }

        private void LoadCommands()
        {
            listOfCommands.Add(new cmdOpen());
            listOfCommands.Add(new cmdClose());
            listOfCommands.Add(new cmdCreate());
            listOfCommands.Add(new cmdUpdate());
            listOfCommands.Add(new cmdRetrieve());
            listOfCommands.Add(new cmdExit());
        }

        public void ShowAvailableCommands()
        {
            string s = "Here is a list of available commands:\n";

            foreach (var item in listOfCommands)
            {
                ICommand objCmd = (ICommand) item;

                s += "- " + objCmd.Name + "\n";
            }

            Console.WriteLine(s);
        }

        public ICommand GetCommand(string name)
        {
            foreach (var item in listOfCommands)
            {
                ICommand objCmd = (ICommand) item;

                if (objCmd.Name == name)
                    return objCmd;
            }
            Console.WriteLine("Invalid command! Please try again.");
            return null;
        }

        #region Commands

        class cmdOpen : ICommand //command 1
        {
            private string _name = "open", _description = "opens a file";
            public string Name { get { return _name; } set { _name = value; } }

            public string Description { get { return _description; } set { _description = value; } }

            public void Run() { Console.WriteLine("running open command..."); }
        }

        class cmdClose : ICommand //command 2
        {
            private string _name = "close", _description = "closes a file";
            public string Name { get { return _name; } set { _name = value; } }
            public string Description { get { return _description; } set { _description = value; } }
            public void Run() { Console.WriteLine("running close command..."); }
        }

        class cmdCreate : ICommand //command 3
        {
            private string _name = "create", _description = "creates a file";
            public string Name { get { return _name; } set { _name = value; } }
            public string Description { get { return _description; } set { _description = value; } }
            public void Run() { Console.WriteLine("running create command..."); }
        }

        class cmdUpdate : ICommand //Command 4
        {
            private string _name = "update", _description = "updates a file";
            public string Name { get { return _name; } set { _name = value; } }
            public string Description { get { return _description; } set { _description = value; } }
            public void Run() { Console.WriteLine("running update command..."); }
        }

        class cmdRetrieve : ICommand //command 5
        {
            private string _name = "retrieve", _description = "retrieves a file";
            public string Name { get { return _name; } set { _name = value; } }
            public string Description { get { return _description; } set { _description = value; } }
            public void Run() { Console.WriteLine("running Retrieve command..."); }
        }
        class cmdExit : ICommand //command 6
        {
            private string _name = "exit", _description = "exit program";
            public string Name { get { return _name; } set { _name = value; } }
            public string Description { get { return _description; } set { _description = value; } }

            public void Run()
            {
                Console.WriteLine("turning off...");
                Environment.Exit(0);
            }
        }
        #endregion
    }
}
