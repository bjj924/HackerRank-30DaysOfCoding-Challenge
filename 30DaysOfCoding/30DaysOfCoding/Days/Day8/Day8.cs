using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day8
{
    public class Day8
    {
        public static void PhoneDirectory()
        {
            Dictionary<String, String> PhoneBook = new Dictionary<String, String>();
            Console.WriteLine("Ingrese la cantidad de registros que tendra el directorio");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el nombre seguido por un espacio y luego el telefono(8 digitos): ");
                Console.WriteLine("(Ejemplo: Prueba 44448888");
                var s = Console.ReadLine().Split(' ');
                PhoneBook.Add(s[0], s[1]);
            }

            String name;
            Console.WriteLine("Ingrese el nombre a buscar: ");
            while (!string.IsNullOrEmpty(name = Console.ReadLine()))
            {
                try
                {
                    Console.WriteLine($"{name}={PhoneBook[name]}");
                }
                catch
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
