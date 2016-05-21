
//using FluentValidation.Attributes;
//using ModernPOS.Data.Access.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using ModernPOS.Core.Common;
using FluentValidation;
using ModernPOS.Core.Common.Utils;

namespace ModernPOS.Business.Entities
{
    
    public class Customer : EntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName  { get; set; }

        public IdentificationType IdentificationTypeId { get; set; }

        public string Identification  { get; set; }

        public string MyPrAddress  { get; set; }

        public string PhoneNumber  { get; set; }

        public User UserId  { get; set; }

        public DateTime CreatedDate  { get; set; }
      
        public DateTime ModifiedDate { get; set; }



        public FluentValidation.IValidator GetValidator()
        {
            return new CustomerValidator();
        }

        private class CustomerValidator : AbstractValidator<Customer>
        {
            public CustomerValidator()
            {
                RuleFor(e => e.Name)
                    .NotEmpty()
                    .WithMessage("The FirstName is required.");
            }
        }

        


    }
}