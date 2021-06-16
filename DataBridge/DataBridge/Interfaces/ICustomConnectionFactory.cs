using System.Data;

namespace DataBridge.Interfaces
{
    public interface ICustomConnectionFactory
    {
        public IDbConnection Connection { get; }
    }
}
