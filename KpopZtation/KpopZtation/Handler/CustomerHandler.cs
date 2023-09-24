using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CustomerHandler
    {

        public static void createCustomer(String name, String email, String gender, String address, String pass, String role)
        {
            Customer cust = CustomerFactory.createCustomer(name, email, gender, address, pass, role);
            CustomerRepository.createCustomer(cust);
        }

        public static Boolean isEmailUnique(String email)
        {
            return CustomerRepository.isEmailUnique(email);
        }

        public static Customer getData(String email, String pass)
        {
            return CustomerRepository.getData(email, pass);
        }

        public static Customer getDataByEmail(String email)
        {
            return CustomerRepository.getDataByEmail(email);
        }

        public static void updateCustomer(Customer customerBeforeUpdate, String name, String email, String gender, String address, String password)
        {
            CustomerRepository.updateCustomer(customerBeforeUpdate, name, email, gender, address, password);
        }

        public static void deleteCustomer(Customer customer)
        {
            CustomerRepository.deleteCustomer(customer);
        }
        public static Customer getDataById(int id)
        {
            return CustomerRepository.getDataById(id);
        }
    }
}