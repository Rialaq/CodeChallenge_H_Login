using ApiLogin.Api.Data;
using ApiLogin.Api.Repositories.UserRespository;

namespace ApiLogin.Api.Factories
{
    public class UserRespositoryFactories
    {
        private readonly UserDBContext _dbContext;

        public UserRespositoryFactories(UserDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUserRepository Create()
        {
            return new UserRespository(_dbContext);
        }
    }
}