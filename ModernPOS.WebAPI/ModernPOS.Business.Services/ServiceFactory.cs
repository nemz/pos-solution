using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Syntax;
using Ninject.Modules;
using ModernPOS.Core;
using ModernPOS.Business.Services.Interfaces;
using ModernPOS.Business.Services.Services;

namespace ModernPOS.Business.Services
{
    public class FactoryModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IServiceFactoryNinject>().To<ServiceFactoryNinject>();
            this.Bind<ICustomerService>().To<CustomerService>();
        }
    }

    public class ServiceFactoryNinject : IServiceFactoryNinject
    {
        IResolutionRoot _resolutionRoot;       

        public ServiceFactoryNinject(IResolutionRoot _resolutionRoot)
        {
            this._resolutionRoot = _resolutionRoot;
        }

        public T GetService<T>()
        {
            return _resolutionRoot.Get<T>();
        }

        public void Dispose()
        {
           
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
