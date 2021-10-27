//****************************************************************************
// Programmer: Ye Liu
// Date: 30 September 2021
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64­bit
// Purpose: Design, define, and use data structures; Code using array of user-defined data types;Use facilities in language to create and manipulate 
//***************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Assessment_1c
{
    public struct Books
    {
        public string title;
        public string author;
        public double price;
        public int year;

        
        //test the structure
        //public void display()
        //{
          //  Console.WriteLine("Title : {0}", title);
          //  Console.WriteLine("Author : {0}", author);
            //Console.WriteLine("Price : {0}", price);
            //Console.WriteLine("Year :{0}", year);
       // }


    }


    public partial class frmMain : Form
    {

        Books[] myBooks;//atrbute

        Book[] myBooks_cls;

        // System.Collections.ArrayList myBooks_cls = new System.Collections.ArrayList();

        public frmMain()
        {
            InitializeComponent();

            // assessment 1c code. replaced by a new comparable class 
            /* 
            myBooks = new Books[4];
            myBooks[0].title = "Ocean";
            myBooks[1].title = "Jane Eyer";
            myBooks[2].title = "The Great Gatsby";
            myBooks[3].title = "Oliver Twist";

            myBooks[0].author = "Y.Jin";
            myBooks[1].author = "C Bronte";
            myBooks[2].author = "F.Scott Fitzgerald";
            myBooks[3].author = "Charles Dickens";


            myBooks[0].price = 16.89;
            myBooks[1].price = 29.99;
            myBooks[2].price = 24.00;
            myBooks[3].price = 45.80;

            myBooks[0].year = 2015;
            myBooks[1].year = 2011;
            myBooks[2].year = 2000;
            myBooks[3].year = 1838;
             */

             myBooks_cls = new Book[4] {

                new Book("Ocean", "Y.Jin", 36.89, 2015),
                new Book("Jane Eyer", "C Bronte", 29.99, 2011),

                new Book("The Great Gatsby", "F.Scott Fitzgerald", 24.00, 200),
                new Book("Oliver Twist", "Charles Dickens", 45.80, 1838)
        };
  
       


            /*
            myBooks_cls.Add(new Book("Ocean", "Y.Jin", 36.89, 2015));
            myBooks_cls.Add(new Book("Jane Eyer", "C Bronte", 29.99, 2011));
            myBooks_cls.Add(new Book("The Great Gatsby", "F.Scott Fitzgerald", 24.00, 200));
            myBooks_cls.Add(new Book("Oliver Twist", "Charles Dickens", 45.80, 1838));
            */
        }





        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            /* 
           foreach(Books element in myBooks)
           lstDisplay.Items.Add("<"+element.title + ">  "+ element.author+ "  "+ "$"+element.price +"  Year published: "+ element.year);
            */
            lstDisplay.Items.Clear();
            foreach (Book element in myBooks_cls)
               lstDisplay.Items.Add("<" + element.title + ">  " + element.author + "  " + "$" + element.price + "  Year published: " + element.year);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // btn click to trigger the nested class 
            // Console.WriteLine("button 2 clicked");
            string msg = nestedcl.Inner_class.method1();
            // Console.WriteLine(msg);
            System.Windows.Forms.MessageBox.Show("Popup message: " + msg);

        }

        private void btn_sort_books_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button sort book clicked ");
            Array.Sort(myBooks_cls);
            //Array.Sort(myBooks_cls, Book.SortPriceDescending());
            lstDisplay.Items.Clear();
            foreach (Book element in myBooks_cls)
                lstDisplay.Items.Add("<" + element.title + ">  " + element.author + "  " + "$" + element.price + "  Year published: " + element.year);
        }

        private void btn_sort_books_des_Click(object sender, EventArgs e)
        {
            //Array.Sort(myBooks_cls);
            Array.Sort(myBooks_cls, Book.SortPriceDescending());
            lstDisplay.Items.Clear();
            foreach (Book element in myBooks_cls)
                lstDisplay.Items.Add("<" + element.title + ">  " + element.author + "  " + "$" + element.price + "  Year published: " + element.year);
        }
    }
}
