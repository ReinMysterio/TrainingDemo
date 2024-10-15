using System.Collections.Generic;
using Model;

namespace TrainingDemo.DataAccess
{
    public interface IUserService
    {
        List<UserResponse> Users { get; }
    }
}