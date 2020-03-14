namespace predictive_coding
{
    partial class PredictiveCodingForm
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
            this.OriginalImagePictureBox = new System.Windows.Forms.PictureBox();
            this.CoderLoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalImagePictureBox
            // 
            this.OriginalImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalImagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.OriginalImagePictureBox.Name = "OriginalImagePictureBox";
            this.OriginalImagePictureBox.Size = new System.Drawing.Size(256, 256);
            this.OriginalImagePictureBox.TabIndex = 0;
            this.OriginalImagePictureBox.TabStop = false;
            // 
            // CoderLoadButton
            // 
            this.CoderLoadButton.Location = new System.Drawing.Point(12, 274);
            this.CoderLoadButton.Name = "CoderLoadButton";
            this.CoderLoadButton.Size = new System.Drawing.Size(75, 23);
            this.CoderLoadButton.TabIndex = 1;
            this.CoderLoadButton.Text = "Load";
            this.CoderLoadButton.UseVisualStyleBackColor = true;
            this.CoderLoadButton.Click += new System.EventHandler(this.CoderLoadButton_Click);
            // 
            // PredictiveCodingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.CoderLoadButton);
            this.Controls.Add(this.OriginalImagePictureBox);
            this.Name = "PredictiveCodingForm";
            this.Text = "Predictive Coding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalImagePictureBox;
        private System.Windows.Forms.Button CoderLoadButton;
    }
}

