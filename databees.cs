using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;

namespace ROVER
{
  public class databees
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        public databees()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Case> GetCase() 
        {
        var cases = new List<Case>();
        using (var connection = factory.CreateConnection()) 
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "select * from tbl_case";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cases.Add(new Case
                        {
                            misdrijf = (string)reader["Misdrijf"]
                        });
                    }
                }
            }
            return cases;
        }

        public void AddCase(Case zaak)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into tbl_case(meldingsnummer, misdrijf, waarneming, datumVoor,samenvattingVerdachte, samenvattingGetuige)Values ({zaak.meldingsnummer},'{zaak.misdrijf} ', '{zaak.waarneming}','{zaak.datumVoor}','{zaak.svVerdachte}','{zaak.svGetuige}')";
                command.ExecuteNonQuery();

            }
        }
        public void AddPerson(Case zaak)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"insert into tbl_Persoon(meldingsnummer, vNaam, aNaam, bsn) Values ({zaak.meldingsnummer},'{zaak.vNaam}','{zaak.aNaam}','{zaak.bsn}')";
                command.ExecuteNonQuery();
            }
        }
    }

}
