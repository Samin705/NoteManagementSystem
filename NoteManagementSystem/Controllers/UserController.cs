using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteManagementSystem.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ILoginRegistration _login;

        public UserController(ILoginRegistration login)
        {
            _login = login;
        }

        [HttpGet]
        [Route("UserLogin")]
        [SwaggerOperation(Description = "Example {  }")]
        public IActionResult UserLogin(Guid UserId, string Password)
        {
            return Ok(_login.UserLogin(UserId, Password));
        }

        [HttpPost]
        [Route("CreateUser")]
        [SwaggerOperation(Description = "Example {  }")]
        public IActionResult CreateUser(CreateUserDTO obj)
        {
            return Ok(_login.CreateUser(obj));
        }
    }
}
