using Model;

namespace TrainingDemo.DataAccess
{
    public class UserService : IUserService
    {

        public List<UserResponse> Users { get; }

        public UserService()
        {
            Users = new List<UserResponse>()
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
        }
    }
}
