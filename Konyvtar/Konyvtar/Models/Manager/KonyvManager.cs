using Konyvtar.Models.Records;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar.Models.Manager
{
    class KonyvManager
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();
            string connectionString = @"Data Source=193.225.33.71;User Id=ORA_S1340;Password=EKE2020";
            oc.ConnectionString = connectionString;
            return oc;
        }

        public List<Konyvek> Select()
        {
            List<Konyvek> records = new List<Konyvek>();
            OracleConnection oc = new OracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT i.nev, k.olvasojegy_code, k.cim, k.mufaj, k.kolcsonzes_date FROM konyvek k INNER JOIN irok i ON i.id = k.iro_id"
            };
            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Konyvek konyv = new Konyvek();
                konyv.Olvasojegy = reader["olvasojegy_code"].ToString();
                konyv.Cim = reader["cim"].ToString();
                konyv.Iro = reader["nev"].ToString();
                konyv.Mufaj = reader["mufaj"].ToString();
                konyv.KolcsonzesDate = (DateTime)reader["kolcsonzes_date"];

                records.Add(konyv);
            }
            oc.Close();

            return records;

        }

        public int Delete(Konyvek record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM konyvek WHERE olvasojegy_code = :olvasojegy_code"
            };

            OracleParameter olvasojegyParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":olvasojegy_code",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Olvasojegy
            };
            command.Parameters.Add(olvasojegyParameter);

            command.Connection = oc;
            command.Transaction = ot;

            int affectedRows = 0;
            try
            {
                affectedRows = command.ExecuteNonQuery();
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }
            oc.Close();

            return affectedRows;
        }


        public int Insert(Konyvek record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_konyvek"
            };

            OracleParameter olvasojegyParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_olvasojegy",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Olvasojegy
            };
            command.Parameters.Add(olvasojegyParameter);

            OracleParameter cimParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_cim",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Cim
            };
            command.Parameters.Add(cimParameter);

            OracleParameter iroParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_iro",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Iro
            };
            command.Parameters.Add(iroParameter);

            OracleParameter mufajParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_mufaj",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Mufaj
            };
            command.Parameters.Add(mufajParameter);

            OracleParameter kolcsonzesDateParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_kolcsonzes_date",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.KolcsonzesDate
            };
            command.Parameters.Add(kolcsonzesDateParameter);

            OracleParameter kolcsonzoNevParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_kolcsonzo_nev",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.KolcsonzoNev
            };
            command.Parameters.Add(kolcsonzoNevParameter);

            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };

            command.Connection = oc;
            command.Transaction = ot;
            

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
                ot.Commit();
                
                return affectedRows;
            }
            catch (Exception)
            {
                ot.Rollback();
                
                return 0;
            }

            
        }

        public bool CheckOlvasojegy(string olvasojegy)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_olvasojegy"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };
           

            OracleParameter olvasojegyParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_olvasojegy",
                Direction = System.Data.ParameterDirection.Input,
                Value = olvasojegy
            };
            command.Parameters.Add(olvasojegyParameter);

            command.Connection = oc;
            oc.Close();

            try
            {
                int succesful = int.Parse(correct.Value.ToString());
                return succesful != 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
