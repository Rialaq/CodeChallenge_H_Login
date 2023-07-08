using ApiLogin.Api.Repositories;
using ApiLogin.Api.Repositories.UserRespository;

namespace ApiLogin.Api.Factories
{
    public class UserRespositoryFactories
    {
        public static IUserRepository Create()
        {
            return new UserRespository();
        }
    }
}