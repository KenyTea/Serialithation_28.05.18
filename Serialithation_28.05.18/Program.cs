using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary; // !!!!!!!!!!!!!!!!!!!!!!!
using System.Runtime.Serialization.Formatters.Soap; // !!!!!!!!!!!!!!!!!!!!!!!

using System.IO;

namespace Serialithation_28._05._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kim", 30);
            Console.WriteLine("Object create!");

            Person[] persons = new Person[3];
            persons[0] = new Person("Пak", 22);
            persons[1] = new Person("Чо", 33);
            persons[2] = new Person("Ха", 44);

            Serialize(person);

            SoapSerialize(person);
            person =  SoapDeserialize() as Person; // из-за  object

            SoapSerialize(persons);


            Console.WriteLine("-----------------------------");
            foreach (var item in SoapDeserialize(""))
            {
                Console.Write(item.Name + " ");
                Console.WriteLine(item.Age);
            }

        }

        static void Serialize(Person person)
        {
            // Сщздаём объект BinaryFormatter
            BinaryFormatter format = new BinaryFormatter();
            using (FileStream fs = new FileStream("person.dat", FileMode.OpenOrCreate))
            {
                format.Serialize(fs, person);
                Console.WriteLine("Object serialzed!");
            }

            // Десиривлизуем
            using (FileStream fs = new FileStream("person.dat", FileMode.OpenOrCreate))
            {
                var newPerson = (Person)format.Deserialize(fs);
                Console.WriteLine("----------------------------");
                Console.WriteLine(newPerson.Name);
                Console.WriteLine(newPerson.Age);
            }
        }

        static void SoapSerialize(Person person)
        {
            SoapFormatter formater = new SoapFormatter();

                using (FileStream fs = new FileStream("person.soap", FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, person);
            }
        }

        static void SoapSerialize(Person[] person)
        {
            SoapFormatter formater = new SoapFormatter();

            using (FileStream fs = new FileStream("person.soap", FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, person);
            }
        }


        static object SoapDeserialize() // object = Person
        {
            object person = null;
            SoapFormatter formater = new SoapFormatter();

            using (FileStream fs = new FileStream("person.soap", FileMode.OpenOrCreate))
            {
               person = formater.Deserialize(fs);
            
            }
            return person;
        }

        static Person[] SoapDeserialize(string t) // object = Person
        {
            Person[] persone = null;
            SoapFormatter formater = new SoapFormatter();

            using (FileStream fs = new FileStream("person.soap", FileMode.OpenOrCreate))
            {
                persone = (Person[])formater.Deserialize(fs);

            }
            return persone;
        }
    }
}
