using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class Connect
    {
        public static ModelKpopZtationEntities db = null;

        public static ModelKpopZtationEntities getInstances()
        {
            if (db == null)
            {
                db = new ModelKpopZtationEntities();
            }

            return db;
        }

    }
}