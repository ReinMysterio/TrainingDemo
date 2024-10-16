using TrainingDemo.Model;

namespace TrainingDemo.Services
{
    public interface IUserService
    {
        public List<UserResponse> Users { get; }
    }
}
