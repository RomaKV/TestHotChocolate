using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestHotChocolate.GraphQL
{
    public class Mutation
    {
        public async Task<Book> AddBook(int id, string title)
        {
            return new Book(id, title);
        }
    }
}
