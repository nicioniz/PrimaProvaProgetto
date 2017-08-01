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
            TextBox tb = new TextBox();
            tb.Name = "_moneyTextBox";
            tb.Tag = "money";
            tableLayoutPanel1.Controls.Add(tb);
            tableLayoutPanel1.RowCount++;
        }

        public Money Money
        {
            get
            {
                String testo = ((TextBox)(tableLayoutPanel1.Controls.Find("_moneyTextBox", false)[0])).Text;
                Decimal moneyDec;
                if (!Decimal.TryParse(testo, out moneyDec))
                {
                    // Gestire messaggio di errore nel caso non venga inserito un decimale
                }
                return new Money(moneyDec);
            }

            set
            {
                ((TextBox)(tableLayoutPanel1.Controls.Find("_moneyTextBox", false)[0])).Text = "" + value;
            }
        }
    }
}
