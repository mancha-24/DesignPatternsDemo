using kitkart.core.Entities;
using kitkart.core.Interfaces;

namespace kitkart.core
{
    public class KitkartManufactoringCompany
    {
        private readonly IFactory _factory;

        private readonly List<IComputer> _computers;
        private readonly List<ITablet> _tablets;
        private readonly List<ISmartPhone> _smartphones;

        public IEnumerable<IComputer> Computers { get => _computers.ToArray(); }
        public IEnumerable<ITablet> Tablets { get => _tablets.ToArray(); }
        public IEnumerable<ISmartPhone> SmartPhones { get => _smartphones.ToArray(); }

        public KitkartManufactoringCompany(IFactory factory)
        {
            _factory = factory;
            _computers = new List<IComputer>();
            _tablets = new List<ITablet>();
            _smartphones = new List<ISmartPhone>();
        }

        public void Produce (Order order)
        {
            CreateComputers(order.Computers);
            CreateTablets(order.Tablets);
            CreateSmartPhones(order.SmartPhones);
        }

        private void CreateComputers(int count)
        {
            while (_computers.Count < count)
            {
                _computers.Add(_factory.CreateComputer());
            }
        }

        private void CreateTablets(int count)
        {
            while (_tablets.Count < count)
            {
                _tablets.Add(_factory.CreateTable());
            }
        }

        private void CreateSmartPhones(int count)
        {
            while (_smartphones.Count < count)
            {
                _smartphones.Add(_factory.CreateSmarthPhone());
            }
        }
    }
}