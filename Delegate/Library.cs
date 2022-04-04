using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
     class Library
    {
        public List<Book> bookList=new List<Book>();

        public  List<Book> FilterByPrice(double minPrice ,double maxPrice)
        {

            return bookList.FindAll(books => books.BookPrice >minPrice && books.BookPrice < maxPrice);
            
        }

        //Ikicur yazmaq olar FilterByGenre -ni
        public List<Book> FilterByGenre(Genre genre)
        {

            return bookList.FindAll(books => books.Genre == genre);
        }
        public List<Book> FilterByGenre(string genre)
        {
            
            return bookList.FindAll(books => books.Genre.ToString() == genre);
        }


        // Bunu Program hissesinde cagira bilmedim hec cur 
        public Book FindBookByNo(int? no)
        {
            return bookList.Find(books => books.No == no);
        }


        //       --------   Ama bu duz iwledi -------------       //

        //public List<Book> FindBookByNo(int? no)
        //{
        //    return bookList.FindAll(books => books.No == no);
        //}
    }
}
