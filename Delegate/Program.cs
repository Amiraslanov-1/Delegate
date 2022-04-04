using System;
using System.Collections.Generic;
using System.Collections;
namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();

            book1.Name = "Don Quixote";
            book1.BookPrice = 150;
            book1.Genre = Genre.Classics;


            book2.Name = "The Lord of the Rings";
            book2.BookPrice = 100;
            book2.Genre = Genre.Action;



            book3.Name = "The Little Prince";
            book3.BookPrice = 50;
            book3.Genre = Genre.Fantasy;

            Library library = new Library();
            library.bookList.Add(book1);
            library.bookList.Add(book2);
            library.bookList.Add(book3);


            //foreach (Book books in library.FilterByPrice(0, 151))
            //{
            //    Console.WriteLine($"BookName   : {books.Name}\nBook Price : {books.BookPrice}\nBook Genre : {books.Genre} \n");
            //}


            //foreach (Book books in library.FilterByGenre(Genre.Fantasy))
            //{
            //    Console.WriteLine($"BookName   : {books.Name}\nBook Price : {books.BookPrice}\nBook Genre : {books.Genre} \n");
            //}
            //foreach (Book books in library.FilterByGenre("Classics"))
            //{
            //    Console.WriteLine($"BookName   : {books.Name}\nBook Price : {books.BookPrice}\nBook Genre : {books.Genre} \n");
            //}


            //Bu FindAll-nan yaratdigimin FindByNo-du, Find-nen yaratdigimi islede bilmedim :(

            //foreach (Book books in library.FindBookByNo(3))
            //{
            //    Console.WriteLine($"BookName   : {books.Name}\nBook Price : {books.BookPrice}\nBook Genre : {books.Genre} \n");
            //}



        }
    }
}
