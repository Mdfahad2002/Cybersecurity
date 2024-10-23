//See https://aka.ms/new-console-template for more information
//Display function
/*using System;
class FirstClass{
    public static void Main(string[]args){
        Console.WriteLine("Welcome to DBS");
        Console.WriteLine("\n\t This is M.Sc Cybersecurity Class");
        Console.WriteLine("\n\t Module code: BYCY100");
        Console.WriteLine("\n\t Module Name: Advance Programming Techniques");
        Console.WriteLine("Enter username:");
        Console.WriteLine("Hello, World!");
        string userName = Console.ReadLine();
        Console.WriteLine("Username is: " + userName);


    }
}
*/

//write a code to accept username and email*/
/*
using System;
using System.Data;
class ExampleClass2{
    public static void Main(string[] args)
    {
     string username, email;
     Console.WriteLine("Please enter your name:");
     username = Console.ReadLine();
     Console.WriteLine("Please enter email address:");
     email = Console.ReadLine();
     Console.WriteLine("**********************");
     Console.WriteLine("USER NAME:"+username);
     Console.WriteLine("EMAIL:"+email);
     Console.WriteLine("****************");
    }
}*/

//Accept integer from user show it positive or negative
/*using System;
class ExampleClass3
{
    public static void Main(string[]args)
    {
        int num;
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        num = Convert.ToInt16(input);
        if(num>0)
        Console.WriteLine("It is a positive number");
        else
        Console.WriteLine("It is a negative number");       
    }
}*/

//Odd or Even
/*
using System;
class ExampleClass3
{
    public static void Main(string[]args)
    {
        int num;
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        num = Convert.ToInt16(input);
        if(num % 2 == 0)
        Console.WriteLine("It is a Even");
        else
        Console.WriteLine("It is a Odd");       
    }
}
*/

//Try catch
/*class Error
{
    public static void Main(string[] args)
    {
        int a;
        bool started = true;
        Console.WriteLine("enter the number");
        while (started)
        {
            try
            {
                a = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("");
                if (a % 2 == 0)
                    Console.WriteLine("number is even");
                else
                    Console.WriteLine("number is odd");
                System.Console.WriteLine("");
                started = false;
            }
            catch
            {
                Console.WriteLine("invalid input ");

            }
        }
    }

}*/

//Object Oriented concept

/*using System;
class Student                                                     //Definition of class
{
    public string studName,courseName,module,moduleCode;
    public double studId;                                           //Abstraction
    public void writeExam()
    {
        Console.WriteLine("Student Writes Exams");
    }
        public void writeAssignemnts()
        {
            Console.WriteLine("Student write assignments");
        }
    public void attendClass()
    {
        Console.WriteLine("Student attends classes");
    }
    public void readStudentData()
    {

    }
    public void showStudentData()
    {
        Console.WriteLine("Student Name:"+studName);
        Console.WriteLine("Student Id:"+studId);
        Console.WriteLine("Course Name:"+courseName);
        Console.WriteLine("Module Name:"+module);
        Console.WriteLine("ModuleId:"+moduleCode); 

    }
}
class DriverClass
{
    public static void Main(string[]args)
    {
        Student obj1=new Student();
        obj1.studId=20016516;
        obj1.studName="Mohamed Fahad";
        obj1.courseName="MSc Cyber Security";
        obj1.moduleCode="B9CY100";
        obj1.module="Advance Programming Techniques";
        Console.WriteLine("----------Student Information--------------");
        obj1.showStudentData();
    }
}
*/

//Constuctor
/*using System;
public class Taxi{
    public string brandName;
    public Taxi()
    {
        brandName="BMW";
    }
}
class TextTaxi{
    static void Main()
    {
        Taxi t=new Taxi();
        Console.WriteLine(t.brandName);
    }
}
*/

//Constructor
/*using System;
class Student                                                     //Definition of class student
{
    public string studName,courseName,module,moduleCode;
    public double studId;                                           //Abstraction
    public Student()                                                //Parameter less constructor
    {
        Console.WriteLine("Object is created");
        studName="Mohamed Fahad";
        studId= 20016516;
        courseName="MSc Cybersecurity";
        module="Advance Programming Techniques";
        moduleCode="B9CY100";
    }
    public void writeExam()
    {
        Console.WriteLine("Student Writes Exams");
    }
        public void writeAssignemnts()
        {
            Console.WriteLine("Student write assignments");
        }
    public void attendClass()
    {
        Console.WriteLine("Student attends classes");
    }
    public void readStudentData()
    {

    }
    public void showStudentData()
    {
        Console.WriteLine("Student Name:"+studName);
        Console.WriteLine("Student Id:"+studId);
        Console.WriteLine("Course Name:"+courseName);
        Console.WriteLine("Module Name:"+module);
        Console.WriteLine("ModuleId:"+moduleCode); 

    }
}
class DriverClass
{
    public static void Main(string[]args)
    {
        Student obj1=new Student();                    //class is instantiated, constructor is called
      
        Console.WriteLine("----------Student Information--------------");
        obj1.showStudentData();
    }
}*/

