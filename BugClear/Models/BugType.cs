using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugClear.Models
{
    public class BugType
    {
        public int Id { get; set; }

        string[] bugtypes = new string[4] { "Memory Usage", "Performance", "RegressionBug", "Specific Website" };
    }
}
