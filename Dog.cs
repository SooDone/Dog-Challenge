using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    public class Dog
    {
        public string Name;
        public string Owner;
        public int Age;
        public enum Gender
        {
            Female,
            Male
        }
        public Gender gender1;

        public Dog()
        {

        }

        public Dog(string name)
        {
            this.Name = name;
        }

        public Dog(string name, string owner)
        {
            this.Name = name;
            this.Owner = owner;
        }

        public Dog(string name, string owner, int age)
        {
            this.Name = name;
            this.Owner = owner;
            this.Age = age;
        }

        public Dog(string name, string owner, int age, Gender gender)
        {
            this.Name = name;
            this.Owner = owner;
            this.Age = age;
            this.gender1 = gender;
        }

        public void bark(int woof)
        { 
            for (int i = 0; i < woof; i++)
            {
                Console.WriteLine("Woof!");
            }
        }

        public void getTag()
        {
            string years;
            var dog = new Dog("Orion", "Shawn", 1, Gender.Male);


            int i = (int)Gender.Male;
            int a = (int)Gender.Female;
       
            if (dog.Age == 1)
            {
                years = "year";
            }
            else
            {
                years = "years";
            }

            if (gender1 == Gender.Male)
            {
                Console.WriteLine("If lost, call {0}. His name is {1} and he is {2} {3} old.", dog.Owner, dog.Name, dog.Age, years);
            }
            else if (gender1 == Gender.Female)
            {
                Console.WriteLine("If lost, call {0}. Her name is {1} and she is {2} {3} old.", dog.Owner, dog.Name, dog.Age, years);
            }

        }  
        
      
    }

     class Program
    { 
      static void Main(string[] args)
        {
            var dog = new Dog("Orion", "Shawn", 1, Dog.Gender.Female);
            dog.bark(3);
            dog.getTag();
            Console.ReadLine();
        }
    }
}
