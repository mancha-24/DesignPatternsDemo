namespace kitkart.core
{
    public class ClientAFactory : IFactory
    {
        public void CreateComputer()
        {
            Console.WriteLine("ClientA");
        }
    }
}