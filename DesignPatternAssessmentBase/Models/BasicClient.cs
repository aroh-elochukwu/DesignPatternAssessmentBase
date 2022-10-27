using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssessmentBase.Models
{
    //the white glove client has its breachDeadline and Response Deadline method overridden based on its requirements
    public class WhiteGloveClient:ClientTypeDecorator
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
