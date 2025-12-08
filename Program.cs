using System;
using System.Collections.Generic;



namespace MyApp
{
    public class Program
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();

            Console.WriteLine("chand nafar ro mikhay ezafe koni?");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("etelaat ro vard konid 1.name 2.age 3.gender");

            for (int i = 0; i < x; i++)

            {
                Console.WriteLine("name?");
                string name = Console.ReadLine();
                Console.WriteLine("age?");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("male or female?");
                bool gender = Convert.ToBoolean(Console.ReadLine());
                persons.Add(new Person { name = name, age = age, gender = gender });


            }
            foreach (var p in persons)
            {
                string genderino = p.gender ? "Male" : "Female";
                Console.WriteLine($"{p.name} , {p.age} , {genderino}");
            }



        }

    }



    public class Person
    {
        public string name;
        public int age;
        public bool gender;
    }


}

