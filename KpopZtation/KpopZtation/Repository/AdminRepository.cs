using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class AdminRepository
    {

        public static ModelKpopZtationEntities db = Connect.getInstances();

        public static Customer loginAdmin(String email, String pass)
        {
            return db.Customers.Where(x => x.CustomerEmail.Equals(email) && x.CustomerPassword.Equals(pass)).FirstOrDefault();
        }
    }
}