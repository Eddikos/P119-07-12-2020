using System;
using _07122020.Models;
using _07122020.Models.Education;

namespace _07122020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Elovset insan = new Elovset();


            Teacher teacher = new Teacher();



            Student student1 = new Student("Eldar", "asasd");
            Console.WriteLine(student1.Name);

            Student student2 = new Student("Gulbahar", "Mammadova");




            student1.FullName();
            student1.FullName();
            student1.FullName();
            student1.FullName();
            student1.FullName();
            student1.FullName();
            student1.FullName();
            student1.FullName();

            // CalculateSalary();



            Console.WriteLine(student1.Salary);

            Cat mesdan = new Cat();
            mesdan.Sleep();
            mesdan.Name = "Mesdan";
            // Console.WriteLine(mesdan.Attack());

            Animal heyvan = new Animal();
            //heyvan.Meow();

            Dog bobik = new Dog();

            iOS phone = new iOS();
            phone.Name = "iPhone 11S";
            phone.WriteSwiftCode();
        }


        public static int CalculateSalary(int s)
        {
            return 0;
        }
        public static int CalculateSalary(int s, int a)
        {
            return 0;
        }
    }
}

