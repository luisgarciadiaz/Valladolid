namespace BasicApi
{
    public interface IAuthService
    {
        string? Authenticate(string username, string password);
    }
}