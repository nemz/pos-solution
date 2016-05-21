using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Core.Common.Utils
{
    public abstract class EntityBase
    {
         private IValidator _validator = null;
        private IEnumerable<ValidationFailure> _validationFailures = null;

        public EntityBase()
        {
            _validator = GetValidator();
   
            Validate();
        }

        public virtual IValidator GetValidator() { return null; }

        public void Validate()
        {
           var result =  _validator.Validate(this);
           _validationFailures = result.Errors;
        }

        public IEnumerable<string> ErrorMessages
        {
            get
            {
                if (_validationFailures == null || _validationFailures.Count() <= 0)
                    return Enumerable.Empty<string>();

                return _validationFailures.Select(e => e.ErrorMessage);
            }
        }

        public bool IsValid()
        {
            if (ErrorMessages != null && ErrorMessages.Count() > 0)
                return false;

            return true;
        }

    }
}
