using ModernPOS.Data.Access;
using ModernPOS.Infrastructure.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Business.Services
{
    public abstract class ServiceBase
    {
        public IUnitOfWork UnitOfWork { get; private set; }

        public ServiceBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            UnitOfWork = new UnitOfWork();
        }
    }
}
