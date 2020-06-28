
using Visums.Domain.Interface;

namespace Visums.Infra.Data.ElasticSearchRepository
{
    public class ElasticSearchBaseRepository<T> :  IElasticSearchBaseRepository<T>  
    {
        private readonly IElasticSearchContext _elasticSearchContext;

        public ElasticSearchBaseRepository(IElasticSearchContext elasticSearchContext)
        {
            _elasticSearchContext = elasticSearchContext;
        }     
        
   
           


        
    
   
    }
}
