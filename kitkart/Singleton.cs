namespace kitkart
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        //private static readonly object obj = new Object();
        public static Singleton GetInstance
        {
            get
            { 
                return instance.Value; 
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter value: {counter}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EndPoint
    {
        public string Address { get; set; }
        public string Binding { get; set; }
    }
}