using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace TestHotChocolate.GraphQL
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(
            IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(f => f.AddBook(default, default));
        }
    }
}
