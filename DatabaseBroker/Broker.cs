using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RentACarDatabase"].ConnectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void Delete(IEntity entity)
        {
            SqlCommand command = new SqlCommand("",connection,transaction);
            command.CommandText = $"delete from {entity.TableName} where {entity.WhereCondition} {entity.WhereValue} ";
            /*if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greska sa bazom podataka");
            }*/
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Brisanje ovog objekta nije dozvoljeno");
            }

        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} {entity.JoinTable1} {entity.JoinCondition1}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public List<IEntity> GetAllWhere(IEntity entity)
        {
            List<IEntity> result=new List<IEntity>();
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} {entity.JoinTable1} {entity.JoinCondition1} {entity.JoinTable2} {entity.JoinCondition2} {entity.JoinTable3} {entity.JoinCondition3} {entity.Where} {entity.WhereCondition}'{entity.WhereValue}'";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }


        public void Save(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.TableName} values ({entity.InsertValues})";
            /*if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }*/
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska sa bazom podataka");
            }
        }

        public void Update(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update {entity.TableName} set {entity.UpdateText} {entity.Where} {entity.WhereCondition}{entity.WhereValue}";
            /*if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }*/
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska sa bazom podataka");
            }
        }

        public int GetNewId(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select max({entity.IdName}) from {entity.TableName} ";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result;
            }
        }
    }
}
