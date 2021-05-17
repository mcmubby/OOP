using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // PartTimeEmployee PTE = new PartTimeEmployee();
            // PTE.firstName = "muiz";
            // PTE.lastName = "Atolagbe";
            // PTE.printFullName();

            // ContractEmployee CTE = new ContractEmployee();
            // CTE.firstName = "Ray";
            // CTE.lastName = "John";
            // CTE.printFullName();

            // ParentClass parent = new ParentClass();
            // parent.printSomething();
            // ChildClass child = new ChildClass();
            // child.saySomething();
            // child.printSomething();

            Rectangle square = new Square();

            square.ShapeMethod();
            square.RectangleMethod();
            

        }
    }

    // public class ParentClass
    // {
    //     public void printSomething()
    //     {
    //         System.Console.WriteLine("This is the parent class");
    //     }
    // }

    // public class ChildClass : ParentClass
    // {
    //     public void saySomething()
    //     {
    //         System.Console.WriteLine("This is the child class");
    //     }
    // }
}
