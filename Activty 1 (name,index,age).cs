using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1
{
    internal class Program
    {
        class student
        {
            private string name;
            private int index;
            private int age;
            
            public void setname()
            {
                Console.WriteLine("enter the name");
                name = Console.ReadLine();
            }

            public void setindex()
            {
                Console.WriteLine("input the index");
                index = Convert.ToInt32((Console.ReadLine()));
            }

            public void setage()
            {
                Console.WriteLine("enter age");
                age = Convert.ToInt32((Console.ReadLine()));
            }



            public void displayname()
            {
                Console.WriteLine("name " + name);
            }
            public void displayindex()
            {
                Console.WriteLine("index " + index);
            }

            public void displayage()
            {
                Console.WriteLine("age " + age);
            }

        }
        static void Main(string[] args)
        {

            student st1 = new student();
            st1.setname();
            st1.setindex();
            st1.setage();
            st1.displayname();
            st1.displayindex();
            st1.displayage();


            Console.ReadKey();
        }
    }
}
