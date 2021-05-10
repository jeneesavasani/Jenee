using Jenee.Model.Data;
using Jenee.Utility.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenee.Repository.Account
{
        public class AccountRepository : IAccountRepository
        {
            JeneeContext dbContext;

            public AccountRepository(JeneeContext _db)
            {
                dbContext = _db;
            }
            public IEnumerable<UserDetails> Get()
            {
                List<UserDetails> user = dbContext.UserDetails.ToList();
                return user;
            }
            public UserDetails Add(UserDetails user)
            {
                if (user != null)
                {
                    dbContext.UserDetails.Add(user);
                    dbContext.SaveChanges();
                    return user;
                }
                return null;
            }
            public UserDetails Update(UserDetails user)
            {
                dbContext.Entry(user).State = EntityState.Modified;
                dbContext.SaveChanges();
                return user;
            }
            public UserDetails Delete(int id)
            {
                var user = dbContext.UserDetails.FirstOrDefault(x => x.Id == id);
                dbContext.Entry(user).State = EntityState.Deleted;
                dbContext.SaveChanges();
                return user;
            }
            public UserDetails GetById(int id)
            {
                var user = dbContext.UserDetails.FirstOrDefault(x => x.Id == id);
                return user;
            }
        }

    }
