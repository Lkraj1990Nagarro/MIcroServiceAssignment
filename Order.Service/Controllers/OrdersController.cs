using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Order.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [Route("{userId:int}")]
        public IActionResult Get(int userId)
        {
            return Ok(new OrderDetails().GetOrders(userId));
        }
    }
}