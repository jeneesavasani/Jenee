using Jenee.API.Authentication;
using Jenee.Model.Auth;
using Jenee.Model.Data;
using Jenee.Repository.Account;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Jenee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository accountRepository;
        public AccountController(IAccountRepository user)
        {
            accountRepository = user;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/UserDetail/Get")]
        public IEnumerable<UserDetails> Get()
        {
            return accountRepository.Get();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/UserDetail/Add")]
        public UserDetails Add(UserDetails user)
        {
            return accountRepository.Add(user);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/UserDetail/Update")]
        public UserDetails Update(UserDetails user)
        {
            return accountRepository.Update(user);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/UserDetail/Delete")]
        public UserDetails Delete(int id)
        {
            return accountRepository.Delete(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/UserDetail/GetById")]
        public UserDetails GetById(int id)
        {  
            return accountRepository.GetById(id);
        }


    }
}
