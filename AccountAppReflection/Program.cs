using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AccountAppReflection.Model;

namespace AccountAppReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finds Methods properties and attribute properties associated with class account using reflection property
            Type type = typeof(Account);
            MethodInfo[] methods = type.GetMethods();
            PropertyInfo[] properties = type.GetProperties();


            Console.WriteLine("\nMethods of Account Class: ");
            for(int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i]);
            }

            Console.WriteLine("\nProperties of Account Class: ");
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine(properties[i]);
            }

            Console.ReadLine();
        }
    }
}
