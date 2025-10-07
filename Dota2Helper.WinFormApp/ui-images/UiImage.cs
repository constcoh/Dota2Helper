namespace Dota2Helper.WinFormApp.ui_images
{
    public class UiImage : IDisposable
    {
        private readonly Bitmap _bitmap;

        public UiImage(
            string name,
            string path)
        {
            _bitmap = new Bitmap(path);
        }

        public string Name { get; }

        public Bitmap Bitmap => _bitmap;

        public void Dispose()
        {
            _bitmap.Dispose();
        }
    }
}
