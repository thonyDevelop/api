using api.Data.Repositories;
using api.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DamageController : Controller
    {
        private readonly IDamageRepository _damageRepository;

        public DamageController(IDamageRepository damageRepository)
        {
            _damageRepository = damageRepository;
        }

        [HttpPost]
        public async Task<IActionResult> DamageRegister([FromBody] Damage damage)
        {
            return Ok(await _damageRepository.DamageRegister(damage));
        }
    }
}
