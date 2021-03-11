using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.Controller
{
    public class MainController
    {
        internal void CloseMainForm()
        {
            Communication.Communication.Instance.Disconnect();
            MainCoordinator.Instance.OpenLoginForm();
        }

        internal void OpenUCAddMusterija(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddMusterija(new MusterijaController()));
        }

        internal void OpenUCSearchMusterija(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCSearchMusterija(new MusterijaController()));
        }

        internal void OpenUCAddAutomobil(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddAutomobil(new AutomobilController()));
        }

        internal void OpenUCSearchAutomobil(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCSearchAutomobil(new AutomobilController()));
        }

        internal void OpenUCUpdateMusterija(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUpdateMusterija(new MusterijaController()));
        }

        internal void OpenUCUpdateAutomobil(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUpdateAutomobil(new AutomobilController()));
        }

        internal void OpenUCAddRentiranje(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddRentiranje(new Rentiranjekontroler()));
        }

        internal void OpenUCUpdateRentiranje(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUpdateRentiranje(new Rentiranjekontroler()));
        }

    }
}
