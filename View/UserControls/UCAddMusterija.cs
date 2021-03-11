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
    public partial class UCAddMusterija : UserControl
    {
        private MusterijaController musterijaController;

        public TextBox TxtJMBG { get => txtJMBG; }
        public TextBox TxtIme { get=>txtIme; }
        public TextBox TxtPrezime { get=>txtPrezime; }
        public TextBox TxtBrojTelefona { get=>txtBrojTelefona;}
        public Label LblJMBG { get=>lblJMBG; set { } }
        public Label LblIme { get => lblIme; set { } }
        public Label LblPrezime { get => lblPrezime; set { } }
        public Label LblBrojTelefona { get => lblBrojTelefona; set { } }
        public Label LblDatum { get => lblDatum; set { } }


        public DateTimePicker DtpDatumRodjenja { get=>dtpDatumRodjenja;}

        public UCAddMusterija(MusterijaController musterijaController)
        {
            InitializeComponent();
            this.musterijaController = musterijaController;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            musterijaController.Save(this);
        }

        private void UCAddMusterija_Load(object sender, EventArgs e)
        {
            musterijaController.InitUCMusterija(this);
        }
    }
}
