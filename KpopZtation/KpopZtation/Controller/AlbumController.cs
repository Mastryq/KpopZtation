using KpopZtation.Handler;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class AlbumController
    {
        public static List<Album> getAllAlbums(String id)
        {
            return AlbumHandler.getAllAlbums(id);
        }

        public static String createAlbum(String artistId, String albumName, String albumDescription, String albumPrice, String albumStock, HttpPostedFile albumImage)
        {

            if (albumName.Equals("") || albumDescription.Equals("") || albumPrice.Equals("") || albumStock.Equals("") || albumImage.ContentLength == 0)
            {
                return "All fields must be filled!";
            }

            if (albumName.Length > 50)
            {
                return "Name length must not exceed 50 characters!";
            }

            if (AlbumHandler.isAlbumNameUnique(albumName, artistId).Equals(true))
            {
                return "Name must be unique!";
            }

            if (albumDescription.Length > 255)
            {
                return "Description length must not exceed 255 characters!";
            }

            int newAlbumPriceFormat;

            if (!int.TryParse(albumPrice, out newAlbumPriceFormat))
            {
                return "Invalid price!";
            }

            if (newAlbumPriceFormat < 100000 || newAlbumPriceFormat > 1000000)
            {
                return "Price must be between 100000 and 1000000!";
            }

            int newAlbumStockFormat;

            if (!int.TryParse(albumStock, out newAlbumStockFormat))
            {
                return "Invalid stock!";
            }

            if (newAlbumStockFormat < 1)
            {
                return "Price must be more than 0!";
            }

            if (!(albumImage.FileName.EndsWith(".jpg") || albumImage.FileName.EndsWith(".jpeg") || albumImage.FileName.EndsWith(".png") || albumImage.FileName.EndsWith(".jfif")))
            {
                return "Extentions must be .jpg or .jpeg or .png or .jfif";
            }

            if (albumImage.ContentLength > 2000000)
            {
                return "File must be lower than 2MB";
            }

            String fileName = "~/Assets/Albums/" + albumImage.FileName;
            AlbumHandler.createAlbum(artistId, albumName, albumDescription, newAlbumPriceFormat, newAlbumStockFormat, fileName);
            return "Insert Successful!";
        }

        public static String updateAlbum(Album albumBeforeUpdate, String albumId, String albumName, String albumDescription, String albumPrice, String albumStock, HttpPostedFile albumImage)
        {

            if (albumName.Equals("") || albumDescription.Equals("") || albumPrice.Equals("") || albumStock.Equals("") || albumImage.ContentLength == 0)
            {
                return "All fields must be filled!";
            }

            if (albumName.Length > 50)
            {
                return "Name length must not exceed 50 characters!";
            }

            if (AlbumHandler.isAlbumNameUnique(albumName, albumBeforeUpdate.ArtistId.ToString()).Equals(true) && albumName != albumBeforeUpdate.AlbumName)
            {
                return "Name must be unique!";
            }

            if (albumDescription.Length > 255)
            {
                return "Description length must not exceed 255 characters!";
            }

            int newAlbumPriceFormat;

            if (!int.TryParse(albumPrice, out newAlbumPriceFormat))
            {
                return "Invalid price!";
            }

            if (newAlbumPriceFormat < 100000 || newAlbumPriceFormat > 1000000)
            {
                return "Price must be between 100000 and 1000000!";
            }

            int newAlbumStockFormat;

            if (!int.TryParse(albumStock, out newAlbumStockFormat))
            {
                return "Invalid stock!";
            }

            if (newAlbumStockFormat < 1)
            {
                return "Price must be more than 0!";
            }

            if (!(albumImage.FileName.EndsWith(".jpg") || albumImage.FileName.EndsWith(".jpeg") || albumImage.FileName.EndsWith(".png") || albumImage.FileName.EndsWith(".jfif")))
            {
                return "Extentions must be .jpg or .jpeg or .png or .jfif";
            }

            if (albumImage.ContentLength > 2000000)
            {
                return "File must be lower than 2MB";
            }

            String fileName = "~/Assets/Albums/" + albumImage.FileName;
            AlbumHandler.updateAlbum(albumId, albumName, albumDescription, newAlbumPriceFormat, newAlbumStockFormat, fileName);
            return "Update Success!";
        }

        public static void deleteAlbum(string albumId)
        {
            AlbumHandler.deleteAlbum(albumId);
        }

        public static Album getAlbumById(string albumId)
        {
            return AlbumHandler.getAlbumById(albumId);
        }

        public static void deleteAllAlbum(String artistId)
        {
            AlbumHandler.deleteAllAlbum(artistId);
        }

    }
}