using Jenee.Model.Data;
using Jenee.Utility.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jenee.Repository.Account
{
    public interface IAccountRepository
    {

        IEnumerable<UserDetails> Get(); 
        UserDetails GetById(int id);
        UserDetails Add(UserDetails user);
        UserDetails Update(UserDetails user);
        UserDetails Delete(int id); 

    }
}
