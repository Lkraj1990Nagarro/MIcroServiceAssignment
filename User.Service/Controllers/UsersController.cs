using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Data;

namespace User.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserContext context;

        public UsersController(UserContext context)
        {
            this.context = context;
        }
        [Route("{userId:int}")]
        public async Task<IActionResult> Get(int userId)
        {
            Users user = await context.Users.FindAsync(userId);
            return Ok(user);
        }
    }
}