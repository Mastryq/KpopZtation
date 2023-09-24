using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class ArtistHandler
    {

        public static void createArtist(String name, String image)
        {
            Artist artist = ArtistFactory.createArtist(name, image);
            ArtistRepository.createArtist(artist);
        }

        public static Boolean isNameUnique(String name)
        {
            return ArtistRepository.isNameUnique(name);
        }

        public static void updateArtist(String name, String image, String id)
        {
            Artist artist = ArtistRepository.findArtist(id);
            ArtistRepository.updateArtist(artist, name, image);
        }

        public static void deleteArtist(String id)
        {
            Artist artist = ArtistRepository.findArtist(id);
            ArtistRepository.deleteArtist(artist);
        }

        public static Artist getArtist(String id)
        {
            return ArtistRepository.findArtist(id);
        }

        public static List<Artist> getAllArtist()
        {
            return ArtistRepository.getAllArtist();
        }
    }
}