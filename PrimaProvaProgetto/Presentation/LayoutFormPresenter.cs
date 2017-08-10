using PrimaProvaProgetto.Model;
using PrimaProvaProgetto.Persistance;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    class LayoutFormPresenter
    {
        LayoutForm _target;

        public LayoutFormPresenter(LayoutForm target)
        {
            _target = target;

            Target.ConfermaButton.Click += ConfermaButton_onClick;
            Target.CaricaComboBox.SelectedValueChanged += CaricaButton_onClick;
            Target.IndietroButton.Click += IndietroButton_onClick;
            
            Carica(LayoutPersisterFactory.GetLayoutLoader("SimpleJsonLayoutLoader").Load(TipoLayout.Ultimo));
        }

        private void CaricaButton_onClick(object sender, EventArgs e)
        {
            Carica(LayoutPersisterFactory.GetLayoutLoader("SimpleJsonLayoutLoader").Load(((TipoLayout)((ComboBox)sender).SelectedItem)));
            
        }

        private void Carica(Dictionary<String, Tavolo> tavoli)
        {
            Ristorante ristorante = Ristorante.GetInstance();
            IEnumerable<PictureBox> layoutBox = Target.TableLayoutPanel2.Controls.OfType<PictureBox>();

            Tavolo tavolo;

            foreach (PictureBox pb in layoutBox)
            {
                String name = pb.Name;
                // Ricavo le coordinate dal nome della PictureBox
                String coordinate = name.Substring(name.Length - 2);
                if (tavoli.ContainsKey(coordinate))
                {
                    tavolo = tavoli[coordinate];
                    pb.Tag = tavolo.PostiMax.ToString();
                    String propertyToInvoke = "Posti" + pb.Tag + "PictureBox";
                    PictureBox pbDestra = (PictureBox)Target.GetType().GetProperty(propertyToInvoke).GetValue(Target);
                    pb.Image = pbDestra.Image;
                }
                else
                {
                    pb.Tag = null;
                    pb.Image = null;
                }
            }
            ristorante.Tavoli = tavoli.Values.ToList();
        }

        private void IndietroButton_onClick(object sender, EventArgs e)
        {
            Target.Close();
        }

        private void ConfermaButton_onClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
               "Sei sicuro di voler salvare questo Layout?",
               "Conferma Layout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Ristorante ristorante = Ristorante.GetInstance();
                Dictionary<String, Tavolo> tavoli = new Dictionary<string, Tavolo>();

                IEnumerable<PictureBox> layoutBox = Target.TableLayoutPanel2.Controls.OfType<PictureBox>();
                
                foreach(PictureBox pb in layoutBox)
                {
                    if(pb.Tag != null)
                    {
                        String name = pb.Name;
                        // Ricavo le coordinate dal nome della PictureBox
                        String coordinate = name.Substring(name.Length - 2);
                        tavoli.Add(coordinate, new Tavolo( int.Parse(pb.Tag.ToString()), StatoTavolo.Libero));
                    }
                }
                ristorante.Tavoli = tavoli.Values.ToList();
                LayoutPersisterFactory.GetLayoutSaver("SimpleJsonLayoutSaver").Save(tavoli);

                Target.Close();
            }
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
