using Task3_5;

Repository<Employee> repository = new Repository<Employee>();

repository.ItemAdded += employee =>
{
    Console.WriteLine($"Event: {employee.Name} was added.");
};

repository.Add(new Employee("Ravi", "IT", 95000));
repository.Add(new Employee("Priya", "HR", 60000));
repository.Add(new Employee("Arun", "IT", 85000));

Console.WriteLine();
Console.WriteLine("Employees:");

foreach (Employee employee in repository.Get())
{
    Console.WriteLine(employee);
}
