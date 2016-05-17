using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernPOS.WebAPI.Models
{
    class IdentificationType
    {
        public int Id { get; set; }

        public string   Name { get; set; }
        
        public User UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
