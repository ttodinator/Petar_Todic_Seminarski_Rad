using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Marka : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string TableName => "Marka";
        public string InsertValues => throw new NotImplementedException();
        public string IdName => throw new NotImplementedException();
        public string JoinCondition => "";
        public string JoinTable => "";
        public string TableAlias => "ma";
        public string SelectValues => "*";
        public string WhereCondition => "";
        public string WhereValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Where => throw new NotImplementedException();
        public string JoinCondition1 => "";
        public string JoinTable1 => "";
        public string UpdateText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string JoinCondition2 => "";
        public string JoinTable2 => "";
        public string JoinCondition3 => "";
        public string JoinTable3 => "";
        public override string ToString()
        {
            return $"{Id} {Naziv}";
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Marka
                {
                    Id = (int)reader["ID"],
                    Naziv = (string)reader["Naziv"]
                }) ;
            }
            return result;
        }
    }

    
}
