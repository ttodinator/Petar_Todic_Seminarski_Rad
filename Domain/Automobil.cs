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
    public class Automobil : IEntity
    {
        public string BrojSasije { get; set; }
        public string Registracija { get; set; }
        public Marka Marka { get; set; }
        public Model Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public double CenaPoDanu { get; set; }

        
        [Browsable(false)]
        public string TableName => "Automobil";
        [Browsable(false)]

        public string InsertValues { get; set; }
        //public string InsertValues => $"'{BrojSasije}','{Registracija}',{GodinaProizvodnje},{CenaPoDanu},{Model.Id}";
        //public string InsertValues => $"'{BrojSasije}','{Registracija}',{GodinaProizvodnje},{CommaConversion()},{Model.Id}";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => "on (a.ModelID=m.ID)";
        [Browsable(false)]
        public string JoinTable => "join Model m";
        [Browsable(false)]
        public string JoinCondition1 => "on (m.MarkaID=ma.ID)";
        [Browsable(false)]
        public string JoinTable1 => "join Marka ma";
        [Browsable(false)]
        public string TableAlias => "a";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string Where => "where";
        [Browsable(false)]
        public string WhereCondition {get;set;}
        [Browsable(false)]
        public string WhereValue { get; set; }
        [Browsable(false)]
        public string UpdateText { get; set; }
        [Browsable(false)]
        public string JoinCondition2 => "";
        [Browsable(false)]
        public string JoinTable2 => "";
        [Browsable(false)]
        public string JoinCondition3 => "";
        [Browsable(false)]
        public string JoinTable3 => "";

        public override string ToString()
        {
            return $"{Model.Marka.Naziv} {Model.Naziv} {Registracija}";
        }

        private string CommaConversion()
        {
            string s = "";
            string d = CenaPoDanu.ToString();
            if (d.Contains("."))
            {
                d.Replace(",",".");
            }
            return s;
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Marka marka = new Marka
                {
                    Id=reader.GetInt32(9),
                    Naziv=reader.GetString(10)
                };

                Model model = new Model
                {
                    Id=reader.GetInt32(5),
                    Naziv=reader.GetString(7),
                    Verzija=reader.GetString(8),
                    Marka=marka
                };

                Automobil automobil = new Automobil
                {
                    BrojSasije = reader.GetString(0),
                    Registracija = reader.GetString(1),
                    GodinaProizvodnje = reader.GetInt32(2),
                    CenaPoDanu = (double)reader.GetDecimal(3),
                    Model = model,
                    Marka = marka
                };
                /*Automobil a = new Automobil
                {
                    BrojSasije=reader.GetString(0),
                    Registracija=reader.GetString(1),
                    GodinaProizvodnje=reader.GetInt32(2),
                    CenaPoDanu=reader.GetDouble(3),
                    Model=new Model
                    {
                        Id=reader.GetInt32(5),
                        Naziv=reader.GetString(7),
                        Verzija=reader.GetString(8),
                        Marka=new Marka
                        {
                            Id=reader.GetInt32(9),
                            Naziv=reader.GetString(10)
                        }
                    }
                };
                result.Add(a);*/

                result.Add(automobil);
            }
            return result;
        }
    }
}
