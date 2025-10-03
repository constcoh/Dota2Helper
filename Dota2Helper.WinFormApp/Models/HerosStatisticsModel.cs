using Dota2Helper.Core;

namespace Dota2Helper.WinFormApp.Models
{
    public class HerosStatisticsModel
    {
        public HerosStatisticsModel()
        {
            ScreenCount = Screen.AllScreens.Length;
            SelectScreen(1);
            LastScreenshotCreatedAt = DateTimeOffset.UtcNow;

            Heroes = new HeroSettings[10];
        }

        public int ScreenCount { get; }
        public int SelectedScreen { get; private set; }
        public bool CanUpdateScreenshot { get; set; }
        public DateTimeOffset LastScreenshotCreatedAt { get; set; }

        public HeroSettings[] Heroes { get; }

        public void SelectScreen(int index)
        {
            index.ToRange(0, ScreenCount - 1);
            var screen = Screen.AllScreens[index];
        }

        public void SetHero(int index, string name)
        {
            if (index < 0) index = 0;
            if (index > 10) index = 9;
            Heroes[index] = AllHeroSettings.Find(name);
        }
    }
}
