namespace Dota2Helper.WinFormApp.Models
{
    public class HerosStatisticsModel
    {
        public HerosStatisticsModel()
        {
            ScreenCount = Screen.AllScreens.Length;
            SelectScreen(1);
            LastScreenshotCreatedAt = DateTimeOffset.UtcNow;
        }

        public int ScreenCount { get; }
        public int SelectedScreen { get; private set; }
        public bool CanUpdateScreenshot { get; set; }
        public DateTimeOffset LastScreenshotCreatedAt { get; set; }

        public void SelectScreen(int index)
        {
            index.ToRange(0, ScreenCount - 1);
            var screen = Screen.AllScreens[index];
        }
    }
}
