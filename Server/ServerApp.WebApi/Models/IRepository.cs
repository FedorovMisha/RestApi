using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerApp.WebApi.Models
{
    public interface IRepository<T>
    {
        public Task Add(T entity);

        public Task<T> Get(int id);

        public Task<List<LoginFormModel>> GetAll();
    }
}