public class Employee(int employeeID, string name, int salary, int experiance) // parametrized constructor
{
    public int EmployeeID { get; set; } = employeeID;
    public string Name { get; set; } = name;
    public int Salary { get; set; } = salary;
    public int Experiance { get; set; } = experiance;

    public static void PromoteEmployee(List<Employee> employees, IsPromotable isEligibleToPromote)
    {
        foreach (var employee in employees)
        {
            if (isEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }

    public static bool Promote(Employee employee)
    {
        if (employee.Experiance >= 5)
            return true;
        else
            return false;
    }
}
