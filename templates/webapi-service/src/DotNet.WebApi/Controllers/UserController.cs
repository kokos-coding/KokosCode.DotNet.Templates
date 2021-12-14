using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public UserController()
        {
            
        }

        [Get("{id:Guid}")]
        public IActionResult GetUserById(Guid id)
        {
            
        }
    }
}