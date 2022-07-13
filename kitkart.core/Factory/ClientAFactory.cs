using kitkart.core.Interfaces;
using kitkart.core.Model;

namespace kitkart.core.Factory
{
    public class ClientAFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new ClientAComputer();
        }

        public ISmartPhone CreateSmarthPhone()
        {
            return new ClientASmartPhone();
        }

        public ITablet CreateTable()
        {
            return new ClientATablet();
        }
    }
}