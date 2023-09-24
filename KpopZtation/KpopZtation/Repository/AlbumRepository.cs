using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class AlbumRepository
    {

        public static ModelKpopZtationEntities db = Connect.getInstances();

        public static List<Album> getAllAlbums(String id)
        {
            int actualArtistId = int.Parse(id);
            return (db.Albums.Where(x => x.ArtistId == actualArtistId)).ToList();
        }

        public static Boolean isAlbumNameUnique(String albumName, String artistId)
        {
            int actualArtistId = int.Parse(artistId);
            return db.Albums.Any(x => x.AlbumName.Equals(albumName) && x.ArtistId == actualArtistId);
        }

        public static void createAlbum(Album album)
        {
            db.Albums.Add(album);
            db.SaveChanges();
        }

        public static Album getAlbumById(String id)
        {
            int actualId = int.Parse(id);
            return (db.Albums.Where(x => x.AlbumId == actualId)).FirstOrDefault();
        }

        public static void deleteAlbum(Album album)
        {
            db.Albums.Remove(album);
            db.SaveChanges();
        }

        public static void deleteAllAlbum(String artistId)
        {
            int actualId = int.Parse(artistId);
            var removeAlbum = db.Albums.Where(x => x.ArtistId == actualId).ToList();

            db.Albums.RemoveRange(removeAlbum);
            db.SaveChanges();
        }

        public static void updateAlbum(Album album, String albumName, String albumDescription, int albumPrice, int albumStock, String fileName)
        {
            album.AlbumName = albumName;
            album.AlbumDescription = albumDescription;
            album.AlbumPrice = albumPrice;
            album.AlbumStock = albumStock;
            album.AlbumImage = fileName;

            db.SaveChanges();
        }

        public static void updateStock(TransactionDetail detail, Album album)
        {
            album.AlbumStock = album.AlbumStock - detail.Qty;
            db.SaveChanges();
        }
    }
}