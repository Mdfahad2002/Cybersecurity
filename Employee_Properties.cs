//3.Rewrite the solution for Ex.2, using properties.
/*using System;
public class Employee
{
    private string name,address;

    public string EmployeeId { get; private set; }
    public string  Position{ get; private set; }

    public double Salary { get; private set; } 
    public Employee()                   //Parameterless constructor
    {
        name = "Mohamed Fahad";
        address = "D24";
        EmployeeId = "20016516";
        Position = "Student";
        Salary = 0.0;                   //Using double
    }
        public Employee(string name, string address, string employeeId, string position, double salary)
    {                                       //Parameterized constructor
        this.name = name;
        this.address = address;
        EmployeeId = employeeId;
        Position = position;
        Salary = salary;                                //Using double
    }
    public Employee(Employee employee)              //Copy constructor
    {
        this.name = employee.name;
        this.address = employee.address;
        this.EmployeeId = employee.EmployeeId;
        this.Position = employee.Position;
        this.Salary = employee.Salary;                  // Using double
    }
    public string Name                          //accessing private name with properties
    {
        get { return name; }
        set { name = value; }
    }
    public string Address                       //accessing private name with properties
    {
        get { return address; }
        set { address = value; }
    }
    public void ShowEmployeeInfo()          //Method to show employee information
    {
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Position: " + Position);
        Console.WriteLine("Salary: " + Salary);
    }
    public double NetPay()
    {
        double taxRate = 0.2; // Example tax rate of 20%
        double incomeTax = Salary * taxRate;
        double netPay = Salary - incomeTax;

        Console.WriteLine($"Income Tax Deducted: {incomeTax}");
        return netPay; // Using double
    }
    public void ShowSalarySlip()            //Method to show salary slip
    {
        Console.WriteLine("Salary Slip");
        Console.WriteLine("Employee ID:"+EmployeeId);
        Console.WriteLine("Name:"+name);
        Console.WriteLine("Position:"+Position);
        Console.WriteLine("Gross Pay:"+Salary);
        double netPay = NetPay();                                   // Using double
        Console.WriteLine($"Net Pay: {netPay}");
        Console.WriteLine("-----------------------");
    }
}
public class EmployeeDetails
{
    public static void Main()
    {
        
        Employee emp1 = new Employee();                 //Parameterless constructor

        // Input for employee 2
        Console.WriteLine("Enter details for Employee 2:");
        Console.Write("Name: ");
        string name2 = Console.ReadLine();

        Console.Write("Address: ");
        string address2 = Console.ReadLine();

        Console.Write("Employee ID: ");
        string employeeId2 = Console.ReadLine();

        Console.Write("Position: ");
        string position2 = Console.ReadLine();

        Console.Write("Salary: ");
        double salary2 = double.Parse(Console.ReadLine());              //Parse to double

        Employee emp2 = new Employee(name2, address2, employeeId2, position2, salary2);

        Employee emp3 = new Employee(emp2);                 //Copy constructor
        
        Console.WriteLine("-----------------------");
        Console.WriteLine("\nEmployee 1:");
        emp1.ShowEmployeeInfo();

        Console.WriteLine("-----------------------");
        Console.WriteLine("\nEmployee 2:");
        emp2.ShowEmployeeInfo();

        Console.WriteLine("-----------------------");
        Console.WriteLine("\nEmployee 3:");
        emp3.ShowEmployeeInfo();
        Console.WriteLine("-----------------------");

        Console.WriteLine("\nEmployee 1 salary slip:"); //Display function
        emp1.ShowSalarySlip();

        Console.WriteLine("\nEmployee 2 salary slip:");
        emp2.ShowSalarySlip();

        Console.WriteLine("\nEmployee 3 salary slip:");
        emp3.ShowSalarySlip();
    }
}*/