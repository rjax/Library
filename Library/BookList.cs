using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class BookList
    {
        public static List<Book> Books => new List<Book>
        {
            new Book
            {
                Id = 1,
                AuthorId = 1,
                //Author = "Ernest Hemingway",
                Title = "For Whom The Bell Tolls"
            },
            new Book
            {
                Id = 2,
                AuthorId = 2,
                //Author = "F. Scot Fitzgerald",
                Title = "The Great Gatsby"
            },
            new Book
            {
                Id = 3,
                AuthorId = 3,
                //Author = "William Faulkner",
                Title = "The Sound and the Fury"
            },
            new Book
            {
                Id = 4,
                AuthorId = 4,
                //Author = "Tom Clancy",
                Title = "Red Storm Rising"
            },
     };
    }
}
