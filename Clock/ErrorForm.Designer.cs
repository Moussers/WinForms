namespace Clock
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.okey = new System.Windows.Forms.Button();
            this.strMessError = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okey
            // 
            this.okey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okey.Location = new System.Drawing.Point(260, 141);
            this.okey.Name = "okey";
            this.okey.Size = new System.Drawing.Size(75, 26);
            this.okey.TabIndex = 1;
            this.okey.Text = "Ок";
            this.okey.UseVisualStyleBackColor = true;
            this.okey.Click += new System.EventHandler(this.okey_Click);
            // 
            // strMessError
            // 
            this.strMessError.BackColor = System.Drawing.SystemColors.Control;
            this.strMessError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.strMessError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strMessError.Location = new System.Drawing.Point(84, 35);
            this.strMessError.Multiline = true;
            this.strMessError.Name = "strMessError";
            this.strMessError.Size = new System.Drawing.Size(251, 91);
            this.strMessError.TabIndex = 2;
            this.strMessError.Text = "Веедена строка, а не число";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StrErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 179);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.strMessError);
            this.Controls.Add(this.okey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StrErrorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StrErrorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okey;
        private System.Windows.Forms.TextBox strMessError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}