using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialithation_28._05._18
{
    [Serializable]
    public class Person
    {

       
        public Person()
        {

        }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Displey()
        {
            Console.WriteLine(Name, Age);
        }

        public int GetAge(int currentYear)
        {
            return currentYear = this.Age;
        }
    }

    public class Human : Person
    {
        public Human(string name, int age) : base(name, age)
        {
        }




     
    }
}
