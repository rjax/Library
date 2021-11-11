using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public record AddBookInput(string title, int authorId, string? summary);
}
