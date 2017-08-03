using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    class StringModifier : TextBox, IModifierControl
    {
        public object MyValue
        {
            get { return Text; }
            set { Text = (string)value; }
        }
    }
}
