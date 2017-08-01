using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimaProvaProgetto.Model;

namespace PrimaProvaProgetto.Presentation
{
    public partial class MoneyModifier : UserControl
    {
        public MoneyModifier()
        {
            InitializeComponent();
        }

        public Money MoneyValue
        {
            set
            {
                _numericUpDown.Value = value;
            }

            get
            {
                return new Money(_numericUpDown.Value);
            }
        }
    }
}
