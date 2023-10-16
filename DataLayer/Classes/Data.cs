using Common.Classes;
using Common.Interfaces;

namespace DataLayer.Classes;

public class Data : IData
{
    List<Employee> employees = new()
    {
        new Employee (Roles.Employee, "Otto", 10000, 1),
        new Employee (Roles.Manager, "Svein", 20000, 2)
};

    public void UpdateSalary(int id, double salary)
    {
        var empl = employees.SingleOrDefault(x => x.Id == id);
        if(empl != null)
            empl.Salary = salary;
    }
}
