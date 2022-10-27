using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssessmentBase.Models
{
    public enum Priority
    {
        low,
        medium,
        high
    }
    
    //initial ticket class, made abstract because a ticket can only be either a service request or bug report
    public abstract class Ticket
    {
        [Key]
        public int Id { get; set; }

        public bool Completed { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MinLength(5, ErrorMessage = "Name must be at least 5 characters long.")]
        [MaxLength(200, ErrorMessage = "Name must be less than or equal to 200 characters.")]
        public string Name { get; set; }

        [Required]
        [Range(1, 999)]
        public int Hours { get; set; }
        public Priority Priority { get; set; }
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [InverseProperty("Tickets")]
        public ICollection<ApplicationUser> Developers { get; set; } = new HashSet<ApplicationUser>();

        [InverseProperty("OwnedTickets")]
        public virtual ICollection<ApplicationUser> TaskOwners { get; set; } = new HashSet<ApplicationUser>();

        [InverseProperty("WatchedTickets")]
        public virtual ICollection<ApplicationUser> TaskWatchers { get; set; } = new HashSet<ApplicationUser>();
        public virtual ICollection<Comment> Comment { get; set; } = new HashSet<Comment>();    
        
        //Added virtual method here declare a base GetResponseMethod which would be overridden at every class instantiation that inherits from the ticket abstract class 
        public virtual double GetResponseDeadline()
        {
            // base conditions
            // should update respond deadline after reviewing conditions
            // from the name GetResponseDeadline i felt it should return the value so me returning 1.1 is a "hack"
            return 1.1;
        }
        private double ResponseDeadline { get; set; }
        //Added virtual method here declare a base GetResponseMethod which would be overridden at every class instantiation that inherits from the ticket abstract class 
        public virtual double GetBreachDeadline()
        {
            // base conditions
            // should update breach deadline after reviewing conditions
            // from the name GetBreachDeadline i felt it should return the value so me returning 2.2 is a "hack"

            return 2.2;
        }        
        private double BreachDeadline { get; set; } 
                    

        
    }
}
