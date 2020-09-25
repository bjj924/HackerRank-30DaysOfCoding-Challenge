using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_13
{
    class MyBook: Book
    {
        private int price = 0;

        public MyBook(string title, string author, int price): base(title, author)
        {
            this.price = price;
        }

        public override void  display()
        {
            Console.WriteLine("Title: {0} \nAuthor: {1} \nPrice: {2}", title, author, price);
        }

    }
}
