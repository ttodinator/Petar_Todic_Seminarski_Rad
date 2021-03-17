using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Common;
using System.Net.Sockets;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
using Controller;

namespace Server
{
    public class ClientHandler
    {
        private Socket client;
        private readonly BindingList<Zaposleni> zaposlenis;

        private Zaposleni loggedInZaposleni;
        public ClientHandler(Socket client, System.ComponentModel.BindingList<Zaposleni> zaposlenis)
        {
            this.client = client;
            this.zaposlenis = zaposlenis;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Veza je prekinuta");
                zaposlenis.Remove(loggedInZaposleni);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Veza je prekinuta");
                zaposlenis.Remove(loggedInZaposleni);

            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
            switch (request.Operation)
            {
                case Operation.Login:
                    response.Result = Controller.Controller.Instance.Login((Zaposleni)request.RequestObject);
                    loggedInZaposleni = (Zaposleni)response.Result;
                    zaposlenis.Add(loggedInZaposleni);
                    break;
                case Operation.SaveMusterija:
                    Controller.Controller.Instance.SaveMusterija((Musterija)request.RequestObject);
                    break;
                case Operation.SaveStavkaRentiranja:
                    Controller.Controller.Instance.SaveStavkaRentiranja((StavkaRentiranja)request.RequestObject);
                    break;
                case Operation.GetAllMarka:
                    response.Result = Controller.Controller.Instance.GetAllMarka();
                    break;
                case Operation.GetAllMusterija:
                    response.Result = Controller.Controller.Instance.GetAllMusterija();
                    break;
                case Operation.GetAllPolisa:
                    response.Result = Controller.Controller.Instance.GetAllPolisa();
                    break;
                /*case Operation.GetRentiranjeID:
                    response.Result = Controller.Controller.Instance.GetRentiranjeID((Rentiranje)request.RequestObject);
                    break;*/
                case Operation.GetAllAutomobil:
                    response.Result = Controller.Controller.Instance.GetAllAutomobil();
                    break;
                case Operation.GetAllModelWhere:
                    response.Result = Controller.Controller.Instance.SearchModel((Model)request.RequestObject);
                    break;
                case Operation.SaveAutomobil:
                    Controller.Controller.Instance.SaveAutomobil((Automobil)request.RequestObject);
                    break;
                case Operation.SaveRentiranje:
                    Controller.Controller.Instance.SaveRentiranje((Rentiranje)request.RequestObject);
                    break;
                
                case Operation.SearchAutomobil:
                    response.Result = Controller.Controller.Instance.SearchAutomobil((Automobil)request.RequestObject);
                    break;
                
                case Operation.SearchMusterija:
                    response.Result = Controller.Controller.Instance.SearchMusterija((Musterija)request.RequestObject);
                    break;
                
                
                case Operation.SearchRentiranje:
                    response.Result = Controller.Controller.Instance.SearchRentiranje((Rentiranje)request.RequestObject);
                    break;

                case Operation.SearchStavkaRentiranja:
                    response.Result = Controller.Controller.Instance.SearchStavkaReniranja((StavkaRentiranja)request.RequestObject);
                    break;
                case Operation.UpdateMusterija:
                    Controller.Controller.Instance.UpdateMusterija((Musterija)request.RequestObject);
                    break;
                case Operation.UpdateAutomobil:
                    Controller.Controller.Instance.UpdateAutomobil((Automobil)request.RequestObject);
                    break;
                case Operation.UpdateRentiranje:
                    Controller.Controller.Instance.UpdateRentiranje((Rentiranje)request.RequestObject);
                    break;
                case Operation.DeleteSatvakRentiranja:
                    Controller.Controller.Instance.DeleteStavkaRentiranja((StavkaRentiranja)request.RequestObject);
                    break;
                case Operation.DeleteAutomobil:
                    Controller.Controller.Instance.DeleteAutomobil((Automobil)request.RequestObject);
                    break;


            }
            return response;
        }

        internal void Stop()
        {
            client.Close();
        }
    }
}