//Practice set 1

//1.Odd or Even
/*using System;
class ExampleClass3
{
    public static void Main(string[]args)
    {
        int num;
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        num = Convert.ToInt16(input);
        if(num % 2 == 0)
        Console.WriteLine("It is a Even");
        else
        Console.WriteLine("It is a Odd");       
    }
}*/

//2.C# code read input from user and check if it’s odd or even
/*using System;  

public class Exercise2  
{  
    public static void Main()  
    {
        int num1, rem1;  
        Console.Write("\n\n");  
        Console.Write("Check whether a number is even or odd :\n");  
        Console.Write("\n\n");  
        Console.Write("Input an number : ");  
        num1 = Convert.ToInt32(Console.ReadLine());  

        rem1 = num1 % 2;  

        if (rem1 == 0)  
            Console.WriteLine("{0} is an even number.\n", num1);  
        else
            Console.WriteLine("{0} is an odd number.\n", num1);  
    }
}*/

//3.C# code to read student id (integer), student name, program name, module code and module name. Show the informa2on entered by user.
/*using System;
class Student                                                     //Definition of class
{
    public string studName,courseName,module,moduleCode;
    public double studId;                                           //Abstraction
    public void writeExam()
    {
        Console.WriteLine("Student Writes Exams");
    }
        public void writeAssignemnts()
        {
            Console.WriteLine("Student write assignments");
        }
    public void attendClass()
    {
        Console.WriteLine("Student attends classes");
    }
    public void readStudentData()
    {

    }
    public void showStudentData()
    {
        Console.WriteLine("Student Name:"+studName);
        Console.WriteLine("Student Id:"+studId);
        Console.WriteLine("Course Name:"+courseName);
        Console.WriteLine("Module Name:"+module);
        Console.WriteLine("ModuleId:"+moduleCode); 

    }
}
class DriverClass
{
    public static void Main(string[]args)
    {
        Student obj1=new Student();
        obj1.studId=20016516;
        obj1.studName="Mohamed Fahad";
        obj1.courseName="MSc Cyber Security";
        obj1.moduleCode="B9CY100";
        obj1.module="Advance Programming Techniques";
        Console.WriteLine("----------Student Information--------------");
        obj1.showStudentData();
    }
}
*/

//4.C# code to accept principle amount(double) and interest rate(float) as inputs. Calculate the final amount and show all the details.
/*using System;
class Pi
{
    static void Main()
    {
        Console.Write("Enter the principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the interest rate (in %): ");
        float interestRate = float.Parse(Console.ReadLine());

        double interest = principal * (interestRate / 100);

        double finalAmount = principal + interest;

        Console.WriteLine("\n--- Loan Details ---");
        Console.WriteLine($"Principal Amount: {principal:C}"); 
        Console.WriteLine($"Interest Rate: {interestRate}%");
        Console.WriteLine($"Interest Amount: {interest:C}");
        Console.WriteLine($"Final Amount (Principal + Interest): {finalAmount:C}");
    }
}*/


//5.C# code to accept student id, student name and marks as inputs. Show the student’s details with the respective grade. You can refer the following table of grade-bands. [Make use of else-if ladder] Marks Grade 0-39 Fail 40-49 C 50-59 C+ 60-69 B 70-79 B+ 80-89 A 90-99 A+
/*using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 

class Grade{ 
	
static void Main(string[] args) 
{ 
	int r, marks1, marks2, marks3, total; 
	float percentage; 
	string n; 

	Console.WriteLine("Enter Student Id:"); 
	r = Convert.ToInt32(Console.ReadLine()); 
	
	Console.WriteLine("Enter Student Name:"); 
	n = Console.ReadLine(); 
	 
	Console.WriteLine("Enter Subject-1 Marks: "); 
	marks1 = Convert.ToInt32(Console.ReadLine()); 
	
	Console.WriteLine("Enter Subject-2 Marks : "); 
	marks2 = Convert.ToInt32(Console.ReadLine()); 
	
	Console.WriteLine("Enter Subject-3 Marks :"); 
	marks3 = Convert.ToInt32(Console.ReadLine()); 
	
	total = marks1 + marks2 + marks3; 
	
	percentage = total / 3.0f; 
	
	Console.WriteLine("Final result of {0} is:", n); 
	Console.WriteLine("Total Marks : " + total); 
	Console.WriteLine("Percentage : " + percentage); 
	
	if (percentage <= 39) 
	{ 
		Console.WriteLine("Sorry You have failed"); 
	} 
	else if (percentage >= 40 && percentage <= 49) 
	{ 
		Console.WriteLine("Your Grade is C"); 
	} 
	else if (percentage >= 50 && percentage <= 59) 
	{ 
		Console.WriteLine("Your Grade is C+"); 
	} 
	else if (percentage >= 60 && percentage <= 69) 
	{ 
		Console.WriteLine("Grade is B"); 
	} 
	else if (percentage >= 70 && percentage <= 79) 
	{ 
		Console.WriteLine("Grade is B+"); 
	} 
	else if (percentage >= 80 && percentage <= 89) 
	{ 
		Console.WriteLine("Grade is A"); 
	} 
	else if (percentage >= 90) 
	{ 
		Console.WriteLine("Grade is A+"); 
	} 
} 
}*/

