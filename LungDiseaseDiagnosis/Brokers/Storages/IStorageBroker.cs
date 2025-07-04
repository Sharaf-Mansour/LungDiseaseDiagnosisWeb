using LungDiseaseDiagnosis.Models;

namespace LungDiseaseDiagnosis.Brokers.Storages
{
    public interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
        IQueryable<User> SelectAllUsers();
        ValueTask<User> UpdateUserAsync(User user);
    }
}
