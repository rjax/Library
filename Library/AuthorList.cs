using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class AuthorList
    {
        public static List<Author> Authors => authors;
        private static List<Author> authors = new List<Author>
        {
            new Author
            {
                Id = 1,
                Name = "Ernest Hemingway"
            },
            new Author
            {
                Id = 2,
                Name = "F. Scot Fitzgerald"
            },
            new Author
            {
                Id = 3,
                Name = "William Faulkner"
            },
            new Author
            {
                Id = 4,
                Name = "Tom Clancy"
            },
        };
    }
}
