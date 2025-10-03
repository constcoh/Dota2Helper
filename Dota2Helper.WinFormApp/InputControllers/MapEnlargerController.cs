using Dota2Helper.WinFormApp.Models;

namespace Dota2Helper.WinFormApp.InputControllers
{
    public class MapEnlargerController : IInputController
    {
        private readonly MapEnlargerModel _model;

        public MapEnlargerController(
            MapEnlargerModel model,
            Button btnRun)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));

            btnRun.Click += BtnRun_Click;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            _model.OnOff();
        }
    }
}
