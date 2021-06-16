using DataBridge.Environment;
using DataBridge.Interfaces;
using DataBridge.Shared.Entities;

namespace DataBridge.Repositories
{
    public class CompanyRepository : Repository<Company>
    {
        public CompanyRepository(ICustomConnectionFactory connectionFactory) : base(connectionFactory, "Companies")
        {
        }
    }
}
