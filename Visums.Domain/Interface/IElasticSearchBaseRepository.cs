
using System.Threading.Tasks;
using Visums.Domain.Models;

namespace Visums.Domain.Interface
{
    public  interface IElasticSearchBaseRepository <T> where T: class
    {

        Task Adicionar(T entity);
       

    }
}
