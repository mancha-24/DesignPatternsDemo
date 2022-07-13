namespace kitkart.core.Interfaces
{
    public interface IFactory
    {
        IComputer CreateComputer();
        ISmartPhone CreateSmarthPhone();
        ITablet CreateTable();
    }
}