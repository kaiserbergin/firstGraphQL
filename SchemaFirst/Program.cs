using System;
using GraphQL;
using GraphQL.Types;

namespace SchemaFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.For(@"
                type Droid {
                    id: String!
                    name: String!
                }

                type Query {
                    hero: Droid
                }
            ", _ =>
            {
                _.Types.Include<Query>();
            });

            var json = schema.Execute(_ =>
            {
                _.Query = "{ hero { id name } }";
            });

            Console.WriteLine(json);
        }
    }
}
