// See https://aka.ms/new-console-template for more information

using kitkart;
using kitkart.core;


Parallel.Invoke
(
    () => NewEmployee(),
    () => NewStudent()
);
NewStudent();
NewEmployee();

Console.ReadKey();

static void NewEmployee()
{
    Singleton fromEmployee = Singleton.GetInstance;
    fromEmployee.PrintDetails("From Employee");
}

static void NewStudent()
{
    Singleton fromStudent = Singleton.GetInstance;
    fromStudent.PrintDetails("From student");
}