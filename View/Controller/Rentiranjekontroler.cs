using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Dialog;
using View.UserControls;
using View.Helpers;

namespace View.Controller
{
    public class Rentiranjekontroler
    {
        private BindingList<StavkaRentiranja> stavkeRentiranja = new BindingList<StavkaRentiranja>();
        private BindingList<StavkaRentiranja> stavkeRentiranjaUpdate = new BindingList<StavkaRentiranja>();
        public int RentiranjeId { get; set; }
        private BindingList<StavkaRentiranja> stavkeRentiranjaUpdateDeletion = new BindingList<StavkaRentiranja>();
        UCAddRentiranje uCAddRentiranje;
        UCUpdateRentiranje uCUpdateRentiranje;
        internal void InitUCAddRentiranje(UCAddRentiranje uCAddRentiranje)
        {
            uCAddRentiranje.CbMusterija.DataSource = Communication.Communication.Instance.GetAllMusterija();
            DateTime dateTime = DateTime.Now;
            uCAddRentiranje.LblDatumShow.Text = dateTime.ToString("MM/dd/yyyy");
        }


        internal void AddStavkaRentiranja()
        {
            int broj = stavkeRentiranja.Count + 1;
            AddStavkaRenitranjaDialog dialog = new AddStavkaRenitranjaDialog(broj);
            dialog.ShowDialog();
            if (dialog.stavkaRentiranja != null)
            {
                stavkeRentiranja.Add(dialog.stavkaRentiranja);

            }
            uCAddRentiranje.LblUkupnaCena.Text = GetUkupnaCena().ToString();
        }

        internal void InitForm(UCAddRentiranje uCAddRentiranje)
        {
            this.uCAddRentiranje = uCAddRentiranje;
            uCAddRentiranje.DgvStavka.DataSource = stavkeRentiranja;
            uCAddRentiranje.LblUkupnaCena.Text = "0";
            
        }

        List<Rentiranje> rentiranja = new List<Rentiranje>();
        //List<StavkaRentiranja> stavkeRentiranja = new List<StavkaRentiranja>();

        internal void SarchPrezime()
        {
            try
            {
                Rentiranje r = new Rentiranje
                {
                    Musterija = new Musterija
                    {
                        Prezime = uCUpdateRentiranje.TxtPretragaImePrezime.Text
                    },
                    WhereCondition="m.Prezime=",
                    WhereValue= uCUpdateRentiranje.TxtPretragaImePrezime.Text
                };
                rentiranja = Communication.Communication.Instance.SearchRentiranje(r);
                uCUpdateRentiranje.CbPretraga.DataSource = rentiranja;
                MessageBox.Show("Postoji rentiranje sa datim prezimenom");
            }
            catch (Exception)
            {

                MessageBox.Show("Ne postoji nijedno rentiranje sa zadatim prezimenom");
            }
            //uCUpdateRentiranje.CbPretraga.DataSource= Communication.Communication.Instance.SearchRentiranjePrezime(m);
        }

        internal void AddStavkaRentiranjaUpdate()
        {
            int broj = stavkeRentiranja.Count + 1;
            AddStavkaRenitranjaDialog dialog = new AddStavkaRenitranjaDialog(broj);
            dialog.ShowDialog();
            if (dialog.stavkaRentiranja != null)
            {
                stavkeRentiranja.Add(dialog.stavkaRentiranja);

            }
            uCUpdateRentiranje.LblUkupnaCena.Text = GetUkupnaCena().ToString();
        }

