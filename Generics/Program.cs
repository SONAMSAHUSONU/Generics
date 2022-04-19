/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Order<T>
    {
        public static bool VerifingGender(string msg)
        {
            Console.WriteLine(msg);
            if (msg == "M")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main()
        {
            // Order.GetValidate<string>("Hello");//this is a Genericsrdr
            Order<string>.GetValidate("Samosa");//Generic is the type safe
                                                // Order<int>.GetValidate("Samosa");
            Order<int>.Get(100, 200);
            Order<bool> order = new Order<bool>();
            List<string> str = new List<string>();
            Console.ReadLine();
        }
        
        public static string GetValidate(T Temp)//Generic Are Placeholder
        {
            return null;
        }
        public static void Get(T FirstValue, T SecondValue)
        {
        }
       
    }
   

}*/
/*using System;
class Myclass<T1, T2>
{
    public T1 MyProperty { get; set; }
    public void Method(T1 p1, T2 p2)
    {
    }
}
class Person
{
    static void Main()
    {
        Myclass<int, string> obj = new Myclass<int, string>();
        obj.MyProperty = 10;
        obj.Method(10, "Sonam");
        Console.ReadLine();
    }
}*/
