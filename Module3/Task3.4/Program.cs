using System.Text.Json;
using Task3_4;

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

string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions
{
    WriteIndented = true
});

File.WriteAllText("employees.json", json);

Console.WriteLine();
Console.WriteLine("Employee data saved to employees.json");

Console.WriteLine();
Console.WriteLine("Reading employee data from JSON file...");

string jsonFromFile = File.ReadAllText("employees.json");

List<Employee> employeesFromJson =
    JsonSerializer.Deserialize<List<Employee>>(jsonFromFile)!;

Console.WriteLine();
Console.WriteLine("Deserialized Employee Data:");

foreach (var employee in employeesFromJson)
{
    Console.WriteLine($"{employee.Name} - {employee.Department} - {employee.Salary}");
}

