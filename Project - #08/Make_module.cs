using System; 

namespace ConsoleApplication1
{
    interface ITest
    {
        string str
        {             
            get;            
            set;
        }
    }
    class MyClass : ITest
    {
        string myStr;         
        public string str
        {             
            set             
            {
                myStr = value;
            }             
            get             
            {
                return myStr;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass obj1 = new MyClass();             
            user1.str = "Hello";             
            Console.ReadLine();
        }
    }
}