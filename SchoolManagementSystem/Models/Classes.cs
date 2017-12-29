using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    class Classes : BaseModel
    {
        [Required]
        public string ClassSubject { get; set; }

        public virtual Staff Staff { get; set; }

        [Required]
        public string ClassTutor { get; set; }

        public virtual ObservableListSource<Pupil> Pupils { get; set; }

        
    }
}
