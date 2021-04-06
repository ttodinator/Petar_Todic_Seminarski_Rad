using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class StavkaRentiranja : IEntity
    {
        [Browsable(false)]
        public int Id { get; set; }
        public int RedniBroj { get; set; }
        [Browsable(false)]
        public Rentiranje Rentiranje { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public Automobil Automobil { get; set; }
        public Polisa Polisa { get; set; }
        [Browsable(false)]
        public string TableName => "StavkaRentiranja";
        [Browsable(false)]
        public string InsertValues => $"{Rentiranje.Id},'{DatumOd.ToString("MM/dd/yyyy")}','{DatumDo.ToString("MM/dd/yyyy")}','{Automobil.BrojSasije}',{Polisa.Id},{RedniBroj}";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => "on(sr.BrojSasije=a.BrojSasije)";
        [Browsable(false)]
        public string JoinTable => "join Automobil a";
        [Browsable(false)]
        public string JoinCondition1 => "on(sr.PolisaID=p.ID)";
        [Browsable(false)]
        public string JoinTable1 => "join Polisa p";
        [Browsable(false)]
        public string TableAlias => "sr";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string Where => "where";
        [Browsable(false)]
        public string WhereCondition { get; set; }
        [Browsable(false)]
        public string WhereValue { get; set; }
        [Browsable(false)]
        public string UpdateText { get; set; }
        [Browsable(false)]
        public string JoinCondition2 => "on(a.ModelID=m.ID)";
        [Browsable(false)]
        public string JoinTable2 => "join Model m";
        [Browsable(false)]
        public string JoinCondition3 => "on(m.MarkaID=ma.ID)";
        [Browsable(false)]
        public string JoinTable3 => "join Marka ma";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Automobil a = new Automobil
                {
                    BrojSasije = reader.GetString(7),
                    Registracija = reader.GetString(8),
                    GodinaProizvodnje = reader.GetInt32(9),
                    CenaPoDanu = Convert.ToDouble(reader.GetDecimal(10)),
                    Model = new Model
                    {
                        Id = reader.GetInt32(16),
                        Naziv=reader.GetString(18),
                        Verzija=reader.GetString(19),
                        Marka=new Marka
                        {
                            Id=reader.GetInt32(20),
                            Naziv=reader.GetString(21)
                        }
                    }

                };

                Polisa p = new Polisa
                {
                    Id = reader.GetInt32(12),
                    Naziv = reader.GetString(13),
                    CenaPoDanu = Convert.ToDouble(reader.GetDecimal(14)),
                    Opis = reader.GetString(15)
                };

                StavkaRentiranja sr = new StavkaRentiranja
                {
                    Polisa = p,
                    Automobil = a,
                    Id = reader.GetInt32(0),
                    DatumOd = reader.GetDateTime(2),
                    DatumDo = reader.GetDateTime(3),
                    Rentiranje = new Rentiranje
                    {
                        Id = reader.GetInt32(1)
                    },
                    RedniBroj=reader.GetInt32(6)
                    
                };

                result.Add(sr);
            }
            return result;
        }
    }
}
