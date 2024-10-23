// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Program.cs
//Main Program
using Namespace1;

namespace NameSpace1
{
    public class MainClass
    {
        public static void Main()
        {
            MyOrder item1=new MyOrder("Sandwich",8);
            item1.showDetails();
        }
    }
}

//Paste the code in Seperate file 
//Order.cs
//Order Class   
using System;
namespace Namespace1
{
    public class MyOrder
    {
        private string _item;
        public double price1,price2;
        private static float _tax=0.2f;
        public MyOrder(string name,double p1)
        {
            _item=name;
            price1=p1;
            price2=cal_price(price1);
        }
        public double cal_price(double amt)
        {
            price2=amt+(amt*_tax);
            return(price2);
        }
        public void showDetails()
        {
            Console.WriteLine("Item:"+_item);
            Console.WriteLine("Price1"+price1);
            Console.WriteLine("Tax"+_tax);
            Console.WriteLine("Amount to Pay:"+Math.Round(price2,2)+"$");
        }
        public bool isValid(double price)
        {
            bool flag;
            if(price<=0.0)
            flag=false;
            else
            flag=true;
            return flag;
        }
        
    }
}

//Paste the code in Seperate file 
// namespace TestProject1;

// [TestClass]
// public class UnitTest1
// {
//     [TestMethod]
//     public void TestMethod1()
//     {
//     }
// }
//Unit Test
using System.Reflection;
using NameSpace1;
//namespace TestProject2;
namespace NameSpace1
{
    [TestClass]
    public class testMyOrder()
{
    public MyOrder myOrder1=new MyOrder("Milkshare",5.3);
    public MyOrder myOrder2=new MyOrder("Smoothie",0.0);
    [TestMethod]
    public void test_cal_price()
    {
        //Price=5.3,  tax=0.2.Bill Amount=double price =myOrder.cal_price(5,3);
        Predicate=Math.Round(price2);
        Assert.AreEqual(6.36,price);
    }
    [TestMethod]
    public void testIsValid()
    {
        //price = 0.0
        bool flag=myOrder.isValid(myOrder2.price1);     //use object myOrder to see failed test
        Assert.IsFalse(flag);
    }
}
}