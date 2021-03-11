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
    public partial class UCUpdateAutomobil : UserControl
    {

        private AutomobilController automobilController;

        public TextBox TxtRegistracija { get=>txtRegistracija; set { } }
        public TextBox TxtBrojSasije { get => txtBrojSasije; set { } }
        public TextBox TxtRegistracijaUpdate { get => txtRegistracijaUpdate; set { } }

        public TextBox TxtCenaUpdate { get => txtCenaUpdate; set { } }

        public ComboBox CbMarka { get=>cbMarkaUpdate; set { } }
        public ComboBox CbModel { get=>cbModelUpdate; set { } }

        public ComboBox CbGodiste { get => cbGodisteUpdate; set { } }

        public ComboBox ComboBox { get=> cbAutomobili; set { } }
        public Label LblMarka { get => lblMarka; set { } }
        public Label LblModel { get => lblModel; set { } }
        public Label LblRegistracija { get => lblRegistracija; set { } }
        public Label LblGodiste { get => lblGodiste; set { } }
        public Label LblCenaPoDanu { get => lblCenaPoDanu; set { } }


        public string BrojSasije { get; set; }

        public UCUpdateAutomobil(AutomobilController automobilController)
        {
            this.automobilController = automobilController;
            InitializeComponent();
        }

        private void btnSearchRegistracija_Click(object sender, EventArgs e)
        {
            automobilController.SearchAutomobilRegistracija(this);
        }

        private void btnSearchBrSasije_Click(object sender, EventArgs e)
        {
            automobilController.SearchAutomobilBrSasije(this);
        }

        private void cbAutomobili_SelectionChangeCommitted(object sender, EventArgs e)
        {
            automobilController.UpdateFill(this);
        }

        private void UCUpdateAutomobil_Load(object sender, EventArgs e)
        {
            automobilController.InitUCUpdateAutomobil(this);
        }

        private void cbMarkaUpdate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            automobilController.UpdateModel(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            automobilController.UpdateAutomobil(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            automobilController.DeleteAutomobil(this);
        }
    }
}
