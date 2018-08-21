using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagement.Data
{
    class VehicleDbConfiguration : DbConfiguration
    {
        public VehicleDbConfiguration()
        {
            SetDatabaseInitializer(new VehicleDBInitializer());
            SetDefaultConnectionFactory(new SqlConnectionFactory("Data Source=HP-PC; Integrated Security=True; MultipleActiveResultSets=True"));
            SetProviderServices("System.Data.SqlClient",
                                     System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }
    }
}
