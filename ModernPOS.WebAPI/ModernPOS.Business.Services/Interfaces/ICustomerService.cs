using ModernPOS.Business.Entities;
using ModernPOS.Core.Dto.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Business.Services.Interfaces
{
    public interface ICustomerService
    {
        bool Add(CustomerInputDto customer);
    }
}
