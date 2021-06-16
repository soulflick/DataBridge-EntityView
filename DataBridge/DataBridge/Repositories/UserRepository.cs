using DataBridge.Interfaces;
using DataBridge.Shared.Entities;

namespace DataBridge.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(ICustomConnectionFactory connectionFactory) : base(connectionFactory, "Users")
        {
        }
    }
}
