using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;
using Domain;
using View.Helpers;

namespace View.Controller
{
    public class MusterijaController
    {
    

        internal void Save(UCAddMusterija UCAddMusterija)
        {
            if (!UserControlHelpers.JMBGFieldValidation(UCAddMusterija.TxtJMBG, UCAddMusterija.LblJMBG)
                | !UserControlHelpers.CapitalLetterValidation(UCAddMusterija.TxtIme,UCAddMusterija.LblIme)
                | !UserControlHelpers.CapitalLetterValidation(UCAddMusterija.TxtPrezime, UCAddMusterija.LblPrezime)
                | !UserControlHelpers.PhoneNumberValidation(UCAddMusterija.TxtBrojTelefona,UCAddMusterija.LblBrojTelefona)
                | !UserControlHelpers.DateValidation(UCAddMusterija.DtpDatumRodjenja,UCAddMusterija.LblDatum)
                )
            {
                return;
            }
            try
            {
                Musterija m = new Musterija
                {
                    JMBG = UCAddMusterija.TxtJMBG.Text,
                    Ime = UCAddMusterija.TxtIme.Text,
                    Prezime = UCAddMusterija.TxtPrezime.Text,
                    BrojTelefona = UCAddMusterija.TxtBrojTelefona.Text,
                    DatumRodjenja = UCAddMusterija.DtpDatumRodjenja.Value
                };
                if (Communication.Communication.Instance.SearchMusterijaJMBG(m))
                {
                    Communication.Communication.Instance.SaveMusterija(m);
                    System.Windows.Forms.MessageBox.Show("Musterija uspesno sacuvana");
                    ResetForm(UCAddMusterija);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musterija vec postoji u bazi");
                    return;
                }
                //Communication.Communication.Instance.SaveMusterija(m);
                //System.Windows.Forms.MessageBox.Show("Musterija uspesno sacuvana");
                //ResetForm(UCAddMusterija);
            }
            catch (Exception)
            {

                //System.Windows.Forms.MessageBox.Show("NE POSTOJI MUSTERIJA");
            }
        }

