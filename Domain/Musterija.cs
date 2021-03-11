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
    public class Musterija : IEntity
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        [Browsable(false)]
        public string TableName => "Musterija";
        [Browsable(false)]
        public string InsertValues => $"'{JMBG}','{Ime}','{Prezime}','{BrojTelefona}','{DatumRodjenja.ToString("MM/dd/yyyy")}'";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias =>"m";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition  { get; set; }
        [Browsable(false)]
        public string WhereValue { get; set; }
        [Browsable(false)]
        public string Where => "where";
        [Browsable(false)]
        public string JoinCondition1 => "";
        [Browsable(false)]
        public string JoinTable1 => "";
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
            return $"{Ime} {Prezime} {JMBG}"; 
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Musterija m = new Musterija
                {
                    JMBG = reader.GetString(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    BrojTelefona = reader.GetString(3),
                    DatumRodjenja = (DateTime)reader.GetDateTime(4)


                };
                result.Add(m);
            }
            return result;
        }
    }
}
