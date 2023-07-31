using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._2_P2
{
    internal class Book
    {
        private string author;
        private int pages;
        private string isbn;
        private string titel;
        private int currentPage;

        public Book()
        {
            author = "Tố Hữu";
            pages = 1;
            isbn = "ABCD";
            titel = "ABCD";
            currentPage = 1;
        }

        public Book(string author, int pages, string isbn, string titel, int currentPage)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.titel = titel;
            this.currentPage = currentPage;
        }

        public string Author { get => author; set => author = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Titel { get => titel; set => titel = value; }
        public int CurrentPage { get => currentPage; set => currentPage = value; }
    
    
        public void Display()
        {
            Console.WriteLine("author:{0}, pages:{1}, isbn:{2}, titel:{3}, currentPage:{4}", Author, Pages, Isbn, Titel, CurrentPage);
        }
        public void flipPageForward()
        {
            CurrentPage++;
            Console.WriteLine("Trang hien tai: " + CurrentPage);
        }
        public void flipPageBackward()
        {
            CurrentPage--;
            Console.WriteLine("Trang hien tai: " + CurrentPage);
        }



    }
}
