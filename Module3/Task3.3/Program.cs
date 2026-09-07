Console.WriteLine("Fetching employee data...");

Task<string> employee1 = GetEmployeeAsync("Ravi", 2000);
Task<string> employee2 = GetEmployeeAsync("Priya", 1500);
Task<string> employee3 = GetEmployeeAsync("Arun", 1000);

string[] employees = await Task.WhenAll(employee1, employee2, employee3);

Console.WriteLine();
Console.WriteLine("Employee Data:");

foreach (string employee in employees)
{
    Console.WriteLine(employee);
}

Console.WriteLine();
Console.WriteLine("All data fetched successfully.");

static async Task<string> GetEmployeeAsync(string name, int delay)
{
    await Task.Delay(delay);

    return $"Employee: {name}";
}
