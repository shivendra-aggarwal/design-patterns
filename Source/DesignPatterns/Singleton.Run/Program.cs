using System;

namespace Singleton.Run
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Singleton asEmployee = Library.Singleton.Instance;
            asEmployee.PrintMessage("As Employee");

            Library.Singleton asStudent = Library.Singleton.Instance;
            asStudent.PrintMessage("As Student");

            Console.ReadLine();
        }
    }
}
