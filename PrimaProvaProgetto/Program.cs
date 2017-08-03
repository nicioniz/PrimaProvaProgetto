using PrimaProvaProgetto.Model;
using PrimaProvaProgetto.Presentation;
using PrimaProvaProgetto.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LayoutForm());
            //(new Test()).Show();

            //Tests();

            //ModifierForm f = new ModifierForm();
            //ModifierFormPresenter mfp = new ModifierFormPresenter(f);
            //Pietanza piet = new Pietanza("primissimo piatto",
            //    4.5m, Categoria.Antipasto,new List<Allergene>());
            //mfp.SetEditableObject(piet);
            //Application.Run(f);
            Application.Run(new Test());
            //f.ShowDialog();
        }

        static void Tests()
        {
            //MoneyTest.Test();
            //PietanzaTest.Test();
            //CriteriDiSelezioneTest.Test();
            //AlgoritmoPrevisioneFactoryTest.Test();
        }
    }
}
