using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernPOS.Core
{
    public interface IServiceFactoryNinject : IDisposable
    {
        T GetService <T> ();
    }
}
