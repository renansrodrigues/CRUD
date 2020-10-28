
using System.Threading.Tasks;
using Visums.Domain.Interface;
using Visums.Domain.Models;

namespace Visums.Infra.Data.ElasticSearchRepository
{
    public class ElasticSearchBaseRepository<T> :  IElasticSearchBaseRepository<T> where T : Entity
    {
        private readonly IElasticSearchContext _elasticSearchContext;

        public ElasticSearchBaseRepository(IElasticSearchContext elasticSearchContext)
        {
            _elasticSearchContext = elasticSearchContext;
        }

      
        public async  Task Adicionar(T entity)
        {
           
        }
    }
}
