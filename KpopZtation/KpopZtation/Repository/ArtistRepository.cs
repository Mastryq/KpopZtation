using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class ArtistRepository
    {

        public static ModelKpopZtationEntities db = Connect.getInstances();

        public static void createArtist(Artist artist)
        {
            db.Artists.Add(artist);
            db.SaveChanges();
        }

        public static Boolean isNameUnique(String name)
        {
            return db.Artists.Any(x => x.ArtistName.Equals(name));
        }

        public static Artist findArtist(String id)
        {
            int realId = int.Parse(id);
            return db.Artists.Find(realId);
        }

        public static void updateArtist(Artist data, String name, String image)
        {
            data.ArtistName = name;
            data.ArtistImage = image;
            db.SaveChanges();
        }

        public static void deleteArtist(Artist data)
        {
            db.Artists.Remove(data);
            db.SaveChanges();
        }

        public static List<Artist> getAllArtist()
        {
            return (db.Artists.ToList());
        }
    }
}