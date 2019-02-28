using System;
using GraphQL;
using GraphQL.Types;

namespace GraphTypeFirst
{
    class DroidType : ObjectGraphType<Droid>
    {
        public DroidType()
        {
            Field(x => x.Id).Description("Duh, an id fool!");
            Field(x => x.Name).Description("Duhscription");
        }
    }
}
