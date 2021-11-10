using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Query
    {
        public List<Book> Books()
        {
            return BookList.Books;
        }

        public Book GetBook()
        {
            return BookList.Books[0];
        }
    }
}
