namespace Observer_Pattern
{
    //Our Subject
    public class Subject
    {
        //List of observers we want to notify
        private readonly HashSet<IObserver> _observers = new();

        /// <summary>
        /// Add observer.
        /// </summary>
        /// <param name="observer">Observer we want to add.</param>
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Remove observer.
        /// </summary>
        /// <param name="observer">Observer we want to remove.</param>
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Notify Observers.
        /// </summary>
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
