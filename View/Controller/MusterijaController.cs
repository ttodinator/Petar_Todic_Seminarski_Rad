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
                    DatumRodjenja = UCAddMusterija.DtpDatumRodjenja.Value,
                    WhereCondition="m.JMBG=",
                    WhereValue= UCAddMusterija.TxtJMBG.Text
                };
                /*List<Musterija> musterijaJMBG;
                if (Communication.Communication.Instance.SearchMusterijaJMBG(m))
                {
                    Communication.Communication.Instance.SaveMusterija(m);
                    System.Windows.Forms.MessageBox.Show("Musterija uspesno sacuvana");
                    ResetForm(UCAddMusterija);
                }
                else
                {
                    musterijaJMBG = Communication.Communication.Instance.SearchMusterija(m);
                    System.Windows.Forms.MessageBox.Show("Musterija vec postoji u bazi");
                    return;
                }*/
                Communication.Communication.Instance.SaveMusterija(m);
                System.Windows.Forms.MessageBox.Show("Musterija uspesno sacuvana");
                ResetForm(UCAddMusterija);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
                    /*JMBG = uCUpdateMusterija.JMBG,
                    Ime = uCUpdateMusterija.TxtImeUpdate.Text,
                    Prezime = uCUpdateMusterija.TxtPrezimeUpdate.Text,
                    BrojTelefona = uCUpdateMusterija.TxtBrojTelefonaUpdate.Text,
                    DatumRodjenja = uCUpdateMusterija.DtpDatumUpdate.Value*/
                    WhereCondition = "JMBG=",
                    WhereValue = $"'{uCUpdateMusterija.JMBG}'",
                    UpdateText = $"Ime='{uCUpdateMusterija.TxtImeUpdate.Text}',Prezime='{uCUpdateMusterija.TxtPrezimeUpdate.Text}', BrojTelefona='{uCUpdateMusterija.TxtBrojTelefonaUpdate.Text}', DatumRodjenja='{uCUpdateMusterija.DtpDatumUpdate.Value.ToString("MM/dd/yyyy")}'"

            };
                Communication.Communication.Instance.UpdateMusterija(m);
                System.Windows.Forms.MessageBox.Show("Musterija uspesno izmenjena");
                ResetForm(uCUpdateMusterija);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void SearchMusterijaIme(UCSearchMusterija uCSearchMusterija)
        {
            try
            {
                Musterija m = new Musterija
                {
                    Ime = uCSearchMusterija.TxtIme.Text,
                    WhereValue = uCSearchMusterija.TxtIme.Text,
                    WhereCondition = "m.Ime="

                };
                if (Communication.Communication.Instance.SearchMusterijaIme(m))
                {
                    System.Windows.Forms.MessageBox.Show("Ne postoji musterija sa tim imenom");

                }
                else
                {
                    uCSearchMusterija.DgvMusterija.DataSource = Communication.Communication.Instance.SearchMusterija(m);
                    System.Windows.Forms.MessageBox.Show("Postoji musterija sa zadatim imenom");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void UpdateFill(UCUpdateMusterija uCUpdateMusterija)
        {
            try
            {
                Musterija m = (Musterija)uCUpdateMusterija.CbMusterije.SelectedItem;

                uCUpdateMusterija.TxtImeUpdate.Text = m.Ime;
                uCUpdateMusterija.TxtPrezimeUpdate.Text = m.Prezime;
                uCUpdateMusterija.TxtBrojTelefonaUpdate.Text = m.BrojTelefona;
                uCUpdateMusterija.DtpDatumUpdate.Value = m.DatumRodjenja;
                uCUpdateMusterija.JMBG = m.JMBG;
                System.Windows.Forms.MessageBox.Show("Ucitana musterija");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void SearchMusterijaIme(UCUpdateMusterija uCUpdateMusterija)
        {
            try
            {
                Musterija m = new Musterija
                {
                    Ime = uCUpdateMusterija.TxtIme.Text,
                    WhereValue = uCUpdateMusterija.TxtIme.Text,
                    WhereCondition = "m.Ime="
                };

                if (Communication.Communication.Instance.SearchMusterijaIme(m))
                {
                    System.Windows.Forms.MessageBox.Show("Ne postoji musterija sa zadatim imenom");

                }
                else
                {
                    uCUpdateMusterija.CbMusterije.DataSource = Communication.Communication.Instance.SearchMusterija(m);
                    System.Windows.Forms.MessageBox.Show("Postoji musterija sa zadatim imenom");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void SearchMusterijaPrezime(UCSearchMusterija uCSearchMusterija)
        {
            try
            {
                Musterija m = new Musterija
                {
                    Prezime = uCSearchMusterija.TxtPrezime.Text,
                    WhereValue = uCSearchMusterija.TxtPrezime.Text,
                    WhereCondition = "m.Prezime="
                };
                if (Communication.Communication.Instance.SearchMusterijaPrezime(m))
                {
                    System.Windows.Forms.MessageBox.Show("Ne postoji musterija sa zadatim prezimenom");

                }
                else
                {
                    uCSearchMusterija.DgvMusterija.DataSource = Communication.Communication.Instance.SearchMusterija(m);
                    System.Windows.Forms.MessageBox.Show("Postoji musterija sa zadatim prezimenom");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        internal void SearchMusterijaPrezime(UCUpdateMusterija uCUpdateMusterija)
        {
            try
            {
                Musterija m = new Musterija
                {
                    Prezime = uCUpdateMusterija.TxtPrezime.Text,
                    WhereValue = uCUpdateMusterija.TxtPrezime.Text,
                    WhereCondition = "m.Prezime="
                };
                if (Communication.Communication.Instance.SearchMusterijaPrezime(m))
                {
                    System.Windows.Forms.MessageBox.Show("Ne postoji musterija sa zadatim prezimenom");


                }
                else
                {
                    uCUpdateMusterija.CbMusterije.DataSource = Communication.Communication.Instance.SearchMusterija(m);
                    System.Windows.Forms.MessageBox.Show("Postoji musterija sa zadatim prezimenom");
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
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
            uCUpdateMusterija.CbMusterije.DataSource = null;
            uCUpdateMusterija.TxtIme.Clear();
            uCUpdateMusterija.TxtPrezime.Clear();
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
