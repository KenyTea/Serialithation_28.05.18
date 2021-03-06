﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary; // !!!!!!!!!!!!!!!!!!!!!!! 1
using System.Runtime.Serialization.Formatters.Soap;   // !!!!!!!!!!!!!!!!!!!!!!! 2
using System.Xml.Serialization;                       // !!!!!!!!!!!!!!!!!!!!!!! 3

using System.IO;
using System.Reflection;

namespace Serialithation_28._05._18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reflections
            Assembly a = Assembly.LoadFrom(@"\\dc\Студенты\ПКО\SEB-171.2\C#\Exception\GeneratorName.dll");

            Type t = a.GetType();

            return;
            MyTestClass mtc = new MyTestClass(12.4, 4.2);
            Reflection.MetjodReflection(mtc);

            return;
            #region Reflections
            Person person = new Person("Kim", 30);

            Type type = typeof(Person);
            Console.WriteLine(type.ToString());
            Console.WriteLine("------------------");
            Console.WriteLine(person.GetType());
            Console.WriteLine("------------------");
            Console.WriteLine();
            Type type2 = Type.GetType("Serialithation_28._05._18.Person", false, true) ;

            foreach (MemberInfo item in type.GetMembers())
            {
                Console.WriteLine(item.DeclaringType + " " + item.MemberType + " " + item.Name);
            }
            #endregion


















            //    Console.WriteLine("Object create!");
            //    //===================================== 
            //    Person[] persons = new Person[3];
            //    persons[0] = new Person("Pak", 22);
            //    persons[1] = new Person("Cho", 33);
            //    persons[2] = new Person("Kha", 44);
            //    //=====================================
            //    Serialize(person);

            //    SoapSerialize(person);
            //    person =  SoapDeserialize() as Person; // из-за  object
            //    //=====================================
            //    SoapSerialize(persons);


            //    Console.WriteLine("-----------------------------");
            //    foreach (var item in SoapDeserialize(""))
            //    {
            //        Console.Write(item.Name + " ");
            //        Console.WriteLine(item.Age);
            //    }
            //    //=====================================

            //    XmlSerialize(person);
            //    XmlDeserialize(person);
            //    //=====================================
            //    XmlSerialize(persons.ToList());
            //    Console.WriteLine("--------------------------");
            //    foreach (var item in XmlDeserialize2())
            //    {
            //        Console.Write(item.Name + " ");
            //        Console.WriteLine(item.Age);
            //    }


            //}

            //static void Serialize(Person person)
            //{
            //    // Сщздаём объект BinaryFormatter
            //    BinaryFormatter format = new BinaryFormatter();                              // 1
            //    using (FileStream fs = new FileStream("person.dat", FileMode.OpenOrCreate))
            //    {
            //        format.Serialize(fs, person);
            //        Console.WriteLine("Object serialzed!");
            //    }

            //    // Десиривлизуем
            //    using (FileStream fs = new FileStream("person.dat", FileMode.OpenOrCreate))
            //    {
            //        var newPerson = (Person)format.Deserialize(fs);
            //        Console.WriteLine("----------------------------");
            //        Console.WriteLine(newPerson.Name);
            //        Console.WriteLine(newPerson.Age);
            //    }
            //}

            //static void SoapSerialize(Person person)
            //{
            //    SoapFormatter formater = new SoapFormatter();

            //        using (FileStream fs = new FileStream("person.soap", FileMode.OpenOrCreate))
            //    {
            //        formater.Serialize(fs, person);
            //    }
            //}

            //static void SoapSerialize(Person[] person)
            //{
            //    SoapFormatter formater = new SoapFormatter();

            //    using (FileStream fs = new FileStream("person.soap", FileMode.OpenOrCreate))
            //    {
            //        formater.Serialize(fs, person);
            //    }
            //}


            //static object SoapDeserialize() // object = Person
            //{
            //    object person = null;
            //    SoapFormatter formater = new SoapFormatter();                                  // 2

            //    using (FileStream fs = new FileStream("person.soap", FileMode.OpenOrCreate))
            //    {
            //       person = formater.Deserialize(fs);

            //    }
            //    return person;
            //}

            //static Person[] SoapDeserialize(string t) // object = Person
            //{
            //    Person[] persone = null;
            //    SoapFormatter formater = new SoapFormatter();

            //    using (FileStream fs = new FileStream("person.soap", FileMode.OpenOrCreate))
            //    {
            //        persone = (Person[])formater.Deserialize(fs);

            //    }
            //    return persone;
            //}

            //public static void XmlSerialize(Person person)
            //{
            //    XmlSerializer formatter = new XmlSerializer(typeof(Person));                      // 3
            //    using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //    {
            //        formatter.Serialize(fs, person);
            //    }


            //}

            //public static void XmlDeserialize(Person person)
            //{
            //    Person personss = null;
            //    XmlSerializer formatter = new XmlSerializer(typeof(Person));                      // 3
            //    using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //    {
            //       personss = (Person)formatter.Deserialize(fs);
            //    }


            //}

            //public static void XmlSerialize(List<Person> person)
            //{
            //    XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));                      // 3
            //    using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //    {
            //        formatter.Serialize(fs, person);
            //    }


            //}

            //public static List<Person> XmlDeserialize2()
            //{
            //    List<Person> pp = new List<Person>();
            //    XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));                      // 3
            //    using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //    {
            //        pp =  (List<Person>)formatter.Deserialize(fs);
            //    }

            //    return pp;
            //}
        }
    }
}
