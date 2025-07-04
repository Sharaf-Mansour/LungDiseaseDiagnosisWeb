using LungDiseaseDiagnosis.Models;

namespace LungDiseaseDiagnosis.Services
{
    public interface IUserService
    {
        User? CurrentUser { get; set; }
    }
}
