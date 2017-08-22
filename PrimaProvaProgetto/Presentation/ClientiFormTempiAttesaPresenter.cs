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

        public ClientiFormTempiAttesaPresenter(ClientiForm target)
        {
            _target = target;

            LocaleRistorazione.GetInstance().ListaPrenotazioniChanged += RefreshListaPrenotazioni;
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
            new InserimentoPrenotazioneForm().Show();
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
            tempoAttesa.Text = GetTempoString(tempo);
            panelAttesa.BackColor = GetTempoAttesaColor(tempo);
            
        }

        private TimeSpan GetTempoAttesaMinimo(int nroPersone)
        {
            List<TimeSpan> tempi = new List<TimeSpan>();
            LocaleRistorazione.GetInstance().Tavoli.Where(t => t.PostiMax >= nroPersone && t.PostiMax <= (nroPersone + 1)).ToList()
                .ForEach(t => tempi.Add(t.CalcolaTempo.TempoRimanente));
            tempi.Sort();
            if (tempi.Count == 0 || localeVuoto())
                return TimeSpan.Zero;
            int index = 0;
            LocaleRistorazione.GetInstance().ListaPrenotazioni.Where(p => p.NumeroCoperti >= nroPersone && p.NumeroCoperti <= (nroPersone + 1)).ToList()
                .ForEach(p => tempi[index % tempi.Count] = tempi[index++ % tempi.Count] + Previsione.GetInstance().OttieniPrevisione(nroPersone));
            return tempi.Count != 0 ? tempi.Min() : TimeSpan.Zero;
        }

        private string GetTempoString(TimeSpan tempo)
        {
            if (tempo == TimeSpan.Zero || localeVuoto())
                return "LIBERO";
            string res = "";
            if(tempo.Hours != 0)
                res = String.Format("{0:%h} or" + ((tempo.Hours > 1) ? ("e") : ("a")) + " e ", tempo);
            return res + String.Format("{0:%m} minuti", tempo);
        }

        private Color GetTempoAttesaColor(TimeSpan tempoAttesa)
        {
            Dictionary<TimeSpan, Color> dict = new Dictionary<TimeSpan, Color>();
            dict.Add(new TimeSpan(0, 15, 0), Color.LightGreen);
            dict.Add(new TimeSpan(0, 50, 0), Color.Orange);
            dict.Add(TimeSpan.MaxValue, Color.Red);
            TimeSpan res = dict.Keys.ToList().First(ts => tempoAttesa <= ts);
            return dict[res];
        }

        private bool localeVuoto()
        {
            return (LocaleRistorazione.GetInstance().ListaPrenotazioni.Count == 0) && (LocaleRistorazione.GetInstance().Tavoli.Where(t => t.Stato.Equals(StatoTavolo.Occupato)).Count() == 0);
        }

    }
}
