using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    class MoneyModifier : NumericUpDown, IModifierControl
    {
        public MoneyModifier()
        {
            DecimalPlaces = 2;
            Increment = 0.01m;
        }

        public object MyValue
        {
            get { return new Money(Value); }
            set { Value = (Money)value; }
        }
    }
}
