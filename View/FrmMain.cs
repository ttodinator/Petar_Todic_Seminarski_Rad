using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View
{
    public partial class FrmMain : Form
    {
        private MainController mainController;
        public FrmMain(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void novaMusterijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddMusterija(this);
        }

        public void SetPanel(UserControl userControl)
        {
            pnlMainContainer.Controls.Clear();
            userControl.Parent = pnlMainContainer;
            userControl.Dock = DockStyle.Fill;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.CloseMainForm();
        }

        private void pretragaMusterijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCSearchMusterija(this);
        }

        private void novAutomobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddAutomobil(this);
        }

        private void pretragaAutomobilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCSearchAutomobil(this);
        }

        private void izmenaMusterijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUpdateMusterija(this);
        }

        private void izmenaAutomobilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUpdateAutomobil(this);
        }

        private void novoRentiranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddRentiranje(this);
        }

        private void izmenaRentiranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUpdateRentiranje(this);
        }
    }
}
