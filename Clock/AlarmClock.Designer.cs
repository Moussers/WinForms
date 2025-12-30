namespace Clock
{
    partial class AlarmClock
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
            this.lblCurretnTime = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonOK = new System.Windows.Forms.Button();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblSettingDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurretnTime
            // 
            this.lblCurretnTime.AutoSize = true;
            this.lblCurretnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurretnTime.Location = new System.Drawing.Point(12, 9);
            this.lblCurretnTime.Name = "lblCurretnTime";
            this.lblCurretnTime.Size = new System.Drawing.Size(96, 20);
            this.lblCurretnTime.TabIndex = 1;
            this.lblCurretnTime.Text = "CurrentTime";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(16, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 30);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(222, 159);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 30);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHours.Location = new System.Drawing.Point(39, 79);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownHours.TabIndex = 6;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinutes.Location = new System.Drawing.Point(144, 79);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownMinutes.TabIndex = 7;
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSeconds.Location = new System.Drawing.Point(244, 79);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownSeconds.TabIndex = 8;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentDate.Location = new System.Drawing.Point(12, 40);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(97, 20);
            this.lblCurrentDate.TabIndex = 9;
            this.lblCurrentDate.Text = "CurrentDate";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHours.Location = new System.Drawing.Point(12, 79);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(21, 20);
            this.lblHours.TabIndex = 10;
            this.lblHours.Text = "H";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblM.Location = new System.Drawing.Point(117, 79);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(22, 20);
            this.lblM.TabIndex = 11;
            this.lblM.Text = "M";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblS.Location = new System.Drawing.Point(218, 79);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(20, 20);
            this.lblS.TabIndex = 12;
            this.lblS.Text = "S";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(111, 133);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // lblSettingDate
            // 
            this.lblSettingDate.AutoSize = true;
            this.lblSettingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSettingDate.Location = new System.Drawing.Point(12, 133);
            this.lblSettingDate.Name = "lblSettingDate";
            this.lblSettingDate.Size = new System.Drawing.Size(95, 20);
            this.lblSettingDate.TabIndex = 14;
            this.lblSettingDate.Text = "SettingDate";
            // 
            // AlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 237);
            this.Controls.Add(this.lblSettingDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.lblCurretnTime);
            this.Name = "AlarmClock";
            this.Text = "Alarm Clock";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurretnTime;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblSettingDate;
    }
}