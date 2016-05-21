using ModernPOS.Business.Entities;
using ModernPOS.Data.Access.Context;
using ModernPOS.Infrastructure.Common.DataRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Data.Access.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        private readonly PosContext _context;

        public CustomerRepository(PosContext posContext) : base(posContext)
        {
            _context = posContext;
        }
    }
}
