using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPOS.Infrastructure.Common.Data;
using ModernPOS.Business.Entities;

namespace ModernPOS.Infrastructure.Common.DataRepositories
{
    public interface ICustomerRepository : IDataRepository<Customer>
    {
    }
}
