// See https://aka.ms/new-console-template for more information

using kitkart.core;

KitkartManufacturingCompany factory = new ConcreteKitKart();

IFactory clientAComputer = factory.GetComputer("A");
clientAComputer.CreateComputer();

IFactory clientBComputer = factory.GetComputer("B");
clientBComputer.CreateComputer();

Console.ReadKey();
