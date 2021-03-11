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
using View.Dialog;
using Domain;

namespace View.UserControls
{
    public partial class UCAddRentiranje : UserControl
    {
        private Rentiranjekontroler rentiranjekontroler;

        public ComboBox CbMusterija { get=>cbMusterija; set { } }
        //public DateTimePicker DtpDatum { get => dtpDatum; set { } }
        public DataGridView DgvStavka { get => dgvStavka; set { } }
        public Label LblUkupnaCena { get => lblUkupnaCena; set { } }
        public Label LblMusterija { get => lblMusterija; set { } }
        public Label LblDatum { get => lblDatum; set { } }
        public Label LblDatumShow { get => lblDatumShow; set { } }


        public UCAddRentiranje(Rentiranjekontroler rentiranjekontroler)
        {
            this.rentiranjekontroler = rentiranjekontroler;
            InitializeComponent();
            //dgvStavka.DataSource = stavkeRentiranja;
            rentiranjekontroler.InitForm(this);
        }

        private void UCAddRentiranje_Load(object sender, EventArgs e)
        {
            rentiranjekontroler.InitUCAddRentiranje(this);
        }

        private BindingList<StavkaRentiranja> stavkeRentiranja = new BindingList<StavkaRentiranja>();
        public BindingList<StavkaRentiranja> StavkeRentiranja { get=>stavkeRentiranja; set { } }

        private void btnAddStavka_Click(object sender, EventArgs e)
        {
            rentiranjekontroler.AddStavkaRentiranja();
            /*int broj = stavkeRentiranja.Count + 1;
            AddStavkaRenitranjaDialog dialog = new AddStavkaRenitranjaDialog(broj);
            dialog.ShowDialog();
            if (dialog.stavkaRentiranja != null)
            {
                stavkeRentiranja.Add(dialog.stavkaRentiranja);
                
            }*/
           
        }

        private void btnRemoveStavka_Click(object sender, EventArgs e)
        {
            rentiranjekontroler.RemoveStavka();
            /*if (dgvStavka.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStavka.SelectedRows[0];
                StavkaRentiranja stavka = (StavkaRentiranja)row.DataBoundItem;
                stavkeRentiranja.Remove(stavka);
                for (int i = 0; i < stavkeRentiranja.Count; i++)
                {
                    stavkeRentiranja[i].RedniBroj = i + 1;
                }
            
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rentiranjekontroler.SaveRentiranje();
        }

        private void dgvStavka_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //rentiranjekontroler.UpdateUkupnaCena();
        }
    }
}
