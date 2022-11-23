using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseWorkflow
{
    internal class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities = new();

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public List<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
