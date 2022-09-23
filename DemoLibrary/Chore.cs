using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        private readonly ILogger _logger;
        private readonly IMessengerSender _messengerSender;

        public string ChoreName { set; get; }
        public IPerson Owner { set; get; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; set; }

        

        public Chore(ILogger logger, IMessengerSender messengerSender)
        {
            _messengerSender = messengerSender;
            _logger = logger;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Completed {ChoreName}");
            _messengerSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }

    }
}
