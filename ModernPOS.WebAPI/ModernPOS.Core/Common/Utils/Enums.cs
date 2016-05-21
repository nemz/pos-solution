using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ModernPOS.Core.Common.Utils
{
    public enum IdentificationType
    {
        [Description("Cédula")]
        Cedula = 1,

        [Description("Pasaporte")]
        Pasaporte = 2,

        [Description("RNC")]
        RNC = 3
    }
}