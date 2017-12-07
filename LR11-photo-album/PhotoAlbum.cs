
namespace LR11_photo_album
{
    public class PhotoAlbum
    {
        private int _pagesCount;

        public PhotoAlbum(int pagesCount)
        {
            _pagesCount = pagesCount;
        }

        public PhotoAlbum() : this(16) { }

        public int GetNumberOfPages()
        {
            return _pagesCount;
        }
    }
}
