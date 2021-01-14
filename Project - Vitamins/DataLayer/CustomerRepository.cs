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
            Customer customer = new Customer();

            while (sqlDataReader.Read())
            {
                Customer c = new Customer();
                c.CustomerID = sqlDataReader.GetInt32(0);
                c.Name = sqlDataReader.GetString(1);
                c.Surname = sqlDataReader.GetString(2);
                c.Adress = sqlDataReader.GetString(3);
                c.City = sqlDataReader.GetString(4);
                c.PhoneNumber = sqlDataReader.GetString(5);
                c.email = sqlDataReader.GetString(6);
                c.Password = sqlDataReader.GetString(7);

                if (c.email == email && c.Password == password)
                {
                    customer = c;
                }
            }

            DBConnection.CloseConnection();
            return customer;
        }
    }
}
