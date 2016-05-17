using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernPOS.WebAPI.Models
{
    public class IdentificationType
    {
        public int Id { get; set; }
        public string   Name { get; set; }        
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public User UserId { get; set; }
        //lo pueden poner en Customer y se puede confundir con la clase si lo dejan customer
        //saben que es una propiedad de relacion
        public virtual ICollection<Customer> customer { get; set; }

    }
}
