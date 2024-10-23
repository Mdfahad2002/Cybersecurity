// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*using System;
namespace Project_NS
{
    public class Fruit                 //Base class Fruit
    {
        protected string def, benefits;         //protected data members
        public Fruit()      //Constructor
        {
            def ="A fruit is a part of tree/plant that bears seed";
            benefits = "minereal,vitamins,fibre,natural sugar,other nutrients";
        }
        public class Apple:Fruit        //single inheritance
        {
            public string color,taste,shape;
            public Apple(string Color, string Taste,string Shape)
            {
                this.color=color;
                taste= Taste;
                shape=Shape;
            }
            public void showApple()
            {
                Console.WriteLine("\n------------------------------------------------");
                Console.WriteLine("Def:"+def);      //protected data of the base class is available in the derived class.
                Console.WriteLine("Benefits:"+benefits);
                Console.WriteLine("Color:"+color+"\t Taste:"+taste+"\tShape:"+shape);
            }
            public class testInheritance
            {
                public static void Main(string[]args)
                {
                    Apple a1 = new Apple("Red","Sweet","Oval");         //Instantiated class Apple
                    Apple a2= new Apple("Pink","Sour-Sweet","Round");   
                    a1.showApple();
                    a2.showApple();
                }
            }
        }
    }
}*/


/*using System;
//multi-level inheritance
namespace Shape_NS
{
    public abstract class Shape         //Abstract class- fir inheritance, class is not instantiated
    {
        public abstract void draw();
    }
    public class Circle:Shape
    {
        public override void draw()     //Keyword - override
        {
            Console.WriteLine("Drawing a Circle......");
        }
    }
    public class Ellipse:Circle
    {
        private double _xLenght,_yLength,_area;
        private const float pi=3.14f;
        public Ellipse(double x,double y)
        {
            _xLenght=x;
            _yLength=y;
            _area=pi*_xLenght*_yLength;
        }
        public void showEllipse()
        {
            Console.WriteLine("The ellipse x-length="+_xLenght);
            Console.WriteLine("Y- length="+_yLength);
            Console.WriteLine("Area="+_area);
        }
    }
    class testMultilevelInheritance
    {
        public static void Main()
        {
            Ellipse obj1=new Ellipse(10,6);
            obj1.showEllipse();
          //  Shape s1=new Shape();   Error - can not instantiate abstract class
        }
    }
}*/

/*using System;
//multi-level inheritance
namespace Shape_NS
{
    public abstract class Shape         //Abstract class- fir inheritance, class is not instantiated
    {
        public abstract void draw();
    }
    public class Circle:Shape
    {
        public override void draw()     //Keyword - override
        {
            Console.WriteLine("Drawing a Circle......");
        }
    }
    public class Ellipse:Circle
    {
        private double _xLenght,_yLength,_area;
        private const float pi=3.14f;
        public Ellipse(double x,double y)
        {
            _xLenght=x;
            _yLength=y;
            _area=pi*_xLenght*_yLength;
        }
        public void showEllipse()
        {
            Console.WriteLine("The ellipse x-length="+_xLenght);
            Console.WriteLine("Y- length="+_yLength);
            Console.WriteLine("Area="+_area);
        }
        public void CalArea()           //Method Overloading
        {
            _area=pi*_xLenght*_yLength;
            Console.WriteLine("Area="+_area);
        }
        public void CalArea(int x,int y)
        {
            _area=pi*x*y;
        }
        public void CalArea(int x, double y)        //signatures of different
        {
            _area=pi*x*y;
            Console.WriteLine("Area="+_area);
        }
    }
    class testMultilevelInheritance
    {
        public static void Main()
        {
            Ellipse obj1=new Ellipse(10,6);
            obj1.showEllipse();
          //  Shape s1=new Shape();   Error - can not instantiate abstract class
          obj1.CalArea();
          obj1.CalArea(10,6);
          obj1.CalArea(12,3.4);
        }
    }
}*/

//write program using triangle, right-angled triangle, isosceles triangle. 

//Using interface
/*using System;
namespace interfaceClasses
{
    public interface IDrawable
    {
        public void draw();
    }
    public interface IClickable
    {
        public void click();
    }
    public  interface IFillColor
    {
        public void fillColor(string color);
    }
    public class Rectangle:IDrawable, IClickable
    {
         public void draw()
        {
            Console.WriteLine("You have clicked on the Rectangle");
        }
        public void click()
        {
            Console.WriteLine("You have clicked on the Rectangle");
        }
    }
    public class Circle: IDrawable,IFillColor
    {
        public void draw()
        {
            Console.WriteLine("You can draw a circle.....");
        }
        public void fillColor(string color)
        {
            Console.WriteLine("Circle is filled with "+color);
        }
 }
public class MainClass
{
    public static void Main()            //main method
    {
        Rectangle r1=new Rectangle();       //Instantiating class Rectangle
        r1.draw();                          //Calling methods of class Rectangle
        r1.click();
        Circle c1=new Circle();             //instantiating class circle
        c1.draw();                          //Calling methods of Class Circle
        c1.fillColor("Red");
   
        }
    }
}*/

