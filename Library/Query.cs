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

        public Book GetBookById(int id)
        {
            return BookList.Books.FirstOrDefault(b => b.Id == id) ?? new Book();
        }
        public Book GetBookByTitle(string title)
        {
            return BookList.Books.FirstOrDefault(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)) ?? new Book();
        }

        public List<Author> Authors()
        {
            return AuthorList.Authors;
        }
        public Author GetAuthorById(int id)
        {
            return AuthorList.Authors.FirstOrDefault(a => a.Id == id) ?? new Author();
        }
        public Author GetAuthorByName(string name)
        {
            return AuthorList.Authors.FirstOrDefault(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) ?? new Author();
        }
    }
}
