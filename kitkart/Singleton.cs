using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kitkart
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj = new Object();
        public static Singleton GetInstance
        {
            get
            { 
                if (instance == null)
                {
                    lock(obj)
                    {
                        if(instance == null)
                            instance = new Singleton();
                    }
                }
                return instance; 
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