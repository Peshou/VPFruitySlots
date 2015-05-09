namespace SlotsGame
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.spinTimer = new System.Windows.Forms.Timer(this.components);
            this.handleTimer = new System.Windows.Forms.Timer(this.components);
            this.waitBetweenSpinTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelHello = new System.Windows.Forms.Label();
            this.tbWin = new System.Windows.Forms.TextBox();
            this.nudYourBet = new System.Windows.Forms.NumericUpDown();
            this.nudLines = new System.Windows.Forms.NumericUpDown();
            this.btnMaxRaise = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaxLines = new System.Windows.Forms.Button();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.btnBuyCredits = new System.Windows.Forms.Button();
            this.labelYouWon = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMaxAutoSpin = new System.Windows.Forms.Label();
            this.nudAutoPlay = new System.Windows.Forms.NumericUpDown();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb15 = new System.Windows.Forms.PictureBox();
            this.pb14 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb13 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.btnHelpAndPayout = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.pbHandle = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYourBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLines)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoPlay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHandle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // spinTimer
            // 
            this.spinTimer.Interval = 60;
            this.spinTimer.Tick += new System.EventHandler(this.spinTimer_Tick);
            // 
            // handleTimer
            // 
            this.handleTimer.Tick += new System.EventHandler(this.handleTimer_Tick);
            // 
            // waitBetweenSpinTimer
            // 
            this.waitBetweenSpinTimer.Tick += new System.EventHandler(this.waitBetweenSpinTimer_Tick);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(251, 16);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(49, 20);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Hello:";
            // 
            // tbWin
            // 
            this.tbWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWin.Location = new System.Drawing.Point(305, 10);
            this.tbWin.Name = "tbWin";
            this.tbWin.ReadOnly = true;
            this.tbWin.Size = new System.Drawing.Size(128, 29);
            this.tbWin.TabIndex = 0;
            this.tbWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudYourBet
            // 
            this.nudYourBet.DecimalPlaces = 2;
            this.nudYourBet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudYourBet.Increment = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            this.nudYourBet.Location = new System.Drawing.Point(3, 70);
            this.nudYourBet.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.nudYourBet.Name = "nudYourBet";
            this.nudYourBet.Size = new System.Drawing.Size(92, 20);
            this.nudYourBet.TabIndex = 22;
            this.nudYourBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYourBet.ThousandsSeparator = true;
            this.nudYourBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYourBet.ValueChanged += new System.EventHandler(this.nudYourBet_ValueChanged);
            // 
            // nudLines
            // 
            this.nudLines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudLines.Location = new System.Drawing.Point(3, 70);
            this.nudLines.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLines.Name = "nudLines";
            this.nudLines.Size = new System.Drawing.Size(92, 20);
            this.nudLines.TabIndex = 22;
            this.nudLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLines.ThousandsSeparator = true;
            this.nudLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLines.ValueChanged += new System.EventHandler(this.nudLines_ValueChanged);
            // 
            // btnMaxRaise
            // 
            this.btnMaxRaise.Location = new System.Drawing.Point(5, 20);
            this.btnMaxRaise.Name = "btnMaxRaise";
            this.btnMaxRaise.Size = new System.Drawing.Size(87, 31);
            this.btnMaxRaise.TabIndex = 20;
            this.btnMaxRaise.Text = "Bet MAX";
            this.btnMaxRaise.UseVisualStyleBackColor = true;
            this.btnMaxRaise.Click += new System.EventHandler(this.btnMaxBet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnMaxLines);
            this.groupBox4.Controls.Add(this.nudLines);
            this.groupBox4.Location = new System.Drawing.Point(202, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 93);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lines";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Max = 15";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaxLines
            // 
            this.btnMaxLines.Location = new System.Drawing.Point(5, 20);
            this.btnMaxLines.Name = "btnMaxLines";
            this.btnMaxLines.Size = new System.Drawing.Size(87, 31);
            this.btnMaxLines.TabIndex = 23;
            this.btnMaxLines.Text = "Max Lines";
            this.btnMaxLines.UseVisualStyleBackColor = true;
            this.btnMaxLines.Click += new System.EventHandler(this.btnMaxLines_Click);
            // 
            // tbBalance
            // 
            this.tbBalance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBalance.Location = new System.Drawing.Point(3, 70);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(92, 20);
            this.tbBalance.TabIndex = 22;
            this.tbBalance.Text = "500";
            this.tbBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBalance.TextChanged += new System.EventHandler(this.tbBalance_TextChanged);
            // 
            // btnBuyCredits
            // 
            this.btnBuyCredits.Location = new System.Drawing.Point(584, 519);
            this.btnBuyCredits.Name = "btnBuyCredits";
            this.btnBuyCredits.Size = new System.Drawing.Size(116, 31);
            this.btnBuyCredits.TabIndex = 0;
            this.btnBuyCredits.Text = "Buy more credits?";
            this.btnBuyCredits.UseVisualStyleBackColor = true;
            this.btnBuyCredits.Click += new System.EventHandler(this.btnBuyCredits_Click);
            // 
            // labelYouWon
            // 
            this.labelYouWon.AutoSize = true;
            this.labelYouWon.BackColor = System.Drawing.Color.Transparent;
            this.labelYouWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYouWon.Location = new System.Drawing.Point(225, 16);
            this.labelYouWon.Name = "labelYouWon";
            this.labelYouWon.Size = new System.Drawing.Size(75, 20);
            this.labelYouWon.TabIndex = 0;
            this.labelYouWon.Text = "You won:";
            this.labelYouWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelYouWon.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblMaxAutoSpin);
            this.groupBox3.Controls.Add(this.nudAutoPlay);
            this.groupBox3.Controls.Add(this.btnAutoPlay);
            this.groupBox3.Location = new System.Drawing.Point(420, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 93);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autoplay";
            // 
            // lblMaxAutoSpin
            // 
            this.lblMaxAutoSpin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxAutoSpin.AutoSize = true;
            this.lblMaxAutoSpin.Location = new System.Drawing.Point(30, 57);
            this.lblMaxAutoSpin.Name = "lblMaxAutoSpin";
            this.lblMaxAutoSpin.Size = new System.Drawing.Size(57, 13);
            this.lblMaxAutoSpin.TabIndex = 23;
            this.lblMaxAutoSpin.Text = "Max = 100";
            this.lblMaxAutoSpin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAutoPlay
            // 
            this.nudAutoPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudAutoPlay.Location = new System.Drawing.Point(3, 70);
            this.nudAutoPlay.Name = "nudAutoPlay";
            this.nudAutoPlay.Size = new System.Drawing.Size(123, 20);
            this.nudAutoPlay.TabIndex = 22;
            this.nudAutoPlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAutoPlay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoPlay.ValueChanged += new System.EventHandler(this.nudAutoPlay_ValueChanged);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Location = new System.Drawing.Point(6, 16);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(118, 38);
            this.btnAutoPlay.TabIndex = 1;
            this.btnAutoPlay.Text = "Autoplay";
            this.btnAutoPlay.UseVisualStyleBackColor = true;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.tbBalance);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(80, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 93);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnd.Location = new System.Drawing.Point(5, 20);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(87, 31);
            this.btnEnd.TabIndex = 20;
            this.btnEnd.Text = "Quit Game";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nudYourBet);
            this.groupBox1.Controls.Add(this.btnMaxRaise);
            this.groupBox1.Location = new System.Drawing.Point(312, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Bet";
            // 
            // pb15
            // 
            this.pb15.BackColor = System.Drawing.Color.White;
            this.pb15.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb15.Location = new System.Drawing.Point(525, 308);
            this.pb15.Name = "pb15";
            this.pb15.Size = new System.Drawing.Size(96, 104);
            this.pb15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb15.TabIndex = 46;
            this.pb15.TabStop = false;
            // 
            // pb14
            // 
            this.pb14.BackColor = System.Drawing.Color.White;
            this.pb14.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb14.Location = new System.Drawing.Point(420, 308);
            this.pb14.Name = "pb14";
            this.pb14.Size = new System.Drawing.Size(96, 104);
            this.pb14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb14.TabIndex = 45;
            this.pb14.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.Color.White;
            this.pb9.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb9.Location = new System.Drawing.Point(421, 188);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(96, 104);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 43;
            this.pb9.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.White;
            this.pb5.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb5.Location = new System.Drawing.Point(525, 69);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(96, 104);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 42;
            this.pb5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.White;
            this.pb4.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb4.Location = new System.Drawing.Point(421, 69);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(96, 104);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 41;
            this.pb4.TabStop = false;
            // 
            // pb13
            // 
            this.pb13.BackColor = System.Drawing.Color.White;
            this.pb13.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb13.Location = new System.Drawing.Point(315, 308);
            this.pb13.Name = "pb13";
            this.pb13.Size = new System.Drawing.Size(96, 104);
            this.pb13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb13.TabIndex = 40;
            this.pb13.TabStop = false;
            // 
            // pb12
            // 
            this.pb12.BackColor = System.Drawing.Color.White;
            this.pb12.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb12.Location = new System.Drawing.Point(209, 308);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(96, 104);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb12.TabIndex = 39;
            this.pb12.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.White;
            this.pb8.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb8.Location = new System.Drawing.Point(314, 188);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(96, 104);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 38;
            this.pb8.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.White;
            this.pb7.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb7.Location = new System.Drawing.Point(209, 188);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(96, 104);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 37;
            this.pb7.TabStop = false;
            // 
            // pb10
            // 
            this.pb10.BackColor = System.Drawing.Color.White;
            this.pb10.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb10.Location = new System.Drawing.Point(525, 188);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(96, 104);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb10.TabIndex = 44;
            this.pb10.TabStop = false;
            // 
            // pb11
            // 
            this.pb11.BackColor = System.Drawing.Color.White;
            this.pb11.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb11.Location = new System.Drawing.Point(103, 308);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(96, 104);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb11.TabIndex = 36;
            this.pb11.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.White;
            this.pb6.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb6.Location = new System.Drawing.Point(103, 188);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(96, 104);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 35;
            this.pb6.TabStop = false;
            // 
            // btnHelpAndPayout
            // 
            this.btnHelpAndPayout.Location = new System.Drawing.Point(506, 2);
            this.btnHelpAndPayout.Name = "btnHelpAndPayout";
            this.btnHelpAndPayout.Size = new System.Drawing.Size(126, 37);
            this.btnHelpAndPayout.TabIndex = 0;
            this.btnHelpAndPayout.Text = "Rules / Payout";
            this.btnHelpAndPayout.UseVisualStyleBackColor = true;
            this.btnHelpAndPayout.Click += new System.EventHandler(this.btnHelpAndPayout_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpin.Location = new System.Drawing.Point(575, 455);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(135, 62);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // pbHandle
            // 
            this.pbHandle.BackColor = System.Drawing.Color.White;
            this.pbHandle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHandle.BackgroundImage")));
            this.pbHandle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbHandle.Enabled = false;
            this.pbHandle.Image = ((System.Drawing.Image)(resources.GetObject("pbHandle.Image")));
            this.pbHandle.ImageLocation = "";
            this.pbHandle.InitialImage = null;
            this.pbHandle.Location = new System.Drawing.Point(652, 69);
            this.pbHandle.Name = "pbHandle";
            this.pbHandle.Size = new System.Drawing.Size(87, 368);
            this.pbHandle.TabIndex = 32;
            this.pbHandle.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.White;
            this.pb3.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb3.Location = new System.Drawing.Point(315, 70);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(96, 104);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 31;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.White;
            this.pb2.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb2.Location = new System.Drawing.Point(209, 70);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(96, 104);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 30;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.Image = global::SlotsGame.Properties.Resources.questionMark;
            this.pb1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb1.InitialImage")));
            this.pb1.Location = new System.Drawing.Point(103, 70);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(96, 104);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 29;
            this.pb1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlotsGame.Properties.Resources.PlayScreen___Copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.tbWin);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnBuyCredits);
            this.Controls.Add(this.labelYouWon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb15);
            this.Controls.Add(this.pb14);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb13);
            this.Controls.Add(this.pb12);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb10);
            this.Controls.Add(this.pb11);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.btnHelpAndPayout);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pbHandle);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudYourBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLines)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoPlay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHandle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer spinTimer;
        private System.Windows.Forms.Timer handleTimer;
        private System.Windows.Forms.Timer waitBetweenSpinTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.TextBox tbWin;
        private System.Windows.Forms.NumericUpDown nudYourBet;
        private System.Windows.Forms.NumericUpDown nudLines;
        private System.Windows.Forms.Button btnMaxRaise;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMaxLines;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Button btnBuyCredits;
        private System.Windows.Forms.Label labelYouWon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMaxAutoSpin;
        private System.Windows.Forms.NumericUpDown nudAutoPlay;
        private System.Windows.Forms.Button btnAutoPlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb15;
        private System.Windows.Forms.PictureBox pb14;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb13;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.Button btnHelpAndPayout;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.PictureBox pbHandle;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label1;
    }
}