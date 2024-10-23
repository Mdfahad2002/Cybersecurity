//Practice set 1

//1.Even or not
/*using System;
class Evennumber
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
        Console.WriteLine("It is not a Even number");       
    }
}*/

//2.C# code read input from user and check if it’s odd or even
/*using System;

class OddEven
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("It is Even.");
        }
        else
        {
            Console.WriteLine("It is Odd.");
        }
    }
}*/


//3.C# code to read student id (integer), student name, program name, module code and module name. Show the informa2on entered by user.
/*using System;
class Student                                                     
{
    public string? studName,courseName,module,moduleCode;
    public double studId;                                          
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
class StudentClass
{
    public static void Main(string[]args)
    {
        Student obj1=new Student();
        obj1.studId=20016516;
        obj1.studName="Mohamed Fahad";
        obj1.courseName="MSc Cyber Security";
        obj1.moduleCode="B9CY100";
        obj1.module="Advance Programming Techniques";
        Console.WriteLine("Student Information");
        obj1.showStudentData();
    }
}*/


//4.C# code to accept principle amount(double) and interest rate(float) as inputs. Calculate the final amount and show all the details.
/*using System;
class Emi
{
    public static void Main()
    {
        Console.Write("Enter the principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the interest rate in Percentage: ");
        float interestRate = float.Parse(Console.ReadLine());

        double interest = principal * (interestRate / 100);

        double finalAmount = principal + interest;

        Console.WriteLine("\nLoan Details");
        Console.WriteLine($"Principal Amount: {principal:C}"); //:C is a format specifier for currency
        Console.WriteLine($"Interest Rate: {interestRate}%");
        Console.WriteLine($"Interest Amount: {interest:C}");
        Console.WriteLine($"Final Amount: {finalAmount:C}");
    }
}*/


//5.C# code to accept student id, student name and marks as inputs. Show the student’s details with the respective grade. You can refer the following table of grade-bands. [Make use of else-if ladder] Marks Grade 0-39 Fail 40-49 C 50-59 C+ 60-69 B 70-79 B+ 80-89 A 90-99 A+
/*using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 

class Grade{ 
	
public static void Main(string[] args) 
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
	
	total = marks1 + marks2 + marks3; //mark formula
	
	percentage = total / 3.0f; //Forumula
	
	Console.WriteLine("Final result of {0} is:", n); //name show here
	Console.WriteLine("Total Marks : " + total); //total show here
	Console.WriteLine("Percentage : " + percentage); //percentage show here
	
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
    public static void Main()
    {
        for (int i = 1; i <= 5; i++) //loop until i=5
        {
            Console.WriteLine($"\nEnter details for Student {i}");

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


//7.C# code to accept student id, student name and marks as inputs. Show the student’s details with the respec2ve grade. You can refer the following table of grade-bands. [Make use of else-if ladder] Marks Grade 0-39 Fail 40-49 C 50-59 C+ 60-69 B 70-79 B+ 80-89 A 90-99 A+.accept student data un2l user enters “NO DATA. PLS QUIT.”
/*using System;
class Nodata
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("\nEnter 'NO DATA. PLS QUIT' to stop or press Enter to continue: ");
            string quitInput = Console.ReadLine();

            if (quitInput.Equals("NO DATA PLS QUIT", StringComparison.OrdinalIgnoreCase)) // quit function by stringcomparison
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
    public static void Main()
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

            if (int.TryParse(marksInput, out marks) && marks >= 0 && marks <= 100) //validate the marks
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a your mark.");
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

        Console.Write("\nEnter the student's grade: ");
        string resultGrade = Console.ReadLine();

        string resultMessage;
        switch (resultGrade.ToUpper()) 
        {
            case "A+":
                resultMessage = "your grade is A+ - First class with distinction ";
                break;
            case "A":
                resultMessage = "your grade is A - First class";
                break;
            case "B+":
                resultMessage = "your grade is B+ - Second class";
                break;
            case "B":
                resultMessage = "your grade is B - Second class";
                break;
            case "C+":
                resultMessage = "your grade is C+ - Third class";
                break;
            case "C":
                resultMessage = "your grade is C - Third class";
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
    public static void Main()
    {
        int n = 3; //intial value
        while (n <= 57) //final value
        {
            Console.Write($"{n} "); 
            n += 3; 
        }
    }
}*/

//10.C# code to generate following series:3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57 using for loop.
/*using System;
class SeriesFor
{
    public static void Main()
    {
        for (int i = 3; i <= 57; i += 3)// instance for loop with intial and final value.
        {
            Console.Write($"{i} ");
        }
    }
}*/

//11.Matrix
/*using System;
class Matrix
{
   public static void Main()
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

//12.C# code to accept messages from user. Stop the program execution as user types ‘quit’ [use break statement in the loop]
/*using System;
class Quit
{
    public static void Main()
    {
        while (true) 
        {
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            if (message.ToLower() == "quit") //Terminate program comparision
            {
                break; 
            }

            Console.WriteLine($"You entered: {message}");
        }

        Console.WriteLine("Program was Terminated.");
    }
}*/