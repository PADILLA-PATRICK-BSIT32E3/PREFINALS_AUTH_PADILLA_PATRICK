using AuthServer.Core;

public class UserService : IUserService
{
    private readonly List<User> _users = new List<User>();

    public Task RegisterAsync(User user)
    {
        _users.Add(user);
        return Task.CompletedTask;
    }

    public Task<User> GetUserByUsernameAsync(string username)
    {
        var user = _users.FirstOrDefault(u => u.Username == username);
        return Task.FromResult(user);
    }
}