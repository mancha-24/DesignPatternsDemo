namespace kitkart.core
{
    public class ClientBFactory : IFactory
    {
        public void CreateComputer()
        {
            Console.WriteLine("ClientB");
        }
    }
}