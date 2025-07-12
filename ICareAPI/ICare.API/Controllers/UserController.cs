using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ICare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        // GET: api/User/{id}
        [HttpGet("{id}")]
        public ActionResult<string> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/User
        [HttpPost]
        public ActionResult<string> CreateUser([FromBody] string user)
        {
            throw new NotImplementedException();
        }

        // PUT: api/User/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] string user)
        {
            throw new NotImplementedException();
        }

        // PATCH: api/User/{id}
        [HttpPatch("{id}")]
        public IActionResult PartialUpdateUser(int id, [FromBody] string user)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/User/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        // OPTIONS: api/User
        [HttpOptions]
        public IActionResult GetOptions()
        {
            Response.Headers.Add("Allow", "GET,POST,PUT,PATCH,DELETE,OPTIONS");
            return Ok();
        }
    }
}