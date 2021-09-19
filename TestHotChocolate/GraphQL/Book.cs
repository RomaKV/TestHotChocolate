using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace TestHotChocolate.GraphQL
{
    public class Book
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        private Book(){}

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }

}