        internal void UpdateRentiranje()
        {
            if (uCUpdateRentiranje.CbPretraga.SelectedItem==null)
            {
                MessageBox.Show("Niste izabrali rentiranje koje zelite da izmenite");
            }
            if (stavkeRentiranja.Count == 0)
            {
                MessageBox.Show("Niste dodali nijednu stavku");
                return;
            }
            if (!UserControlHelpers.ComboBoxValidation(uCUpdateRentiranje.CbMusterijaUpdate,uCUpdateRentiranje.LblMusterija))
            {
                return;

            }
            Rentiranje r = new Rentiranje
            {
                Id=RentiranjeId,
                Musterija = (Musterija)uCUpdateRentiranje.CbMusterijaUpdate.SelectedItem,
                Datum = DateTime.Now,
                UkupnaCena = GetUkupnaCena(),
                StavkeRentiranja=stavkeRentiranja.ToList()
            };
            Communication.Communication.Instance.UpdateRentiranje(r);

            if (stavkeRentiranjaUpdateDeletion.Count>0)
            {
                for (int i = 0; i < stavkeRentiranjaUpdateDeletion.Count; i++)
                {
                    Communication.Communication.Instance.DeleteStavkaRentiranja(stavkeRentiranjaUpdateDeletion[i]);
                } 
            }
            /*for (int i = 0; i < stavkeRentiranja.Count; i++)
            {
                stavkeRentiranja[i].Rentiranje = r;
                Communication.Communication.Instance.SaveStavkarentiranja(stavkeRentiranja[i]);
            }*/

            MessageBox.Show("Rentiranje je uspesno azurirano");
            stavkeRentiranja.Clear();
            uCUpdateRentiranje.CbPretraga.DataSource = null;
            uCUpdateRentiranje.TxtPretragaImePrezime.Text = "";
            
        }

        internal void SearchDatum()
        {
            try
            {
                Rentiranje r = new Rentiranje
                {
                    Datum = uCUpdateRentiranje.DtpDatum.Value,
                    WhereCondition="r.Datum=",
                    WhereValue= uCUpdateRentiranje.DtpDatum.Value.ToString("MM/dd/yyyy")
            };
                rentiranja = Communication.Communication.Instance.SearchRentiranje(r);
                uCUpdateRentiranje.CbPretraga.DataSource = rentiranja;
                //uCUpdateRentiranje.CbPretraga.DataSource = Communication.Communication.Instance.SearchRentiranjeDatum(r);
                MessageBox.Show("Postoji rentiranja za taj dan");
            }
            catch (Exception)
            {

                MessageBox.Show("Za ovaj datum ne postoji nijedno rentiranje");
            }
        }

        
        internal void UpdateFill()
        {
            Rentiranje r = (Rentiranje)uCUpdateRentiranje.CbPretraga.SelectedItem;
            RentiranjeId = r.Id;
            //uCUpdateRentiranje.DtpDatumUpdate.Value = r.Datum;
            uCUpdateRentiranje.CbMusterijaUpdate.SelectedIndex = uCUpdateRentiranje.CbMusterijaUpdate.FindStringExact($"{r.Musterija.Ime} {r.Musterija.Prezime} {r.Musterija.JMBG}");
            uCUpdateRentiranje.LblUkupnaCena.Text = r.UkupnaCena.ToString();
            stavkeRentiranjaUpdateDeletion = new BindingList<StavkaRentiranja>(Communication.Communication.Instance.SearchStavkaRentiranja(r.Id));
            stavkeRentiranja = new BindingList<StavkaRentiranja>(Communication.Communication.Instance.SearchStavkaRentiranja(r.Id));
            uCUpdateRentiranje.DgvStavkeRentiranja.DataSource = stavkeRentiranja;
            //uCUpdateRentiranje.DgvStavkeRentiranja.DataSource = Communication.Communication.Instance.SearchStavkaRentiranja(r.Id);
            uCUpdateRentiranje.Refresh();
            MessageBox.Show("Uspesno ucitano rentiranje");
        }

        internal void InitUCUpdateRentiranje()
        {
            uCUpdateRentiranje.CbMusterijaUpdate.DataSource = Communication.Communication.Instance.GetAllMusterija();
            DateTime dateTime = DateTime.Now;
            uCUpdateRentiranje.LblDatumShow.Text = dateTime.ToString("MM/dd/yyyy");
        }

        internal void SarchIme()
        {
            try
            {
                Rentiranje r = new Rentiranje
                {
                    Musterija = new Musterija
                    {
                        Ime = uCUpdateRentiranje.TxtPretragaImePrezime.Text
                    },
                    WhereCondition="m.Ime=",
                    WhereValue= uCUpdateRentiranje.TxtPretragaImePrezime.Text

                };
                rentiranja = Communication.Communication.Instance.SearchRentiranje(r);
                uCUpdateRentiranje.CbPretraga.DataSource = rentiranja;
                //uCUpdateRentiranje.CbPretraga.DataSource = Communication.Communication.Instance.SearchRentiranjeIme(m);
                MessageBox.Show("Postoji rentiranje sa zadatim imenom");
            }
            catch (Exception)
            {

                MessageBox.Show("Ne postoji nijedno rentiranje za zadato ime");
            }
        }

