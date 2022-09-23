using DemoLibrary;

namespace ConsoleUI
{
    public  static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessengerSender CreateMessageSender()
        {
            return new Emailer(); // Here you could use Emailer or Texter and nothing broken
        }
        
    }
}
