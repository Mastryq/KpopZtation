using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class AlbumFactory
    {
        public static Album createAlbum(String artistId, String albumName, String albumDescription, int newAlbumPriceFormat, int newAlbumStockFormat, String fileName)
        {
            int newArtistIdFormat = int.Parse(artistId);

            Album album = new Album
            {
                ArtistId = newArtistIdFormat,
                AlbumName = albumName,
                AlbumDescription = albumDescription,
                AlbumPrice = newAlbumPriceFormat,
                AlbumStock = newAlbumStockFormat,
                AlbumImage = fileName,
            };

            return album;
        }
    }
}