using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugClear.Models
{
    public class BugSeverity
    {
        public int Id { get; set; }
        string[] bugseverities = new string[3] { "P1", "P2", "P3" };
    }
}
