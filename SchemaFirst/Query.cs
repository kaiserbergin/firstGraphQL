using System;
using System.Collections.Generic;
using System.Text;
using GraphQL;

namespace SchemaFirst
{
    class Query
    {
        [GraphQLMetadata("hero")]
        public Droid GetHero()
        {
            return new Droid { Id = "1", Name = "R2-D2" };
        }
    }
}