//6.C# code to accept student id, student name and marks as inputs. Show the student’s details with the respec2ve grade. You can refer the following table of grade-bands. [Make use of else-if ladder] Marks Grade 0-39 Fail 40-49 C 50-59 C+ 60-69 B 70-79 B+ 80-89 A 90-99 A+.to accept data for 5 students.
/*using System;

class Fivestudent
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"\n--- Enter details for Student {i} ---");

            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();
           
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            string grade;
            if (marks >= 90 && marks <= 99)
            {
                grade = "A+";
            }
            else if (marks >= 80 && marks <= 89)
            {
                grade = "A";
            }
            else if (marks >= 70 && marks <= 79)
            {
                grade = "B+";
            }
            else if (marks >= 60 && marks <= 69)
            {
                grade = "B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                grade = "C+";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade = "C";
            }
            else if (marks >= 0 && marks <= 39)
            {
                grade = "Fail";
            }
            else
            {
                grade = "Invalid Marks"; 
            }
            Console.WriteLine("\nStudent Details");
            Console.WriteLine($"Student ID: {studentId}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Marks: {marks}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
*/

//7.C# code to accept student id, student name and marks as inputs. Show the student’s details with the respec2ve grade. You can refer the following table of grade-bands. [Make use of else-if ladder] Marks Grade 0-39 Fail 40-49 C 50-59 C+ 60-69 B 70-79 B+ 80-89 A 90-99 A+.accept student data un2l user enters “NO DATA. PLS QUIT.”
/*using System;
class Nodata
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nEnter 'NO DATA. PLS QUIT' to stop or press Enter to continue: ");
            string quitInput = Console.ReadLine();

            if (quitInput.Equals("NO DATA. PLS QUIT", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Data entry stopped.");
                break;
            }

            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            string grade;
            if (marks >= 90 && marks <= 99)
            {
                grade = "A+";
            }
            else if (marks >= 80 && marks <= 89)
            {
                grade = "A";
            }
            else if (marks >= 70 && marks <= 79)
            {
                grade = "B+";
            }
            else if (marks >= 60 && marks <= 69)
            {
                grade = "B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                grade = "C+";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade = "C";
            }
            else if (marks >= 0 && marks <= 39)
            {
                grade = "Fail";
            }
            else
            {
                grade = "Invalid Marks"; 
            }

            Console.WriteLine("\nStudent Details");
            Console.WriteLine($"Student ID: {studentId}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Marks: {marks}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}*/

//8.C# code to accept student id, student name and marks as inputs. Show the student’s details with the respec2ve grade. You can refer the following table of grade-bands. [Make use of else-if ladder] Marks Grade 0-39 Fail 40-49 C 50-59 C+ 60-69 B 70-79 B+ 80-89 A 90-99 A+.Accept grade of a student and show respec2ve results. You may refer to the grade-bands[use: switch statement]
/*using System;

class Gradewithswitch
{
    static void Main()
    {
        Console.Write("Enter Student ID: ");
        string studentId = Console.ReadLine();

        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();

        int marks;
        while (true)
        {
            Console.Write("Enter Marks: ");
            string marksInput = Console.ReadLine();

            if (int.TryParse(marksInput, out marks) && marks >= 0 && marks <= 100)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer between 0 and 100 for marks.");
            }
        }

        string grade;
        if (marks >= 90)
        {
            grade = "A+";
        }
        else if (marks >= 80)
        {
            grade = "A";
        }
        else if (marks >= 70)
        {
            grade = "B+";
        }
        else if (marks >= 60)
        {
            grade = "B";
        }
        else if (marks >= 50)
        {
            grade = "C+";
        }
        else if (marks >= 40)
        {
            grade = "C";
        }
        else
        {
            grade = "Fail";
        }

        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine($"Student ID: {studentId}");
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Marks: {marks}");
        Console.WriteLine($"Grade: {grade}");

        Console.Write("\nEnter the student's grade to see the respective result: ");
        string resultGrade = Console.ReadLine();

        string resultMessage;
        switch (resultGrade.ToUpper()) 
        {
            case "A+":
                resultMessage = "your grade is (A+) - First class with distinction ";
                break;
            case "A":
                resultMessage = "your grade is (A) - First class";
                break;
            case "B+":
                resultMessage = "your grade is (B+) - Second class";
                break;
            case "B":
                resultMessage = "your grade is (B) - Second class";
                break;
            case "C+":
                resultMessage = "your grade is (C+) - Third class";
                break;
            case "C":
                resultMessage = "your grade is (C) - Third class";
                break;
            case "FAIL":
                resultMessage = "you have failed.";
                break;
            default:
                resultMessage = "Invalid grade entered. Please enter a valid grade.";
                break;
        }
        Console.WriteLine("\nResult");
        Console.WriteLine(resultMessage);
    }
}*/


