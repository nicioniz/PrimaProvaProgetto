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
            //Application.Run(new Test());
            //f.ShowDialog();

            //Ristorante.GetInstance().Menu = InitMenu();
            //MenuForm mf = new MenuForm();
            //MenuFormPresenter mfp = new MenuFormPresenter(mf);
            //Application.Run(mf);

            //Application.Run(new LayoutForm());

            Ristorante.GetInstance().Menu = InitMenu();
            FirstWindowForm f = new FirstWindowForm();
            new FirstWindowFormPresenter(f);
            Application.Run(f);

            //ClientiForm cf = new ClientiForm();
            //new ClientiFormSelezioneMenuPresenter(cf);

            //Application.Run(cf);
        }

        static void Tests()
        {
            //MoneyTest.Test();
            //PietanzaTest.Test();
            //CriteriDiSelezioneTest.Test();
            //AlgoritmoPrevisioneFactoryTest.Test();
        }

        static List<Pietanza> InitMenu()
        {
            List<Allergene> empty = new List<Allergene>();
            List<Pietanza> res = new List<Pietanza>();
            res.Add(new Pietanza(
                "Prosciutto e melone",
                5.0m,
                Categoria.Antipasto,
                empty,
                "Antipasto fresco e molto buono con materie prime di qualità",
                true));

            res.Add(new Pietanza(
                "Spaghetti al pesto",
                7.50m,
                Categoria.Primo,
                empty,
                "",
                false));
            res.Add(new Pietanza(
                "Tiramisù",
                3.0m,
                Categoria.Dolce,
                empty,
                "",
                true));
            return res;
        }
    }
}
