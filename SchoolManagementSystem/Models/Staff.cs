using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    class Staff : BaseModel
    {

        [Required]
        [StringLength(30)]
        public string TutorFirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string TutorLastName { get; set; }

        [StringLength(100)]
        public string TutorFullName { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
