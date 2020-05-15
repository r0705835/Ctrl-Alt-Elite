using System;

namespace Model
{
    class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
    }

    [Serializable]
    class InvalidUserNameException : Exception
    {
        public InvalidUserNameException()
        {

        }

        public InvalidUserNameException(string name)
            : base(String.Format("Invalid User Name: {0}", name))
        {

        }

    }

    class Products
    {
        public int ProduceID { get; set; }
        public string ProductName { get; set; }
    }

    [Serializable]
    class InvalidProductNameException : Exception
    {
        public InvalidProductNameException()
        {

        }

        public InvalidProductNameException(string name)
            : base(String.Format("Invalid Product Name: {0}", name))
        {

        }

    }

    public delegate void MyDelegate(string msg);

   
    MyDelegate del = new MyDelegate(MethodA);
    MyDelegate del = MethodA;
    MyDelegate del = (string msg) => Console.WriteLine(msg);

    // target
    static void MethodA(string message)
    {
        Console.WriteLine(message);
    }

    public delegate void MyDelegate(string msg); //declaring a delegate

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("User Final Calculations: " + msg);
            del("Hello World");
        }
    }

    class ClassA
    {
        static void MethodA(string message)
        {
            Console.WriteLine("UserName and Identification: " + message);
        }
    }

    class ClassB
    {
        static void MethodB(string message)
        {
            Console.WriteLine("Amount of Eco-Coin accumilated: " + message);
        }
    }

}
