using Task3_2;

List<Employee> employees = new List<Employee>
{
    new Employee("Ravi", "IT", 95000),
    new Employee("Priya", "HR", 60000),
    new Employee("Arun", "IT", 85000),
    new Employee("Sneha", "Finance", 75000),
    new Employee("Kiran", "HR", 55000),
    new Employee("Anjali", "IT", 90000),
    new Employee("Rahul", "Finance", 65000),
    new Employee("Divya", "Finance", 70000)
};

Console.WriteLine("Employee List");

foreach (var employee in employees)
{
    Console.WriteLine($"{employee.Name} - {employee.Department} - {employee.Salary}");
}

Console.WriteLine();
Console.WriteLine("Employees with Salary > 70000");

var highSalaryEmployees = employees
    .Where(e => e.Salary > 70000);

foreach (var employee in highSalaryEmployees)
{
    Console.WriteLine($"{employee.Name} - {employee.Salary}");
}

Console.WriteLine();
Console.WriteLine("Employee Names");

var employeeNames = employees
    .Select(e => e.Name);

foreach (var name in employeeNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();
Console.WriteLine("Employees Sorted by Salary");

var sortedEmployees = employees
    .OrderBy(e => e.Salary);

foreach (var employee in sortedEmployees)
{
    Console.WriteLine($"{employee.Name} - {employee.Salary}");
}

Console.WriteLine();
Console.WriteLine("Top 3 Earners");

var top3Earners = employees
    .OrderByDescending(e => e.Salary)
    .Take(3);

foreach (var employee in top3Earners)
{
    Console.WriteLine($"{employee.Name} - {employee.Department} - {employee.Salary}");
}

Console.WriteLine();
Console.WriteLine("Employees Grouped by Department");

var employeesByDepartment = employees
    .GroupBy(e => e.Department);

foreach (var group in employeesByDepartment)
{
    Console.WriteLine();
    Console.WriteLine(group.Key);

    foreach (var employee in group)
    {
        Console.WriteLine($"  {employee.Name} - {employee.Salary}");
    }
}

Console.WriteLine();
Console.WriteLine("Average Salary by Department");

var averageSalaryByDepartment = employees
    .GroupBy(e => e.Department)
    .Select(group => new
    {
        Department = group.Key,
        AverageSalary = group.Average(e => e.Salary)
    });

foreach (var result in averageSalaryByDepartment)
{
    Console.WriteLine($"{result.Department} - Average Salary: {result.AverageSalary:F2}");
}

Console.WriteLine();
Console.WriteLine("Total Salary");

var totalSalary = employees.Sum(e => e.Salary);

Console.WriteLine($"Total Salary: {totalSalary:F2}");
