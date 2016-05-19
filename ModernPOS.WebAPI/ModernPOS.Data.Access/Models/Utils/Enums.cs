using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ModernPOS.Data.Access.Models.Utils
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