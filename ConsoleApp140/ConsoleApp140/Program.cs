using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp140
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception exceptionParameter)
            {
                Console.WriteLine("exceptionParameter.Tostring:\n" + exceptionParameter);
                Console.WriteLine("\nexceptionParameter.Message:\n" + exceptionParameter.Message);
                Console.WriteLine("\nexceptionParameter.StackTrace:\n" + exceptionParameter.StackTrace);
                Console.WriteLine("\nexcecptionParameter.InnerException:\n" + exceptionParameter.InnerException);
                Console.ReadLine();
            }

        }

        static void Method1()
        {
            Method2();
        }
        static void Method2()
        {
            Method3();
        }

        static void Method3()
        {
            try
            {
                int.Parse("Not an integer");
            }
            catch (FormatException formatExceptionParameter)
            {
                throw new Exception("Exception occurred in Method3", formatExceptionParameter);
            }
        }
     
                
    }
}
