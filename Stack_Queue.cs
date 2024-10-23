// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//10/10/24
//Stack
/*using System;
public class StackDemo
{
    public static void Main(string[]args)
    {
        Stack<int>myStack=new Stack<int>();     //Creating a stack of integer
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);
        myStack.Push(50);
        Console.WriteLine("The Stack Contains:");
        foreach(int num in myStack)
        Console.WriteLine(num);

        Console.WriteLine("-----------------Peek()--------------");
        Console.WriteLine("Number at the top of the stack is"+myStack.Peek());
        
        int num1=myStack.Pop();
        Console.WriteLine("Number"+num1+"is deleted from the stack");
        // Console.WriteLine("\n-----------Pop()----------")
       

        Console.WriteLine("\nAfter Removing 50, The Stack is:");
        foreach(int num in myStack)
        Console.WriteLine(num);

        //Use of tryPop()
        myStack.TryPop(out int num2);
        Console .WriteLine("---------TryPop()----------");
        Console.WriteLine("\nTryPop() number is"+num2);

        Console.WriteLine("After TryPop() the stack is - ");
        foreach(int num in myStack)
        Console.WriteLine(num);

        Console.WriteLine("No of elements in the stack - "+myStack.Count);

    }
}*/

//Create a class book create stack of object book

//Non-Generic Stack
/*using System;
using System.Collections;
public class NGstackDemo
{
    public static void Main()
    {
        Stack ngStack=new Stack();          //Creating non-generic stack
        ngStack.Push(1000);
        ngStack.Push(3.10);
        ngStack.Push("Robert Guy");
        ngStack.Push('#');

        Console.WriteLine("The non-generic stack");
        foreach(var item in ngStack)           //use of 'var'
        Console.WriteLine(item);
    }
}*/

//Linked List
/*using System;
using System.Collections;
public class LinkedListDemo
{
    public static void Main()
    {
        string[]words={"Do","Re","Me","Fa","So","Doe"};
        LinkedList<string>sentence=new LinkedList<string>(words);
        foreach(string str in sentence)
        Console.WriteLine(str);
        Console.WriteLine("After adding the first node - \n");
        sentence.AddFirst("\n\nThe linkedlist starts here.....");
        foreach(string str in sentence)
        Console.WriteLine(str);
        sentence.AddLast("Bye!");
        foreach(string str in sentence)
        Console.WriteLine(str);

        LinkedListNode<string> node=sentence.Find("So");
        sentence.AddAfter(node,"La");
        Console.WriteLine("The Updated linkedlist is");
        foreach(string str in sentence)
        Console.WriteLine(str);

        ///Add "Ti" using AddBefore before "Doe"()
        LinkedListNode<string> node1=sentence.Find("Doe");
        sentence.AddBefore(node,"Ti");
        Console.WriteLine("The Updated linkedlist is");
        foreach(string str in sentence)
        Console.WriteLine(str);

        //Remove "Fa"
        //Remove the last node
    }
}*/




