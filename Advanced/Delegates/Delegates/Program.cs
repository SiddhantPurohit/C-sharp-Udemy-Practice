//Delegate is an object that knows how to call a method (or group of method).
//A reference to a function.
//For designing Extensible application.

using System;

namespace Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }


    public class PhotoProcessorWithDelegate
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo); //This method doesn't know anything about the implimentation of function.

            photo.Save();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UsingPhotoProcessorWithDelegates:");
            var processor = new PhotoProcessorWithDelegate();
            var filters = new PhotoFilters();

            PhotoProcessorWithDelegate.PhotoFilterHandler filterHandler;
            filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter;
            filterHandler += ToGrayFilter;

            processor.Process("photo.jpg", filterHandler);

            static void RemoveRedEyeFilter(Photo photo)
            {
                Console.WriteLine("Apply RemoveRedEyes");
            }

            static void ToGrayFilter(Photo photo)
            {
                Console.WriteLine("Apply change to Gray filter");
            }
        }
    }
}
