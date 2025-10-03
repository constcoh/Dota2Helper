using Dota2Helper.WinFormApp.Models;

namespace Dota2Helper.WinFormApp.ViewModelObservers
{
    public class MapEnlargerInputSettingsObserver : IViewModelObserver
    {
        private readonly MapEnlargerModel _model;
        private readonly Button _btnRun;

        public MapEnlargerInputSettingsObserver(
            MapEnlargerModel model,
            Button btnRun)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _btnRun = btnRun ?? throw new ArgumentNullException(nameof(btnRun));
        }

        public void UpdateView()
        {
            UpdateBtnRunText();
        }

        private void UpdateBtnRunText()
        {
            _btnRun.Text = _model.IsEnabled
                ? "STOP"
                : "RUN";
        }
    }
}
