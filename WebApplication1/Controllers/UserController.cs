using api.Data.Repositories;
using api.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> getUserByEmail([FromBody] EmailRequest emailReques)
        {
            try
            {
                string email = emailReques.email;
                if (email == null)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(await _userRepository.getUserByEmail(email));
            }
            catch (Exception ex)
            {   
                Console.Out.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                return BadRequest("Ocurrió un error");
            }
        }
    }
}