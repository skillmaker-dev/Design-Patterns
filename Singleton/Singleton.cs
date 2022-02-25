namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleton;
        private Singleton()
        {

        }
        public int Number { get; set; }
        public static Singleton GetInstance()
        {

            if(singleton == null)
                singleton = new Singleton();

            return singleton;              
        }
    }
}