//Method overloading
/*public class MyCalculator
{
    public void addition(int num1, int num2)
    {
        int res=num1+num2;
        Console.WriteLine("\n\tAddition="+res);
    }
    public void addition(float num1,int num2)
    {
        double res=num1*num2;
        Console.WriteLine("\n\tAddition="+res);
    } 
    public void addition(int num1, int num2,int num3)
    {
        int res=num1+num2+num3;
        Console.WriteLine("\n\tAddition +"+res);
    }
    public class testMyCalculator
    {
        public static void Main()
        {
            MyCalculator obj=new MyCalculator();
            obj.addition(10,10);
            obj.addition(10.10f,20);
            obj.addition(12,23,34);
        }
    }
}*/

//Write a code to show odd and even using array
/*using System;
public class ArrayDemo
{
    public static void Main()
    {
        int[] arr_even = new int[50];
        int[] arr_odd = new int[50];

        int i, j=0;
        for(i=1, j=0; i<=50; i++)
        {
            if(i%2 == 0)
            {   
                //Console.WriteLine(i);
                arr_even[j]=i;
            }
            else
            {
               // Console.WriteLine(i);
                arr_odd[j]=i;
                j++;
            }
        }
        Console.WriteLine("Array containing even elements: ");
        foreach (int ele in arr_even)
            Console.WriteLine(ele);
        
        Console.WriteLine("Array containing odd elements: ");
        foreach (int ele in arr_odd)
            Console.WriteLine(ele);
        
    }
}*/

//List of EU Countries

/*using System;
using System.Runtime.InteropServices;

public class ListDemo
{
    public static void Main(string[] args)
    {
        List<string> EUcountries = new List<string>() {"Germany","Ireland","France","Spain","Switzerland"} ;
        Console.WriteLine("The list items are as follows: ");
        foreach(string country in EUcountries)
            Console.WriteLine(country);

        // add the following countries in the list: Austria, Belgium, Denmark, Finland
        EUcountries.Add("Austria");  
        EUcountries.Add("Belgium");
        EUcountries.Add("Denmark");
        EUcountries.Add("Finland");

        // Show the updated list
        Console.WriteLine("Updated list = ");
        foreach(string country in EUcountries)
            Console.Write("\t"+country);

        // Show the country at the 4th position (index=3)
            
        //Show the index of Denmark
        int index = EUcountries.IndexOf("Denmark");
        Console.WriteLine("\nDenmark at "+(index+1)+"position");

        // Reverse the list

        List<string> copy_EUcountries = new List<string>(EUcountries);      // Copy constructor

        EUcountries.Reverse();
        Console.WriteLine("The Reversed List is = ");
        foreach(string country in EUcountries)
            Console.WriteLine(country);
    }
}*/
/*
class Part
{
    part_id,
    part_name (Bus/ register/ RAM/ HD )
}
Create a list of objects for class Part, Perform List operations on the list
*/

/*w*/

// Implementation of hashset

/*using System;

public class HashSetDemo
{
    public static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>();
        set1.Add(2);
        set1.Add(4);
        set1.Add(6);
        set1.Add(8);
        set1.Add(12);

        Console.WriteLine("Set1 = ");
        foreach(int num in set1)
            Console.WriteLine(num);

        HashSet<int> set2 = new HashSet<int>() {3,6,9,12,15,18,21,24,27,30};
        Console.WriteLine("Set2 = ");
        foreach(int num in set2)
            Console.WriteLine(num);
        
        HashSet<int> copy_set1 = new HashSet<int>(set1);
        HashSet<int> copy_set2 = new HashSet<int>(set2);
        
        set1.IntersectWith(set2);
        Console.WriteLine("\n After intersection set1 is ");
        foreach(int num in set1)
            Console.WriteLine(num);
        
        // Union with
        set1.UnionWith(set2);
        Console.WriteLine("\n set1 union set2 is ");
        foreach(int num in set1)
            Console.WriteLine(num);
        
        //Except with
    }
}*/


//Create a sortedset to store numbers is two groups
//Group1=88,77,44,33,11 Group2=99,22,66,55

