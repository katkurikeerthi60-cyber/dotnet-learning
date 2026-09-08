namespace Task3_5;

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string department, double salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{Name} - {Department} - {Salary}";
    }
}
