using System;
using SolrNet.Commands.Parameters;

namespace SolrNet
{
    public interface ISolrQueryBuilderOperation
    {
        Uri GetQuery(ISolrConnection connection, ISolrQuery query, QueryOptions options);
    }
}
