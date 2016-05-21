using ModernPOS.Business.Entities;
using ModernPOS.Data.Access.Context;
using ModernPOS.Data.Access.Repositories;
using ModernPOS.Infrastructure.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Data.Access
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PosContext _context;

        public UnitOfWork()
        {
            _context = new PosContext();
        }

        public bool Commit()
        {
            var saveChanges = _context.SaveChanges() > 0;

            return saveChanges;
        }


        public Infrastructure.Common.DataRepositories.ICustomerRepository Customer
        {
            get { return new CustomerRepository(_context); }
        }
    }
}
