using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssessmentBase.Models
{
    //this inherits from the abstract ticket class overriding the methods for calculating the deadlines
    //although i didn't explain the details of calculating them
    public class BugReport: Ticket
    {
        [DisplayName("Error Codes")]
        public ICollection<string> ErrorCodes { get; set; }= new HashSet<string>();

        [DisplayName("Error Logs")]
        public ICollection<string> ErrorLogs { get; set; }= new HashSet<string>();

        public BugReport(string name, int hours)
        {
            Name = name;
            Hours = hours;
        }
        
        //here I override the virtual method inherited from parent abstract class
        public override double GetBreachDeadline()
        {
            //conditions
            //calculations
            return 1.2;

        }

        //here I override the virtual method inherited from parent abstract class
        public override double GetResponseDeadline()
        {
            //conditions
            //calculations
            return 1.3;

        }
    }
}
