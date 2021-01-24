using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace _2001_Web_Api.Models
{
    public class DataAccess : DbContext
    {
        private string Connection;
        private COMP2001_DAndrewsContext context;

        public DataAccess(COMP2001_DAndrewsContext _context)
        {
            context = _context;
        }

        public bool Validate(User user)
        {
            if (context.Database.ExecuteSqlRaw("EXEC ValidateUser @email, @password",
                new SqlParameter("@email", user.Email.ToString()),
                new SqlParameter("@password", user.Password.ToString())) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Register(User user, string outstring)
        {
            context.Database.ExecuteSqlRaw("EXEC ValidateUser @firstName, @surname, @email, @password",
                new SqlParameter("@firstname", user.Firstname.ToString()),
                new SqlParameter("@surname", user.Surname.ToString()),
                new SqlParameter("@email", user.Password.ToString()),
                new SqlParameter("@password", user.Password.ToString()));
        }

        public void Update(User user, int id)
        {
            context.Database.ExecuteSqlRaw("EXEC UpdateUser @id, @firstName, @surname, @email, @password",
                new SqlParameter("@id", Convert.ToInt64(user.UserId)),
                new SqlParameter("@firstname", user.Firstname.ToString()),
                new SqlParameter("@surname", user.Surname.ToString()),
                new SqlParameter("@email", user.Password.ToString()),
                new SqlParameter("@password", user.Password.ToString()));
        }

        public void Delete(int id)
        {
            context.Database.ExecuteSqlRaw("EXEC DeleteUser @id", new SqlParameter("@id", id));
        }
    }
}
