using System;

namespace IntermediateCourse
{
    public class Stopwatch
    {
        private DateTime _start, _end;
        private bool _isRunning = false;

        public Stopwatch()
        {
            _start = new DateTime();
            _end = new DateTime();
        }

        public void RunStopwatch()
        {
            Console.WriteLine("Press 'S' to start stopwatch");
            Console.WriteLine("Press 'E' to stop stopwatch");
            Console.WriteLine("Press 'Q' to exit application");

            while (true)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        Start();
                        break;
                    case "E":
                        Stop();
                        break;
                    case "Q":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Press 'S' to start stopwatch");
                        Console.WriteLine("Press 'E' to stop stopwatch");
                        Console.WriteLine("Press 'Q' to exit application");
                        break;

                }
            }
        }

        public void Start()
        {
            if (!_isRunning)
            {
                _start = DateTime.Now;
                Console.Clear();
                Console.WriteLine("Started");
                _isRunning = true;
                Console.WriteLine("Press 'E' to stop stopwatch");
                Console.WriteLine("Press 'Q' to exit application");
            }
            else
            {
                throw new InvalidOperationException("Already started");
            }
        }

        public void Stop()
        {
            if (_isRunning)
            {
                _end = DateTime.Now;
                var _result = _end - _start;
                Console.Clear();
                Console.WriteLine("Ended, result: " + _result);
                _isRunning = false;
                Console.WriteLine("Press 'S' to start stopwatch");
                Console.WriteLine("Press 'Q' to exit application");
            }
            else
            {
                throw new InvalidOperationException("Not started yet");
            }
        }
    }
}
