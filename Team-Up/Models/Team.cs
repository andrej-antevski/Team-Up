using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_Up.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
      
        [Required]
        [Display(Name = "Team Name")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Due Date")]
        public DateTime? DueDate { get; set; }
        [Display(Name = "Team Admin(s)")]
        public virtual ICollection<ApplicationUser> Admins { get; set; }
        public virtual ICollection<Message> Chat { get; set; }
        [Display(Name = "Role(s) Needed")]
        public virtual ICollection<RolesNeeded> RolesNeeded { get; set; }
        [Display(Name = "Team Members")]
        public virtual ICollection<ApplicationUser> Members { get; set; }

        public Team(ApplicationUser Creator)
        {
            
            this.Members = new List<ApplicationUser> { Creator };
            this.Admins = new List<ApplicationUser> { Creator };
            this.Chat = new List<Message>();
            this.RolesNeeded = new List<RolesNeeded>();
        }
       

    }
}