namespace Dota2Helper.WinFormApp.Models
{
    public class MapEnlargerModel
    {
        public MapEnlargerModel()
        {
            ScreenCount = Screen.AllScreens.Length;
            SelectScreen(1);
            CopyAreaLeft = 0;
            CopyAreaTop = 698;
            CopyAreaRight = 202;
            CopyAreaBottom = 900;
        }

        public bool IsEnabled { get; private set; }

        public int ScreenCount { get; }
        public int SelectedScreen { get; private set; }
        public int SelectedScreenWidth { get; private set; }
        public int SelectedScreenHeight { get; private set; }

        public int CopyAreaLeft { get; private set; }
        public int CopyAreaRight { get; private set; }
        public int CopyAreaTop { get; private set; }
        public int CopyAreaBottom { get; private set; }

        public void SelectScreen(int index)
        {
            index.ToRange(0, ScreenCount - 1);
            var screen = Screen.AllScreens[index];
            SelectedScreen = index;
            SelectedScreenWidth = screen.Bounds.Width;
            SelectedScreenHeight = screen.Bounds.Height;

            CopyAreaLeft = CopyAreaLeft.ToRange(0, SelectedScreenWidth);
            CopyAreaRight = CopyAreaRight.ToRange(0, SelectedScreenWidth);
            CopyAreaTop = CopyAreaTop.ToRange(0, SelectedScreenHeight);
            CopyAreaBottom = CopyAreaBottom.ToRange(0, SelectedScreenHeight);

            SelectCopyAreaLeft(CopyAreaLeft);
            SelectCopyAreaTop(CopyAreaTop);
            SelectCopyAreaRight(CopyAreaRight);
            SelectCopyAreaBottom(CopyAreaBottom);
        }

        public void SelectCopyAreaLeft(int newValue)
        {
            CopyAreaLeft = newValue.ToRange(0, SelectedScreenWidth - 1);
        }

        public void SelectCopyAreaTop(int newValue)
        {
            CopyAreaTop = newValue.ToRange(0, SelectedScreenHeight - 1);
        }

        public void SelectCopyAreaRight(int newValue)
        {
            CopyAreaRight = newValue.ToRange(0, SelectedScreenWidth - 1);
        }

        public void SelectCopyAreaBottom(int newValue)
        {
            CopyAreaBottom = newValue.ToRange(0, SelectedScreenHeight - 1);
        }

        public void OnOff()
        {
            IsEnabled = !IsEnabled;
        }
    }
}
