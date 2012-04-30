using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolrNet;
using SolrNet.Commands.Parameters;
using SolrNet.Impl;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = Startup.GetQueryBuilder();
            var conn = new SolrConnection("http://localhost:9090/solr");
            var query = builder.GetQuery(conn, new SolrQuery("*:*"), new QueryOptions {Rows = 99});
            Console.WriteLine(query);
            Console.ReadLine();
        }
    }
}
