using ApiLogin.Api.Models;

namespace ApiLogin.Api.Repositories.UserRespository
{
    public class UserRespository : IUserRepository
    {
        private readonly List<User> _users;

        public UserRespository()
        {
            _users = new List<User>();
        }
        
        public Task<User?> GetById(int Id)
        {
            return Task.FromResult(_users.FirstOrDefault(x => x.Id == Id));
        }

        public Task<User?> GetByUsernameAndPassword(string username, string password)
        {
            return Task.FromResult(_users.FirstOrDefault(x => x.Username == username && x.Password == password));
        }

        public Task CreateUser(User user)
        {
            _users.Add(user);
            return Task.CompletedTask;
        }
    }
}