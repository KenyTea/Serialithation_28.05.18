using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary; // !!!!!!!!!!!!!!!!!!!!!!!
using System.IO;

namespace Serialithation_28._05._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kim", 30);
            Console.WriteLine("Object create!");

            // Сщздаём объект BinaryFormatter
            BinaryFormatter format = new BinaryFormatter();
            using (FileStream fs = new FileStream("person.dat", FileMode.OpenOrCreate))
            {
                format.Serialize(fs, person);
                Console.WriteLine("Object serialzed!");

            }
        }
    }
}
