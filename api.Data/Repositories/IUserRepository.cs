using api.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Data.Repositories
{
    public interface IUserRepository
    {
        Task<Users> getUserByEmail(string email);
    }
}
