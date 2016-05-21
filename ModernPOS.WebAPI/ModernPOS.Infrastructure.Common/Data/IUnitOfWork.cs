using ModernPOS.Business.Entities;
using ModernPOS.Infrastructure.Common.DataRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Infrastructure.Common.Data
{
    public interface IUnitOfWork
    {
        bool Commit();
        ICustomerRepository Customer {get;}
    }
}
