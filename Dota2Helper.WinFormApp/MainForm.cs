using Dota2Helper.WinFormApp.InputControllers;
using Dota2Helper.WinFormApp.ViewModelObservers;
using SharpHook;
using System.Drawing.Imaging;

namespace Dota2Helper.WinFormApp
{
    public partial class MainForm : Form
    {
        private TaskPoolGlobalHook _hook = new TaskPoolGlobalHook();

        public MainForm()
        {
            InitializeComponent();
        }

        private void tmrScreenUpdate_Tick(object sender, EventArgs e)
        {
            ////Rectangle bounds = Screen.GetBounds(Point.Empty);
            ////using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            ////{
            ////    using (Graphics g = Graphics.FromImage(bitmap))
            ////    {
            ////        g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            ////    }

            ////    using (Graphics g = pnlDisplay.CreateGraphics())
            ////    {
            ////        g.DrawImage(bitmap, Point.Empty);
            ////    }
            ////}
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            RootViewModel.Init();

            RootViewModel.Instance.AddRange(new List<IViewModelObserver>
            {
                new MapEnlargerInputSettingsObserver(
                    RootViewModel.Instance.MapEnlargerModel,
                    btnRun,
                    numericUpDownScreen,
                    numericUpDownLeft,
                    numericUpDownTop,
                    numericUpDownRight,
                    numericUpDownBottom),
                new MapEnlagerCopyAreaObserver(
                    RootViewModel.Instance.MapEnlargerModel,
                    pnlDisplay),
                new HerosStatisticsCopyAreaObserver(
                    RootViewModel.Instance.HerosStatisticsModel,
                    pnlPlayers,
                    lblScreenDelayValue)
            });

            RootViewModel.Instance.AddRange(new List<IInputController>
            {
                new MapEnlargerController(
                    RootViewModel.Instance.MapEnlargerModel,
                    btnRun,
                    numericUpDownScreen,
                    numericUpDownLeft,
                    numericUpDownTop,
                    numericUpDownRight,
                    numericUpDownBottom),
                new HerosStatisticsController(
                    RootViewModel.Instance.HerosStatisticsModel,
                    _hook)
            });

            await _hook.RunAsync();
        }

        private void tmrUI_Tick(object sender, EventArgs e)
        {
            RootViewModel.Instance.UpdateView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
