public class Employee
{
    public string FirstName;
    public string LastName;
    public string? Salary;

    public string GetName()
    {
        return $"{FirstName} {LastName}";
    }

    public void SetName(string newFirstName, string newLastName)
    {
        this.FirstName = newFirstName;
        this.LastName = newLastName;
        Console.WriteLine($"Name changed to '{this.GetName()}'");
    }
}

class Program
{
    static void Main()
    {
        Employee employee1 = new Employee();
        Employee employee2;
        employee2 = new Employee();

        employee1.FirstName = "Inigo";
        employee1.LastName = "Montoya";
        employee1.Salary = "Too Little";
        IncreaseSalary(employee1);
        Console.WriteLine($"{employee1.GetName()}: {employee1.Salary}");
    }
    static void IncreaseSalary(Employee employee)
    {
        employee.Salary = "Enough to survive on";
    }
}