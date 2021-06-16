using DataBridge.Environment;
using DataBridge.Interfaces;
using DataBridge.Shared.Entities;

namespace DataBridge.Repositories
{
    public class FactoryRepository : Repository<Factory>
    {
        public FactoryRepository(ICustomConnectionFactory connectionFactory) : base(connectionFactory, "Factories")
        {
        }
    }
}
