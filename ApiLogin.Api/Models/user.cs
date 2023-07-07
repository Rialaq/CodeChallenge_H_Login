namespace ApiLogin.Api.Models
{
    public record User(
        int Id,
        string Name,
        string Lastname,
        string Mail,
        string Username,
        string Password,
        bool IsAuthorize
    );
}