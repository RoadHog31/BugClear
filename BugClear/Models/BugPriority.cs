using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugClear.Models
{
    public class BugPriority
    {
        public int Id { get; set; }
        string[] bugpriorities = new string[3] { "High", "Medium", "Low" };
    }
}
