using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    class Pupil : BaseModel
    {

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [Range(0, 150)]
        public int Age { get; set; }

        [Required]
        [StringLength(20)]
        public string Telephone { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(10)]
        public string Grade { get; set; }

        public virtual Classes Class {get;set;}

        [Required]
        public int Classid { get; set; }

        [StringLength(100)]
        public string FullName { get { return String.Format("{0} {1}", FirstName, LastName).Trim(); } }

    }
}
