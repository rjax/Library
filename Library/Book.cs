

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
        public string Author { get; set; } = default!;
        public string? Summary { get; set; } 
    }
}
