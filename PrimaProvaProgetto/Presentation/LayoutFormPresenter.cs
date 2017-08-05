using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Presentation
{
    class LayoutFormPresenter
    {
        LayoutForm _target;

        public LayoutFormPresenter(LayoutForm target)
        {
            _target = target;

            Target.ConfermaButton.Click += ConfermaButton_onClick;
            Target.CaricaButton.Click += CaricaButton_onClick;
            Target.IndietroButton.Click += IndietroButton_onClick;
        }

        private void CaricaButton_onClick(object sender, EventArgs e)
        {
            // TODO
        }

        private void IndietroButton_onClick(object sender, EventArgs e)
        {
            Target.Close();
        }

        private void ConfermaButton_onClick(object sender, EventArgs e)
        {
            // TODO
        }

        public LayoutForm Target
        {
            get
            {
                return _target;
            }
        }
    }
}
