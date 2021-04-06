using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Domain
{
    public interface IEntity
    {
        string TableName { get;  }
        string InsertValues { get; }
        string IdName { get; }
        string JoinCondition { get; }
        string JoinTable { get; }
        string JoinCondition1 { get; }
        string JoinTable1 { get; }
        string JoinCondition2 { get; }
        string JoinTable2 { get; }
        string JoinCondition3 { get; }
        string JoinTable3 { get; }
        string TableAlias { get; }
        string SelectValues { get; }
        string Where { get; }
        string WhereCondition { get; }
        string WhereValue { get; set; }

        string UpdateText { get; set; }

        List<IEntity> GetEntities(SqlDataReader reader);


    }
}
