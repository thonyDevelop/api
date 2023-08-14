using api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Data.Repositories
{
    public interface IDamageRepository
    {
        Task<ResponseDamage> DamageRegister(Damage damage);
    }
}