//9.C# code to generate following series:3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57 Use while loop
/*using System;
class While
{
    static void Main()
    {
        int number = 3; 
        while (number <= 57) 
        {
            Console.Write($"{number} "); 
            number += 3; 
        }
    }
}*/

//10.C# code to generate following series:3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57 using for loop.
/*using System;
class For
{
    static void Main()
    {
        for (int i = 3; i <= 57; i += 3) 
        {
            for (int j = 0; j < 1; j++) 
            {
                Console.Write($"{i} "); 
            }
        }
    }
}*/


//11.Matrix
/*using System;
class Matrix
{
    static void Main()
    {
        for (int i = 0; i < 2; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write($"\t{i},{j} ");  
            }
            Console.WriteLine("");                          
        }
    }
}*/

//12.C# code to accept messages from user. Stop the program execu2on as user types ‘quit’ [use break statement in the loop]
/*using System;
class Quit
{
    static void Main()
    {
        while (true) 
        {
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            if (message.ToLower() == "quit") 
            {
                break; 
            }

            Console.WriteLine($"You entered: {message}");
        }

        Console.WriteLine("Program has ended.");
    }
}*/


//Class Employee
/*using System;
class Employee
{
    public string? empName,deptName,deptNo;
    private double _ppsn,_empId,_salary;
    public void showEmpData()
    {
        Console.WriteLine("Emp Name:"+empName);
        Console.WriteLine("Emp Id:"+_empId);
        Console.WriteLine("Department:"+deptName);
        Console.WriteLine("Dept No:"+deptNo);
    }
    public Employee()
    {
        Console.WriteLine("This is parameterless constructor");
        _salary=10000;
    }
    public Employee(string name,string deptname,string deptno,double empid,double ppsn)
    {
        _empId=empid;
        empName=name;
        deptName=deptname;
        deptNo=deptno;
        _ppsn=ppsn;
    }
}
class RunEmployeeClass
{
    public static void Main(string[]args)      //Entry point of the program
    {
        Employee e1=new Employee();             //parameterless and  parameterised constructor
        Employee e2=new Employee("Mohamed Fahad","Admin","A001",20016516,1234567890);
        Console.WriteLine("Object e1:");
        e1.showEmpData();

        Console.WriteLine("\neObject e2:");
        e2.showEmpData();
    }
}*/

//Create a class Book ||Data:bookname,author,media,price||Method:showbookl(),book(bookname,author 1,media1,price1)
/*using System;
class Book
{
    public string? bookname,author,media,price;
    public void showbook1()
    {
        Console.WriteLine("Book Name:"+bookname);
        Console.WriteLine("author:"+author);
        Console.WriteLine("media:"+media);
        Console.WriteLine("Price:"+price);
    }
    public Book()
    {
        Console.WriteLine("This is parameterless constructor");
    }
    public Book1(string Bookname,string Author,string Media,double Price)
    {
        bookname=Bookname;
        author=Author;
        media=Media;
        price=Price;
       
    }
}
class RunBookclass
{
    public static void Main(string[]args)      //Entry point of the program
    {
        Book e1=new Book();             //parameterless and  parameterised constructor
        Book e2=new Book("Mohamed Fahad","Admin","A001",20016516,1234567890);
        Console.WriteLine("Object e1:");
        e1.showbook1();

        Console.WriteLine("\nObject e2:");
        e2.bookname();
    }
}*/

//Use of properties
using System;
class Employee
{
    private double _salary;
    public double salary{
        get{return _salary;}            //getter method returns value of private variable
        set{_salary=value;}             //setter method assign new value to _salary
    }
}
public class RunEmployeeClass
{
    public static void Main(string[]args)
    {
        Employee obj=new Employee();            //default constructor
        obj.salary=7000;
        Console.WriteLine("Salary="+obj.salary);

    }
}

//