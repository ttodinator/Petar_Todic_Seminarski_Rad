using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        public FrmLogin(LoginController loginController)
        {
            this.loginController = loginController;
            InitializeComponent();
            txtKorisnickoIme.Text = "mixa";
            txtLozinka.Text = "mixa";
        }

        private void btnUloguj_Click(object sender, EventArgs e)
        {
            if (loginController.Connect())
                loginController.Login(txtKorisnickoIme, txtLozinka, this);
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
