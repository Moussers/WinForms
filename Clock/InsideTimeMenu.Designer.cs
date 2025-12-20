namespace Clock
{
    partial class InsideTimeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsideTimeMenu));
            this.Hours = new System.Windows.Forms.Label();
            this.fieldHours = new System.Windows.Forms.TextBox();
            this.Minutes = new System.Windows.Forms.Label();
            this.fieldMinutes = new System.Windows.Forms.TextBox();
            this.Seconds = new System.Windows.Forms.Label();
            this.fieldSeconds = new System.Windows.Forms.TextBox();
            this.okey = new System.Windows.Forms.Button();
            this.errorField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hours.Location = new System.Drawing.Point(58, 30);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(72, 29);
            this.Hours.TabIndex = 0;
            this.Hours.Text = "Часы";
            // 
            // fieldHours
            // 
            this.fieldHours.Location = new System.Drawing.Point(143, 39);
            this.fieldHours.Name = "fieldHours";
            this.fieldHours.Size = new System.Drawing.Size(322, 20);
            this.fieldHours.TabIndex = 1;
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minutes.Location = new System.Drawing.Point(27, 83);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(103, 29);
            this.Minutes.TabIndex = 2;
            this.Minutes.Text = "Минуты";
            // 
            // fieldMinutes
            // 
            this.fieldMinutes.Location = new System.Drawing.Point(143, 92);
            this.fieldMinutes.Name = "fieldMinutes";
            this.fieldMinutes.Size = new System.Drawing.Size(322, 20);
            this.fieldMinutes.TabIndex = 3;
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seconds.Location = new System.Drawing.Point(17, 133);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(113, 29);
            this.Seconds.TabIndex = 4;
            this.Seconds.Text = "Секунды";
            // 
            // fieldSeconds
            // 
            this.fieldSeconds.Location = new System.Drawing.Point(143, 142);
            this.fieldSeconds.Name = "fieldSeconds";
            this.fieldSeconds.Size = new System.Drawing.Size(322, 20);
            this.fieldSeconds.TabIndex = 5;
            // 
            // okey
            // 
            this.okey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okey.Location = new System.Drawing.Point(378, 191);
            this.okey.Name = "okey";
            this.okey.Size = new System.Drawing.Size(87, 30);
            this.okey.TabIndex = 6;
            this.okey.Text = "Ок";
            this.okey.UseVisualStyleBackColor = true;
            this.okey.Click += new System.EventHandler(this.okey_Click);
            // 
            // errorField
            // 
            this.errorField.Location = new System.Drawing.Point(22, 191);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(219, 20);
            this.errorField.TabIndex = 7;
            // 
            // InsideTimeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 244);
            this.Controls.Add(this.errorField);
            this.Controls.Add(this.okey);
            this.Controls.Add(this.fieldSeconds);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.fieldMinutes);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.fieldHours);
            this.Controls.Add(this.Hours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsideTimeMenu";
            this.Text = "Изменение часов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.TextBox fieldHours;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.TextBox fieldMinutes;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.TextBox fieldSeconds;
        private System.Windows.Forms.Button okey;
        private System.Windows.Forms.TextBox errorField;
    }
}