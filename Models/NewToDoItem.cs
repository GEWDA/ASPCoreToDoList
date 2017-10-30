using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreToDoList.Models
{
    public class NewToDoItem
    {
        [Required]
        public string Title { get; set; }
    }
}
