using System.Threading.Tasks;
using ApiLogin.Api.Models;
using ApiLogin.Api.Repositories;
using ApiLogin.Api.Repositories.UserRespository;
using Microsoft.AspNetCore.Mvc;

namespace ApiLogin.Api.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public AuthController (IUserRepository userRepository){
            _userRepository = userRepository;
        }

    }

}