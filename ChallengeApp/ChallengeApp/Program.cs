using ChallengeApp;

Employee employee1 = new Employee("Jan", "Nowak", 18);
Employee employee2 = new Employee("Milena", "Milewska", 50);
Employee employee3 = new Employee("Piotr", "Piotrowski", 90);


employee1.AddScore(3);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(2);
employee1.AddScore(0);

employee2.AddScore(3);
employee2.AddScore(0);
employee2.AddScore(7);
employee2.AddScore(1);
employee2.AddScore(9);

employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(6);
employee3.AddScore(2);
employee3.AddScore(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;


foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("The Winner is:");
Console.WriteLine("Name: " + employeeWithMaxResult.Name);
Console.WriteLine("Surname: " + employeeWithMaxResult.Surname);
Console.WriteLine("Age: " + employeeWithMaxResult.Age);
Console.WriteLine("He have: " + employeeWithMaxResult.Result + " points");