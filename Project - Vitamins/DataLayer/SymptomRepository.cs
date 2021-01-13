using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SymptomRepository : ISymptomRepository
    {
        public Symptom FindSymptom(string description)
        {
            Symptom symptom = new Symptom();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM SYMPTOMS");

            while (sqlDataReader.Read())
            {
                Symptom s = new Symptom();
                s.SymptomID = sqlDataReader.GetInt32(0);
                s.Description = sqlDataReader.GetString(1);
                s.VitaminID = sqlDataReader.GetInt32(2);

                if (s.Description.Equals(description))
                {
                    symptom = s;
                }
            }

            DBConnection.CloseConnection();
            return symptom;
        }
    }
}
