using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseWorkflow
{
    internal interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        List<IActivity> GetActivities();
    }
}
