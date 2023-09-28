using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class DynamicFormFactory : Dictionary<eFormType, IFormCommand>
    {
        public void RegisterForm(eFormType formType, IFormCommand command)
        {
            this[formType] = command;
        }

        public AbstractForm CreateForm(eFormType formType)
        {
            if (TryGetValue(formType, out var command))
            {
                return command.Execute();
            }
            else
            {
                throw new ArgumentException("Invalid product type");
            }
        }
    }

}
