using Dota2Helper.WinFormApp.Models;

namespace Dota2Helper.WinFormApp.ViewModelObservers
{
    public class MapEnlargerInputSettingsObserver : IViewModelObserver
    {
        private readonly MapEnlargerModel _model;
        private readonly Button _btnRun;
        private readonly NumericUpDown _numericUpDownScreen;
        private readonly NumericUpDown _numericUpDownLeft;
        private readonly NumericUpDown _numericUpDownTop;
        private readonly NumericUpDown _numericUpDownRight;
        private readonly NumericUpDown _numericUpDownBottom;

        public MapEnlargerInputSettingsObserver(
            MapEnlargerModel model,
            Button btnRun,
            NumericUpDown numericUpDownScreen,
            NumericUpDown numericUpDownLeft,
            NumericUpDown numericUpDownTop,
            NumericUpDown numericUpDownRight,
            NumericUpDown numericUpDownBottom)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _btnRun = btnRun ?? throw new ArgumentNullException(nameof(btnRun));
            _numericUpDownScreen = numericUpDownScreen ?? throw new ArgumentNullException(nameof(numericUpDownScreen));
            _numericUpDownLeft = numericUpDownLeft ?? throw new ArgumentNullException(nameof(numericUpDownLeft));
            _numericUpDownTop = numericUpDownTop ?? throw new ArgumentNullException(nameof(numericUpDownTop));
            _numericUpDownRight = numericUpDownRight ?? throw new ArgumentNullException(nameof(numericUpDownRight));
            _numericUpDownBottom = numericUpDownBottom ?? throw new ArgumentNullException(nameof(numericUpDownBottom));
        }

        public void UpdateView()
        {
            UpdateBtnRunText();
            UpdateScreenSelector();
            UpdateLeftSelector();
            UpdateRightSelector();
            UpdateTopSelector();
            UpdateBottomSelector();
        }

        private void UpdateBtnRunText()
        {
            _btnRun.Text = _model.IsEnabled
                ? "STOP"
                : "RUN";
        }

        private void UpdateScreenSelector()
        {
            _numericUpDownScreen.Minimum = 0;
            _numericUpDownScreen.Maximum = _model.ScreenCount - 1;

            if(_numericUpDownScreen.Value != _model.SelectedScreen)
            {
                _numericUpDownScreen.Value = _model.SelectedScreen;
            }
        }

        private void UpdateLeftSelector()
        {
            _numericUpDownLeft.Minimum = 0;
            _numericUpDownLeft.Maximum = _model.SelectedScreenWidth - 1;

            if (_numericUpDownLeft.Value != _model.CopyAreaLeft)
            {
                _numericUpDownLeft.Value = _model.CopyAreaLeft;
            }
        }

        private void UpdateRightSelector()
        {
            _numericUpDownRight.Minimum = 0;
            _numericUpDownRight.Maximum = _model.SelectedScreenWidth - 1;

            if (_numericUpDownRight.Value != _model.CopyAreaRight)
            {
                _numericUpDownRight.Value = _model.CopyAreaRight;
            }
        }

        private void UpdateTopSelector()
        {
            _numericUpDownTop.Minimum = 0;
            _numericUpDownTop.Maximum = _model.SelectedScreenHeight - 1;

            if (_numericUpDownTop.Value != _model.CopyAreaTop)
            {
                _numericUpDownTop.Value = _model.CopyAreaTop;
            }
        }

        private void UpdateBottomSelector()
        {
            _numericUpDownBottom.Minimum = 0;
            _numericUpDownBottom.Maximum = _model.SelectedScreenHeight - 1;

            if (_numericUpDownBottom.Value != _model.CopyAreaBottom)
            {
                _numericUpDownBottom.Value = _model.CopyAreaBottom;
            }
        }
    }
}
