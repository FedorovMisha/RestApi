using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.WebApi.Models
{
    public class LoginRepository : IRepository<LoginFormModel>
    {

        private List<LoginFormModel> _logins;


        public LoginRepository()
        {
            _logins = new List<LoginFormModel>();
        }
        
        public Task Add(LoginFormModel entity)
        {
            entity.Id = _logins.Count + 1;
            _logins.Add(entity);
            return Task.CompletedTask;
        }

        public Task<LoginFormModel> Get(int id)
        {
            return Task.FromResult(_logins.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<LoginFormModel>> GetAll()
        {
            return Task.FromResult(_logins);
        }
    }
}