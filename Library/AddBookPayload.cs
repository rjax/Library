using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class AddBookPayload
    {
        public Book Book { get; set; } = default!;
    }
}
