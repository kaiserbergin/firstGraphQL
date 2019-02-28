using System;
using GraphQL;
using GraphQL.Types;

namespace GraphTypeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = new Schema { Query = new StarWarsQuery() };

            var json = schema.Execute(_ =>
            {
                _.Query = "{ hero { id name } }";
            });

            Console.WriteLine(json);
        }
    }
}
