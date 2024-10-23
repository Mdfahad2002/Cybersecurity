//2.Create a class Employee. Find out data and methods for this class. (e.g. An Employee has personal information like name, address, professional details like employee id, salary, position, etc.)
// a. Keep personal/sensitive data (e.g. employee address, salary) as private data.
// b. Create records for 3 employees using parameterless constructor, parameterised constructor and copy constructor.
// c. Show the Employee details using method showEmployeeInfo().
// d. Write a method that calculate income tax, deduct the tax from the gross pay and show the on the net pay.
// e. Write a method to show salary slip

/*using System;

public class Employee
{
    private string name,address,employeeId,position;        //Private fields   
    private double salary; 

    public Employee()               //Parameterless constructor
    {
        name = "Mohamed Fahad";
        address = "D24";
        employeeId = "20016516";  //Default employee ID
        position = "Student";      //Default position
        salary = 0.0; 
    }

    public Employee(string name, string address, string employeeId, string position, double salary) 
    {                                   //Parameterized constructor
        this.name = name;
        this.address = address;
        this.employeeId = employeeId;  //Directly assigned to private field
        this.position = position;      
        this.salary = salary;
    }

    public Employee(Employee employee)          //Copy constructor
    {
        this.name = employee.name;
        this.address = employee.address;
        this.employeeId = employee.employeeId;  //Directly assigned to private field
        this.position = employee.position;      
        this.salary = employee.salary;
    }

    public void ShowEmployeeInfo()              //Show the Employee details using method
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Position: " + position);
        Console.WriteLine("Salary: " + salary);
    }

    public double NetPay()
    {
        double taxRate = 0.2;           //Based on Ireland tax rate
        double incomeTax = salary * taxRate;
        double netPay = salary - incomeTax;

        Console.WriteLine($"Income Tax Deducted: {incomeTax}");
        return netPay;
    }

    public void ShowSalarySlip()                //Method to show salary slip
    {
        Console.WriteLine("Salary Slip");
        Console.WriteLine("Employee ID:"+employeeId);
        Console.WriteLine("Name:"+name);
        Console.WriteLine("Position:"+position);
        Console.WriteLine("Gross Pay:"+salary);
        double netPay = NetPay();
        Console.WriteLine($"Net Pay: {netPay}");
        Console.WriteLine("--------------------------");
    }

    public static Employee InputEmployeeDetails()  //Static method for input from user
    {
        Console.WriteLine("Enter Employee Details:");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        string employeeId = Console.ReadLine();

        Console.Write("Enter Position: ");
        string position = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine());       //Double Stores fractional numbers

        return new Employee(name, address, employeeId, position, salary);
    }
}

public class EmployeeDetails
{
    public static void Main()
    {
        Employee emp1 = new Employee();                     //Using parameterless constructor
        Employee emp2 = Employee.InputEmployeeDetails();    //Using parameterized constructor
        Employee emp3 = new Employee(emp2);                 //Copy of emp2 using the copy constructor
        
        Console.WriteLine("--------------------------");
        Console.WriteLine("\nEmployee 1 - Default Constructor:"); //Display function
        emp1.ShowEmployeeInfo();
        Console.WriteLine("--------------------------");

        Console.WriteLine("\nEmployee 2 - Parameterized Constructor:");
        emp2.ShowEmployeeInfo();
        Console.WriteLine("--------------------------");
        
        Console.WriteLine("\nEmployee 3 - Copy Constructor:");
        emp3.ShowEmployeeInfo();
        Console.WriteLine("--------------------------");
        Console.WriteLine("\nEmployee 1 salary slip:");
        emp1.ShowSalarySlip();

        Console.WriteLine("\nEmployee 2 salary slip:");
        emp2.ShowSalarySlip();

        Console.WriteLine("\nEmployee 3 salary slip:");
        emp3.ShowSalarySlip();
    }
}*/
