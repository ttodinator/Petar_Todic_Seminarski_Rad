using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;
using Storage.Implementation.Database;
using Domain;
using SystemOperation;
using SystemOperation.ZaposleniSO;
using SystemOperation.MusterijaSO;
using SystemOperation.MarkaSO;
using SystemOperation.ModelSO;
using SystemOperation.AutomobilSO;
using SystemOperation.PolisaSO;
using SystemOperation.RentiranjeSO;
using SystemOperation.StavkaRentiranjaSO;

namespace Controller
{
    public class Controller
    {
        private GenericRepository repository;
        public Zaposleni Zaposleni { get; set; }
        private static Controller instance;

        private static object _lock = new object();
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }
        private Controller()
        {
            repository = new GenericRepository();
        }
        public Zaposleni Login(Zaposleni zaposleni)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(zaposleni);
            return so.Result;
        }

        public void SaveMusterija(Musterija musterija)
        {
            ZapamtiMusterijuSO so = new ZapamtiMusterijuSO();
            so.ExecuteTemplate(musterija);
        }

        public void SaveAutomobil(Automobil automobil)
        {
            ZapamtiAutomobilSO so = new ZapamtiAutomobilSO();
            so.ExecuteTemplate(automobil);
        }

        public List<Marka> GetAllMarka()
        {
            VratiListuMarkiSO so = new VratiListuMarkiSO();
            so.ExecuteTemplate(new Marka());
            return so.Result;
        }

        public List<Automobil> GetAllAutomobil()
        {
            VratiListuAutomobilaSO so = new VratiListuAutomobilaSO();
            so.ExecuteTemplate(new Automobil());
            return so.Result;
        }

        public List<Model> GetAllModel()
        {
            VratiListuModelaSO so = new VratiListuModelaSO() ;
            so.ExecuteTemplate(new Model());
            return so.Result;
        }

        public List<Model> SearchModel(Model model)
        {

            VratiModelePoKriterijumuSO so = new VratiModelePoKriterijumuSO();
            so.ExecuteTemplate(model);
            return so.Result;
        }



        public void SaveStavkaRentiranja(StavkaRentiranja stavkaRentirnja)
        {
            ZapamtiStavkuRentiranjaSO so = new ZapamtiStavkuRentiranjaSO();
            so.ExecuteTemplate(stavkaRentirnja);

        }

        public void DeleteStavkaRentiranja(StavkaRentiranja stavkaRentiranja)
        {
            IzbrisiStavkaRentiranjaSO so = new IzbrisiStavkaRentiranjaSO();
            so.ExecuteTemplate(stavkaRentiranja);
        }




        public List<Musterija> SearchMusterija(Musterija musterija)
        {
            VratiMusterijePoKriterijumuSO so = new VratiMusterijePoKriterijumuSO();
            so.ExecuteTemplate(musterija);
            return so.Result;
        }

        public List<Rentiranje> SearchRentiranje(Rentiranje rentiranje)
        {
            VratiRentiranjePoKriterijumuSO so = new VratiRentiranjePoKriterijumuSO();
            so.ExecuteTemplate(rentiranje);
            return so.Result;
        }

        public List<Automobil> SearchAutomobil(Automobil automobil)
        {
            VratiAutomobilePoKriterijumuSO so = new VratiAutomobilePoKriterijumuSO();
            so.ExecuteTemplate(automobil);
            return so.Result;
        }







        public object GetAllMusterija()
        {
            UcitajListuMusterijaSO so = new UcitajListuMusterijaSO();
            so.ExecuteTemplate(new Musterija());
            return so.Result;
        }

        public void SaveRentiranje(Rentiranje rentiranje)
        {
            ZapamtiRentiranjeSO so = new ZapamtiRentiranjeSO();
            so.ExecuteTemplate(rentiranje);
        }

        public object GetAllPolisa()
        {
            UcitajListuPolisaSO so = new UcitajListuPolisaSO();
            so.ExecuteTemplate(new Polisa());
            return so.Result;
        }

        public void UpdateMusterija(Musterija musterija)
        {
            IzmeniMusterijuSO so = new IzmeniMusterijuSO();
            so.ExecuteTemplate(musterija);
            
        }

        public void UpdateRentiranje(Rentiranje rentiranje)
        {
            IzmeniRentiranjeSO so = new IzmeniRentiranjeSO();
            so.ExecuteTemplate(rentiranje);

        }

        public void UpdateAutomobil(Automobil automobil)
        {
           
            IzmeniAutomobilSO so = new IzmeniAutomobilSO();
            so.ExecuteTemplate(automobil);
 
        }



        public object SearchStavkaReniranja(StavkaRentiranja stavkaRentiranja)
        {
            VratiStavkarentiranjaPoKriterijumuSO so = new VratiStavkarentiranjaPoKriterijumuSO();
            so.ExecuteTemplate(stavkaRentiranja);
            return so.Result;
        }

        public void DeleteAutomobil(Automobil automobil)
        {
            IzbrisiAutomobilSO so = new IzbrisiAutomobilSO();
            so.ExecuteTemplate(automobil);

        }
    }
}
