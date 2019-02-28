using System;
using System.Collections.Generic;
using System.Text;
using GraphQL;
using GraphQL.Types;

namespace GraphTypeFirst
{
    class StarWarsQuery : ObjectGraphType
    {
        public StarWarsQuery()
        {
            Field<DroidType>(
                "hero",
                resolve: context => new Droid { Id = "1", Name = "R2-D2"}
            );
        }
    }
}
