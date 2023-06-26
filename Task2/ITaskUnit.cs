using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface ITaskUnit
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DueDate { get; set; }
    }
}
