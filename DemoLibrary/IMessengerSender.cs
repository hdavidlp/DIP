namespace DemoLibrary
{
    public interface IMessengerSender
    {
        void SendMessage(IPerson person, string message);
    }
}