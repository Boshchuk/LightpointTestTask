using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace LightpointTestTask.DAL
{
    public class LightpointConfiguration : DbConfiguration
    {
        public LightpointConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}