        internal void Update(UCUpdateMusterija uCUpdateMusterija)
        {
            if (uCUpdateMusterija.CbMusterije.SelectedItem==null)
            {
                System.Windows.Forms.MessageBox.Show("Niste izabrali musteriju koju zelite da izmenite");
                return;
            }
            if(!UserControlHelpers.CapitalLetterValidation(uCUpdateMusterija.TxtImeUpdate,uCUpdateMusterija.LblIme)
                | !UserControlHelpers.CapitalLetterValidation(uCUpdateMusterija.TxtPrezimeUpdate,uCUpdateMusterija.LblPrezime)
                | !UserControlHelpers.PhoneNumberValidation(uCUpdateMusterija.TxtBrojTelefonaUpdate,uCUpdateMusterija.LblBrojTelefona)
                | !UserControlHelpers.DateValidation(uCUpdateMusterija.DtpDatumUpdate,uCUpdateMusterija.LblDatum)
                )
            {
                return;
            }
            try
            {
                Musterija m = new Musterija
                {
                    JMBG = uCUpdateMusterija.JMBG,
                    Ime = uCUpdateMusterija.TxtImeUpdate.Text,
                    Prezime = uCUpdateMusterija.TxtPrezimeUpdate.Text,
                    BrojTelefona = uCUpdateMusterija.TxtBrojTelefonaUpdate.Text,
                    DatumRodjenja = uCUpdateMusterija.DtpDatumUpdate.Value
                };
                Communication.Communication.Instance.UpdateMusterija(m);
                System.Windows.Forms.MessageBox.Show("Musterija uspesno izmenjena");
                ResetForm(uCUpdateMusterija);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void SearchMusterijaIme(UCSearchMusterija uCSearchMusterija)
        {
            Musterija m = new Musterija
            {
                Ime = uCSearchMusterija.TxtIme.Text
            };

            try
            {
                uCSearchMusterija.DgvMusterija.DataSource = Communication.Communication.Instance.SearchMusterijaIme(m);
                System.Windows.Forms.MessageBox.Show("Postoji musterija sa zadatim imenom");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Nema musterija za zadatim imenom");
            }
        }

        internal void UpdateFill(UCUpdateMusterija uCUpdateMusterija)
        {
            Musterija m = (Musterija)uCUpdateMusterija.CbMusterije.SelectedItem;
            
            uCUpdateMusterija.TxtImeUpdate.Text = m.Ime;
            uCUpdateMusterija.TxtPrezimeUpdate.Text = m.Prezime;
            uCUpdateMusterija.TxtBrojTelefonaUpdate.Text = m.BrojTelefona;
            uCUpdateMusterija.DtpDatumUpdate.Value = m.DatumRodjenja;
            uCUpdateMusterija.JMBG = m.JMBG;
            System.Windows.Forms.MessageBox.Show("Ucitana musterija");
        }

        internal void SearchMusterijaIme(UCUpdateMusterija uCUpdateMusterija)
        {
            Musterija m = new Musterija
            {
                Ime = uCUpdateMusterija.TxtIme.Text
            };

            try
            {
                uCUpdateMusterija.CbMusterije.DataSource = Communication.Communication.Instance.SearchMusterijaIme(m);
                System.Windows.Forms.MessageBox.Show("Postoji musterija sa zadatim imenom");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Nema musterija za zadatim imenom");
            }
        }

        internal void SearchMusterijaPrezime(UCSearchMusterija uCSearchMusterija)
        {
            Musterija m = new Musterija
            {
                Prezime = uCSearchMusterija.TxtPrezime.Text
            };

            try
            {
                uCSearchMusterija.DgvMusterija.DataSource = Communication.Communication.Instance.SearchMusterijaPrezime(m);
                System.Windows.Forms.MessageBox.Show("Postoji musterija sa zadatim prezimenom");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Nema musterija za zadatim prezimenom");
            }
        }

        internal void SearchMusterijaPrezime(UCUpdateMusterija uCUpdateMusterija)
        {
            Musterija m = new Musterija
            {
                Prezime = uCUpdateMusterija.TxtPrezime.Text
            };

            try
            {
                uCUpdateMusterija.CbMusterije.DataSource = Communication.Communication.Instance.SearchMusterijaPrezime(m);
                System.Windows.Forms.MessageBox.Show("Postoji musterija sa zadatim prezimenom");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Nema musterija za zadatim prezimenom");
            }
        }

        internal void InitUCMusterija(UCAddMusterija uCAddMusterija)
        {
            
        }

        internal void ResetForm(UCAddMusterija uCAddMusterija)
        {
            uCAddMusterija.TxtJMBG.Clear();
            uCAddMusterija.TxtIme.Clear();
            uCAddMusterija.TxtPrezime.Clear();
            uCAddMusterija.TxtBrojTelefona.Clear();
            DateTime dt = DateTime.Now;
            uCAddMusterija.DtpDatumRodjenja.Value = dt;
            uCAddMusterija.LblIme.Text = "";
            uCAddMusterija.LblPrezime.Text = "";
            uCAddMusterija.LblBrojTelefona.Text = "";
            uCAddMusterija.LblJMBG.Text = "";
            uCAddMusterija.LblDatum.Text = "";

        }

        internal void ResetForm(UCUpdateMusterija uCUpdateMusterija)
        {
            uCUpdateMusterija.TxtImeUpdate.Clear();
            uCUpdateMusterija.TxtPrezimeUpdate.Clear();
            uCUpdateMusterija.TxtBrojTelefonaUpdate.Clear();
            DateTime dt = DateTime.Now;
            uCUpdateMusterija.DtpDatumUpdate.Value = dt;
            uCUpdateMusterija.LblIme.Text = "";
            uCUpdateMusterija.LblPrezime.Text = "";
            uCUpdateMusterija.LblBrojTelefona.Text = "";
            uCUpdateMusterija.LblDatum.Text = "";
        }
    }
}
