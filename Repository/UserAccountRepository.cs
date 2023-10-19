using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andon.Backend.Data;
using Andon.Backend.Interfaces;
using Andon.Backend.Models;
using Dapper;

namespace Andon.Backend.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly AndonDBContext _context;

        public UserAccountRepository(AndonDBContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<UserAccount>> GetUserAccounts()
        {
            var query =
@"SELECT
user_id AS Id,
user_username AS Username,
user_email AS Email,
user_firstname AS FirstName,
user_lastname AS LastName,
user_password AS Password,
user_pwchangetoken AS PwChangeToken,
user_tokenexpiration AS TokenExpires,
user_lastpwchange AS LastPwChange,
user_active AS Active,
user_orgid AS OrgId,
user_poolid AS PoolId,
user_shiftid AS ShiftId

FROM user_account
";

            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<UserAccount>(query);
                return companies.ToList();
            }
        }

    }
}
