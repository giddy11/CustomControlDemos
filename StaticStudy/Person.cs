using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStudy
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

            Person.personCount += 0;
        }


        public static void GetName()
        {
            Console.WriteLine("Gideon");
        }

        static double CalculateCirclePerimeter(double r)
        {
            // Accessing the static variable PI from static method
            return 0;
        }



        public static int personCount;
        private string name;
        private int age;
    }
}
