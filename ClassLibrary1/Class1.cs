public class Employee
{
    // instance fields
    public int EmpID;
    public string EmpName;
    public decimal SalaryPerHour;
    public int NoOfWorkingHours;
    public decimal NetSalary;

    public static string OrganizationName = "MyCompany";

    public const string TypeOfEmployee = "Contract Base";

    public readonly string DepartmentName;

    // constructor
    public Employee()
    {
       DepartmentName = "Finance Department";
    }
}
