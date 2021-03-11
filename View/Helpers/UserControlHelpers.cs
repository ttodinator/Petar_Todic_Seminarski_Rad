using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace View.Helpers
{
    public class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool JMBGFieldValidation(TextBox txt,Label label)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else if (txt.Text.Length!=13 || !txt.Text.All(char.IsDigit))
            {
                
                label.Text = "JMBG MORA IMATI 13 CIFARA";
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool CapitalLetterValidation(TextBox txt, Label label)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else if (char.IsLower(txt.Text[0]))
            {

                label.Text = "Mora poceti velikim slovom";
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool RegistrationValidation(TextBox txt, Label label)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            if (txt.Text.Length!=7)
            {
                label.Text = "Registracija se sastoji od 7 karaktera";
                return false;
            }
            for (int i = 0; i < 2; i++)
            {
                if(!char.IsLetter(txt.Text[i]) || char.IsLower(txt.Text[i]))
                {
                    label.Text = "Prva dva karaktera moraju biti velika slova";
                    return false;
                }
            }

            for (int i = 2; i < 5; i++)
            {
                if (!char.IsDigit(txt.Text[i]))
                {
                    label.Text = "Nakon 2 slova mora da sledi 3 cifre";
                    return false;
                }
            }

            for (int i = 5; i < 7; i++)
            {
                if (!char.IsLetter(txt.Text[i]) || char.IsLower(txt.Text[i]))
                {
                    label.Text = "Poslednja dva karaktera moraju biti velika slova";
                    return false;
                }
            }

            return true;

        }

        public static bool VINNumberValidation(TextBox txt, Label label)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            if (txt.Text.Length != 17)
            {
                label.Text = "Broj sasije se sastoji od 17 karaktera";
                return false;
            }
            return true;

        }

        public static bool DoubleValidation(TextBox txt,Label label)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            if (txt.Text.Contains("."))
            {
                label.Text = "Koristite zapetu umesto tacke za decimalne brojeve";
                return false;
            }
            
            try
            {
                double k=double.Parse(txt.Text);
                //Double.TryParse(txt.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out _);
                if (k < 0)
                {
                    label.Text = "Morate uneti cenu koja je pozitivna";
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                label.Text = "Morate uneti broj";
                return false;
            }
        }

        public static bool PhoneNumberValidation(TextBox txt, Label label)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else if (!txt.Text.All(char.IsDigit))
            {

                label.Text = "Broj telefona sadrzi samo cifre";
                return false;
            }
            else if(!txt.Text.StartsWith("381"))
            {
                label.Text = "Broj telefona mora poceti sa 381";
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool DateValidation(DateTimePicker dtp, Label label)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime dtNow = DateTime.Now;
            DateTime dtSelected = dtp.Value;
            if (dtNow.Year == dtSelected.Year)
            {
                label.Text = "Musterija mora biti punoletna";
                return false;
            }
            TimeSpan ts = dtNow - dtSelected;
            int years = (zeroTime + ts).Year - 1;
            if (years < 18)
            {
                label.Text = "Musterija mora biti punoletna";
                return false;
            }
            
            return true;

        }

        public static bool DateRentiranjeValidation(DateTimePicker dtp1,DateTimePicker dtp2,Label label)
        {
            DateTime datumDo = dtp1.Value.Date;
            DateTime datumOd = dtp2.Value.Date;
            DateTime now = DateTime.Now.Date;
            TimeSpan ts1 = datumDo - now;
            double br1 =ts1.TotalDays;
            TimeSpan ts2 = datumOd - now;
            double br2 =ts2.TotalDays;
            TimeSpan ts3 = datumDo - datumOd;
            double br3 = ts3.TotalDays;

            if (br1<1)
            {
                label.Text = "Datum do mora biti ili sutrasnji ili neki datum u budcnosti";
                return false;
            }
            if (br2 < 0)
            {
                label.Text = "Datum od mora biti ili danasnji ili neki datum u buducnosti";
                return false;
            }
            if (br3==0)
            {
                label.Text = "Datum od i Datum do ne mogu biti isti";
                return false;
            }
            if (br3<0)
            {
                label.Text = "Datum do ne moze biti pre Datuma od";
                return false;
            }
            return true;
        }

        public static bool DateRentiranjeValidation(DateTimePicker dtp,Label label)
        {
            DateTime datum = dtp.Value.Date;
            DateTime now = DateTime.Now.Date;
            TimeSpan ts = datum - now;
            double broj = ts.TotalDays;
            if (broj < 0)
            {
                label.Text = "Datum mora biti sadasnji ili neki u buducnosti";
                return false;
            }
            return true;
        }

        public static bool ComboBoxValidation(ComboBox cmb, Label label)
        {
            if (cmb.SelectedItem == null)
            {
                label.Text = "Morate izabrati vrednost iz padajuce liste";
                return false;
            }
            if (cmb.Items.Count==0)
            {
                label.Text= "Morate izabrati vrednost iz padajuce liste";
                return false;
            }
            if (cmb.DataSource == null)
            {
                label.Text = "Morate izabrati vrednost iz padajuce liste";
                return false;
            }
            return true;

        }
    }
}
