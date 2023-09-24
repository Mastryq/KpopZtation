using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class ArtistFactory
    {

        public static Artist createArtist(String name, String image)
        {
            Artist artist = new Artist();
            artist.ArtistName = name;
            artist.ArtistImage = image;

            return artist;
        }

    }
}