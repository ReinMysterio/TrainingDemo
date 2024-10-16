using TrainingDemo.Model;

namespace TrainingDemo.Services;

public class UserService : IUserService
{
    public List<UserResponse> Users { get; }

    public UserService()
    {
        Users =
        [
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
        ];
    }

}