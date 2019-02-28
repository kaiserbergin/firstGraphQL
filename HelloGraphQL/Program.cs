using GraphQL.Types;
using System;
using GraphQL;

namespace HelloGraphQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.For(@"
                type Query {
                    hello: String
                }
            ");

            var json = schema.Execute(x =>
            {
                x.Query = " { hello }";
                x.Root = new { Hello = "Hello, GraphQL!" };
            });

            Console.WriteLine(json);
        }
    }
}
