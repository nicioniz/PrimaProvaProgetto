using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    interface IMenuSaver
    {
        void Save(List<Pietanza> menu);
    }

    interface IMenuLoader
    {
        List<Pietanza> Load();
    }
}

