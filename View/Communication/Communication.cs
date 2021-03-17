using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Domain;

namespace View.Communication
{
    public class Communication
    {
        private static Communication instance;

        private Socket socket;
        private CommunicationClient client;



        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        internal List<Automobil> GetAllAutomobil()
        {
            List<Automobil> automobils;
            Request request = new Request()
            {
                Operation = Operation.GetAllAutomobil
            };
            client.SendRequest(request);
            automobils = (List<Automobil>)client.GetResponseResult();
            return automobils;
        }

        internal List<Polisa> GetAllPolisa()
        {
            List<Polisa> automobils;
            Request request = new Request()
            {
                Operation = Operation.GetAllPolisa
            };
            client.SendRequest(request);
            automobils = (List<Polisa>)client.GetResponseResult();
            return automobils; 
        }

        internal List<Marka> GetAllMarka()
        {
            List<Marka> marks ;
            Request request = new Request()
            {
                Operation = Operation.GetAllMarka
            };
            client.SendRequest(request);
            marks= (List<Marka>)client.GetResponseResult();
            return marks;

            //return (List<Marka>)client.GetResponseResult();
        }

        internal List<Rentiranje> SearchRentiranjePrezime(Musterija m)
        {
            List<Rentiranje> rentiranja;
            Request request = new Request()
            {
                Operation = Operation.SearchRentiranjePrezime,
                RequestObject = new Rentiranje
                {
                    Musterija = m
                }
            };
            client.SendRequest(request);
            rentiranja = (List<Rentiranje>)client.GetResponseResult();
            if (rentiranja==null || rentiranja.Count==0)
            {
                throw new Exception();
            }
            return rentiranja;
        }

        internal List<Rentiranje> SearchRentiranje(Rentiranje r)
        {
            List<Rentiranje> rentiranja;
            Request request = new Request()
            {
                Operation = Operation.SearchRentiranje,
                RequestObject = r
            };
            client.SendRequest(request);
            rentiranja = (List<Rentiranje>)client.GetResponseResult();
            if (rentiranja == null || rentiranja.Count == 0)
            {
                throw new Exception();
            }
            return rentiranja;
        }

        internal List<Rentiranje> SearchRentiranjeDatum(Rentiranje r)
        {
            List<Rentiranje> rentiranja;
            Request request = new Request()
            {
                Operation=Operation.SearchRentiranjeDatum,
                RequestObject = r
            };
            client.SendRequest(request);
            rentiranja = (List<Rentiranje>)client.GetResponseResult();
            if (rentiranja == null || rentiranja.Count == 0)
            {
                throw new Exception();
            }
            return rentiranja;
        }

        internal List<StavkaRentiranja> SearchStavkaRentiranja(int rentiranjeId)
        {
            List<StavkaRentiranja> stavke;
            Request request = new Request()
            {
                Operation = Operation.SearchStavkaRentiranja,
                RequestObject = new StavkaRentiranja
                {
                    Rentiranje = new Rentiranje
                    {
                        Id = rentiranjeId
                    }
                }
            };

            client.SendRequest(request);
            stavke = (List<StavkaRentiranja>)client.GetResponseResult();
            return stavke;
        }

