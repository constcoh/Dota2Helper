using Dota2Helper.WinFormApp.Models;

namespace Dota2Helper.WinFormApp.InputControllers
{
    public class MapEnlargerController : IInputController
    {
        private readonly MapEnlargerModel _model;
        private readonly NumericUpDown _numericUpDownScreen;
        private readonly NumericUpDown _numericUpDownLeft;
        private readonly NumericUpDown _numericUpDownTop;
        private readonly NumericUpDown _numericUpDownRight;
        private readonly NumericUpDown _numericUpDownBottom;

        public MapEnlargerController(
            MapEnlargerModel model,
            Button btnRun,
            NumericUpDown numericUpDownScreen,
            NumericUpDown numericUpDownLeft,
            NumericUpDown numericUpDownTop,
            NumericUpDown numericUpDownRight,
            NumericUpDown numericUpDownBottom)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));

            btnRun.Click += BtnRun_Click;

            _numericUpDownScreen = numericUpDownScreen ?? throw new ArgumentNullException(nameof(numericUpDownScreen));
            numericUpDownScreen.ValueChanged += NumericUpDownScreen_ValueChanged;

            _numericUpDownLeft = numericUpDownLeft ?? throw new ArgumentNullException(nameof(numericUpDownLeft));
            numericUpDownLeft.ValueChanged += NumericUpDownLeft_ValueChanged;

            _numericUpDownTop = numericUpDownTop ?? throw new ArgumentNullException(nameof(numericUpDownTop));
            numericUpDownTop.ValueChanged += NumericUpDownTop_ValueChanged;

            _numericUpDownRight = numericUpDownRight ?? throw new ArgumentNullException(nameof(numericUpDownRight));
            numericUpDownRight.ValueChanged += NumericUpDownRight_ValueChanged;

            _numericUpDownBottom = numericUpDownBottom ?? throw new ArgumentNullException(nameof(numericUpDownBottom));
            numericUpDownBottom.ValueChanged += NumericUpDownBottom_ValueChanged;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            _model.OnOff();
        }

        private void NumericUpDownScreen_ValueChanged(object sender, EventArgs e)
        {
            _model.SelectScreen((int)_numericUpDownScreen.Value);
        }

        private void NumericUpDownLeft_ValueChanged(object sender, EventArgs e)
        {
            _model.SelectCopyAreaLeft((int)_numericUpDownLeft.Value);
        }

        private void NumericUpDownTop_ValueChanged(object sender, EventArgs e)
        {
            _model.SelectCopyAreaTop((int)_numericUpDownTop.Value);
        }

        private void NumericUpDownRight_ValueChanged(object sender, EventArgs e)
        {
            _model.SelectCopyAreaRight((int)_numericUpDownRight.Value);
        }

        private void NumericUpDownBottom_ValueChanged(object sender, EventArgs e)
        {
            _model.SelectCopyAreaBottom((int)_numericUpDownBottom.Value);
        }
    }
}
