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
    public class Zaposleni:IEntity
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        [Browsable(false)]
        public string Lozinka { get; set; }

        [Browsable(false)]
        public string TableName => "Zaposleni";
        [Browsable(false)]
        public string InsertValues => throw new NotImplementedException();
        [Browsable(false)]
        public string IdName => "ID";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "z";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]

        public string WhereCondition => "";
        [Browsable(false)]
        public string WhereValue { get => ""; set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string Where => "";
        [Browsable(false)]
        public string JoinCondition1 => "";
        [Browsable(false)]
        public string JoinTable1 => "";
        [Browsable(false)]
        public string UpdateText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string JoinCondition2 => "";
        [Browsable(false)]
        public string JoinTable2 => "";
        [Browsable(false)]
        public string JoinCondition3 => "";
        [Browsable(false)]
        public string JoinTable3 => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Zaposleni z = new Zaposleni
                {
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    KorisnickoIme = (string)reader["KorisnickoIme"],
                    Lozinka = (string)reader["Lozinka"]
                };
                result.Add(z);
                
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
