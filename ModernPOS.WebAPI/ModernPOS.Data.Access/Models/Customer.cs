//using FluentValidation.Attributes;
//using ModernPOS.Data.Access.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ModernPOS.Data.Access.Models.Utils;

namespace ModernPOS.Data.Access.Models
{
    

//[Validator(typeof(RegisterViewModelValidator))]
[Table("Customers")]
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Nombres")]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        public string LastName  { get; set; }

        //Se puede colocar esta propiedad con otro nombre y ademas hay que decirle FluidAPI que no la mappe
        /* [Display(Name = "Tipo de identificacion")]
         public Enums.IdetificaIdentificationType IdentificationType { get; set; }*/

        public IdentificationType IdentificationTypeId { get; set; }

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