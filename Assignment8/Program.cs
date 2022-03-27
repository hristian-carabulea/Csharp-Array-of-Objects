/// <summary>
/// Ask for employee data up for up to 10 employess or until "Yes" is not entered, store it in an array and display it.
/// </summary>
class Program
{
    static void Main()
    {

        Employee[] employeeArray = new Employee[10];

        for (int j = 0; j < 10; j++)
        {
            employeeArray[j] = new Employee();
            employeeArray[j].EmpID = 0;
            employeeArray[j].EmpName = "   ";
            employeeArray[j].SalaryPerHour = 0;
            employeeArray[j].NoOfWorkingHours = 0;
            employeeArray[j].NetSalary = 0;
        }
        bool continueProcessing = true; int i = 0;
        
        while (continueProcessing && i < 10) { 
            
            System.Console.Write("\nEnter employee id: ");
            employeeArray[i].EmpID = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter employee name: ");
            employeeArray[i].EmpName = System.Console.ReadLine();

            System.Console.Write("Enter employee salary per hour : ");
            employeeArray[i].SalaryPerHour = decimal.Parse(System.Console.ReadLine());

            System.Console.Write("Enter Number of working hours: ");
            employeeArray[i].NoOfWorkingHours = int.Parse(System.Console.ReadLine());

            employeeArray[i].NetSalary = employeeArray[i].SalaryPerHour * employeeArray[i].NoOfWorkingHours;

            System.Console.WriteLine("\n" + "EmpID" + " EmpName" + " SalaryPerHour" + " NoOfWorkingHours" + " NetSalary" + " OrganizationName" + " TypeOfEmployee" + " DepartmentName");

            System.Console.WriteLine(employeeArray[i].EmpID + ", " + employeeArray[i].EmpName + ", " + employeeArray[i].SalaryPerHour + ", " + employeeArray[i].NoOfWorkingHours + ", " + employeeArray[i].NetSalary + ", " + Employee.OrganizationName + ", " + Employee.TypeOfEmployee + ", " + employeeArray[i].DepartmentName);

            System.Console.Write("\nIf you want to continue enter Yes: ");
            string answer = System.Console.ReadLine();

            if (answer != "Yes")
            {
                continueProcessing = false;
            }
        }
        System.Console.ReadKey();
    }
}