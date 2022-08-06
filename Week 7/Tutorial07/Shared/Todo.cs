using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial07.Shared
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public String Name { get; set; }

        public String Description { get; set; }
    }
}
