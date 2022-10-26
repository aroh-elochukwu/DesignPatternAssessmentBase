using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssessmentBase.Models
{
    //GoldLevelClientTicket explains in details here the nitty-gritty of ticket(bugReport or serviceRequest) received from a VIP client where the deadlines and completion date amongst other things could/should be different from a basic  
    public class GoldLevelClientTicket: Ticket
    {
        public override double GetBreachDeadline()
        {
            // base conditions
            // should update breach deadline after reviewing conditions
            // from the name GetBreachDeadline i felt it should return the value so me returning 2.2 is a "hack"

            return 2.2;
        }

    }
}
