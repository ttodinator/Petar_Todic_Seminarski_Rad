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
            AddMusterijaSO so = new AddMusterijaSO();
            so.ExecuteTemplate(musterija);
        }

        public void SaveAutomobil(Automobil automobil)
        {
            AddAutomobilSO so = new AddAutomobilSO();
            so.ExecuteTemplate(automobil);
        }

        public List<Marka> GetAllMarka()
        {
            GetAllMarkaSO so = new GetAllMarkaSO();
            so.ExecuteTemplate(new Marka());
            return so.Result;
        }

        public List<Automobil> GetAllAutomobil()
        {
            GetAllAutomobilSO so = new GetAllAutomobilSO();
            so.ExecuteTemplate(new Automobil());
            return so.Result;
        }

        public List<Model> GetAllModel()
        {
            GetAllModelSO so = new GetAllModelSO() ;
            so.ExecuteTemplate(new Model());
            return so.Result;
        }

        public List<Model> GetAllModelWhere(Model model)
        {

            GetAllModelWhereSO so = new GetAllModelWhereSO();
            so.ExecuteTemplate(model);
            return so.Result;
        }



        public void SaveStavkaRentiranja(StavkaRentiranja stavkaRentirnja)
        {
            AddStavkaRentiranjaSO so = new AddStavkaRentiranjaSO();
            so.ExecuteTemplate(stavkaRentirnja);

        }

        public void DeleteStavkaRentiranja(StavkaRentiranja stavkaRentiranja)
        {
            DeleteStavkaRentiranjaSO so = new DeleteStavkaRentiranjaSO();
            so.ExecuteTemplate(stavkaRentiranja);
        }




        public List<Musterija> SearchMusterija(Musterija musterija)
        {
            SearchMusterijaSO so = new SearchMusterijaSO();
            so.ExecuteTemplate(musterija);
            return so.Result;
        }

        public List<Rentiranje> SearchRentiranje(Rentiranje rentiranje)
        {
            SearchRentiranjeSO so = new SearchRentiranjeSO();
            so.ExecuteTemplate(rentiranje);
            return so.Result;
        }

        public List<Automobil> SearchAutomobil(Automobil automobil)
        {
            SearchAutomobilSO so = new SearchAutomobilSO();
            so.ExecuteTemplate(automobil);
            return so.Result;
        }







        public object GetAllMusterija()
        {
            GetAllMusterijaSO so = new GetAllMusterijaSO();
            so.ExecuteTemplate(new Musterija());
            return so.Result;
        }

        public void SaveRentiranje(Rentiranje rentiranje)
        {
            AddRentiranjeSO so = new AddRentiranjeSO();
            so.ExecuteTemplate(rentiranje);
        }

        public object GetAllPolisa()
        {
            GetAllPolisaSO so = new GetAllPolisaSO();
            so.ExecuteTemplate(new Polisa());
            return so.Result;
        }

        public void UpdateMusterija(Musterija musterija)
        {
            UpdateMusterijaSO so = new UpdateMusterijaSO();
            so.ExecuteTemplate(musterija);
            
        }

        public void UpdateRentiranje(Rentiranje rentiranje)
        {
            UpdateRentiranjeSO so = new UpdateRentiranjeSO();
            so.ExecuteTemplate(rentiranje);

        }

        public void UpdateAutomobil(Automobil automobil)
        {
            UpdateAutomobilSO so = new UpdateAutomobilSO();
            so.ExecuteTemplate(automobil);

        }



        public object SearchStavkaReniranja(StavkaRentiranja stavkaRentiranja)
        {
            SearchStavkaRentiranjaSO so = new SearchStavkaRentiranjaSO();
            so.ExecuteTemplate(stavkaRentiranja);
            return so.Result;
        }

        public void DeleteAutomobil(Automobil automobil)
        {
            DeleteAutomobilSO so = new DeleteAutomobilSO();
            so.ExecuteTemplate(automobil);

        }
    }
}
