using Model;

namespace TrainingDemo.Model
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string ConfirmEmail { get; set; }

        public string Password { get; set; }

        public RoleType RoleType { get; set; }
    }
}
