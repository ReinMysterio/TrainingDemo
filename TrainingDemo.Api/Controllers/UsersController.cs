using Microsoft.AspNetCore.Mvc;
using Model;
using TrainingDemo.Model;
using TrainingDemo.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userService.Users);
        }

        [HttpGet("user")]
        public IActionResult GetUserBy(int id)
        {
            var user = _userService.Users.FirstOrDefault(u => u.Id == id);
            return Ok(user);
        }


        [HttpPost]
        public IActionResult CreateUser([FromBody] UserRequestModel userRequestModel)
        {
            var input = new UserResponse()
            {
                ConfirmEmail = userRequestModel.Email,
                Name = userRequestModel.Name,
                Email = userRequestModel.Email,
            };

            _userService.Users.Add(input);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUserBy(int id, [FromBody] UserRequestModel userRequestModel)
        {
            var user = _userService.Users.FirstOrDefault(u => u.Id == id);

            user.ConfirmEmail = userRequestModel.Email;
            user.Name = userRequestModel.Name;
            user.Email = userRequestModel.Email;
            
            return Ok();
        }

        [HttpDelete("{id}")]
        
        public IActionResult DeleteUserBy(int id)
        {
            var user = _userService.Users.FirstOrDefault(u => u.Id == id);

            _userService.Users.Remove(user);

            return Ok();
        }
    }
}
