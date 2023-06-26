using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TaskTracker <TUnit> where TUnit : ITaskUnit
    {
        private List<TUnit> TaskList;

        public TaskTracker(List<TUnit> tasks) 
        {
            TaskList = tasks;
        }

        public void Add (TUnit task) 
        {
            TaskList.Add(task);    
        }

        public void Remove (TUnit task)
        {
            TaskList.Remove(task);
        }
        public List<TUnit>  LastestTasks() {

            var list = TaskList.Where(task => task.DueDate > DateTimeOffset.Now ).OrderByDescending(task => DateTimeOffset.Now - task.DueDate).ToList();
            return list;
        }

        public int TasksNumber ()
        { 
            return TaskList.Count; 
        }

    }
}
