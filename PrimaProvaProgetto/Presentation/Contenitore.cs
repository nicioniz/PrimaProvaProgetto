using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Presentation
{
    public class Contenitore
    {
        private string _image;
        private Point _location;

        public Contenitore()
        {
            _image = null;
            _location = new Point(0,0);
        }

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public Point Location
        {
            get { return _location; }
            set { _location = value; }
        }




    }
}
