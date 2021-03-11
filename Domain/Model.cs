using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Model : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Verzija { get; set; }
        public Marka Marka { get; set; }
        public string TableName => "Model";

        public string InsertValues => $"{Marka.Id},'{Naziv}','{Verzija}'";

        public string IdName => "ID";

        public string JoinCondition => "on (m.MarkaID=ma.ID)";

        public string JoinTable => "join Marka ma";

        public string TableAlias => "m";

        public string SelectValues => "*";


        public string WhereCondition => "ma.Naziv=";

        public string WhereValue { get; set; }

        public string Where => "where";

        public string JoinCondition1 => "";

        public string JoinTable1 => "";

        public string UpdateText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string JoinCondition2 => "";

        public string JoinTable2 => "";

        public string JoinCondition3 => "";

        public string JoinTable3 => "";

        public override string ToString()
        {
            return $"{Naziv} {Verzija}";
        }

        private string ReturnVerzija(string m)
        {
            if (m.Equals("/"))
            {
                return "";
            }
            return m;
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {

                List<IEntity> result = new List<IEntity>();
                while (reader.Read())
                {
                    Model m = new Model
                    {
                        Marka = new Marka
                        {
                            Id = reader.GetInt32(4),
                            Naziv = reader.GetString(5)
                        },
                        Id = reader.GetInt32(0),
                        Naziv = reader.GetString(2),
                        Verzija = reader.GetString(3),

                    };
                    result.Add(m);
                }
                return result;
            }
        }
    }

