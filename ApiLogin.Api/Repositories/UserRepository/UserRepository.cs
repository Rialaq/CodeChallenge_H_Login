using ApiLogin.Api.Data;
using ApiLogin.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLogin.Api.Repositories.UserRespository
{
    public class UserRespository : IUserRepository
    {
        private readonly UserDBContext _context;

        public UserRespository(UserDBContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByUsername(string? username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username);
            return user;
        }

        public async Task<User?> GetByMail(string? Mail)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Mail == Mail);
            return user;
        }

        public async Task<User?> GetByUsernameAndPassword(string? username, string? password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
            return user;
        }

        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}