        internal void InitForm(UCUpdateRentiranje uCUpdateRentiranje)
        {
            this.uCUpdateRentiranje = uCUpdateRentiranje;

        }

        internal void RemoveStavka()
        {
            if (uCAddRentiranje.DgvStavka.SelectedRows.Count > 0)
            {
                DataGridViewRow row = uCAddRentiranje.DgvStavka.SelectedRows[0];
                StavkaRentiranja stavka = (StavkaRentiranja)row.DataBoundItem;
                stavkeRentiranja.Remove(stavka);
                for (int i = 0; i < stavkeRentiranja.Count; i++)
                {
                    stavkeRentiranja[i].RedniBroj = i + 1;
                }

            }
            else
            {
                MessageBox.Show("Niste oznacili nijedan red");
            }

            uCAddRentiranje.LblUkupnaCena.Text = GetUkupnaCena().ToString();
        }

        internal void RemoveStavkaUpdate()
        {
            if (uCUpdateRentiranje.DgvStavkeRentiranja.SelectedRows.Count > 0)
            {
                DataGridViewRow row = uCUpdateRentiranje.DgvStavkeRentiranja.SelectedRows[0];
                StavkaRentiranja stavka = (StavkaRentiranja)row.DataBoundItem;
                stavkeRentiranja.Remove(stavka);
                for (int i = 0; i < stavkeRentiranja.Count; i++)
                {
                    stavkeRentiranja[i].RedniBroj = i + 1;
                }

            }
            else
            {
                MessageBox.Show("Niste oznacili nijedan red");
            }

            uCUpdateRentiranje.LblUkupnaCena.Text = GetUkupnaCena().ToString();
        }

        internal void SaveRentiranje()
        {
            if (stavkeRentiranja.Count == 0)
            {
                MessageBox.Show("Niste uneli nijednu stavku");
                return;
            }
            if(!UserControlHelpers.ComboBoxValidation(uCAddRentiranje.CbMusterija,uCAddRentiranje.LblMusterija)                )
            {
                return;
            }
            Rentiranje r = new Rentiranje
            {
                Musterija = (Musterija)uCAddRentiranje.CbMusterija.SelectedItem,
                Datum = DateTime.Now,
                //StavkeRentiranja = stavkeRentiranja.ToList(),
                UkupnaCena=GetUkupnaCena(),
                StavkeRentiranja=stavkeRentiranja.ToList()
            };
            //Communication.Communication.Instance.SaveRentiranje(r);
            //int ID=Communication.Communication.Instance.GetRentiranjeID(r);
            //r.Id = ID;
            /*if (stavkeRentiranja.Count < 1)
            {
                MessageBox.Show("Ne postoji nijedna stavka");
                return;
            }
            for (int i = 0; i < stavkeRentiranja.Count; i++)
            {
                stavkeRentiranja[i].Rentiranje = r;
                Communication.Communication.Instance.SaveStavkarentiranja(stavkeRentiranja[i]);

            }
            */
            //r.StavkeRentiranja = stavkeRentiranja.ToList();
            Communication.Communication.Instance.SaveRentiranje(r);
            MessageBox.Show("Rentiranje je uspesno sacuvano");
            stavkeRentiranja.Clear();
        }

        internal void UpdateUkupnaCena()
        {
            uCAddRentiranje.LblUkupnaCena.Text = GetUkupnaCena().ToString();
        }

        private double GetUkupnaCena()
        {
            double ukupnaCena=0;
            for (int i = 0; i < stavkeRentiranja.Count; i++)
            {
                StavkaRentiranja sr= stavkeRentiranja[i];
                ukupnaCena += (sr.DatumDo - sr.DatumOd).TotalDays * (sr.Automobil.CenaPoDanu + sr.Polisa.CenaPoDanu);
            }
            return Math.Round(ukupnaCena,2);
        }

    }
}
