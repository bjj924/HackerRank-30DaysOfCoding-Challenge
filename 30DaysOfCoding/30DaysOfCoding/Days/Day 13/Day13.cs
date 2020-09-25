using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_13
{
    public class Day13
    {
        public static void AbstractClassExercise()
        {
            Console.WriteLine("Ingrese el titulo del libro: ");
            String title = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro: ");
            String author = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del libro: ");
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
