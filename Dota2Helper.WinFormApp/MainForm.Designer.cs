namespace Dota2Helper.WinFormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrScreenUpdate = new System.Windows.Forms.Timer(components);
            pnlDisplay = new Panel();
            lblLeft = new Label();
            btnRun = new Button();
            numericUpDownLeft = new NumericUpDown();
            numericUpDownTop = new NumericUpDown();
            lblTop = new Label();
            numericUpDownBottom = new NumericUpDown();
            lblDBottom = new Label();
            numericUpDownRight = new NumericUpDown();
            lblRight = new Label();
            numericUpDownScreen = new NumericUpDown();
            label1 = new Label();
            tmrUI = new System.Windows.Forms.Timer(components);
            pnlPlayers = new Panel();
            lblScreenDelayCaption = new Label();
            lblScreenDelayValue = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreen).BeginInit();
            SuspendLayout();
            // 
            // tmrScreenUpdate
            // 
            tmrScreenUpdate.Enabled = true;
            tmrScreenUpdate.Interval = 50;
            tmrScreenUpdate.Tick += tmrScreenUpdate_Tick;
            // 
            // pnlDisplay
            // 
            pnlDisplay.BorderStyle = BorderStyle.FixedSingle;
            pnlDisplay.Location = new Point(432, 37);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(500, 500);
            pnlDisplay.TabIndex = 0;
            // 
            // lblLeft
            // 
            lblLeft.AutoSize = true;
            lblLeft.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblLeft.ForeColor = Color.Gold;
            lblLeft.Location = new Point(593, 22);
            lblLeft.Name = "lblLeft";
            lblLeft.Size = new Size(41, 17);
            lblLeft.TabIndex = 1;
            lblLeft.Text = "Left:";
            lblLeft.TextAlign = ContentAlignment.TopRight;
            lblLeft.Visible = false;
            // 
            // btnRun
            // 
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Location = new Point(825, 6);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(107, 23);
            btnRun.TabIndex = 2;
            btnRun.Text = "RUN";
            btnRun.UseVisualStyleBackColor = false;
            // 
            // numericUpDownLeft
            // 
            numericUpDownLeft.BackColor = Color.Black;
            numericUpDownLeft.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            numericUpDownLeft.ForeColor = Color.Gold;
            numericUpDownLeft.Location = new Point(640, 22);
            numericUpDownLeft.Name = "numericUpDownLeft";
            numericUpDownLeft.Size = new Size(46, 20);
            numericUpDownLeft.TabIndex = 3;
            numericUpDownLeft.Visible = false;
            // 
            // numericUpDownTop
            // 
            numericUpDownTop.BackColor = Color.Black;
            numericUpDownTop.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            numericUpDownTop.ForeColor = Color.Gold;
            numericUpDownTop.Location = new Point(757, 22);
            numericUpDownTop.Name = "numericUpDownTop";
            numericUpDownTop.Size = new Size(46, 20);
            numericUpDownTop.TabIndex = 5;
            numericUpDownTop.Visible = false;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTop.ForeColor = Color.Gold;
            lblTop.Location = new Point(710, 25);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(41, 17);
            lblTop.TabIndex = 4;
            lblTop.Text = "Top:";
            lblTop.Visible = false;
            lblTop.Click += lblTop_Click;
            // 
            // numericUpDownBottom
            // 
            numericUpDownBottom.BackColor = Color.Black;
            numericUpDownBottom.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            numericUpDownBottom.ForeColor = Color.Gold;
            numericUpDownBottom.Location = new Point(757, 51);
            numericUpDownBottom.Name = "numericUpDownBottom";
            numericUpDownBottom.Size = new Size(46, 20);
            numericUpDownBottom.TabIndex = 9;
            numericUpDownBottom.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownBottom.Visible = false;
            // 
            // lblDBottom
            // 
            lblDBottom.AutoSize = true;
            lblDBottom.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblDBottom.ForeColor = Color.Gold;
            lblDBottom.Location = new Point(688, 51);
            lblDBottom.Name = "lblDBottom";
            lblDBottom.Size = new Size(63, 17);
            lblDBottom.TabIndex = 8;
            lblDBottom.Text = "Bottom:";
            lblDBottom.Visible = false;
            // 
            // numericUpDownRight
            // 
            numericUpDownRight.BackColor = Color.Black;
            numericUpDownRight.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            numericUpDownRight.ForeColor = Color.Gold;
            numericUpDownRight.Location = new Point(640, 48);
            numericUpDownRight.Name = "numericUpDownRight";
            numericUpDownRight.Size = new Size(46, 20);
            numericUpDownRight.TabIndex = 7;
            numericUpDownRight.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownRight.Visible = false;
            // 
            // lblRight
            // 
            lblRight.AutoSize = true;
            lblRight.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblRight.ForeColor = Color.Gold;
            lblRight.Location = new Point(583, 48);
            lblRight.Name = "lblRight";
            lblRight.Size = new Size(51, 17);
            lblRight.TabIndex = 6;
            lblRight.Text = "Right:";
            lblRight.TextAlign = ContentAlignment.TopRight;
            lblRight.Visible = false;
            // 
            // numericUpDownScreen
            // 
            numericUpDownScreen.BackColor = Color.Black;
            numericUpDownScreen.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            numericUpDownScreen.ForeColor = Color.Gold;
            numericUpDownScreen.Location = new Point(883, 22);
            numericUpDownScreen.Name = "numericUpDownScreen";
            numericUpDownScreen.Size = new Size(46, 20);
            numericUpDownScreen.TabIndex = 11;
            numericUpDownScreen.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(822, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 10;
            label1.Text = "Screen:";
            label1.Visible = false;
            // 
            // tmrUI
            // 
            tmrUI.Enabled = true;
            tmrUI.Interval = 50;
            tmrUI.Tick += tmrUI_Tick;
            // 
            // pnlPlayers
            // 
            pnlPlayers.BorderStyle = BorderStyle.FixedSingle;
            pnlPlayers.Location = new Point(12, 37);
            pnlPlayers.Name = "pnlPlayers";
            pnlPlayers.Size = new Size(400, 544);
            pnlPlayers.TabIndex = 1;
            pnlPlayers.Paint += panel1_Paint;
            // 
            // lblScreenDelayCaption
            // 
            lblScreenDelayCaption.AutoSize = true;
            lblScreenDelayCaption.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblScreenDelayCaption.ForeColor = Color.Gold;
            lblScreenDelayCaption.Location = new Point(12, 9);
            lblScreenDelayCaption.Name = "lblScreenDelayCaption";
            lblScreenDelayCaption.Size = new Size(101, 17);
            lblScreenDelayCaption.TabIndex = 12;
            lblScreenDelayCaption.Text = "screen delay";
            lblScreenDelayCaption.TextAlign = ContentAlignment.TopRight;
            // 
            // lblScreenDelayValue
            // 
            lblScreenDelayValue.AutoSize = true;
            lblScreenDelayValue.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblScreenDelayValue.ForeColor = Color.Gold;
            lblScreenDelayValue.Location = new Point(119, 9);
            lblScreenDelayValue.Name = "lblScreenDelayValue";
            lblScreenDelayValue.Size = new Size(101, 17);
            lblScreenDelayValue.TabIndex = 13;
            lblScreenDelayValue.Text = "screen delay";
            lblScreenDelayValue.TextAlign = ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(944, 637);
            Controls.Add(lblScreenDelayValue);
            Controls.Add(lblScreenDelayCaption);
            Controls.Add(pnlPlayers);
            Controls.Add(numericUpDownScreen);
            Controls.Add(label1);
            Controls.Add(numericUpDownBottom);
            Controls.Add(lblDBottom);
            Controls.Add(numericUpDownRight);
            Controls.Add(lblRight);
            Controls.Add(numericUpDownTop);
            Controls.Add(lblTop);
            Controls.Add(numericUpDownLeft);
            Controls.Add(btnRun);
            Controls.Add(lblLeft);
            Controls.Add(pnlDisplay);
            ForeColor = Color.Goldenrod;
            KeyPreview = true;
            Name = "MainForm";
            Text = "dota2 helper 0.2.0";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrScreenUpdate;
        private Panel pnlDisplay;
        private Label lblLeft;
        private Button btnRun;
        private NumericUpDown numericUpDownLeft;
        private NumericUpDown numericUpDownTop;
        private Label lblTop;
        private NumericUpDown numericUpDownBottom;
        private Label lblDBottom;
        private NumericUpDown numericUpDownRight;
        private Label lblRight;
        private NumericUpDown numericUpDownScreen;
        private Label label1;
        private System.Windows.Forms.Timer tmrUI;
        private Panel pnlPlayers;
        private Label lblScreenDelayCaption;
        private Label lblScreenDelayValue;
    }
}
