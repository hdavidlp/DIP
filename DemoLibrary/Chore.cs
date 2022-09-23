using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public  class Chore
    {
        public string ChoreName { set; get; }
        public Person Owner { set; get; }   
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; set; }    

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            Logger log = new Logger();
            log.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            
            Logger log = new Logger();
            log.Log($"Completed { ChoreName}");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The chore {ChoreName} is complete.");
        }

    }
}
