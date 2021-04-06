using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Polisa : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double CenaPoDanu { get; set; }
        public string Opis { get; set; }
        public string TableName => "Polisa";
        public string InsertValues => throw new NotImplementedException();
        public string IdName => "ID";
        public string JoinCondition => "";
        public string JoinTable => "";
        public string JoinCondition1 => "";
        public string JoinTable1 => "";
        public string TableAlias => "p";
        public string SelectValues => "*";
        public string Where => "";
        public string WhereCondition => "";
        public string WhereValue { get => ""; set => throw new NotImplementedException(); }
        public string UpdateText { get => ""; set => throw new NotImplementedException(); }
        public string JoinCondition2 => "";
        public string JoinTable2 => "";
        public string JoinCondition3 => "";
        public string JoinTable3 => "";
        public override string ToString()
        {
            return $"{Naziv} {CenaPoDanu}";
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Polisa p = new Polisa
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                    CenaPoDanu = Convert.ToDouble(reader.GetDecimal(2)),
                    Opis = reader.GetString(3)
                };
                result.Add(p);
            }
            return result;
        }
    }
}
