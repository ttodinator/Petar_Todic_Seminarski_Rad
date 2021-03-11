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
    public partial class UCSearchAutomobil : UserControl
    {
        private AutomobilController automobilController;

        public TextBox TxtRegistracija { get => txtRegistracija; }
        public TextBox TxtBrSasisije { get => txtBrojSasije; }

        public DataGridView DgvAutomobili { get => dgvAutomobil; }
        public UCSearchAutomobil(AutomobilController automobilController)
        {
            this.automobilController = automobilController;
            InitializeComponent();
        }

        private void btnSearchRegistracija_Click(object sender, EventArgs e)
        {
            automobilController.SearchAutomobilRegistracija(this);
            dgvAutomobil.Refresh();
        }



        private void btnSearchBrSasije_Click(object sender, EventArgs e)
        {
            automobilController.SearchAutomobilBrSasije(this);
            dgvAutomobil.Refresh();
        }
    }
}
