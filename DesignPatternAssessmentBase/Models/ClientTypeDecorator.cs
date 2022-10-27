using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssessmentBase.Models
{
    //ClientTypeDecorator is an abstract class inheriting from the basic ticket class allowing the breachDeadline and ResponseDeadline be modified in sub classes. 
    public abstract class ClientTypeDecorator: Ticket
    {
        public override double GetBreachDeadline()
        {
            // base conditions
            // should update breach deadline after reviewing conditions
            // from the name GetBreachDeadline i felt it should return the value so me returning 2.2 is a "hack"

            return 2.2;
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
