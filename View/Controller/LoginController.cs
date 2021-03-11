using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communication;
using View.Helpers;
using Domain;

namespace View.Controller
{
    public class LoginController
    {
        internal bool Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                System.Windows.Forms.MessageBox.Show("Neuspesno povezivanje sa serverom");
                return false;
            }
        }

        internal void Login(TextBox txtKorisnickoIme,TextBox txtLozinka,FrmLogin frmLogin)
        {
            if(!UserControlHelpers.EmptyFieldValidation(txtKorisnickoIme) | !UserControlHelpers.EmptyFieldValidation(txtLozinka))
            {
                return;
            }
            try
            {
                Zaposleni z = Communication.Communication.Instance.Login(txtKorisnickoIme.Text, txtLozinka.Text);
                MainCoordinator.Instance.Zaposleni = z;
                MessageBox.Show($"Zaposleni: {z.Ime} {z.Prezime} se ulogovao");
                MainCoordinator.Instance.OpenMainForm();
                frmLogin.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
