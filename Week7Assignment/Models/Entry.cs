using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week7Assignment.Models
{
    public class Entry
    {
        public int ID { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set;
            /* get
            {
                return DateAdded;
            }
            
            set
            {
                DateAdded = DateTime.Now; 
            }  */
        }

        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        [Range(0,150)]
        public int Chapter { get; set; }

        [Range(0, 150)]
        public int Verse { get; set; }

        [Required]
        public string Note { get; set; }
    }
}
