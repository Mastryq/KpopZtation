using KpopZtation.Handler;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class ArtistController
    {

        public static String createArtist(String name, HttpPostedFile image)
        {
            if(name.Equals("") || image.Equals(""))
            {
                return "Missing some credentials !";
            }

            if (ArtistHandler.isNameUnique(name).Equals(true))
            {
                return "Name must be unique!";
            }

            if(!(image.FileName.EndsWith(".jpg") || image.FileName.EndsWith(".jpeg") || image.FileName.EndsWith(".png") || image.FileName.EndsWith(".jfif")))
            {
                return "Extentions must be .jpg or .jpeg or .png or .jfif";
            }

            if(image.ContentLength > 2000000)
            {
                return "File must be lower than 2MB";
            }

            String fileName = "../Assets/Artists/" + image.FileName;
            ArtistHandler.createArtist(name, fileName);
            return "Insert Successfuly !";
        }


        public static String updateArtist(String name, HttpPostedFile image, String id)
        {
            if (name.Equals("") || image.Equals(""))
            {
                return "Missing some credentials !";
            }

            if (ArtistHandler.isNameUnique(name).Equals(true))
            {
                return "Name must be unique!";
            }

            if (!(image.FileName.EndsWith(".jpg") || image.FileName.EndsWith(".jpeg") || image.FileName.EndsWith(".png") || image.FileName.EndsWith(".jfif")))
            {
                return "Extentions must be .jpg or .jpeg or .png or .jfif";
            }

            if (image.ContentLength > 2000000)
            {
                return "File must be lower than 2MB";
            }

            String fileName = "../Assets/Artists/" + image.FileName;
            ArtistHandler.updateArtist(name, fileName, id);
            return "Insert Successfuly !";
        }

        public static void deleteArtist(String id)
        {
            ArtistHandler.deleteArtist(id);
        }

        public static Artist getArtist(String id)
        {
            return ArtistHandler.getArtist(id);
        }

        public static List<Artist> getAllArtist()
        {
            return ArtistHandler.getAllArtist();
        }
    }
}