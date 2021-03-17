using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public enum Operation
    {
        Login,
        SaveMusterija,
        SaveRentiranje,
        SaveStavkaRentiranja,
        UpdateRentiranje,
        GetAllMarka,
        GetAllModelWhere,
        GetAllPolisa,
        GetAllAutomobil,
        GetAllMusterija,
        SaveAutomobil,
        GetRentiranjeID,
        SearchAutomobil,
        SearchAutomobilRegistracija,
        SearchAutomobilBrSasije,
        SearchMusterija,
        SearchMusterijaIme,
        SearchMusterijaPrezime,
        SearchMusterijaJMBG,
        SearchRentiranje,
        SearchRentiranjeIme,
        SearchRentiranjePrezime,
        SearchRentiranjeDatum,
        SearchStavkaRentiranja,
        UpdateMusterija,
        UpdateAutomobil,
        DeleteSatvakRentiranja,
        DeleteAutomobil
    }
}
