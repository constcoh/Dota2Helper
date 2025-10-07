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
                    btnRun),
                new MapEnlagerCopyAreaObserver(
                    RootViewModel.Instance.MapEnlargerModel,
                    pnlDisplay),
                new HerosStatisticsCopyAreaObserver(
                    RootViewModel.Instance.HerosStatisticsModel,
                    this,
                    pnlPlayers,
                    lblScreenDelayValue,
                    new[]
                    {
                        richTextBoxInputHero0,
                        richTextBoxInputHero1,
                        richTextBoxInputHero2,
                        richTextBoxInputHero3,
                        richTextBoxInputHero4,
                        richTextBoxInputHero5,
                        richTextBoxInputHero6,
                        richTextBoxInputHero7,
                        richTextBoxInputHero8,
                        richTextBoxInputHero9
                    },
                    new[]
                    {
                        lblHeroStat0,
                        lblHeroStat1,
                        lblHeroStat2,
                        lblHeroStat3,
                        lblHeroStat4,
                        lblHeroStat5,
                        lblHeroStat6,
                        lblHeroStat7,
                        lblHeroStat8,
                        lblHeroStat9,
                    })
            });

            RootViewModel.Instance.AddRange(new List<IInputController>
            {
                new MapEnlargerController(
                    RootViewModel.Instance.MapEnlargerModel,
                    btnRun),
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hook.Dispose();
        }

        private void richTextBoxInputHero0_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(0, richTextBoxInputHero0.Text);
        }

        private void richTextBoxInputHero1_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(1, richTextBoxInputHero1.Text);
        }

        private void richTextBoxInputHero2_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(2, richTextBoxInputHero2.Text);
        }

        private void richTextBoxInputHero3_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(3, richTextBoxInputHero3.Text);
        }

        private void richTextBoxInputHero4_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(4, richTextBoxInputHero4.Text);
        }

        private void richTextBoxInputHero5_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(5, richTextBoxInputHero5.Text);
        }

        private void richTextBoxInputHero6_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(6, richTextBoxInputHero6.Text);
        }

        private void richTextBoxInputHero7_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(7, richTextBoxInputHero7.Text);
        }

        private void richTextBoxInputHero8_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(8, richTextBoxInputHero8.Text);
        }

        private void richTextBoxInputHero9_Leave(object sender, EventArgs e)
        {
            RootViewModel.Instance.HerosStatisticsModel.SetHero(9, richTextBoxInputHero9.Text);
        }
    }
}
