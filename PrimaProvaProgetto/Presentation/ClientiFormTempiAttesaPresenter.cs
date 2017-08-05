using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;

namespace PrimaProvaProgetto.Presentation
{
    class ClientiFormTempiAttesaPresenter
    {
        private ClientiForm _target;
        private TimeSpan sogliaTempoBreve = new TimeSpan(0, 16, 0);

        public ClientiFormTempiAttesaPresenter(ClientiForm target)
        {
            _target = target;

            Ristorante.GetInstance().ListaPrenotazioniChanged += RefreshListaPrenotazioni;
            Target.AggiungiPrenotazioneButton.Click += AggiungiPrenotazioneButton_Click;

            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DrawTempiAttesa();
        }

        private void AggiungiPrenotazioneButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public ClientiForm Target
        {
            get { return _target; }
        }

        private void RefreshListaPrenotazioni(object sender, NotifyCollectionChangedEventArgs e)
        {
            DrawTempiAttesa();
        }

        private void DrawTempiAttesa()
        {
            for (int i = 1; i < 8; i += 2)
                DrawSingoloTempo(i);
        }

        private void DrawSingoloTempo(int nroPersone)
        {
            TimeSpan tempo = GetTempoAttesaMinimo(nroPersone);
            Label tempoAttesa = (Label)Target.GetType().GetProperty("LabelAttesaPers" + nroPersone).GetGetMethod().Invoke(Target, null);
            TableLayoutPanel panelAttesa = (TableLayoutPanel)Target.GetType().GetProperty("PanelAttesaPers" + nroPersone).GetGetMethod().Invoke(Target, null);
            tempoAttesa.Text = String.Format("{0:%h} or" + ((tempo.Hours > 1) ? ("e") : ("a")) + " e {0:%m} minuti", tempo);
            panelAttesa.BackColor = (tempo < sogliaTempoBreve) ? (Color.LightGreen) : (Color.Orange);

        }

        private TimeSpan GetTempoAttesaMinimo(int nroPersone)
        {
            List<TimeSpan> tempi = new List<TimeSpan>();
            Ristorante.GetInstance().Tavoli.Where(t => t.Coperti >= nroPersone && t.Coperti <= (nroPersone + 1)).ToList()
                .ForEach(t => tempi.Add(t.CalcolaTempo.TempoRimanente));
            tempi.Sort();
            int index = 0;
            Ristorante.GetInstance().ListaPrenotazioni.Where(p => p.NumeroCoperti >= nroPersone && p.NumeroCoperti <= (nroPersone + 1)).ToList()
                .ForEach(p => tempi[index++ % tempi.Count] = tempi[index++ % tempi.Count] + Previsione.GetInstance().OttieniPrevisione(nroPersone));
            return tempi.Min();
        }
    }
}
