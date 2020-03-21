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
            this.ErrorImagePictureBox = new System.Windows.Forms.PictureBox();
            this.OriginalImageLabel = new System.Windows.Forms.Label();
            this.ErrorImageLabel = new System.Windows.Forms.Label();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.CoderSaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.kSelectorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kSelectorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalImagePictureBox
            // 
            this.OriginalImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalImagePictureBox.Location = new System.Drawing.Point(12, 23);
            this.OriginalImagePictureBox.Name = "OriginalImagePictureBox";
            this.OriginalImagePictureBox.Size = new System.Drawing.Size(256, 256);
            this.OriginalImagePictureBox.TabIndex = 0;
            this.OriginalImagePictureBox.TabStop = false;
            // 
            // CoderLoadButton
            // 
            this.CoderLoadButton.Location = new System.Drawing.Point(12, 302);
            this.CoderLoadButton.Name = "CoderLoadButton";
            this.CoderLoadButton.Size = new System.Drawing.Size(75, 23);
            this.CoderLoadButton.TabIndex = 1;
            this.CoderLoadButton.Text = "Load";
            this.CoderLoadButton.UseVisualStyleBackColor = true;
            this.CoderLoadButton.Click += new System.EventHandler(this.CoderLoadButton_Click);
            // 
            // ErrorImagePictureBox
            // 
            this.ErrorImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorImagePictureBox.Location = new System.Drawing.Point(287, 23);
            this.ErrorImagePictureBox.Name = "ErrorImagePictureBox";
            this.ErrorImagePictureBox.Size = new System.Drawing.Size(256, 256);
            this.ErrorImagePictureBox.TabIndex = 2;
            this.ErrorImagePictureBox.TabStop = false;
            // 
            // OriginalImageLabel
            // 
            this.OriginalImageLabel.AutoSize = true;
            this.OriginalImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalImageLabel.Location = new System.Drawing.Point(9, 4);
            this.OriginalImageLabel.Name = "OriginalImageLabel";
            this.OriginalImageLabel.Size = new System.Drawing.Size(109, 16);
            this.OriginalImageLabel.TabIndex = 3;
            this.OriginalImageLabel.Text = "Original Image";
            // 
            // ErrorImageLabel
            // 
            this.ErrorImageLabel.AutoSize = true;
            this.ErrorImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorImageLabel.Location = new System.Drawing.Point(284, 4);
            this.ErrorImageLabel.Name = "ErrorImageLabel";
            this.ErrorImageLabel.Size = new System.Drawing.Size(89, 16);
            this.ErrorImageLabel.TabIndex = 4;
            this.ErrorImageLabel.Text = "Error Image";
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(12, 331);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(75, 23);
            this.EncodeButton.TabIndex = 5;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            // 
            // CoderSaveButton
            // 
            this.CoderSaveButton.Location = new System.Drawing.Point(12, 360);
            this.CoderSaveButton.Name = "CoderSaveButton";
            this.CoderSaveButton.Size = new System.Drawing.Size(75, 23);
            this.CoderSaveButton.TabIndex = 6;
            this.CoderSaveButton.Text = "Save";
            this.CoderSaveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predictor Selector";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(41, 105);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(65, 17);
            this.radioButton9.TabIndex = 9;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "JPEGLS";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(109, 84);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(74, 17);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "(A + B) / 2";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(109, 62);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(90, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "B + (A - C) / 2";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(109, 39);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(90, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "A + (B - C) / 2";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(109, 16);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(67, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "A + B - C";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 85);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(32, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "C";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "A";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "128";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // kSelectorNumericUpDown
            // 
            this.kSelectorNumericUpDown.Location = new System.Drawing.Point(121, 331);
            this.kSelectorNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kSelectorNumericUpDown.Name = "kSelectorNumericUpDown";
            this.kSelectorNumericUpDown.ReadOnly = true;
            this.kSelectorNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.kSelectorNumericUpDown.TabIndex = 8;
            this.kSelectorNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kSelectorNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // kValueLabel
            // 
            this.kValueLabel.AutoSize = true;
            this.kValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kValueLabel.Location = new System.Drawing.Point(118, 302);
            this.kValueLabel.Name = "kValueLabel";
            this.kValueLabel.Size = new System.Drawing.Size(61, 16);
            this.kValueLabel.TabIndex = 9;
            this.kValueLabel.Text = "K Value";
            // 
            // PredictiveCodingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.kValueLabel);
            this.Controls.Add(this.kSelectorNumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CoderSaveButton);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.ErrorImageLabel);
            this.Controls.Add(this.OriginalImageLabel);
            this.Controls.Add(this.ErrorImagePictureBox);
            this.Controls.Add(this.CoderLoadButton);
            this.Controls.Add(this.OriginalImagePictureBox);
            this.Name = "PredictiveCodingForm";
            this.Text = "Predictive Coding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kSelectorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalImagePictureBox;
        private System.Windows.Forms.Button CoderLoadButton;
        private System.Windows.Forms.PictureBox ErrorImagePictureBox;
        private System.Windows.Forms.Label OriginalImageLabel;
        private System.Windows.Forms.Label ErrorImageLabel;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button CoderSaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.NumericUpDown kSelectorNumericUpDown;
        private System.Windows.Forms.Label kValueLabel;
    }
}

