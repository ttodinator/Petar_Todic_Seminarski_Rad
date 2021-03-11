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
    public partial class UCUpdateRentiranje : UserControl
    {
        private Rentiranjekontroler rentiranjekontroler;

        public TextBox TxtPretragaImePrezime { get=>txtPretragaImePrezime; set { } }
        public DateTimePicker DtpDatum { get=>dtpDatum; set { } }
        public ComboBox CbPretraga { get=>cbPretraga; set { } }
        public ComboBox CbMusterijaUpdate { get=>cbMusterija; set { } }

        //public DateTimePicker DtpDatumUpdate { get=>dtpDatumUpdate; set { } }

        public Label LblUkupnaCena { get=>lblUkupnaCena; set { } }
        public Label LblDatum { get => lblDatum; set { } }
        public Label LblDatumShow { get => lblDatumShow; set { } }
        public Label LblMusterija { get => lblMusterija; set { } }

        public DataGridView DgvStavkeRentiranja { get=>dgvStavkeRentiranja; set { } }
        public UCUpdateRentiranje(Rentiranjekontroler rentiranjekontroler)
        {
            this.rentiranjekontroler = rentiranjekontroler;
            InitializeComponent();
            rentiranjekontroler.InitForm(this);
        }

        private void btnSearchImePrezime_Click(object sender, EventArgs e)
        {
            if (rBIme.Checked)
            {
                //MessageBox.Show("Izabran prvi");
                rentiranjekontroler.SarchIme();
            }else if (rBPrezime.Checked)
            {
                rentiranjekontroler.SarchPrezime();
                //MessageBox.Show("Izabran drugi");

            }
            else
            {
                MessageBox.Show("Nije izabran nijedan kritererijum pretrage");
                return;
            }
        }

        private void btnSearchDatum_Click(object sender, EventArgs e)
        {
            rentiranjekontroler.SearchDatum();
        }

        private void cbPretraga_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rentiranjekontroler.UpdateFill();
        }

        private void UCUpdateRentiranje_Load(object sender, EventArgs e)
        {
            rentiranjekontroler.InitUCUpdateRentiranje();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rentiranjekontroler.AddStavkaRentiranjaUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rentiranjekontroler.RemoveStavkaUpdate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            rentiranjekontroler.UpdateRentiranje();
        }
    }
}
