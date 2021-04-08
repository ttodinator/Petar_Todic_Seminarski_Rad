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
using System.Runtime.Serialization;
using System.Net.Sockets;

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
            try
            {
                uCAddRentiranje.CbMusterija.DataSource = Communication.Communication.Instance.GetAllMusterija();
                DateTime dateTime = DateTime.Now;
                uCAddRentiranje.LblDatumShow.Text = dateTime.ToString("MM/dd/yyyy");
                uCAddRentiranje.LblUkupnaCena.Text = "0";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            try
            {
                this.uCAddRentiranje = uCAddRentiranje;
                uCAddRentiranje.DgvStavka.DataSource = stavkeRentiranja;
                uCAddRentiranje.LblUkupnaCena.Text = "0";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //uCUpdateRentiranje.CbPretraga.DataSource= Communication.Communication.Instance.SearchRentiranjePrezime(m);
        }

        internal void AddStavkaRentiranjaUpdate()
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            try
            {
                Musterija m = (Musterija)uCUpdateRentiranje.CbMusterijaUpdate.SelectedItem;
                string k = CommaConversion(GetUkupnaCena().ToString());
                Rentiranje r = new Rentiranje
                {
                    Id = RentiranjeId,
                    Musterija = (Musterija)uCUpdateRentiranje.CbMusterijaUpdate.SelectedItem,
                    Datum = DateTime.Now,
                    UkupnaCena = GetUkupnaCena(),
                    StavkeRentiranja = stavkeRentiranja.ToList(),
                    WhereCondition = "ID=",
                    WhereValue = $"{RentiranjeId}",
                    UpdateText = $"JMBG='{m.JMBG}',Datum='{DateTime.Now.ToString("MM/dd/yyyy")}',UkupnaCena={k}"



            };
                //Communication.Communication.Instance.UpdateRentiranje(r);

                if (stavkeRentiranjaUpdateDeletion.Count > 0)
                {
                    for (int i = 0; i < stavkeRentiranjaUpdateDeletion.Count; i++)
                    {
                        stavkeRentiranjaUpdateDeletion[i].WhereCondition = "ID=";
                        stavkeRentiranjaUpdateDeletion[i].WhereValue = $"{stavkeRentiranjaUpdateDeletion[i].Id}";
                        Communication.Communication.Instance.DeleteStavkaRentiranja(stavkeRentiranjaUpdateDeletion[i]);
                    }
                }
                Communication.Communication.Instance.UpdateRentiranje(r);
                MessageBox.Show("Rentiranje je uspesno azurirano");
                stavkeRentiranja.Clear();
                uCUpdateRentiranje.CbPretraga.DataSource = null;
                uCUpdateRentiranje.TxtPretragaImePrezime.Text = "";
                InitUCUpdateRentiranje();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
            
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
        }

        
        internal void UpdateFill()
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void InitUCUpdateRentiranje()
        {
            try
            {
                uCUpdateRentiranje.CbMusterijaUpdate.DataSource = Communication.Communication.Instance.GetAllMusterija();
                DateTime dateTime = DateTime.Now;
                uCUpdateRentiranje.LblDatumShow.Text = dateTime.ToString("MM/dd/yyyy");
                uCUpdateRentiranje.LblUkupnaCena.Text = "0";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            try
            {
                string k = CommaConversion(GetUkupnaCena().ToString());
                Musterija m = (Musterija)uCAddRentiranje.CbMusterija.SelectedItem;
                Rentiranje r = new Rentiranje
                {
                    Musterija = m,
                    Datum = DateTime.Now,
                    //StavkeRentiranja = stavkeRentiranja.ToList(),
                    UkupnaCena = GetUkupnaCena(),
                    StavkeRentiranja = stavkeRentiranja.ToList(),
                    InsertValues = $"'{m.JMBG}','{DateTime.Now.ToString("MM/dd/yyyy")}',{k}"
                };

                Communication.Communication.Instance.SaveRentiranje(r);
                MessageBox.Show("Rentiranje je uspesno sacuvano");
                stavkeRentiranja.Clear();
                InitUCAddRentiranje(uCAddRentiranje);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private string CommaConversion(string s)
        {
            if (s.Contains(","))
            {
                return s.Replace(",", ".");
            }
            return s;
        }

    }
}
