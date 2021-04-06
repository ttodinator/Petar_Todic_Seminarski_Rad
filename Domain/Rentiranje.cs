using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Rentiranje : IEntity
    {
        public int Id { get; set; }
        public Musterija Musterija { get; set; }
        public DateTime Datum { get; set; }
        public double UkupnaCena { get; set; }
        public List<StavkaRentiranja> StavkeRentiranja { get; set; }
        public string TableName => "Rentiranje";
        public string InsertValues { get; set; }
        public string IdName => "ID";
        public string JoinCondition => "on(r.JMBG=m.JMBG)";
        public string JoinTable => "join Musterija m";
        public string JoinCondition1 => "";
        public string JoinTable1 => "";
        public string TableAlias => "r";
        public string SelectValues => "*";
        public string Where => "where";
        public string WhereCondition { get; set; }
        public string WhereValue { get; set; }
        public string UpdateText { get; set; }
        public string JoinCondition2 => "";
        public string JoinTable2 => "";
        public string JoinCondition3 => "";
        public string JoinTable3 => "";

        public override string ToString()
        {
            return $"{Id} {Musterija.Ime} {Musterija.Prezime} {Datum.ToString("MM/dd/yyyy")}";
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Musterija m = new Musterija
                {
                    JMBG = reader.GetString(4),
                    Ime = reader.GetString(5),
                    Prezime = reader.GetString(6),
                    BrojTelefona = reader.GetString(7),
                    DatumRodjenja = reader.GetDateTime(8)

                };

                Rentiranje r = new Rentiranje
                {
                    Id = reader.GetInt32(0),
                    Datum = reader.GetDateTime(2),
                    UkupnaCena= Convert.ToDouble(reader.GetDecimal(3)),
                    Musterija = m
                };

                result.Add(r);
            }
            return result;
        }
    }
}
