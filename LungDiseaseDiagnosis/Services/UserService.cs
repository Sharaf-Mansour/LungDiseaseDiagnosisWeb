using LungDiseaseDiagnosis.Models;

namespace LungDiseaseDiagnosis.Services
{
    public class UserService : IUserService
    {
        public User? CurrentUser { get; set; }
    }
}
