using System.Collections.Generic;
using System.Threading.Tasks;
using Andon.Backend.Models;

namespace Andon.Backend.Interfaces
{
    public interface IUserAccountRepository
    {
        public Task<IEnumerable<UserAccount>> GetUserAccounts();
    }
}
