using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using View.Helpers;

namespace View.Dialog
{
    public partial class AddStavkaRenitranjaDialog : Form
    {
        private int redniBroj;
        public StavkaRentiranja stavkaRentiranja { get; set; }
        public AddStavkaRenitranjaDialog(int redniBroj)
        {
            InitializeComponent();
            this.redniBroj = redniBroj;
            cbAutomobil.DataSource = Communication.Communication.Instance.GetAllAutomobil();
            cbPolisa.DataSource = Communication.Communication.Instance.GetAllPolisa();
        }

        private void btnAddStavka_Click(object sender, EventArgs e)
        {
            if(!UserControlHelpers.ComboBoxValidation(cbAutomobil,lblAutomobil)
                | !UserControlHelpers.ComboBoxValidation(cbPolisa,lblPolisa)
                | !UserControlHelpers.DateRentiranjeValidation(dtpDatumDo,dtpDatumOd,lblDatumDo)
                )
            {
                return;
            }
            stavkaRentiranja = new StavkaRentiranja
            {
                RedniBroj = redniBroj,
                DatumOd = dtpDatumOd.Value,
                DatumDo = dtpDatumDo.Value,
                Automobil = (Automobil)cbAutomobil.SelectedItem,
                Polisa = (Polisa)cbPolisa.SelectedItem

            };
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
