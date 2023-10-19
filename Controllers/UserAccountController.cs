using System;
using System.Threading.Tasks;
using Andon.Backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Andon.Backend.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserAccountController : ControllerBase
    {
        private readonly IUserAccountRepository _userAccountRepository;

        public UserAccountController(IUserAccountRepository userAccountRepository)
        {
            _userAccountRepository = userAccountRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserAccounts()
        {
            try
            {
                var useraccounts = await _userAccountRepository.GetUserAccounts();
                return Ok(useraccounts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
