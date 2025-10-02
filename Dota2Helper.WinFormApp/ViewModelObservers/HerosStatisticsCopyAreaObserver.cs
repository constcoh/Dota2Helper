using Dota2Helper.WinFormApp.Models;

namespace Dota2Helper.WinFormApp.ViewModelObservers
{
    public class HerosStatisticsCopyAreaObserver : IViewModelObserver
    {
        private readonly HerosStatisticsModel _model;
        private readonly Panel _targetDrawPanel;
        private readonly Label _lastScreenshotCreatedAtValue;

        public HerosStatisticsCopyAreaObserver(
            HerosStatisticsModel model,
            Panel targetDrawPanel,
            Label lastScreenshotCreatedAtValue)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _targetDrawPanel = targetDrawPanel ?? throw new ArgumentNullException(nameof(targetDrawPanel));
            _lastScreenshotCreatedAtValue = lastScreenshotCreatedAtValue ?? throw new ArgumentNullException(nameof(lastScreenshotCreatedAtValue));
        }

        public void UpdateView()
        {
            var delay = DateTimeOffset.UtcNow.Subtract(_model.LastScreenshotCreatedAt);

            _lastScreenshotCreatedAtValue.Text = $"-{delay.ToString(@"mm\:ss")}";

            if (!_model.CanUpdateScreenshot) return;
            _model.LastScreenshotCreatedAt = DateTimeOffset.UtcNow;

            Rectangle bounds = new Rectangle(
                0,
                44,
                590,
                640);


            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(
                        bounds.Left,
                        bounds.Top,
                        0,
                        0, bounds.Size);
                }

                using (Graphics g = _targetDrawPanel.CreateGraphics())
                {
                    g.DrawImage(bitmap,
                        new Rectangle(
                        0,
                        0,
                        250,
                        _targetDrawPanel.Height),
                        new Rectangle(
                        0,
                        0,
                        250,
                        bounds.Height),
                        GraphicsUnit.Pixel);


                    g.DrawImage(bitmap,
                        new Rectangle(
                        250,
                        0,
                        40,
                        _targetDrawPanel.Height),
                        new Rectangle(
                        330,
                        0,
                        40,
                        bounds.Height),
                        GraphicsUnit.Pixel);


                    g.DrawImage(bitmap,
                        new Rectangle(
                        290,
                        0,
                        90,
                        _targetDrawPanel.Height),
                        new Rectangle(
                        460,
                        0,
                        90,
                        bounds.Height),
                        GraphicsUnit.Pixel);
                }
            }
        }
    }
}
