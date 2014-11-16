using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_2
{
    // receiver class
    class Light
    {
        private bool _currentState = false;
        private bool _previousState = false;
        private bool _hasExploded = false;

        public bool CurrentState
        {
            get { return _currentState; }
        }

        public bool PreviousState
        {
            get { return _previousState; }
        }

        public bool HasExploded
        {
            get { return _hasExploded; }
        }


        public void ChangeState(bool turnOn)
        {
            if (HasExploded)
            {
                Console.WriteLine("Cannot change the light, since it has exploded!");
                return;
            }
            _previousState = _currentState;

            if (turnOn)
                _currentState = true;
            else
                _currentState = false;

            GetStatus();

        }

        public void Explode(bool explode)
        {
            _previousState = _currentState;

            _hasExploded = explode;
            
            if (explode)
                Console.WriteLine("Light has exploded!");
        }

        public void GetStatus()
        {
            if (!HasExploded)
                Console.WriteLine(string.Format("Light is turned on: {0}", _currentState));
            else
                Console.WriteLine("Light has exploded!");
        }

    }
}
