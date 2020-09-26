using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team_Up.Models
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        [Required]
        public string Education { get; set; }
        [Required]
        public string Experience { get; set; }
        public virtual ICollection<Technology> Technologies { get; set; }
        [Required]
        [Display(Name = "Hobbies And Interests")]
        public string HobbiesInterests { get; set; }

        public Resume()
        {
            this.Links = new List<Link>();
            this.Technologies = new List<Technology>();
        }

    }
}