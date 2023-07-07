using System.Threading.Tasks;
using ApiLogin.Api.Models;

namespace ApiLogin.Api.Services.UserRespository
{
    public interface IUserService
    {
        /// <summary>
        /// Obtiene desde la base de datos un unico usuario por el email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns> Datos completos del usuario (Models.User). </returns>
        Task<User> GetByEmail(string email);

        /// <summary>
        /// Obtiene desde la base de datos un unico usuario por el username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns> Datos completos del usuario (Models.User). </returns>
        Task<User> GetByUsername(string username);

        /// <summary>
        /// Obtiene desde la base de datos un unico usuario por el username y la contraseña.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns> Datos completos del usuario (Models.User). </returns>
        Task<User> GetByUsernameAndPassword(string username, string password);

        /// <summary>
        /// Crea un unico usuario en la base de datos en base a Models.User.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Retorna tarea completa y un throw en caso de error.</returns>
        Task CreateUser(User user);

        /// <summary>
        /// Actualiza un unico usuario de la base de datos.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Retorna tarea completa y un throw en caso de error.</returns>
        Task UpdateUserById(User user);

        /// <summary>
        /// Borra un unico usuario de la base de datos.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Retorna tarea completa y un throw en caso de error.</returns>
        Task DeleteUserById(User user);
    }
}