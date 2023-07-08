using ApiLogin.Api.Data;
using ApiLogin.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLogin.Api.Repositories.UserRespository
{
    public class UserRespository : IUserRepository
    {
        private readonly List<User> _users;
        private readonly UserDBContext _context;

        public UserRespository(UserDBContext context)
        {
            _users = new List<User>();
            _context = context;
        }

        public Task<User?> GetByUsername(string? username)
        {
            return Task.FromResult(_users.FirstOrDefault(x => x.Username == username));
        }

        public Task<User?> GetByMail(string? Mail)
        {
            return Task.FromResult(_users.FirstOrDefault(x => x.Mail == Mail));
        }

        public Task<User?> GetByUsernameAndPassword(string? username, string? password)
        {
            return Task.FromResult(_users.FirstOrDefault(x => x.Username == username && x.Password == password));
        }

        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}