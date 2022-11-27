namespace Observer_Pattern
{
    //Our concrete observer that need to be notified of datasource changes.
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart updated.");
        }
    }
}
