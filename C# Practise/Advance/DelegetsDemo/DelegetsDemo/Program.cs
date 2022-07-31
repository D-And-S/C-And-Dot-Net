using System;

namespace DelegetsDemo
{  
    public class PhotoProcessor
    {      
        public delegate void PhotoFilterHandler(Photo photo);
        public void process(string path, Action<Photo> photoFilterHandler)
        {
            var photo = Photo.Load(path);

            var filter = new PhotoFilters();
            //filter.ApplyBrightness(photo);
            //filter.ApplyContrast(photo);
            //filter.Resize(photo);

            photoFilterHandler(photo);

        }
    }
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
            Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize Photo");
        }


    }
    class Program
    {
        public delegate void HelloFUnction(string message);
        static void Main(string[] args)
        {
            //var del = new HelloFUnction(Hello);
            //del("Hello World");
            var photoProcessor = new PhotoProcessor();
            var filter = new PhotoFilters();

             Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemoveRedEyeFiler;
                
            photoProcessor.process("C:",filterHandler);

        }

        static void RemoveRedEyeFiler(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
    
}
