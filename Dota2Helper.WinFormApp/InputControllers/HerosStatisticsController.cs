using Dota2Helper.WinFormApp.Models;
using SharpHook;

namespace Dota2Helper.WinFormApp.InputControllers
{
    public class HerosStatisticsController : IInputController
    {
        private readonly HerosStatisticsModel _herosStatisticsModel;

        public HerosStatisticsController(
            HerosStatisticsModel herosStatisticsModel,
            TaskPoolGlobalHook keyboardHook) 
        {
            _herosStatisticsModel = herosStatisticsModel ?? throw new ArgumentNullException(nameof(HerosStatisticsModel)); 
            keyboardHook.KeyPressed += OnKeyPressed;
            keyboardHook.KeyReleased += OnKeyReleased;
        }

        private void OnKeyPressed(object sender, KeyboardHookEventArgs e)
        {
            e.SuppressEvent = false;

            if (e.Data.KeyCode == SharpHook.Native.KeyCode.VcBackQuote)
            {
                _herosStatisticsModel.CanUpdateScreenshot = true;
            }

            if (e.Data.KeyCode == SharpHook.Native.KeyCode.VcZ)
            {
                var width = 1400;
                var height = 900;

                Rectangle bounds = new Rectangle(
                    0,
                    0,
                    width,
                    height);

                using (Bitmap bitmap = new Bitmap(width, height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(
                            0,
                            0,
                            0,
                            0, bounds.Size);
                    }

                    using (var stream = new MemoryStream())
                    {
                        bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        var bitmapBytes = stream.ToArray();

                        var heroes = new Dota2ScreenParser().GetGame(bitmapBytes);

                        for (int i = 0; i < _herosStatisticsModel.Heroes.Length; ++i)
                        {
                            _herosStatisticsModel.SetHero(i, heroes[i]);
                        }
                    }
                }
            }
        }

        private void OnKeyReleased(object sender, KeyboardHookEventArgs e)
        {
            e.SuppressEvent = false;

            if (e.Data.KeyCode == SharpHook.Native.KeyCode.VcBackQuote)
            {
                _herosStatisticsModel.CanUpdateScreenshot = false;
            }
        }
    }
}
