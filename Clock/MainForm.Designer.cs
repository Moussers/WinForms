namespace Clock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBrownFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYellowFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGreenFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGreyFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlueFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLightBlueFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarkBlueFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVioletFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlackFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPinkFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWhiteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBrownArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrangeArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYellowArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGreenArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGreyArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlueArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiLightBlueArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarkBlueArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVioletArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlackArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWhiteArea = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAlarms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAutoStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.cbShowWeekday = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tsmiCustomFonts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegularFonts = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(261, 51);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "CurrentTime";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsmiShowControls,
            this.toolStripSeparator1,
            this.tsmiShowDate,
            this.tsmiShowWeekday,
            this.toolStripSeparator2,
            this.tsmiShowConsole,
            this.toolStripSeparator3,
            this.tsmiFont,
            this.tsmiColor,
            this.toolStripSeparator4,
            this.tsmiAlarms,
            this.toolStripSeparator5,
            this.tsmiAutoStart,
            this.toolStripSeparator6,
            this.tsmiQuit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 282);
            // 
            // tsmiTopmost
            // 
            this.tsmiTopmost.CheckOnClick = true;
            this.tsmiTopmost.Name = "tsmiTopmost";
            this.tsmiTopmost.Size = new System.Drawing.Size(180, 22);
            this.tsmiTopmost.Text = "Topmost";
            // 
            // tsmiShowControls
            // 
            this.tsmiShowControls.CheckOnClick = true;
            this.tsmiShowControls.Name = "tsmiShowControls";
            this.tsmiShowControls.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowControls.Text = "Show controls";
            this.tsmiShowControls.CheckedChanged += new System.EventHandler(this.tsmiShowControls_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiShowDate
            // 
            this.tsmiShowDate.CheckOnClick = true;
            this.tsmiShowDate.Name = "tsmiShowDate";
            this.tsmiShowDate.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowDate.Text = "Show date";
            this.tsmiShowDate.CheckedChanged += new System.EventHandler(this.tsmiShowDate_CheckedChanged);
            // 
            // tsmiShowWeekday
            // 
            this.tsmiShowWeekday.CheckOnClick = true;
            this.tsmiShowWeekday.Name = "tsmiShowWeekday";
            this.tsmiShowWeekday.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowWeekday.Text = "Show weekday";
            this.tsmiShowWeekday.CheckedChanged += new System.EventHandler(this.tsmiShowWeekday_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiShowConsole
            // 
            this.tsmiShowConsole.CheckOnClick = true;
            this.tsmiShowConsole.Name = "tsmiShowConsole";
            this.tsmiShowConsole.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowConsole.Text = "Show concole";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiFont
            // 
            this.tsmiFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomFonts,
            this.tsmiRegularFonts});
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(180, 22);
            this.tsmiFont.Text = "Font";
            this.tsmiFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmiColor
            // 
            this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundColor,
            this.tsmiBackgroundColor});
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiColor.Text = "Color";
            // 
            // tsmiForegroundColor
            // 
            this.tsmiForegroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRedFont,
            this.tsmiBrownFont,
            this.tsmiOrangeFont,
            this.tsmiYellowFont,
            this.tsmiGreenFont,
            this.tsmiGreyFont,
            this.tsmiBlueFont,
            this.tsmiLightBlueFont,
            this.tsmiDarkBlueFont,
            this.tsmiVioletFont,
            this.tsmiBlackFont,
            this.tsmiPinkFont,
            this.tsmiWhiteColor});
            this.tsmiForegroundColor.Name = "tsmiForegroundColor";
            this.tsmiForegroundColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiForegroundColor.Text = "Foreground color";
            // 
            // tsmiRedFont
            // 
            this.tsmiRedFont.Name = "tsmiRedFont";
            this.tsmiRedFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiRedFont.Text = "Red";
            this.tsmiRedFont.Click += new System.EventHandler(this.tsmiRedFont_Click);
            // 
            // tsmiBrownFont
            // 
            this.tsmiBrownFont.Name = "tsmiBrownFont";
            this.tsmiBrownFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiBrownFont.Text = "Brown";
            this.tsmiBrownFont.Click += new System.EventHandler(this.tsmiBrownFont_Click);
            // 
            // tsmiOrangeFont
            // 
            this.tsmiOrangeFont.Name = "tsmiOrangeFont";
            this.tsmiOrangeFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiOrangeFont.Text = "Orange";
            this.tsmiOrangeFont.Click += new System.EventHandler(this.tsmiOrangeFont_Click);
            // 
            // tsmiYellowFont
            // 
            this.tsmiYellowFont.Name = "tsmiYellowFont";
            this.tsmiYellowFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiYellowFont.Text = "Yellow";
            this.tsmiYellowFont.Click += new System.EventHandler(this.tsmiYellowFont_Click);
            // 
            // tsmiGreenFont
            // 
            this.tsmiGreenFont.Name = "tsmiGreenFont";
            this.tsmiGreenFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiGreenFont.Text = "Green";
            this.tsmiGreenFont.Click += new System.EventHandler(this.tsmiGreenFont_Click);
            // 
            // tsmiGreyFont
            // 
            this.tsmiGreyFont.Name = "tsmiGreyFont";
            this.tsmiGreyFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiGreyFont.Text = "Grey";
            this.tsmiGreyFont.Click += new System.EventHandler(this.tsmiGreyFont_Click);
            // 
            // tsmiBlueFont
            // 
            this.tsmiBlueFont.Name = "tsmiBlueFont";
            this.tsmiBlueFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiBlueFont.Text = "Blue";
            this.tsmiBlueFont.Click += new System.EventHandler(this.tsmiBlueArea_Click);
            // 
            // tsmiLightBlueFont
            // 
            this.tsmiLightBlueFont.Name = "tsmiLightBlueFont";
            this.tsmiLightBlueFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiLightBlueFont.Text = "Light Blue";
            this.tsmiLightBlueFont.Click += new System.EventHandler(this.tsmiLightBlueFont_Click);
            // 
            // tsmiDarkBlueFont
            // 
            this.tsmiDarkBlueFont.Name = "tsmiDarkBlueFont";
            this.tsmiDarkBlueFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiDarkBlueFont.Text = "Dark Blue";
            this.tsmiDarkBlueFont.Click += new System.EventHandler(this.tsmiDarkBlueFont_Click);
            // 
            // tsmiVioletFont
            // 
            this.tsmiVioletFont.Name = "tsmiVioletFont";
            this.tsmiVioletFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiVioletFont.Text = "Violet";
            this.tsmiVioletFont.Click += new System.EventHandler(this.tsmiVioletFont_Click);
            // 
            // tsmiBlackFont
            // 
            this.tsmiBlackFont.Name = "tsmiBlackFont";
            this.tsmiBlackFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiBlackFont.Text = "Black";
            this.tsmiBlackFont.Click += new System.EventHandler(this.tsmiBlackFont_Click);
            // 
            // tsmiPinkFont
            // 
            this.tsmiPinkFont.Name = "tsmiPinkFont";
            this.tsmiPinkFont.Size = new System.Drawing.Size(127, 22);
            this.tsmiPinkFont.Text = "Pink";
            this.tsmiPinkFont.Click += new System.EventHandler(this.tsmiPinkFont_Click);
            // 
            // tsmiWhiteColor
            // 
            this.tsmiWhiteColor.Name = "tsmiWhiteColor";
            this.tsmiWhiteColor.Size = new System.Drawing.Size(127, 22);
            this.tsmiWhiteColor.Text = "White";
            this.tsmiWhiteColor.Click += new System.EventHandler(this.tsmiWhiteColor_Click);
            // 
            // tsmiBackgroundColor
            // 
            this.tsmiBackgroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRedArea,
            this.tsmiBrownArea,
            this.tsmiOrangeArea,
            this.tsmiYellowArea,
            this.tsmiGreenArea,
            this.tsmiGreyArea,
            this.tsmiBlueArea,
            this.tmsiLightBlueArea,
            this.tsmiDarkBlueArea,
            this.tsmiVioletArea,
            this.tsmiBlackArea,
            this.tsmiWhiteArea});
            this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
            this.tsmiBackgroundColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiBackgroundColor.Text = "Background color";
            // 
            // tsmiRedArea
            // 
            this.tsmiRedArea.Name = "tsmiRedArea";
            this.tsmiRedArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiRedArea.Text = "Red";
            this.tsmiRedArea.Click += new System.EventHandler(this.tsmiRedArea_Click);
            // 
            // tsmiBrownArea
            // 
            this.tsmiBrownArea.Name = "tsmiBrownArea";
            this.tsmiBrownArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiBrownArea.Text = "Brown";
            this.tsmiBrownArea.Click += new System.EventHandler(this.tsmiBrownArea_Click);
            // 
            // tsmiOrangeArea
            // 
            this.tsmiOrangeArea.Name = "tsmiOrangeArea";
            this.tsmiOrangeArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiOrangeArea.Text = "Orange";
            this.tsmiOrangeArea.Click += new System.EventHandler(this.tsmiOrangeArea_Click);
            // 
            // tsmiYellowArea
            // 
            this.tsmiYellowArea.Name = "tsmiYellowArea";
            this.tsmiYellowArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiYellowArea.Text = "Yellow";
            this.tsmiYellowArea.Click += new System.EventHandler(this.tsmiYellowArea_Click);
            // 
            // tsmiGreenArea
            // 
            this.tsmiGreenArea.Name = "tsmiGreenArea";
            this.tsmiGreenArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiGreenArea.Text = "Green";
            this.tsmiGreenArea.Click += new System.EventHandler(this.tsmiGreenArea_Click);
            // 
            // tsmiGreyArea
            // 
            this.tsmiGreyArea.Name = "tsmiGreyArea";
            this.tsmiGreyArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiGreyArea.Text = "Grey";
            this.tsmiGreyArea.Click += new System.EventHandler(this.tsmiGreyArea_Click);
            // 
            // tsmiBlueArea
            // 
            this.tsmiBlueArea.Name = "tsmiBlueArea";
            this.tsmiBlueArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiBlueArea.Text = "Blue";
            this.tsmiBlueArea.Click += new System.EventHandler(this.tsmiBlueArea_Click_1);
            // 
            // tmsiLightBlueArea
            // 
            this.tmsiLightBlueArea.Name = "tmsiLightBlueArea";
            this.tmsiLightBlueArea.Size = new System.Drawing.Size(180, 22);
            this.tmsiLightBlueArea.Text = "Light Blue";
            this.tmsiLightBlueArea.Click += new System.EventHandler(this.tmsiLightBlueArea_Click);
            // 
            // tsmiDarkBlueArea
            // 
            this.tsmiDarkBlueArea.Name = "tsmiDarkBlueArea";
            this.tsmiDarkBlueArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiDarkBlueArea.Text = "Dark Blue";
            this.tsmiDarkBlueArea.Click += new System.EventHandler(this.tsmiDarkBlueArea_Click);
            // 
            // tsmiVioletArea
            // 
            this.tsmiVioletArea.Name = "tsmiVioletArea";
            this.tsmiVioletArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiVioletArea.Text = "Violet";
            this.tsmiVioletArea.Click += new System.EventHandler(this.tsmiVioletArea_Click);
            // 
            // tsmiBlackArea
            // 
            this.tsmiBlackArea.Name = "tsmiBlackArea";
            this.tsmiBlackArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiBlackArea.Text = "Black";
            this.tsmiBlackArea.Click += new System.EventHandler(this.tsmiBlackArea_Click);
            // 
            // tsmiWhiteArea
            // 
            this.tsmiWhiteArea.Name = "tsmiWhiteArea";
            this.tsmiWhiteArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiWhiteArea.Text = "White";
            this.tsmiWhiteArea.Click += new System.EventHandler(this.tsmiWhiteArea_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiAlarms
            // 
            this.tsmiAlarms.Name = "tsmiAlarms";
            this.tsmiAlarms.Size = new System.Drawing.Size(180, 22);
            this.tsmiAlarms.Text = "Alarms";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiAutoStart
            // 
            this.tsmiAutoStart.Name = "tsmiAutoStart";
            this.tsmiAutoStart.Size = new System.Drawing.Size(180, 22);
            this.tsmiAutoStart.Text = "Auto start";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(180, 22);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.Location = new System.Drawing.Point(21, 196);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(159, 28);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Показать дату";
            this.cbShowDate.UseVisualStyleBackColor = true;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
            // 
            // cbShowWeekday
            // 
            this.cbShowWeekday.AutoSize = true;
            this.cbShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowWeekday.Location = new System.Drawing.Point(21, 230);
            this.cbShowWeekday.Name = "cbShowWeekday";
            this.cbShowWeekday.Size = new System.Drawing.Size(234, 28);
            this.cbShowWeekday.TabIndex = 2;
            this.cbShowWeekday.Text = "Показать день недели";
            this.cbShowWeekday.UseVisualStyleBackColor = true;
            this.cbShowWeekday.CheckedChanged += new System.EventHandler(this.cbShowWeekday_CheckedChanged);
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(21, 280);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(262, 90);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "System tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // tsmiCustomFonts
            // 
            this.tsmiCustomFonts.Name = "tsmiCustomFonts";
            this.tsmiCustomFonts.Size = new System.Drawing.Size(180, 22);
            this.tsmiCustomFonts.Text = "Custom Fonts";
            // 
            // tsmiRegularFonts
            // 
            this.tsmiRegularFonts.Name = "tsmiRegularFonts";
            this.tsmiRegularFonts.Size = new System.Drawing.Size(180, 22);
            this.tsmiRegularFonts.Text = "Regular Fonts";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 382);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeekday);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ClockPV521";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.CheckBox cbShowWeekday;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlarms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiBrownFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrangeFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiYellowFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiGreenFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiLightBlueFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarkBlueFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiVioletFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlackFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiBrownArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrangeArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiYellowArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiGreenArea;
        private System.Windows.Forms.ToolStripMenuItem tmsiLightBlueArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarkBlueArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiVioletArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlackArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlueFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiPinkFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlueArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiWhiteColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiWhiteArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiGreyFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiGreyArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomFonts;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegularFonts;
    }
}

