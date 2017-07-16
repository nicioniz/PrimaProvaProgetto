using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EditabileAttribute : Attribute
    {
        private Type _modifier;

        public EditabileAttribute() { }

        public Type Modifier
        {
            get
            {
                return _modifier;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("modifier");
                _modifier = value;
            }
        }
    }
}
