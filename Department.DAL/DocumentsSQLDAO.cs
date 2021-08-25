using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public class DocumentsSQLDAO : IDocumentsDAO
    {
        public void AddDocument(Documents document)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "AddDocument";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@documentNumber", string.IsNullOrEmpty(document.DocumentNumber) ? Convert.DBNull : document.DocumentNumber);
                    command.Parameters.AddWithValue("@documentType", string.IsNullOrEmpty(document.DocumentType) ? Convert.DBNull : document.DocumentType);
                    command.Parameters.AddWithValue("@country", string.IsNullOrEmpty(document.Country) ? Convert.DBNull : document.Country);
                    command.Parameters.AddWithValue("@ownerID", document.OwnerId);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteDocument(Documents document)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DeleteDocument";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@documentNumber", document.DocumentNumber);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<Documents> GetDocuments()
        {
            List<Entities.Documents> documents = new List<Documents>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetDocuments";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Entities.Documents document = new Documents(reader.GetString(0), reader.GetString(1),
                            reader.GetString(2), reader.GetInt32(3));
                        documents.Add(document);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return documents;
        }

        public void UpdateDocument(Documents document)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UpdateDocument";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@documentNumber", string.IsNullOrEmpty(document.DocumentNumber) ? Convert.DBNull : document.DocumentNumber);
                    command.Parameters.AddWithValue("@documentType", string.IsNullOrEmpty(document.DocumentType) ? Convert.DBNull : document.DocumentType);
                    command.Parameters.AddWithValue("@country", string.IsNullOrEmpty(document.Country) ? Convert.DBNull : document.Country);
                    command.Parameters.AddWithValue("@ownerID", document.OwnerId);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
