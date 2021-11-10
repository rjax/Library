

using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id { get; init; }
        public string Title { get; set; } = default!;
        public int AuthorId { get; set; } = default!;
        public Author Author([Parent] Book book)
        {
            return AuthorList.Authors.FirstOrDefault(a => a.Id == book.AuthorId) ?? new Author();
        }
        public string? Summary { get; set; }
    }
}
