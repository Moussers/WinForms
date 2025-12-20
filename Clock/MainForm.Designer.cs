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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.cbShowWeelDay = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startTime = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTime = new System.Windows.Forms.ToolStripMenuItem();
            this.restartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SetTime = new System.Windows.Forms.ToolStripMenuItem();
            this.closePopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(261, 51);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "CurrentTime";
            this.labelTime.MouseHover += new System.EventHandler(this.labelTime_MouseHover);
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
            // 
            // cbShowWeelDay
            // 
            this.cbShowWeelDay.AutoSize = true;
            this.cbShowWeelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowWeelDay.Location = new System.Drawing.Point(21, 230);
            this.cbShowWeelDay.Name = "cbShowWeelDay";
            this.cbShowWeelDay.Size = new System.Drawing.Size(234, 28);
            this.cbShowWeelDay.TabIndex = 2;
            this.cbShowWeelDay.Text = "Показать день недели";
            this.cbShowWeelDay.UseVisualStyleBackColor = true;
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(21, 280);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(226, 74);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "System tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTime,
            this.stopTime,
            this.restartMenu,
            this.SetTime,
            this.closePopUpMenu});
            this.ContextMenu.Name = "contextMenuStrip1";
            this.ContextMenu.Size = new System.Drawing.Size(181, 136);
            this.ContextMenu.Text = "Контекстное меню";
            this.ContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenu_MouseClick);
            // 
            // startTime
            // 
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(180, 22);
            this.startTime.Text = "Запустить время";
            this.startTime.Click += new System.EventHandler(this.startTime_Click);
            // 
            // stopTime
            // 
            this.stopTime.Name = "stopTime";
            this.stopTime.Size = new System.Drawing.Size(180, 22);
            this.stopTime.Text = "Остановить время";
            this.stopTime.Click += new System.EventHandler(this.stopTime_Click);
            // 
            // restartMenu
            // 
            this.restartMenu.Name = "restartMenu";
            this.restartMenu.Size = new System.Drawing.Size(180, 22);
            this.restartMenu.Text = "Обновить время";
            this.restartMenu.Click += new System.EventHandler(this.restartMenu_Click);
            // 
            // SetTime
            // 
            this.SetTime.Name = "SetTime";
            this.SetTime.Size = new System.Drawing.Size(180, 22);
            this.SetTime.Text = "Установить время";
            this.SetTime.Click += new System.EventHandler(this.SetTime_Click);
            // 
            // closePopUpMenu
            // 
            this.closePopUpMenu.Name = "closePopUpMenu";
            this.closePopUpMenu.Size = new System.Drawing.Size(180, 22);
            this.closePopUpMenu.Text = "Закрыть";
            this.closePopUpMenu.Click += new System.EventHandler(this.closePopUpMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 382);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeelDay);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClockPV_521";
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.CheckBox cbShowWeelDay;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem startTime;
        private System.Windows.Forms.ToolStripMenuItem stopTime;
        private System.Windows.Forms.ToolStripMenuItem restartMenu;
        private System.Windows.Forms.ToolStripMenuItem SetTime;
        private System.Windows.Forms.ToolStripMenuItem closePopUpMenu;
    }
}

