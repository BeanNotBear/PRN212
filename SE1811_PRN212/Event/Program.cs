namespace Event
{
    // step 1:
    public delegate void Dele5(String msg);

    class EventMethod
    {
        public static void ShowLower(String msg) => Console.WriteLine(msg);
    }

    class Events
    {
        // step 2:
        event Dele5 EV;
        Dele5 dele5 = EventMethod.ShowLower;

        public void RegisterEvent()
        {
            EV += dele5;
        }

        public void RaisingEvent()
        {
            EV("Hello world!");
        }

        public void UnregisterEvent()
        {
            EV -= dele5;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // Event: created by delegate
            // step 1: create delegate
            // step 2: create event from delegate in step 1
            // step 3: register/cancel Event by using +=, -=
            // step 4: active Event

            Events events = new Events();
            events.RegisterEvent();
            events.RaisingEvent();
            events.UnregisterEvent();
            events.RaisingEvent();
        }
    }
}
