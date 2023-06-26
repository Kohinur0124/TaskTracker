using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TaskUnit : ITaskUnit
    {
        public string Name { get; set; }
        public string Description { get ; set ;}
        public DateTimeOffset DueDate { get ; set ;}

        public TaskUnit( string name, string description , DateTimeOffset dateTimeOffset)
        {
            Name = name;
            Description = description;
            this.DueDate = dateTimeOffset;
            
        }

        public override string ToString()
        {
            return $"{Name}  {Description}  {DueDate}";
        }

    }
}
