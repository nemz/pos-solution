using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ModernPOS.WebAPI.Models.Utils;

namespace ModernPOS.WebAPI.Models
{
    

[Validator(typeof(RegisterViewModelValidator))]
[Table("Customers")]
    public class Customers
    {
        [Display(Name = "Nombres")]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        public string LastName  { get; set; }

        [Display(Name = "Tipo de identificacion")]
        public Enums.IdetificaIdentificationType IdentificationType { get; set; }

        [Display(Name = "Identificación")]
        public string Identification  { get; set; }

        [Display(Name = "Dirección")]
        public string MyPrAddress  { get; set; }

        [Display(Name = "Telefono")]
        public string PhoneNumber  { get; set; }

        [Display(Name = "Usuario")]
        public User UserId  { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime CreatedDate  { get; set; }
      
        [Display(Name = "Tipo de identificacion")]
        public DateTime ModifiedDate { get; set; }


    }
}