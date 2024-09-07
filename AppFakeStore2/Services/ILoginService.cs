using AppFakeStore2.Models;

namespace AppFakeStore2.Services
{
    public interface ILoginService
    {
        Task<string> AuthenticateAsync(Login login);
    }
}