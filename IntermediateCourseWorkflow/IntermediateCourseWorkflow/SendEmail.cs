using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseWorkflow
{
    internal class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email to user");
        }
    }
}
