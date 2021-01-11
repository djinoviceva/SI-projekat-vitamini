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
    public class CustomerRepository : ICustomerRepository
    {
        public int InsertCustomer(Customer customer)
        {
            var insert = DBConnection.EditData(string.Format("INSERT INTO CUSTOMERS VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    customer.Name, customer.Surname, customer.Adress, customer.City, customer.PhoneNumber, customer.email, customer.Password));
            DBConnection.CloseConnection();

            return insert;
        }
        public Customer FindCustomer(string email, string password)
        {
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM CUSTOMERS");

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.email = sqlDataReader.GetString(6);
                customer.Password = sqlDataReader.GetString(7);

                if (customer.email == email && customer.Password == password)
                {
                    return customer;
                }
            }

            DBConnection.CloseConnection();
            return null;
        }
    }
}
