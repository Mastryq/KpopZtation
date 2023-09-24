using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CustomerFactory
    {

        public static Customer createCustomer(String name, String email, String gender, String address, String pass, String role)
        {
            Customer cust = new Customer();
            cust.CustomerName = name;
            cust.CustomerEmail = email;
            cust.CustomerGender = gender;
            cust.CustomerAddress = address;
            cust.CustomerPassword = pass;
            cust.CustomerRole = role;

            return cust;
        }

    }
}