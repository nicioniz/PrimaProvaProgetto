using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    class IntModifier : NumericUpDown, IModifierControl
    {
        public object MyValue
        {
            get { return (int)Value; }
            set { Value = (int)value; }
        }
    }
}
