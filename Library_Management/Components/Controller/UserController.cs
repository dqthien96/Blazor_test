using Library_Management.Components.Data;
using Library_Management.Components.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Library_Management.Components.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Dbcontext _context;

        public UserController(Dbcontext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(Users model)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
            if (user == null)
            {
                return NotFound("Invalid username or password");
            }

            // Return user details without password for security reasons
            return Ok(new { user.Id, user.Username, user.FullName, user.Email, user.Role });
        }
    }
}
