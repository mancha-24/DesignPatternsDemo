namespace kitkart.core
{
    public class ConcreteKitKart : KitkartManufacturingCompany
    {
        public override IFactory GetComputer(string clientName)
        {
            switch (clientName)
            {
                case "A":
                return new ClientAFactory();
                case "B":
                return new ClientBFactory();
                default:
                throw new ApplicationException(string.Format("We cannot create computer"));
            }
        }
    }
}