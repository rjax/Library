using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        public int Id { get; set; }
        public string? Bio { get; set; }
        public string Name { get; set; } = default!;
        public DateTime BirthDate { get; set; }

        public List<Book> Books([Parent] Author author)
        {
            return BookList.Books.Where(b => b.AuthorId == author.Id).ToList();
        }
    }
}
