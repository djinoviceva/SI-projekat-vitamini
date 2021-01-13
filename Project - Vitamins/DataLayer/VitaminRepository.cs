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
    public class VitaminRepository : IVitaminRepository
    {
        public List<Vitamin> GetAllVitamins()
        {
            List<Vitamin> vitamins = new List<Vitamin>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM VITAMINS");

            while (sqlDataReader.Read())
            {
                Vitamin v = new Vitamin();
                v.VitaminID = sqlDataReader.GetInt32(0);
                v.VitaminName = sqlDataReader.GetString(1);
                v.Manufacturer = sqlDataReader.GetString(2);
                v.Price = sqlDataReader.GetDecimal(3);
                v.Amount = sqlDataReader.GetInt32(4);

                vitamins.Add(v);
            }

            DBConnection.CloseConnection();

            return vitamins;
        }
        public Vitamin GetRequiredVitamin(Symptom s)
        {
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM VITAMINS");
            Vitamin vitamin = new Vitamin();

            while (sqlDataReader.Read())
            {
                Vitamin v = new Vitamin();
                v.VitaminID = sqlDataReader.GetInt32(0);
                v.VitaminName = sqlDataReader.GetString(1);
                v.Manufacturer = sqlDataReader.GetString(2);
                v.Price = sqlDataReader.GetDecimal(3);
                v.Amount = sqlDataReader.GetInt32(4);

                if (v.VitaminID == s.VitaminID)
                {
                    vitamin = v;
                }
            }

            DBConnection.CloseConnection();
            return vitamin;
        }
    }
}
