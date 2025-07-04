using System.Linq;
using System.Threading.Tasks;
using LungDiseaseDiagnosis.Models;
using Microsoft.EntityFrameworkCore;

namespace LungDiseaseDiagnosis.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }

        public async ValueTask<User> InsertUserAsync(User user)
        {
            await this.Users.AddAsync(user);
            await this.SaveChangesAsync();

            return user;
        }

        public IQueryable<User> SelectAllUsers() =>
            this.Users.AsQueryable();

        public async ValueTask<User> UpdateUserAsync(User user)
        {
            this.Users.Update(user);
            await this.SaveChangesAsync();

            return user;
        }
    }
}
