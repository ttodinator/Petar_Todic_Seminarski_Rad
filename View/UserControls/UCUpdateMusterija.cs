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
    public partial class UCUpdateMusterija : UserControl
    {
        private MusterijaController musterijaController;

        public TextBox TxtIme { get => txtIme; }

        public string JMBG { get; set; }
        public TextBox TxtPrezime { get => txtPrezime; }

        public TextBox TxtImeUpdate { get => txtImeUpdate;set { } }
        public TextBox TxtPrezimeUpdate { get => txtPrezimeUpdate;set { } }
        public TextBox TxtBrojTelefonaUpdate { get => txtBrojUpdate;set { } }

        public DateTimePicker DtpDatumUpdate { get => dtpDatumUpdate;set { } }

        public Label LblIme { get => lblIme; set { } }
        public Label LblPrezime { get => lblPrezime; set { } }
        public Label LblBrojTelefona { get => lblBrojTelefona; set { } }
        public Label LblDatum { get => lblDatum; set { } }


        public ComboBox CbMusterije { get=>cbPretraga; set { } }



        public UCUpdateMusterija(MusterijaController musterijaController)
        {
            this.musterijaController = musterijaController;
            InitializeComponent();
        }

        private void btnIme_Click(object sender, EventArgs e)
        {
            musterijaController.SearchMusterijaIme(this);
        }

        private void btnPrezime_Click(object sender, EventArgs e)
        {
            musterijaController.SearchMusterijaPrezime(this);
        }

        private void cbPretraga_SelectionChangeCommitted(object sender, EventArgs e)
        {
            musterijaController.UpdateFill(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cbPretraga.Refresh();
            musterijaController.Update(this);
            //KreirajUc(new UCUpdateMusterija(musterijaController), this);
            /*txtImeUpdate.Text = "";
            txtPrezimeUpdate.Text = "";
            txtBrojUpdate.Text = "";
            dtpDatumUpdate.Value = DateTime.Now;
            cbPretraga.DataSource = null;*/
        }

        private void KreirajUc(UserControl u1,UserControl u2)
        {
            u2.Controls.Clear();
            u1.Parent = u2;
            u1.Dock = DockStyle.Fill;
        }
    }
}
