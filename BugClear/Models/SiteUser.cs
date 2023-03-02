using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugClear.Models
{
    public class SiteUser
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string UserName { get; set; }

        [Required, StringLength(128)]
        public string Password { get; set; }
    }
}
