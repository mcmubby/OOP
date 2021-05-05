namespace OOP
{
    public class ContractEmployee : Employee
    {
        // public new void printFullName()
        // {
        //     System.Console.WriteLine(firstName + " " + lastName + "----contract employee");
        // }

        public override void printFullName()
        {
            System.Console.WriteLine(firstName + " " + lastName + "----contract employee");
            base.printFullName();
        }
    }
}