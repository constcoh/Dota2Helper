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
            btnRun = new Button();
            tmrUI = new System.Windows.Forms.Timer(components);
            pnlPlayers = new Panel();
            lblScreenDelayCaption = new Label();
            lblScreenDelayValue = new Label();
            richTextBoxInputHero0 = new RichTextBox();
            richTextBoxInputHero1 = new RichTextBox();
            richTextBoxInputHero2 = new RichTextBox();
            richTextBoxInputHero3 = new RichTextBox();
            richTextBoxInputHero4 = new RichTextBox();
            richTextBoxInputHero9 = new RichTextBox();
            richTextBoxInputHero8 = new RichTextBox();
            richTextBoxInputHero7 = new RichTextBox();
            richTextBoxInputHero6 = new RichTextBox();
            richTextBoxInputHero5 = new RichTextBox();
            lblHeroStat0 = new Label();
            lblHeroStat5 = new Label();
            lblHeroStat6 = new Label();
            lblHeroStat7 = new Label();
            lblHeroStat8 = new Label();
            lblHeroStat9 = new Label();
            lblHeroStat4 = new Label();
            lblHeroStat3 = new Label();
            lblHeroStat2 = new Label();
            lblHeroStat1 = new Label();
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
            pnlDisplay.Location = new Point(680, 40);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(500, 500);
            pnlDisplay.TabIndex = 0;
            // 
            // btnRun
            // 
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Location = new Point(1073, 9);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(107, 23);
            btnRun.TabIndex = 2;
            btnRun.Text = "RUN";
            btnRun.UseVisualStyleBackColor = false;
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
            // richTextBoxInputHero0
            // 
            richTextBoxInputHero0.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero0.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero0.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero0.Location = new Point(418, 71);
            richTextBoxInputHero0.Name = "richTextBoxInputHero0";
            richTextBoxInputHero0.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero0.Size = new Size(120, 28);
            richTextBoxInputHero0.TabIndex = 46;
            richTextBoxInputHero0.Text = "test";
            richTextBoxInputHero0.Leave += richTextBoxInputHero0_Leave;
            // 
            // richTextBoxInputHero1
            // 
            richTextBoxInputHero1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero1.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero1.Location = new Point(418, 123);
            richTextBoxInputHero1.Name = "richTextBoxInputHero1";
            richTextBoxInputHero1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero1.Size = new Size(120, 28);
            richTextBoxInputHero1.TabIndex = 47;
            richTextBoxInputHero1.Text = "test";
            richTextBoxInputHero1.Leave += richTextBoxInputHero1_Leave;
            // 
            // richTextBoxInputHero2
            // 
            richTextBoxInputHero2.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero2.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero2.Location = new Point(418, 172);
            richTextBoxInputHero2.Name = "richTextBoxInputHero2";
            richTextBoxInputHero2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero2.Size = new Size(120, 28);
            richTextBoxInputHero2.TabIndex = 48;
            richTextBoxInputHero2.Text = "test";
            richTextBoxInputHero2.Leave += richTextBoxInputHero2_Leave;
            // 
            // richTextBoxInputHero3
            // 
            richTextBoxInputHero3.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero3.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero3.Location = new Point(418, 221);
            richTextBoxInputHero3.Name = "richTextBoxInputHero3";
            richTextBoxInputHero3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero3.Size = new Size(120, 28);
            richTextBoxInputHero3.TabIndex = 49;
            richTextBoxInputHero3.Text = "test";
            richTextBoxInputHero3.Leave += richTextBoxInputHero3_Leave;
            // 
            // richTextBoxInputHero4
            // 
            richTextBoxInputHero4.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero4.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero4.Location = new Point(418, 274);
            richTextBoxInputHero4.Name = "richTextBoxInputHero4";
            richTextBoxInputHero4.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero4.Size = new Size(120, 28);
            richTextBoxInputHero4.TabIndex = 50;
            richTextBoxInputHero4.Text = "test";
            richTextBoxInputHero4.Leave += richTextBoxInputHero4_Leave;
            // 
            // richTextBoxInputHero9
            // 
            richTextBoxInputHero9.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero9.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero9.Location = new Point(418, 544);
            richTextBoxInputHero9.Name = "richTextBoxInputHero9";
            richTextBoxInputHero9.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero9.Size = new Size(120, 28);
            richTextBoxInputHero9.TabIndex = 55;
            richTextBoxInputHero9.Text = "test";
            richTextBoxInputHero9.Leave += richTextBoxInputHero9_Leave;
            // 
            // richTextBoxInputHero8
            // 
            richTextBoxInputHero8.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero8.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero8.Location = new Point(418, 491);
            richTextBoxInputHero8.Name = "richTextBoxInputHero8";
            richTextBoxInputHero8.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero8.Size = new Size(120, 28);
            richTextBoxInputHero8.TabIndex = 54;
            richTextBoxInputHero8.Text = "test";
            richTextBoxInputHero8.Leave += richTextBoxInputHero8_Leave;
            // 
            // richTextBoxInputHero7
            // 
            richTextBoxInputHero7.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero7.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero7.Location = new Point(418, 442);
            richTextBoxInputHero7.Name = "richTextBoxInputHero7";
            richTextBoxInputHero7.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero7.Size = new Size(120, 28);
            richTextBoxInputHero7.TabIndex = 53;
            richTextBoxInputHero7.Text = "test";
            richTextBoxInputHero7.Leave += richTextBoxInputHero7_Leave;
            // 
            // richTextBoxInputHero6
            // 
            richTextBoxInputHero6.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero6.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero6.Location = new Point(418, 393);
            richTextBoxInputHero6.Name = "richTextBoxInputHero6";
            richTextBoxInputHero6.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero6.Size = new Size(120, 28);
            richTextBoxInputHero6.TabIndex = 52;
            richTextBoxInputHero6.Text = "test";
            richTextBoxInputHero6.Leave += richTextBoxInputHero6_Leave;
            // 
            // richTextBoxInputHero5
            // 
            richTextBoxInputHero5.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            richTextBoxInputHero5.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero5.Location = new Point(418, 341);
            richTextBoxInputHero5.Name = "richTextBoxInputHero5";
            richTextBoxInputHero5.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero5.Size = new Size(120, 28);
            richTextBoxInputHero5.TabIndex = 51;
            richTextBoxInputHero5.Text = "test";
            richTextBoxInputHero5.Leave += richTextBoxInputHero5_Leave;
            // 
            // lblHeroStat0
            // 
            lblHeroStat0.AutoSize = true;
            lblHeroStat0.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat0.ForeColor = Color.Gold;
            lblHeroStat0.Location = new Point(544, 65);
            lblHeroStat0.Name = "lblHeroStat0";
            lblHeroStat0.Size = new Size(119, 34);
            lblHeroStat0.TabIndex = 56;
            lblHeroStat0.Text = "agility\r\nroles: 1,2,3,4,5";
            // 
            // lblHeroStat5
            // 
            lblHeroStat5.AutoSize = true;
            lblHeroStat5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat5.ForeColor = Color.Gold;
            lblHeroStat5.Location = new Point(544, 335);
            lblHeroStat5.Name = "lblHeroStat5";
            lblHeroStat5.Size = new Size(119, 17);
            lblHeroStat5.TabIndex = 61;
            lblHeroStat5.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat6
            // 
            lblHeroStat6.AutoSize = true;
            lblHeroStat6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat6.ForeColor = Color.Gold;
            lblHeroStat6.Location = new Point(544, 387);
            lblHeroStat6.Name = "lblHeroStat6";
            lblHeroStat6.Size = new Size(119, 17);
            lblHeroStat6.TabIndex = 62;
            lblHeroStat6.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat7
            // 
            lblHeroStat7.AutoSize = true;
            lblHeroStat7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat7.ForeColor = Color.Gold;
            lblHeroStat7.Location = new Point(544, 436);
            lblHeroStat7.Name = "lblHeroStat7";
            lblHeroStat7.Size = new Size(119, 17);
            lblHeroStat7.TabIndex = 63;
            lblHeroStat7.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat8
            // 
            lblHeroStat8.AutoSize = true;
            lblHeroStat8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat8.ForeColor = Color.Gold;
            lblHeroStat8.Location = new Point(544, 485);
            lblHeroStat8.Name = "lblHeroStat8";
            lblHeroStat8.Size = new Size(119, 17);
            lblHeroStat8.TabIndex = 64;
            lblHeroStat8.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat9
            // 
            lblHeroStat9.AutoSize = true;
            lblHeroStat9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat9.ForeColor = Color.Gold;
            lblHeroStat9.Location = new Point(544, 538);
            lblHeroStat9.Name = "lblHeroStat9";
            lblHeroStat9.Size = new Size(119, 17);
            lblHeroStat9.TabIndex = 65;
            lblHeroStat9.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat4
            // 
            lblHeroStat4.AutoSize = true;
            lblHeroStat4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat4.ForeColor = Color.Gold;
            lblHeroStat4.Location = new Point(544, 268);
            lblHeroStat4.Name = "lblHeroStat4";
            lblHeroStat4.Size = new Size(119, 17);
            lblHeroStat4.TabIndex = 60;
            lblHeroStat4.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat3
            // 
            lblHeroStat3.AutoSize = true;
            lblHeroStat3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat3.ForeColor = Color.Gold;
            lblHeroStat3.Location = new Point(544, 215);
            lblHeroStat3.Name = "lblHeroStat3";
            lblHeroStat3.Size = new Size(119, 17);
            lblHeroStat3.TabIndex = 59;
            lblHeroStat3.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat2
            // 
            lblHeroStat2.AutoSize = true;
            lblHeroStat2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat2.ForeColor = Color.Gold;
            lblHeroStat2.Location = new Point(544, 166);
            lblHeroStat2.Name = "lblHeroStat2";
            lblHeroStat2.Size = new Size(119, 17);
            lblHeroStat2.TabIndex = 58;
            lblHeroStat2.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat1
            // 
            lblHeroStat1.AutoSize = true;
            lblHeroStat1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHeroStat1.ForeColor = Color.Gold;
            lblHeroStat1.Location = new Point(544, 117);
            lblHeroStat1.Name = "lblHeroStat1";
            lblHeroStat1.Size = new Size(119, 17);
            lblHeroStat1.TabIndex = 57;
            lblHeroStat1.Text = "roles: 1,2,3,4,5";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1192, 637);
            Controls.Add(lblHeroStat9);
            Controls.Add(lblHeroStat8);
            Controls.Add(lblHeroStat7);
            Controls.Add(lblHeroStat6);
            Controls.Add(lblHeroStat5);
            Controls.Add(lblHeroStat4);
            Controls.Add(lblHeroStat3);
            Controls.Add(lblHeroStat2);
            Controls.Add(lblHeroStat1);
            Controls.Add(lblHeroStat0);
            Controls.Add(richTextBoxInputHero9);
            Controls.Add(richTextBoxInputHero8);
            Controls.Add(richTextBoxInputHero7);
            Controls.Add(richTextBoxInputHero6);
            Controls.Add(richTextBoxInputHero5);
            Controls.Add(richTextBoxInputHero4);
            Controls.Add(richTextBoxInputHero3);
            Controls.Add(richTextBoxInputHero2);
            Controls.Add(richTextBoxInputHero1);
            Controls.Add(richTextBoxInputHero0);
            Controls.Add(lblScreenDelayValue);
            Controls.Add(lblScreenDelayCaption);
            Controls.Add(pnlPlayers);
            Controls.Add(btnRun);
            Controls.Add(pnlDisplay);
            ForeColor = Color.Goldenrod;
            KeyPreview = true;
            Name = "MainForm";
            Text = "dota2 helper 1.0.0";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrScreenUpdate;
        private Panel pnlDisplay;
        private Button btnRun;
        private System.Windows.Forms.Timer tmrUI;
        private Panel pnlPlayers;
        private Label lblScreenDelayCaption;
        private Label lblScreenDelayValue;
        private RichTextBox richTextBoxInputHero0;
        private RichTextBox richTextBoxInputHero1;
        private RichTextBox richTextBoxInputHero2;
        private RichTextBox richTextBoxInputHero3;
        private RichTextBox richTextBoxInputHero4;
        private RichTextBox richTextBoxInputHero9;
        private RichTextBox richTextBoxInputHero8;
        private RichTextBox richTextBoxInputHero7;
        private RichTextBox richTextBoxInputHero6;
        private RichTextBox richTextBoxInputHero5;
        private Label lblHeroStat0;
        private Label lblHeroStat5;
        private Label lblHeroStat6;
        private Label lblHeroStat7;
        private Label lblHeroStat8;
        private Label lblHeroStat9;
        private Label lblHeroStat4;
        private Label lblHeroStat3;
        private Label lblHeroStat2;
        private Label lblHeroStat1;
    }
}
