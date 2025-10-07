using Dota2Helper.Core;
using Dota2Helper.WinFormApp.Models;
using Dota2Helper.WinFormApp.ui_images;
using System.Drawing;

namespace Dota2Helper.WinFormApp.ViewModelObservers
{
    public class HerosStatisticsCopyAreaObserver : IViewModelObserver
    {
        private readonly Dictionary<(int, int), PrimaryAttrEnum> _drawnAttr = new Dictionary<(int, int), PrimaryAttrEnum>();

        private readonly HerosStatisticsModel _model;
        private readonly Form _form;
        private readonly Panel _targetDrawPanel;
        private readonly Label _lastScreenshotCreatedAtValue;
        private readonly RichTextBox[] _heroTextBoxNames;
        private readonly Label[] _heroStatLabels;

        public HerosStatisticsCopyAreaObserver(
            HerosStatisticsModel model,
            Form form,
            Panel targetDrawPanel,
            Label lastScreenshotCreatedAtValue,
            RichTextBox[] heroTextBoxNames,
            Label[] heroStatLabels)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _form = form ?? throw new ArgumentNullException(nameof(form));
            _targetDrawPanel = targetDrawPanel ?? throw new ArgumentNullException(nameof(targetDrawPanel));
            _lastScreenshotCreatedAtValue = lastScreenshotCreatedAtValue ?? throw new ArgumentNullException(nameof(lastScreenshotCreatedAtValue));
            _heroTextBoxNames = heroTextBoxNames ?? throw new ArgumentNullException(nameof(heroTextBoxNames));
            _heroStatLabels = heroStatLabels ?? throw new ArgumentNullException(nameof(heroStatLabels));
        }

        public void UpdateView()
        {
            UpdateHeroesScreenshot();
            UpdateDelayTime(); 
            UpdateHeroStats();
        }

        private void UpdateDelayTime()
        {
            var delay = DateTimeOffset.UtcNow.Subtract(_model.LastScreenshotCreatedAt);

            _lastScreenshotCreatedAtValue.Text = $"-{delay.ToString(@"mm\:ss")}";
        }

        private void UpdateHeroesScreenshot()
        {
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

        private void UpdateHeroStats()
        {
            for(int i = 0; i < _model.Heroes.Length; ++i)
            {
                var hero = _model.Heroes[i];

                if (hero == null)
                {
                    SetText(_heroTextBoxNames[i], "NONE");
                    DrawAttr(PrimaryAttrEnum.Unknown, _heroTextBoxNames[i].Left - 20, _heroTextBoxNames[i].Top);
                    SetText(_heroStatLabels[i], "");
                    continue;
                }

                SetText(_heroTextBoxNames[i], $"{hero.Name}");
                DrawAttr(hero.PrimaryAttr, _heroTextBoxNames[i].Left - 20, _heroTextBoxNames[i].Top);

                SetText(
                    _heroStatLabels[i], 
                    $"mov speed: {hero.MovementSpeed}\nroles: {string.Join(",", hero.GetRoleIndexes())}");
            }
        }

        private void DrawAttr(PrimaryAttrEnum primaryAttrEnum, int left, int top)
        {
            if (_drawnAttr.TryGetValue((left, top), out var prev)
                && primaryAttrEnum == prev)
            {
                return;
            }

            _drawnAttr[(left, top)] = primaryAttrEnum;

            var uiImage = UiImages.GetFor(primaryAttrEnum);

            using (Graphics g = _form.CreateGraphics())
            {
                var rect = new Rectangle(left, top, 16, 16);
                g.FillEllipse(new SolidBrush(_form.BackColor), rect);
                g.DrawImage(uiImage.Bitmap, rect);
            }
        }

        private void SetText(RichTextBox richTextBox, string newText)
        {
            if (richTextBox.Focused) return;
            if (richTextBox.Text == newText) return;
            richTextBox.Text = newText;
        }

        private void SetText(Label label, string newText)
        {
            if (label.Text == newText) return;
            label.Text = newText;
        }
    }
}
