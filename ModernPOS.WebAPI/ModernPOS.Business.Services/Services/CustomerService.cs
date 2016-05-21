using ModernPOS.Business.Entities;
using ModernPOS.Business.Services.Interfaces;
using ModernPOS.Core.Dto.Input;
using ModernPOS.Infrastructure.Common.DataRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Business.Services.Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = base.UnitOfWork.Customer;
        }


        public bool Add(CustomerInputDto customer)
        {
            _customerRepository.Create(new Customer()
            {
                Name = customer.FirstName,
                LastName = customer.LastName
            });

            return base.UnitOfWork.Commit();
        }
    }
}
