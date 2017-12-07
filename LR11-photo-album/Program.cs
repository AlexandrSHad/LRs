using System;

namespace LR11_photo_album
{
    class Program
    {
        static void Main(string[] args)
        {
            var album16 = new PhotoAlbum();
            var album24 = new PhotoAlbum(24);
            var album64 = new BigPhotoAlbum();

            Console.WriteLine("Album page count {0}", album16.GetNumberOfPages());
            Console.WriteLine("Album page count {0}", album24.GetNumberOfPages());
            Console.WriteLine("Album page count {0}", album64.GetNumberOfPages());

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
