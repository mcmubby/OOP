namespace OOP
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        // for method hiding no "virtual" keyword needed
        // public void printFullName()
        // {
        //     System.Console.WriteLine(firstName + " " + lastName);
        // }

        public virtual void printFullName()
        {
            System.Console.WriteLine(firstName + " " + lastName);
        }
    }
}