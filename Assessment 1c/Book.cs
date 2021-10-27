//****************************************************************************
// Programmer: Ye Liu
// Date: 27 October 2021
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64­bit
// Purpose: Develop a Windows forms app using a nested class.	Implement a comparator.
//***************************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1c
{
    public class Book : IComparable 
    {

        // Nested class to do Descending sort on price property.
        private class SortPriceDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Book c1 = (Book)a;
                Book c2 = (Book)b;

                if (c1.price > c2.price)
                    return -1;

                if (c1.price < c2.price)
                    return 1;

                else
                    return 0;
            }
        }

        public string title;
        public string author;
        public double price;
        public int year;

        public Book(string title, string author, double price, int year)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.year = year;
        }


        int IComparable.CompareTo(object obj)
        {
            Book that = (Book)obj;

            if (this.price < that.price) return -1;
            if (this.price == that.price) return 0;
            return 1;
         
        }

        public static IComparer SortPriceDescending()
        {
            return (IComparer)new SortPriceDescendingHelper();
        }



    }
}

