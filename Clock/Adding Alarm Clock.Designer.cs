namespace Clock
{
    partial class AddingAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingAlarm));
            this.AlarmList = new System.Windows.Forms.ListBox();
            this.buttonAddNewAlarm = new System.Windows.Forms.Button();
            this.buttonChangeAlarm = new System.Windows.Forms.Button();
            this.buttonDeleteAlarm = new System.Windows.Forms.Button();
            this.lblListAlarms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlarmList
            // 
            this.AlarmList.FormattingEnabled = true;
            this.AlarmList.Location = new System.Drawing.Point(16, 40);
            this.AlarmList.Name = "AlarmList";
            this.AlarmList.Size = new System.Drawing.Size(218, 303);
            this.AlarmList.TabIndex = 2;
            // 
            // buttonAddNewAlarm
            // 
            this.buttonAddNewAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewAlarm.Location = new System.Drawing.Point(249, 40);
            this.buttonAddNewAlarm.Name = "buttonAddNewAlarm";
            this.buttonAddNewAlarm.Size = new System.Drawing.Size(114, 31);
            this.buttonAddNewAlarm.TabIndex = 3;
            this.buttonAddNewAlarm.Text = "Добавить";
            this.buttonAddNewAlarm.UseVisualStyleBackColor = true;
            this.buttonAddNewAlarm.Click += new System.EventHandler(this.buttonNewAlarm_Click);
            // 
            // buttonChangeAlarm
            // 
            this.buttonChangeAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeAlarm.Location = new System.Drawing.Point(249, 95);
            this.buttonChangeAlarm.Name = "buttonChangeAlarm";
            this.buttonChangeAlarm.Size = new System.Drawing.Size(111, 31);
            this.buttonChangeAlarm.TabIndex = 4;
            this.buttonChangeAlarm.Text = "Изменить";
            this.buttonChangeAlarm.UseVisualStyleBackColor = true;
            this.buttonChangeAlarm.Click += new System.EventHandler(this.buttonChangeAlarm_Click);
            // 
            // buttonDeleteAlarm
            // 
            this.buttonDeleteAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteAlarm.Location = new System.Drawing.Point(249, 156);
            this.buttonDeleteAlarm.Name = "buttonDeleteAlarm";
            this.buttonDeleteAlarm.Size = new System.Drawing.Size(90, 31);
            this.buttonDeleteAlarm.TabIndex = 5;
            this.buttonDeleteAlarm.Text = "Удалить";
            this.buttonDeleteAlarm.UseVisualStyleBackColor = true;
            this.buttonDeleteAlarm.Click += new System.EventHandler(this.buttonDeleteAlarm_Click);
            // 
            // lblListAlarms
            // 
            this.lblListAlarms.AutoSize = true;
            this.lblListAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblListAlarms.Location = new System.Drawing.Point(16, 13);
            this.lblListAlarms.Name = "lblListAlarms";
            this.lblListAlarms.Size = new System.Drawing.Size(166, 20);
            this.lblListAlarms.TabIndex = 6;
            this.lblListAlarms.Text = "Список будильников";
            // 
            // AddingAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 358);
            this.Controls.Add(this.lblListAlarms);
            this.Controls.Add(this.buttonDeleteAlarm);
            this.Controls.Add(this.buttonChangeAlarm);
            this.Controls.Add(this.buttonAddNewAlarm);
            this.Controls.Add(this.AlarmList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddingAlarm";
            this.Text = "Adding Alarm Clocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox AlarmList;
        private System.Windows.Forms.Button buttonAddNewAlarm;
        private System.Windows.Forms.Button buttonChangeAlarm;
        private System.Windows.Forms.Button buttonDeleteAlarm;
        private System.Windows.Forms.Label lblListAlarms;
    }
}