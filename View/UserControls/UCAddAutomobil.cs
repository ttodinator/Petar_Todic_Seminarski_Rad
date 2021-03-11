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

namespace View.UserControls
{
    public partial class UCAddAutomobil : UserControl
    {

        private AutomobilController automobilController;

        public ComboBox CbMarka { get=>cbMarka; }
        public ComboBox CbModel { get => cbModel; }
        public ComboBox CbGodiste { get => cbGodiste; }
        public TextBox TxtBrojSasije { get => txtBrojSasije; }
        public TextBox TxtCenaPoDanu { get => txtCenaPoDanu; }
        public TextBox TxtRegistracija { get => txtRegistracija; }

        public Label LblMarka { get => lblMarka; }
        public Label LblModel { get => lblMarka; }
        public Label LblBrojSasije { get => lblBrojSasije; }
        public Label LblRegistracija { get => lblRegistracija; }
        public Label LblGodinaProizvodnje { get => lblGodinaProizvodnje; }
        public Label LblCenaPoDanu { get => lblCenaPoDanu; }

        public UCAddAutomobil(AutomobilController automobilController)
        {
            InitializeComponent();
            this.automobilController = automobilController;
        }

        private void UCAddAutomobil_Load(object sender, EventArgs e)
        {
            automobilController.InitUCAddAutomobil(this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            automobilController.Save(this);
        }
        
        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //automobilController.
            //txtBrojSasije.Text = broj.ToString();
            //broj++;

            //automobilController.GetAllModel(this);
        }

        private void cbMarka_SelectionChangeCommitted(object sender, EventArgs e)
        {
            automobilController.GetAllModel(this);
        }
    }
}
