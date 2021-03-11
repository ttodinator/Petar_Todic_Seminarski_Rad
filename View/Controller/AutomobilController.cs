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
    public class AutomobilController
    {
        internal void InitUCAddAutomobil(UCAddAutomobil ucAddAutomobil)
        {
            List<int> godista = new List<int>();
            for (int i = 1980; i < 2021; i++)
            {
                godista.Add(i);

            }
            //ucAddAutomobil.CbGodiste.DataSource = Communication.Communication.Instance.GetAllMarka();
            ucAddAutomobil.CbMarka.DataSource = Communication.Communication.Instance.GetAllMarka();
            ucAddAutomobil.CbGodiste.DataSource = godista;
            
        }

        internal void InitUCUpdateAutomobil(UCUpdateAutomobil uCUpdateAutomobil)
        {
            List<int> godista = new List<int>();
            for (int i = 1980; i < 2021; i++)
            {
                godista.Add(i);

            }
            //ucAddAutomobil.CbGodiste.DataSource = Communication.Communication.Instance.GetAllMarka();
            uCUpdateAutomobil.CbMarka.DataSource = Communication.Communication.Instance.GetAllMarka();
            uCUpdateAutomobil.CbGodiste.DataSource = godista;

        }

        internal void Save(UCAddAutomobil uCAddAutomobil)
        {
            if (!UserControlHelpers.RegistrationValidation(uCAddAutomobil.TxtRegistracija,uCAddAutomobil.LblRegistracija)
                | !UserControlHelpers.DoubleValidation(uCAddAutomobil.TxtCenaPoDanu,uCAddAutomobil.LblCenaPoDanu)
                | !UserControlHelpers.VINNumberValidation(uCAddAutomobil.TxtBrojSasije,uCAddAutomobil.LblBrojSasije)
                | !UserControlHelpers.ComboBoxValidation(uCAddAutomobil.CbMarka,uCAddAutomobil.LblMarka)
                | !UserControlHelpers.ComboBoxValidation(uCAddAutomobil.CbModel,uCAddAutomobil.LblModel)
                )
            {
                
                return;
            }
            try
            {
                Automobil a = new Automobil
                {
                    BrojSasije = uCAddAutomobil.TxtBrojSasije.Text,
                    Registracija = uCAddAutomobil.TxtRegistracija.Text,
                    CenaPoDanu = double.Parse(uCAddAutomobil.TxtCenaPoDanu.Text),
                    Model = (Model)uCAddAutomobil.CbModel.SelectedItem,
                    GodinaProizvodnje = (int)uCAddAutomobil.CbGodiste.SelectedItem

                };

                if (Communication.Communication.Instance.AutomobilBrojSasijeCheck(a))
                {
                    Communication.Communication.Instance.SaveAutomobil(a);
                    System.Windows.Forms.MessageBox.Show("Automobil je sacuvan");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Vec postoji automobil sa ovim brojem sasije");
                    return;
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void DeleteAutomobil(UCUpdateAutomobil uCUpdateAutomobil)
        {
            if ((Automobil)uCUpdateAutomobil.ComboBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Niste izabrali automobil");
                return;
            }
            Automobil a = (Automobil)uCUpdateAutomobil.ComboBox.SelectedItem;
            try
            {
                Communication.Communication.Instance.DeleteAutomobil(a);
                System.Windows.Forms.MessageBox.Show("Automobil je uspesno obrisan");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Automobil ne moze biti obrisan jer postoji rentiranje u kome ucestvuje");
            }
        }

        internal void UpdateAutomobil(UCUpdateAutomobil uCUpdateAutomobil)
        {
            if (uCUpdateAutomobil.ComboBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Niste izabrali automobil koji zelite da izmenite");
                return;
            }
            if(!UserControlHelpers.ComboBoxValidation(uCUpdateAutomobil.CbMarka,uCUpdateAutomobil.LblMarka)
                | !UserControlHelpers.ComboBoxValidation(uCUpdateAutomobil.CbModel,uCUpdateAutomobil.LblModel)
                | !UserControlHelpers.RegistrationValidation(uCUpdateAutomobil.TxtRegistracijaUpdate,uCUpdateAutomobil.LblRegistracija)
                | !UserControlHelpers.DoubleValidation(uCUpdateAutomobil.TxtCenaUpdate,uCUpdateAutomobil.LblCenaPoDanu)

                )
            {
                return;
            }
            try
            {
                Automobil a = new Automobil
                {
                    BrojSasije=uCUpdateAutomobil.BrojSasije,
                    Registracija=uCUpdateAutomobil.TxtRegistracijaUpdate.Text,
                    CenaPoDanu=double.Parse(uCUpdateAutomobil.TxtCenaUpdate.Text),
                    GodinaProizvodnje=(int)uCUpdateAutomobil.CbGodiste.SelectedItem,
                    Model=(Model)uCUpdateAutomobil.CbModel.SelectedItem
                };
                Communication.Communication.Instance.UpdateAutomobil(a);
                System.Windows.Forms.MessageBox.Show("Automobil uspesno sacuvan");
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void UpdateModel(UCUpdateAutomobil uCUpdateAutomobil)
        {
            uCUpdateAutomobil.CbModel.DataSource = Communication.Communication.Instance.GetAllModel((Marka)uCUpdateAutomobil.CbMarka.SelectedItem);
        }

        internal void UpdateFill(UCUpdateAutomobil uCUpdateAutomobil)
        {
            Automobil a = (Automobil)uCUpdateAutomobil.ComboBox.SelectedItem;
            uCUpdateAutomobil.TxtCenaUpdate.Text = a.CenaPoDanu.ToString();
            uCUpdateAutomobil.TxtRegistracijaUpdate.Text = a.Registracija;
            uCUpdateAutomobil.CbMarka.SelectedIndex = uCUpdateAutomobil.CbMarka.FindStringExact(a.Model.Marka.ToString());
            uCUpdateAutomobil.CbModel.DataSource = Communication.Communication.Instance.GetAllModel(a.Marka);
            //System.Windows.Forms.MessageBox.Show($"{a.Model.Naziv} {a.Model.Verzija}");
            uCUpdateAutomobil.CbGodiste.SelectedIndex = uCUpdateAutomobil.CbGodiste.FindStringExact(a.GodinaProizvodnje.ToString());
            uCUpdateAutomobil.CbModel.SelectedIndex = uCUpdateAutomobil.CbModel.FindStringExact($"{a.Model.Naziv} {a.Model.Verzija}");
            //uCUpdateAutomobil.CbMarka.Text = a.Model.Marka.ToString();
            //uCUpdateAutomobil.CbModel.Text = a.Model.ToString();
            uCUpdateAutomobil.BrojSasije = a.BrojSasije;
            
        }

        internal void SearchAutomobilBrSasije(UCSearchAutomobil uCSearchAutomobil)
        {
            Automobil a = new Automobil
            {
                BrojSasije = uCSearchAutomobil.TxtBrSasisije.Text
            };
            try
            {
                uCSearchAutomobil.DgvAutomobili.DataSource = Communication.Communication.Instance.SearchAutomobilBrSasije(a);
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Nema automobila sa zadatim brojem sasije");
            }
        }

        internal void SearchAutomobilRegistracija(UCSearchAutomobil uCSearchAutomobil)
        {
            Automobil a = new Automobil
            {
                Registracija = uCSearchAutomobil.TxtRegistracija.Text
            };
            try
            {
                uCSearchAutomobil.DgvAutomobili.DataSource = Communication.Communication.Instance.SearchAutomobilRegistracija(a);
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Ne postoji Automobil sa datom registracijom");
            }

        }

        internal void SearchAutomobilRegistracija(UCUpdateAutomobil uCUpdateAutomobil)
        {
            Automobil a = new Automobil
            {
                Registracija = uCUpdateAutomobil.TxtRegistracija.Text
            };
            try
            {
                uCUpdateAutomobil.ComboBox.DataSource = Communication.Communication.Instance.SearchAutomobilRegistracija(a);
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Ne postoji Automobil sa datom registracijom");
            }

        }

        internal void SearchAutomobilBrSasije(UCUpdateAutomobil uCUpdateAutomobil)
        {
            Automobil a = new Automobil
            {
                BrojSasije = uCUpdateAutomobil.TxtBrojSasije.Text
            };
            try
            {
                List<Automobil> automobili= Communication.Communication.Instance.SearchAutomobilBrSasije(a);
                uCUpdateAutomobil.ComboBox.DataSource = automobili;

            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Ne postoji Automobil sa datom registracijom");
            }

        }

        internal void GetAllModel(UCAddAutomobil uCAddAutomobil)
        {
            uCAddAutomobil.CbModel.DataSource = Communication.Communication.Instance.GetAllModel((Marka)uCAddAutomobil.CbMarka.SelectedItem);
        }


    }
}
