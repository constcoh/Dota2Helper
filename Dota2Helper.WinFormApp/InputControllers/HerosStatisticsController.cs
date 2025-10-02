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
