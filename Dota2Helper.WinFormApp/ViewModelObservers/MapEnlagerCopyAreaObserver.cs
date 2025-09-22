using Dota2Helper.WinFormApp.Models;

namespace Dota2Helper.WinFormApp.ViewModelObservers
{
    public class MapEnlagerCopyAreaObserver : IViewModelObserver
    {
        private readonly MapEnlargerModel _model;
        private readonly Panel _targetDrawPanel;

        public MapEnlagerCopyAreaObserver(
            MapEnlargerModel model,
            Panel targetDrawPanel)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _targetDrawPanel = targetDrawPanel ?? throw new ArgumentNullException(nameof(targetDrawPanel));
        }

        public void UpdateView()
        {
            if (!_model.IsEnabled) return;

            var width = _model.CopyAreaRight - _model.CopyAreaLeft + 1;
            width = width.ToRange(1, _model.SelectedScreenWidth);

            var height = _model.CopyAreaBottom - _model.CopyAreaTop + 1;
            height = height.ToRange(1, _model.SelectedScreenHeight);

            Rectangle bounds = new Rectangle(
                _model.CopyAreaLeft,
                _model.CopyAreaTop,
                width,
                height);

            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(
                        _model.CopyAreaLeft,
                        _model.CopyAreaTop,
                        0,
                        0, bounds.Size);
                }

                using (Graphics g = _targetDrawPanel.CreateGraphics())
                {
                    g.DrawImage(bitmap, new Rectangle(
                        0, 
                        0, 
                        _targetDrawPanel.Width,
                        _targetDrawPanel.Height));
                }
            }
        }
    }
}
