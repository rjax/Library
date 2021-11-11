using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Mutation
    {
        public async Task<AddBookPayload> AddBook(AddBookInput input)
        {
            int id = BookList.Books.Max(b => b.Id) + 1;
            Book book = new Book
            {
                Id = id,
                Title = input.title,
                AuthorId = input.authorId,
                Summary = input.summary
            };

            await Task.Run(() => BookList.Books.Add(book));
            return new AddBookPayload { Book = BookList.Books.FirstOrDefault(b => b.Id == book.Id) ?? new Book() };
        }

        public async Task<AddAuthorPayload> AddAuthor(AddAuthorInput input)
        {
            int id = AuthorList.Authors.Max(a => a.Id) + 1;
            Author author = new Author { Id = id, Name = input.name, Bio = input.bio };

            await Task.Run(() => AuthorList.Authors.Add(author));
            return new AddAuthorPayload { Author = AuthorList.Authors.FirstOrDefault(b => b.Id == author.Id) ?? new Author() };
        }
    }
}
