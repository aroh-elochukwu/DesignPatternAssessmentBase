using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssessmentBase.Models
{
    //this inherits from the abstract ticket class overriding the methods for calculating the deadlines
    //although i didn't explain the details of calculating them
    public class ServiceRequest:Ticket
    {
        public RequestType RequestType { get; set; }
        public string ReturnString { get; set; }

        public ServiceRequest(string name, int hours, RequestType requestType)
        {           
            Name = name;
            Hours = hours;
            RequestType = requestType;
            int i = (int)RequestType;

            switch (i)
            {             
                case 0:
                ReturnString = "Hello, what information can I help you with today?";
                 break;

                case 1:
                ReturnString = "Hello, what request are you looking to change?";
                break;

                default:
                throw new ArgumentException();
            }

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
    
    public enum RequestType
    {
        RequestForInformation,
        ChangeRequest
    }
}
