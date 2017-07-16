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
            Application.Run(new MenuForm());
            (new Test()).Show();

            //Tests();
        }

        static void Tests()
        {
            //MoneyTest.Test();
            //PietanzaTest.Test();
            //CriteriDiSelezioneTest.Test();
            AlgoritmoPrevisioneFactoryTest.Test();
        }
    }
}
