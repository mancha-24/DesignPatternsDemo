// See https://aka.ms/new-console-template for more information

using kitkart;
using kitkart.core;

Singleton fromEmployee = Singleton.GetInstance;
fromEmployee.PrintDetails("From Employee");

Singleton fromStudent = Singleton.GetInstance;
fromEmployee.PrintDetails("From student");

Console.ReadKey();
