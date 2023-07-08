using System.Threading.Tasks;
using ApiLogin.Api.Models;

namespace ApiLogin.Api.Repositories.UserRespository
{
    public interface IUserRepository
    {
        /// <summary>
        /// Obtiene desde la base de datos un unico usuario por el username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns> Datos completos del usuario (Models.User) o nulo en caso de no encontrarlo. </returns>
        Task<User?> GetByUsername(string? username);

        /// <summary>
        /// Obtiene desde la base de datos un unico usuario por el mail.
        /// </summary>
        /// <param name="Mail"></param>
        /// <returns> Datos completos del usuario (Models.User) o nulo en caso de no encontrarlo. </returns>
        Task<User?> GetByMail(string? Mail);

        /// <summary>
        /// Obtiene desde la base de datos un unico usuario por el username y la contraseña y muestra si tiene acceso.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns> Datos completos del usuario (Models.User) o nulo en caso de no encontralo. </returns>
        Task<User?> GetByUsernameAndPassword(string? username, string? password);

        /// <summary>
        /// Crea un unico usuario en la base de datos en base a Models.User.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Retorna tarea completa y un throw en caso de error.</returns>
        Task CreateUser(User user);
    }
}