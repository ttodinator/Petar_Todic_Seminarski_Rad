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
    public partial class UCSearchMusterija : UserControl
    {

        public TextBox TxtIme { get => txtIme; }
        public TextBox TxtPrezime { get => txtPrezime; }

        public DataGridView DgvMusterija { get => dgvMusterije; set { } }

        private MusterijaController musterijaController;
        public UCSearchMusterija(MusterijaController musterijaController)
        {
            this.musterijaController = musterijaController;
            InitializeComponent();
        }

        private void btnSearchIme_Click(object sender, EventArgs e)
        {
            musterijaController.SearchMusterijaIme(this);
            dgvMusterije.Refresh();
        }

        private void btnSearchPrezime_Click(object sender, EventArgs e)
        {
            musterijaController.SearchMusterijaPrezime(this);
            dgvMusterije.Refresh();
        }
    }
}
