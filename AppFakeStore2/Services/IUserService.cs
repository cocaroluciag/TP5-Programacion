using AppFakeStore2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore2.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserByIdAsync(int id);
    }
}