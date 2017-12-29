using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    class BaseModel
    {
        [Key]
        public int id { get; set; } 

        [Required]
        public string AddedBy { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }



    }
}
