public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees =
        [
            new Employee(101, "Priyanka", 10000, 10),
            new Employee(102, "Suraj", 80000, 8),
            new Employee(103, "Vishu", 11000, 11),
            new Employee(104, "Rohit", 4000, 4),
            new Employee(101, "Rahi", 3000, 3),
        ];

        //IsPromotable isPromotable = new(Employee.Promote);
        //Employee.PromoteEmployee(employees, isPromotable);

        // Simply using LINQ ... No need of Employee.Promote()
        Employee.PromoteEmployee(employees, employee => employee.Experiance >= 5);
    }
}

public delegate bool IsPromotable(Employee employee);
