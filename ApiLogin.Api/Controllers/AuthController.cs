using System.Threading.Tasks;
using ApiLogin.Api.Models;
using ApiLogin.Api.Repositories;
using ApiLogin.Api.Repositories.UserRespository;
using Microsoft.AspNetCore.Mvc;
using ApiLogin.Api.Data;

namespace ApiLogin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Metodo para el inicio de sesion del usuario valida si el usuario existe y cumple con las credenciales.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Retorna el usuario si el mismo es correcto.</returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            var getUser = await _userRepository.GetByUsernameAndPassword(user.Username, user.Password);
            if (getUser == null)
            {
                return Unauthorized("La cuenta no existe");
            }

            if (getUser.Password != user.Password)
            {
                return Unauthorized("Contraseña Incorrecta");
            }

            return Ok(getUser);
        }

        [HttpPost("signin")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            var existingUser = _userRepository.GetByUsername(user?.Username);

            if(existingUser.Result != null)
            {
                return Conflict("Ya existe un usuario con el nombre de usuario");
            }
            
            await _userRepository.CreateUser(user);
            return Ok();
        }
    }
}