        internal void DeleteAutomobil(Automobil a)
        {
            Request request = new Request
            {
                Operation = Operation.DeleteAutomobil,
                RequestObject = a
            };
            try
            {
                client.SendRequest(request);
                client.GetResponseResult();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal void DeleteStavkaRentiranja(StavkaRentiranja stavkaRentiranja)
        {
            Request request = new Request
            {
                Operation = Operation.DeleteSatvakRentiranja,
                RequestObject = stavkaRentiranja
            };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void UpdateRentiranje(Rentiranje r)
        {
            Request request = new Request
            {
                Operation = Operation.UpdateRentiranje,
                RequestObject = r
            };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<Rentiranje> SearchRentiranjeIme(Musterija m)
        {
            List<Rentiranje> rentiranja;
            Request request = new Request()
            {
                Operation = Operation.SearchRentiranjeIme,
                RequestObject = new Rentiranje
                {
                    Musterija = m
                }
            };
            client.SendRequest(request);
            rentiranja = (List<Rentiranje>)client.GetResponseResult();
            if (rentiranja == null || rentiranja.Count == 0)
            {
                throw new Exception();
            }
            return rentiranja;
        }

        internal List<Musterija> GetAllMusterija()
        {
            List<Musterija> marks;
            Request request = new Request()
            {
                Operation = Operation.GetAllMusterija
            };
            client.SendRequest(request);
            marks = (List<Musterija>)client.GetResponseResult();
            return marks;

            //return (List<Marka>)client.GetResponseResult();
        }

        internal int GetRentiranjeID(Rentiranje r)
        {
            int ID;
            Request request = new Request()
            {
                Operation = Operation.GetRentiranjeID,
                RequestObject = r
                
            };
            client.SendRequest(request);
            ID = (int)client.GetResponseResult();
            return ID;
        }

        internal void SaveStavkarentiranja(StavkaRentiranja stavkaRentiranja)
        {
            Request request = new Request
            {
                Operation=Operation.SaveStavkaRentiranja,
                RequestObject=stavkaRentiranja
            };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SaveRentiranje(Rentiranje r)
        {
            Request request = new Request()
            {
                Operation = Operation.SaveRentiranje
            };
            request.RequestObject = r;
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<Model> GetAllModel(Marka marka)
        {
            //List<Model> models;
            Request request = new Request()
            {
                Operation = Operation.GetAllModelWhere,
                RequestObject = new Model { Marka=marka}
            };
            client.SendRequest(request);
            return (List<Model>)client.GetResponseResult();
        }

        /*internal List<Musterija> SearchMusterijaIme(Musterija m)
        {
            Request request = new Request
            {
                Operation = Operation.SearchMusterijaIme,
                RequestObject = m
            };
            List<Musterija> musterijas;

            client.SendRequest(request);
            musterijas = (List<Musterija>)client.GetResponseResult();
            //return (List<Automobil>)client.GetResponseResult();
            if (musterijas.Count == 0 || musterijas == null)
            {
                throw new Exception();
            }

            return musterijas;
        }*/

        internal List<Musterija> SearchMusterija(Musterija m)
        {
            Request request = new Request
            {
                Operation = Operation.SearchMusterija,
                RequestObject = m
            };
            List<Musterija> musterijas;

            client.SendRequest(request);
            musterijas = (List<Musterija>)client.GetResponseResult();
            //return (List<Automobil>)client.GetResponseResult();
            if (musterijas.Count == 0 || musterijas == null)
            {
                throw new Exception();
            }
            //musterijas = new List<Musterija>();
            return musterijas;
        }

        internal bool SearchMusterijaJMBG(Musterija m)
        {
            Request request = new Request
            {
                Operation = Operation.SearchMusterijaJMBG,
                RequestObject = m
            };
            List<Musterija> musterijas;

            client.SendRequest(request);
            musterijas = (List<Musterija>)client.GetResponseResult();
            //return (List<Automobil>)client.GetResponseResult();
            if (musterijas.Count == 0 || musterijas == null)
            {
                return true;
            }

            return false;
        }

        internal bool AutomobilBrojSasijeCheck(Automobil a)
        {
            Request request = new Request
            {
                Operation = Operation.SearchAutomobilBrSasije,
                RequestObject = a
            };
            List<Automobil> automobils;

            client.SendRequest(request);
            automobils = (List<Automobil>)client.GetResponseResult();
            //return (List<Automobil>)client.GetResponseResult();
            if (automobils.Count == 0 || automobils == null)
            {
                return true;
            }

            return false;
        }

        internal void UpdateMusterija(Musterija m)
        {
            Musterija mu = new Musterija();
            Request request = new Request
            {
                Operation = Operation.UpdateMusterija,
                RequestObject = m
            };
            client.SendRequest(request);
            mu = (Musterija)client.GetResponseResult();
        }

        internal void SaveAutomobil(Automobil a)
        {
            Request request = new Request()
            {
                Operation = Operation.SaveAutomobil
            };
            request.RequestObject = a;
            client.SendRequest(request);
            client.GetResponseResult();
        }

        /*internal List<Musterija> SearchMusterijaPrezime(Musterija m)
        {
            Request request = new Request
            {
                Operation = Operation.SearchMusterijaPrezime,
                RequestObject = m
            };
            List<Musterija> musterijas;

            client.SendRequest(request);
            musterijas = (List<Musterija>)client.GetResponseResult();
            //return (List<Automobil>)client.GetResponseResult();
            if (musterijas.Count == 0 || musterijas == null)
            {
                throw new Exception();
            }

            return musterijas;
        }*/

        internal void UpdateAutomobil(Automobil a)
        {
            Request request = new Request
            {
                Operation = Operation.UpdateAutomobil,
                RequestObject = a
            };
            client.SendRequest(request);
            Automobil ab = new Automobil();
            ab = (Automobil)client.GetResponseResult();
        }

        private Communication()
        {

        }

        internal List<Automobil> SearchAutomobilRegistracija(Automobil a)
        {
            Request request = new Request
            {
                Operation=Operation.SearchAutomobilRegistracija,
                RequestObject=a
            };
            List<Automobil> automobils;

            client.SendRequest(request);
            automobils = (List<Automobil>)client.GetResponseResult();
            //return (List<Automobil>)client.GetResponseResult();
            if (automobils==null || automobils.Count == 0 )
            {
                throw new Exception();
            }

            return automobils;
        }

        internal List<Automobil> SearchAutomobil(Automobil a)
        {
            Request request = new Request
            {
                Operation = Operation.SearchAutomobil,
                RequestObject = a
            };
            List<Automobil> automobils;

            client.SendRequest(request);
            automobils = (List<Automobil>)client.GetResponseResult();
            //return (List<Automobil>)client.GetResponseResult();
            if (automobils == null || automobils.Count == 0)
            {
                throw new Exception();
            }

            return automobils;
        }

        internal List<Automobil> SearchAutomobilBrSasije(Automobil a)
        {
            Request request = new Request
            {
                Operation = Operation.SearchAutomobilBrSasije,
                RequestObject = a
            };
            List<Automobil> automobils;

            client.SendRequest(request);
            automobils = (List<Automobil>)client.GetResponseResult();
            //return (List<Automobil>)client.GetResponseResult();
            if (automobils.Count == 0)
            {
                throw new Exception();
            }

            return automobils;
        }

        public void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            client = new CommunicationClient(socket);

        }

        internal void SaveMusterija(Musterija m)
        {
            Request request = new Request()
            {
                Operation=Operation.SaveMusterija
            };
            request.RequestObject = m;
            client.SendRequest(request);
            client.GetResponseResult();

        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }

        

        internal Zaposleni Login(string korsnickoIme, string lozinka)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = new Zaposleni { KorisnickoIme = korsnickoIme, Lozinka = lozinka }
            };
            client.SendRequest(request);
            return (Zaposleni)client.GetResponseResult();
        }


    }
}
