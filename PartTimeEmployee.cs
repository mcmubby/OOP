namespace OOP
{
    public class PartTimeEmployee : Employee
    {
        // hiding
        // public new void printFullName()
        // {
        //     System.Console.WriteLine(firstName + " " + lastName + "---part time employee");
        // }

        public override void printFullName()
        {
            System.Console.WriteLine(firstName + " " + lastName + "---part time employee");
        }
    }
}