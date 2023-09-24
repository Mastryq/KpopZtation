using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CustomerRepository
    {
        public static ModelKpopZtationEntities db = Connect.getInstances();

        public static void createCustomer(Customer data)
        {
            db.Customers.Add(data);
            db.SaveChanges();
        }
       
        public static Boolean isEmailUnique(String email)
        {
            return db.Customers.Any(x => x.CustomerEmail.Equals(email));
        }

        public static Customer getData(String email, String pass)
        {
            return db.Customers.Where(x => x.CustomerEmail.Equals(email) && x.CustomerPassword.Equals(pass)).FirstOrDefault();
        }

        public static Customer getDataByEmail(String email)
        {
            return (db.Customers.Where(x => x.CustomerEmail == email)).FirstOrDefault();
        }

        public static Customer getDataById(int id)
        {
            return (db.Customers.Where(x => x.CustomerId == id)).FirstOrDefault();
        }

        public static void updateCustomer(Customer customerBeforeUpdate, String name, String email, String gender, String address, String password)
        {
            customerBeforeUpdate.CustomerName = name;
            customerBeforeUpdate.CustomerEmail = email;
            customerBeforeUpdate.CustomerGender = gender;
            customerBeforeUpdate.CustomerAddress = address;
            customerBeforeUpdate.CustomerPassword = password;

            db.SaveChanges();
        }

        public static void deleteCustomer(Customer customer)
        {
            db.Customers.Remove(customer);
            db.SaveChanges();
        }
    }
}