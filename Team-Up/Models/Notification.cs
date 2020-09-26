using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team_Up.Models
{
    public class Notification
    {
 
        public Notification ()
        {
            this.Recievers = new List<ApplicationUser>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Date Sent")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        public ApplicationUser Sender { get; set; }

        [Required]
        public virtual ICollection<ApplicationUser> Recievers { get; set; }

        [Required]
        [Display(Name ="Notification Message")]
        public string NotificationMessage { get; set; }

        [Required]
        public bool Seen { get; set; }

    }
}