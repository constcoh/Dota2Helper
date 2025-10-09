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
            lblLinkPT_0 = new Label();
            lblLinkPT_1 = new Label();
            lblLinkPT_2 = new Label();
            lblLinkPT_3 = new Label();
            lblLinkPT_4 = new Label();
            lblLinkPT_5 = new Label();
            lblLinkPT_6 = new Label();
            lblLinkPT_7 = new Label();
            lblLinkPT_8 = new Label();
            lblLinkPT_9 = new Label();
            lblLinkD2_9 = new Label();
            lblLinkD2_8 = new Label();
            lblLinkD2_7 = new Label();
            lblLinkD2_6 = new Label();
            lblLinkD2_5 = new Label();
            lblLinkD2_4 = new Label();
            lblLinkD2_3 = new Label();
            lblLinkD2_2 = new Label();
            lblLinkD2_1 = new Label();
            lblLinkD2_0 = new Label();
            SuspendLayout();
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
            pnlPlayers.Size = new Size(390, 544);
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
            richTextBoxInputHero0.BorderStyle = BorderStyle.None;
            richTextBoxInputHero0.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero0.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero0.Location = new Point(481, 65);
            richTextBoxInputHero0.Name = "richTextBoxInputHero0";
            richTextBoxInputHero0.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero0.Size = new Size(120, 16);
            richTextBoxInputHero0.TabIndex = 46;
            richTextBoxInputHero0.Text = "test";
            richTextBoxInputHero0.Leave += richTextBoxInputHero0_Leave;
            // 
            // richTextBoxInputHero1
            // 
            richTextBoxInputHero1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero1.BorderStyle = BorderStyle.None;
            richTextBoxInputHero1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero1.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero1.Location = new Point(481, 117);
            richTextBoxInputHero1.Name = "richTextBoxInputHero1";
            richTextBoxInputHero1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero1.Size = new Size(120, 16);
            richTextBoxInputHero1.TabIndex = 47;
            richTextBoxInputHero1.Text = "test";
            richTextBoxInputHero1.Leave += richTextBoxInputHero1_Leave;
            // 
            // richTextBoxInputHero2
            // 
            richTextBoxInputHero2.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero2.BorderStyle = BorderStyle.None;
            richTextBoxInputHero2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero2.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero2.Location = new Point(481, 166);
            richTextBoxInputHero2.Name = "richTextBoxInputHero2";
            richTextBoxInputHero2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero2.Size = new Size(120, 16);
            richTextBoxInputHero2.TabIndex = 48;
            richTextBoxInputHero2.Text = "test";
            richTextBoxInputHero2.Leave += richTextBoxInputHero2_Leave;
            // 
            // richTextBoxInputHero3
            // 
            richTextBoxInputHero3.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero3.BorderStyle = BorderStyle.None;
            richTextBoxInputHero3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero3.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero3.Location = new Point(481, 215);
            richTextBoxInputHero3.Name = "richTextBoxInputHero3";
            richTextBoxInputHero3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero3.Size = new Size(120, 16);
            richTextBoxInputHero3.TabIndex = 49;
            richTextBoxInputHero3.Text = "test";
            richTextBoxInputHero3.Leave += richTextBoxInputHero3_Leave;
            // 
            // richTextBoxInputHero4
            // 
            richTextBoxInputHero4.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero4.BorderStyle = BorderStyle.None;
            richTextBoxInputHero4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero4.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero4.Location = new Point(481, 268);
            richTextBoxInputHero4.Name = "richTextBoxInputHero4";
            richTextBoxInputHero4.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero4.Size = new Size(120, 16);
            richTextBoxInputHero4.TabIndex = 50;
            richTextBoxInputHero4.Text = "test";
            richTextBoxInputHero4.Leave += richTextBoxInputHero4_Leave;
            // 
            // richTextBoxInputHero9
            // 
            richTextBoxInputHero9.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero9.BorderStyle = BorderStyle.None;
            richTextBoxInputHero9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero9.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero9.Location = new Point(481, 538);
            richTextBoxInputHero9.Name = "richTextBoxInputHero9";
            richTextBoxInputHero9.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero9.Size = new Size(120, 16);
            richTextBoxInputHero9.TabIndex = 55;
            richTextBoxInputHero9.Text = "test";
            richTextBoxInputHero9.Leave += richTextBoxInputHero9_Leave;
            // 
            // richTextBoxInputHero8
            // 
            richTextBoxInputHero8.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero8.BorderStyle = BorderStyle.None;
            richTextBoxInputHero8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero8.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero8.Location = new Point(481, 485);
            richTextBoxInputHero8.Name = "richTextBoxInputHero8";
            richTextBoxInputHero8.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero8.Size = new Size(120, 16);
            richTextBoxInputHero8.TabIndex = 54;
            richTextBoxInputHero8.Text = "test";
            richTextBoxInputHero8.Leave += richTextBoxInputHero8_Leave;
            // 
            // richTextBoxInputHero7
            // 
            richTextBoxInputHero7.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero7.BorderStyle = BorderStyle.None;
            richTextBoxInputHero7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero7.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero7.Location = new Point(481, 436);
            richTextBoxInputHero7.Name = "richTextBoxInputHero7";
            richTextBoxInputHero7.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero7.Size = new Size(120, 16);
            richTextBoxInputHero7.TabIndex = 53;
            richTextBoxInputHero7.Text = "test";
            richTextBoxInputHero7.Leave += richTextBoxInputHero7_Leave;
            // 
            // richTextBoxInputHero6
            // 
            richTextBoxInputHero6.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero6.BorderStyle = BorderStyle.None;
            richTextBoxInputHero6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero6.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero6.Location = new Point(481, 387);
            richTextBoxInputHero6.Name = "richTextBoxInputHero6";
            richTextBoxInputHero6.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero6.Size = new Size(120, 16);
            richTextBoxInputHero6.TabIndex = 52;
            richTextBoxInputHero6.Text = "test";
            richTextBoxInputHero6.Leave += richTextBoxInputHero6_Leave;
            // 
            // richTextBoxInputHero5
            // 
            richTextBoxInputHero5.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInputHero5.BorderStyle = BorderStyle.None;
            richTextBoxInputHero5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBoxInputHero5.ForeColor = Color.FromArgb(255, 192, 128);
            richTextBoxInputHero5.Location = new Point(481, 335);
            richTextBoxInputHero5.Name = "richTextBoxInputHero5";
            richTextBoxInputHero5.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxInputHero5.Size = new Size(120, 16);
            richTextBoxInputHero5.TabIndex = 51;
            richTextBoxInputHero5.Text = "test";
            richTextBoxInputHero5.Leave += richTextBoxInputHero5_Leave;
            // 
            // lblHeroStat0
            // 
            lblHeroStat0.AutoSize = true;
            lblHeroStat0.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat0.ForeColor = Color.Gold;
            lblHeroStat0.Location = new Point(408, 84);
            lblHeroStat0.Name = "lblHeroStat0";
            lblHeroStat0.Size = new Size(119, 32);
            lblHeroStat0.TabIndex = 56;
            lblHeroStat0.Text = "agility\r\nroles: 1,2,3,4,5";
            // 
            // lblHeroStat5
            // 
            lblHeroStat5.AutoSize = true;
            lblHeroStat5.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat5.ForeColor = Color.Gold;
            lblHeroStat5.Location = new Point(408, 354);
            lblHeroStat5.Name = "lblHeroStat5";
            lblHeroStat5.Size = new Size(119, 16);
            lblHeroStat5.TabIndex = 61;
            lblHeroStat5.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat6
            // 
            lblHeroStat6.AutoSize = true;
            lblHeroStat6.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat6.ForeColor = Color.Gold;
            lblHeroStat6.Location = new Point(408, 406);
            lblHeroStat6.Name = "lblHeroStat6";
            lblHeroStat6.Size = new Size(119, 16);
            lblHeroStat6.TabIndex = 62;
            lblHeroStat6.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat7
            // 
            lblHeroStat7.AutoSize = true;
            lblHeroStat7.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat7.ForeColor = Color.Gold;
            lblHeroStat7.Location = new Point(408, 455);
            lblHeroStat7.Name = "lblHeroStat7";
            lblHeroStat7.Size = new Size(119, 16);
            lblHeroStat7.TabIndex = 63;
            lblHeroStat7.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat8
            // 
            lblHeroStat8.AutoSize = true;
            lblHeroStat8.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat8.ForeColor = Color.Gold;
            lblHeroStat8.Location = new Point(408, 504);
            lblHeroStat8.Name = "lblHeroStat8";
            lblHeroStat8.Size = new Size(119, 16);
            lblHeroStat8.TabIndex = 64;
            lblHeroStat8.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat9
            // 
            lblHeroStat9.AutoSize = true;
            lblHeroStat9.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat9.ForeColor = Color.Gold;
            lblHeroStat9.Location = new Point(408, 557);
            lblHeroStat9.Name = "lblHeroStat9";
            lblHeroStat9.Size = new Size(119, 16);
            lblHeroStat9.TabIndex = 65;
            lblHeroStat9.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat4
            // 
            lblHeroStat4.AutoSize = true;
            lblHeroStat4.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat4.ForeColor = Color.Gold;
            lblHeroStat4.Location = new Point(408, 287);
            lblHeroStat4.Name = "lblHeroStat4";
            lblHeroStat4.Size = new Size(119, 16);
            lblHeroStat4.TabIndex = 60;
            lblHeroStat4.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat3
            // 
            lblHeroStat3.AutoSize = true;
            lblHeroStat3.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat3.ForeColor = Color.Gold;
            lblHeroStat3.Location = new Point(408, 234);
            lblHeroStat3.Name = "lblHeroStat3";
            lblHeroStat3.Size = new Size(119, 16);
            lblHeroStat3.TabIndex = 59;
            lblHeroStat3.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat2
            // 
            lblHeroStat2.AutoSize = true;
            lblHeroStat2.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat2.ForeColor = Color.Gold;
            lblHeroStat2.Location = new Point(408, 185);
            lblHeroStat2.Name = "lblHeroStat2";
            lblHeroStat2.Size = new Size(119, 16);
            lblHeroStat2.TabIndex = 58;
            lblHeroStat2.Text = "roles: 1,2,3,4,5";
            // 
            // lblHeroStat1
            // 
            lblHeroStat1.AutoSize = true;
            lblHeroStat1.Font = new Font("Cascadia Mono", 9F);
            lblHeroStat1.ForeColor = Color.Gold;
            lblHeroStat1.Location = new Point(408, 136);
            lblHeroStat1.Name = "lblHeroStat1";
            lblHeroStat1.Size = new Size(119, 16);
            lblHeroStat1.TabIndex = 57;
            lblHeroStat1.Text = "roles: 1,2,3,4,5";
            // 
            // lblLinkPT_0
            // 
            lblLinkPT_0.AutoSize = true;
            lblLinkPT_0.Cursor = Cursors.Hand;
            lblLinkPT_0.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_0.ForeColor = Color.Gold;
            lblLinkPT_0.Location = new Point(428, 65);
            lblLinkPT_0.Name = "lblLinkPT_0";
            lblLinkPT_0.Size = new Size(24, 15);
            lblLinkPT_0.TabIndex = 66;
            lblLinkPT_0.Text = "PT";
            // 
            // lblLinkPT_1
            // 
            lblLinkPT_1.AutoSize = true;
            lblLinkPT_1.Cursor = Cursors.Hand;
            lblLinkPT_1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_1.ForeColor = Color.Gold;
            lblLinkPT_1.Location = new Point(428, 118);
            lblLinkPT_1.Name = "lblLinkPT_1";
            lblLinkPT_1.Size = new Size(24, 15);
            lblLinkPT_1.TabIndex = 67;
            lblLinkPT_1.Text = "PT";
            // 
            // lblLinkPT_2
            // 
            lblLinkPT_2.AutoSize = true;
            lblLinkPT_2.Cursor = Cursors.Hand;
            lblLinkPT_2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_2.ForeColor = Color.Gold;
            lblLinkPT_2.Location = new Point(428, 166);
            lblLinkPT_2.Name = "lblLinkPT_2";
            lblLinkPT_2.Size = new Size(24, 15);
            lblLinkPT_2.TabIndex = 68;
            lblLinkPT_2.Text = "PT";
            // 
            // lblLinkPT_3
            // 
            lblLinkPT_3.AutoSize = true;
            lblLinkPT_3.Cursor = Cursors.Hand;
            lblLinkPT_3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_3.ForeColor = Color.Gold;
            lblLinkPT_3.Location = new Point(428, 215);
            lblLinkPT_3.Name = "lblLinkPT_3";
            lblLinkPT_3.Size = new Size(24, 15);
            lblLinkPT_3.TabIndex = 69;
            lblLinkPT_3.Text = "PT";
            // 
            // lblLinkPT_4
            // 
            lblLinkPT_4.AutoSize = true;
            lblLinkPT_4.Cursor = Cursors.Hand;
            lblLinkPT_4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_4.ForeColor = Color.Gold;
            lblLinkPT_4.Location = new Point(428, 268);
            lblLinkPT_4.Name = "lblLinkPT_4";
            lblLinkPT_4.Size = new Size(24, 15);
            lblLinkPT_4.TabIndex = 70;
            lblLinkPT_4.Text = "PT";
            // 
            // lblLinkPT_5
            // 
            lblLinkPT_5.AutoSize = true;
            lblLinkPT_5.Cursor = Cursors.Hand;
            lblLinkPT_5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_5.ForeColor = Color.Gold;
            lblLinkPT_5.Location = new Point(428, 335);
            lblLinkPT_5.Name = "lblLinkPT_5";
            lblLinkPT_5.Size = new Size(24, 15);
            lblLinkPT_5.TabIndex = 71;
            lblLinkPT_5.Text = "PT";
            // 
            // lblLinkPT_6
            // 
            lblLinkPT_6.AutoSize = true;
            lblLinkPT_6.Cursor = Cursors.Hand;
            lblLinkPT_6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_6.ForeColor = Color.Gold;
            lblLinkPT_6.Location = new Point(428, 388);
            lblLinkPT_6.Name = "lblLinkPT_6";
            lblLinkPT_6.Size = new Size(24, 15);
            lblLinkPT_6.TabIndex = 72;
            lblLinkPT_6.Text = "PT";
            // 
            // lblLinkPT_7
            // 
            lblLinkPT_7.AutoSize = true;
            lblLinkPT_7.Cursor = Cursors.Hand;
            lblLinkPT_7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_7.ForeColor = Color.Gold;
            lblLinkPT_7.Location = new Point(428, 436);
            lblLinkPT_7.Name = "lblLinkPT_7";
            lblLinkPT_7.Size = new Size(24, 15);
            lblLinkPT_7.TabIndex = 73;
            lblLinkPT_7.Text = "PT";
            // 
            // lblLinkPT_8
            // 
            lblLinkPT_8.AutoSize = true;
            lblLinkPT_8.Cursor = Cursors.Hand;
            lblLinkPT_8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_8.ForeColor = Color.Gold;
            lblLinkPT_8.Location = new Point(428, 485);
            lblLinkPT_8.Name = "lblLinkPT_8";
            lblLinkPT_8.Size = new Size(24, 15);
            lblLinkPT_8.TabIndex = 74;
            lblLinkPT_8.Text = "PT";
            // 
            // lblLinkPT_9
            // 
            lblLinkPT_9.AutoSize = true;
            lblLinkPT_9.Cursor = Cursors.Hand;
            lblLinkPT_9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkPT_9.ForeColor = Color.Gold;
            lblLinkPT_9.Location = new Point(428, 538);
            lblLinkPT_9.Name = "lblLinkPT_9";
            lblLinkPT_9.Size = new Size(24, 15);
            lblLinkPT_9.TabIndex = 75;
            lblLinkPT_9.Text = "PT";
            // 
            // lblLinkD2_9
            // 
            lblLinkD2_9.AutoSize = true;
            lblLinkD2_9.Cursor = Cursors.Hand;
            lblLinkD2_9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_9.ForeColor = Color.Gold;
            lblLinkD2_9.Location = new Point(450, 538);
            lblLinkD2_9.Name = "lblLinkD2_9";
            lblLinkD2_9.Size = new Size(25, 15);
            lblLinkD2_9.TabIndex = 85;
            lblLinkD2_9.Text = "D2";
            // 
            // lblLinkD2_8
            // 
            lblLinkD2_8.AutoSize = true;
            lblLinkD2_8.Cursor = Cursors.Hand;
            lblLinkD2_8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_8.ForeColor = Color.Gold;
            lblLinkD2_8.Location = new Point(450, 485);
            lblLinkD2_8.Name = "lblLinkD2_8";
            lblLinkD2_8.Size = new Size(25, 15);
            lblLinkD2_8.TabIndex = 84;
            lblLinkD2_8.Text = "D2";
            // 
            // lblLinkD2_7
            // 
            lblLinkD2_7.AutoSize = true;
            lblLinkD2_7.Cursor = Cursors.Hand;
            lblLinkD2_7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_7.ForeColor = Color.Gold;
            lblLinkD2_7.Location = new Point(450, 436);
            lblLinkD2_7.Name = "lblLinkD2_7";
            lblLinkD2_7.Size = new Size(25, 15);
            lblLinkD2_7.TabIndex = 83;
            lblLinkD2_7.Text = "D2";
            // 
            // lblLinkD2_6
            // 
            lblLinkD2_6.AutoSize = true;
            lblLinkD2_6.Cursor = Cursors.Hand;
            lblLinkD2_6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_6.ForeColor = Color.Gold;
            lblLinkD2_6.Location = new Point(450, 388);
            lblLinkD2_6.Name = "lblLinkD2_6";
            lblLinkD2_6.Size = new Size(25, 15);
            lblLinkD2_6.TabIndex = 82;
            lblLinkD2_6.Text = "D2";
            // 
            // lblLinkD2_5
            // 
            lblLinkD2_5.AutoSize = true;
            lblLinkD2_5.Cursor = Cursors.Hand;
            lblLinkD2_5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_5.ForeColor = Color.Gold;
            lblLinkD2_5.Location = new Point(450, 335);
            lblLinkD2_5.Name = "lblLinkD2_5";
            lblLinkD2_5.Size = new Size(25, 15);
            lblLinkD2_5.TabIndex = 81;
            lblLinkD2_5.Text = "D2";
            // 
            // lblLinkD2_4
            // 
            lblLinkD2_4.AutoSize = true;
            lblLinkD2_4.Cursor = Cursors.Hand;
            lblLinkD2_4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_4.ForeColor = Color.Gold;
            lblLinkD2_4.Location = new Point(450, 268);
            lblLinkD2_4.Name = "lblLinkD2_4";
            lblLinkD2_4.Size = new Size(25, 15);
            lblLinkD2_4.TabIndex = 80;
            lblLinkD2_4.Text = "D2";
            // 
            // lblLinkD2_3
            // 
            lblLinkD2_3.AutoSize = true;
            lblLinkD2_3.Cursor = Cursors.Hand;
            lblLinkD2_3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_3.ForeColor = Color.Gold;
            lblLinkD2_3.Location = new Point(450, 215);
            lblLinkD2_3.Name = "lblLinkD2_3";
            lblLinkD2_3.Size = new Size(25, 15);
            lblLinkD2_3.TabIndex = 79;
            lblLinkD2_3.Text = "D2";
            // 
            // lblLinkD2_2
            // 
            lblLinkD2_2.AutoSize = true;
            lblLinkD2_2.Cursor = Cursors.Hand;
            lblLinkD2_2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_2.ForeColor = Color.Gold;
            lblLinkD2_2.Location = new Point(450, 166);
            lblLinkD2_2.Name = "lblLinkD2_2";
            lblLinkD2_2.Size = new Size(25, 15);
            lblLinkD2_2.TabIndex = 78;
            lblLinkD2_2.Text = "D2";
            // 
            // lblLinkD2_1
            // 
            lblLinkD2_1.AutoSize = true;
            lblLinkD2_1.Cursor = Cursors.Hand;
            lblLinkD2_1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_1.ForeColor = Color.Gold;
            lblLinkD2_1.Location = new Point(450, 118);
            lblLinkD2_1.Name = "lblLinkD2_1";
            lblLinkD2_1.Size = new Size(25, 15);
            lblLinkD2_1.TabIndex = 77;
            lblLinkD2_1.Text = "D2";
            // 
            // lblLinkD2_0
            // 
            lblLinkD2_0.AutoSize = true;
            lblLinkD2_0.Cursor = Cursors.Hand;
            lblLinkD2_0.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline);
            lblLinkD2_0.ForeColor = Color.Gold;
            lblLinkD2_0.Location = new Point(450, 65);
            lblLinkD2_0.Name = "lblLinkD2_0";
            lblLinkD2_0.Size = new Size(25, 15);
            lblLinkD2_0.TabIndex = 76;
            lblLinkD2_0.Text = "D2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1191, 637);
            Controls.Add(lblLinkD2_9);
            Controls.Add(lblLinkD2_8);
            Controls.Add(lblLinkD2_7);
            Controls.Add(lblLinkD2_6);
            Controls.Add(lblLinkD2_5);
            Controls.Add(lblLinkD2_4);
            Controls.Add(lblLinkD2_3);
            Controls.Add(lblLinkD2_2);
            Controls.Add(lblLinkD2_1);
            Controls.Add(lblLinkD2_0);
            Controls.Add(lblLinkPT_9);
            Controls.Add(lblLinkPT_8);
            Controls.Add(lblLinkPT_7);
            Controls.Add(lblLinkPT_6);
            Controls.Add(lblLinkPT_5);
            Controls.Add(lblLinkPT_4);
            Controls.Add(lblLinkPT_3);
            Controls.Add(lblLinkPT_2);
            Controls.Add(lblLinkPT_1);
            Controls.Add(lblLinkPT_0);
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
            Font = new Font("Microsoft Sans Serif", 9F);
            ForeColor = Color.Goldenrod;
            KeyPreview = true;
            Name = "MainForm";
            Text = "dota2 helper 1.1.0";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label lblLinkPT_0;
        private Label lblLinkPT_1;
        private Label lblLinkPT_2;
        private Label lblLinkPT_3;
        private Label lblLinkPT_4;
        private Label lblLinkPT_5;
        private Label lblLinkPT_6;
        private Label lblLinkPT_7;
        private Label lblLinkPT_8;
        private Label lblLinkPT_9;
        private Label lblLinkD2_9;
        private Label lblLinkD2_8;
        private Label lblLinkD2_7;
        private Label lblLinkD2_6;
        private Label lblLinkD2_5;
        private Label lblLinkD2_4;
        private Label lblLinkD2_3;
        private Label lblLinkD2_2;
        private Label lblLinkD2_1;
        private Label lblLinkD2_0;
    }
}
