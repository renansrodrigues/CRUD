
using Elasticsearch.Net;

namespace Visums.Domain.Interface
{
    public  interface IElasticSearchContext
    {

        ElasticLowLevelClient RetornaClient();

    }
}
