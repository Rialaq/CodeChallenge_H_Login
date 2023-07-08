using System.Threading.Tasks;
using ApiLogin.Api.Models;

namespace ApiLogin.Api.Repositories.UserRespository
{
    public interface IUserRepository
    {
        /// <summary>
        /// Obtiene desde la base de datos un unico usuario por el id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns> Datos completos del usuario (Models.User) o nulo en caso de no encontrarlo. </returns>
        Task<User?> GetById(int Id);

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