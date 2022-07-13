using kitkart.core.Interfaces;
using kitkart.core.Model;

namespace kitkart.core.Factory
{
    public class ClientBFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new ClientBComputer();
        }

        public ISmartPhone CreateSmarthPhone()
        {
            return new ClientBSmartPhone();
        }

        public ITablet CreateTable()
        {
            return new ClientBTablet();
        }
    }
}