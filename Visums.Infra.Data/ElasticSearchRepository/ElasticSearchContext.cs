using Elasticsearch.Net;
using System;
using Visums.Domain.Interface;

namespace Visums.Infra.Data.ElasticSearchRepository
{
    public class ElasticSearchContext : IElasticSearchContext
    {
    
        public ElasticLowLevelClient RetornaClient()
        {
            try
            {
                //LOCAL HOST PORT 9200
                return new ElasticLowLevelClient();
            }
            catch (Exception ex)
            { 
                throw ex;
            }
          
        }
   
    }
}
