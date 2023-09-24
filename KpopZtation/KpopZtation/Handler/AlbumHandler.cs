using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class AlbumHandler
    {
        public static List<Album> getAllAlbums(String id)
        {
            return AlbumRepository.getAllAlbums(id);
        }
        public static Boolean isAlbumNameUnique(String albumName, String artistId)
        {
            return AlbumRepository.isAlbumNameUnique(albumName, artistId);
        }

        public static void createAlbum(String artistId, String albumName, String albumDescription, int albumPrice, int albumStock, String fileName)
        {
            Album album = AlbumFactory.createAlbum(artistId, albumName, albumDescription, albumPrice, albumStock, fileName);
            AlbumRepository.createAlbum(album);
        }
        public static Album getAlbumById(String albumId)
        {
            return AlbumRepository.getAlbumById(albumId);
        }

        public static void updateAlbum(String albumId, String albumName, String albumDescription, int albumPrice, int albumStock, String fileName)
        {
            Album album = getAlbumById(albumId);
            AlbumRepository.updateAlbum(album, albumName, albumDescription, albumPrice, albumStock, fileName);
        }

        public static void deleteAlbum(String albumId)
        {
            Album album = AlbumRepository.getAlbumById(albumId);
            AlbumRepository.deleteAlbum(album);
        }

        public static void deleteAllAlbum(String artistId)
        {
            AlbumRepository.deleteAllAlbum(artistId);
        }
    }
}