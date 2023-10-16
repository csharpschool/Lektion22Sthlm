namespace Common.Classes;

public enum Roles
{
    Employee,
    Manager
}
public class Employee
{
    public int Id { get; set; }
    public Roles Role { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public Employee(Roles role, string name, double salary, int id)
    {
        Role = role;
        Name = name;
        Salary = salary;
        Id = id;

    }
}
