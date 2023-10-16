using Common.Classes;
using Common.Interfaces;

namespace Business.Classes;

public class Processor
{
    IData _data;
    public Processor(IData data) => _data = data;
    
    public void UpdateSallay(Employee empl, int employeeId, double salary)
    {
        if (_data == null || empl == null) 
            throw new ArgumentNullException();

        if (empl.Role != Roles.Manager) throw new ArgumentException("Is not a manager.");

        if(empl.Id == employeeId) throw new ArgumentException("Cannot assign sallry to self.");

        _data.UpdateSalary(employeeId, salary);
    }
}
