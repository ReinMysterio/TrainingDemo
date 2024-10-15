using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Validators;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private List<UserResponse> _user = new List<UserResponse>()
        {
            new UserResponse()
            {
                Id = 1,
                UserName = "John",
                Name = "John Doe",
                Email = ""
            },
            new UserResponse()
            {
                Id = 2,
                UserName = "Jane",
                Name = "Jane Doe",
                Email = ""
            }
        };


        [HttpGet]
        public string GetUsers()
        {
            return "Reading all Users";
        }

        [HttpGet("{id}")]
        public IActionResult GetUserBy(int id)
        {
            var user = _user.FirstOrDefault(u => u.Id == id);
            return Ok(user);
        }


        [HttpPost]
        public string CreateUser([FromBody] UserRequestModel userRequestModel)
        {
            return "Create new user";
        }

        [HttpPut("{id}")]
        public string UpdateUserBy(int id)
        {
            return $"Update user with Id :{id}";
        }

        [HttpDelete("{id}")]
        
        public string DeleteUserBy(int id)
        {
            return $"Delete user with Id :{id}";
        }
    }
}
