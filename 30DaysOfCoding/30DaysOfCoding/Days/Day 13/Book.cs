﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_13
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

}
