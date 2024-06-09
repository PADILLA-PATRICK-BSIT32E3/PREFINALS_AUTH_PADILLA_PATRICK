using AuthServer.Core;

public interface IUserService
{
    Task RegisterAsync(User user);
    Task<User> GetUserByUsernameAsync(string username);
}