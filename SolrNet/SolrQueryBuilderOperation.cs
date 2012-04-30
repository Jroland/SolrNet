using System;
using SolrNet.Impl;

namespace SolrNet
{
    public class SolrQueryBuilderOperation : ISolrQueryBuilderOperation
    {
        private readonly ISolrQuerySerializer querySerializer;
        private readonly ISolrFacetQuerySerializer facetQuerySerializer;

        public SolrQueryBuilderOperation(ISolrQuerySerializer querySerializer, ISolrFacetQuerySerializer facetQuerySerializer)
        {
            this.querySerializer = querySerializer;
            this.facetQuerySerializer = facetQuerySerializer;
        }

        public Uri GetQuery(ISolrConnection connection, ISolrQuery query, Commands.Parameters.QueryOptions options)
        {
            var executor = new SolrQueryExecuter<object>(null, connection, querySerializer, facetQuerySerializer, null);
            var param = executor.GetAllParameters(query, options);
            return connection.GetQuery(SolrQueryExecuter<object>.DefaultHandler, param);
        }
    }
}
