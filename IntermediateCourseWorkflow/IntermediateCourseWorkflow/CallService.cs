using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseWorkflow
{
    internal class CallService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling video encoding service");
        }
    }
}
