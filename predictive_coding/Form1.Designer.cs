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
            this.originalImagePictureBox = new System.Windows.Forms.PictureBox();
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
            this.ErrorImageRefreshButton = new System.Windows.Forms.Button();
            this.ComputeErrorButton = new System.Windows.Forms.Button();
            this.MinErrorLabel = new System.Windows.Forms.Label();
            this.MaxErrorLabel = new System.Windows.Forms.Label();
            this.ErrorImageGroupBox = new System.Windows.Forms.GroupBox();
            this.QuantizedPredictionErrorRadioButton = new System.Windows.Forms.RadioButton();
            this.PredictionErrorRadioButton = new System.Windows.Forms.RadioButton();
            this.contrastTextBox = new System.Windows.Forms.TextBox();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.saveModeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.originalImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kSelectorNumericUpDown)).BeginInit();
            this.ErrorImageGroupBox.SuspendLayout();
            this.saveModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // originalImagePictureBox
            // 
            this.originalImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImagePictureBox.Location = new System.Drawing.Point(12, 23);
            this.originalImagePictureBox.Name = "originalImagePictureBox";
            this.originalImagePictureBox.Size = new System.Drawing.Size(256, 256);
            this.originalImagePictureBox.TabIndex = 0;
            this.originalImagePictureBox.TabStop = false;
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
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // CoderSaveButton
            // 
            this.CoderSaveButton.Location = new System.Drawing.Point(12, 360);
            this.CoderSaveButton.Name = "CoderSaveButton";
            this.CoderSaveButton.Size = new System.Drawing.Size(75, 23);
            this.CoderSaveButton.TabIndex = 6;
            this.CoderSaveButton.Text = "Save";
            this.CoderSaveButton.UseVisualStyleBackColor = true;
            this.CoderSaveButton.Click += new System.EventHandler(this.CoderSaveButton_Click);
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
            this.kSelectorNumericUpDown.ValueChanged += new System.EventHandler(this.KSelectorNumericUpDown_ValueChanged);
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
            // ErrorImageRefreshButton
            // 
            this.ErrorImageRefreshButton.Location = new System.Drawing.Point(468, 325);
            this.ErrorImageRefreshButton.Name = "ErrorImageRefreshButton";
            this.ErrorImageRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.ErrorImageRefreshButton.TabIndex = 10;
            this.ErrorImageRefreshButton.Text = "Refresh";
            this.ErrorImageRefreshButton.UseVisualStyleBackColor = true;
            this.ErrorImageRefreshButton.Click += new System.EventHandler(this.ErrorImageRefreshButton_Click);
            // 
            // ComputeErrorButton
            // 
            this.ComputeErrorButton.Location = new System.Drawing.Point(287, 528);
            this.ComputeErrorButton.Name = "ComputeErrorButton";
            this.ComputeErrorButton.Size = new System.Drawing.Size(86, 23);
            this.ComputeErrorButton.TabIndex = 11;
            this.ComputeErrorButton.Text = "Compute Error";
            this.ComputeErrorButton.UseVisualStyleBackColor = true;
            this.ComputeErrorButton.Click += new System.EventHandler(this.ComputeErrorButton_Click);
            // 
            // MinErrorLabel
            // 
            this.MinErrorLabel.AutoSize = true;
            this.MinErrorLabel.Location = new System.Drawing.Point(284, 563);
            this.MinErrorLabel.Name = "MinErrorLabel";
            this.MinErrorLabel.Size = new System.Drawing.Size(52, 13);
            this.MinErrorLabel.TabIndex = 12;
            this.MinErrorLabel.Text = "Min Error:";
            // 
            // MaxErrorLabel
            // 
            this.MaxErrorLabel.AutoSize = true;
            this.MaxErrorLabel.Location = new System.Drawing.Point(284, 590);
            this.MaxErrorLabel.Name = "MaxErrorLabel";
            this.MaxErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.MaxErrorLabel.TabIndex = 13;
            this.MaxErrorLabel.Text = "Max Error:";
            // 
            // ErrorImageGroupBox
            // 
            this.ErrorImageGroupBox.Controls.Add(this.QuantizedPredictionErrorRadioButton);
            this.ErrorImageGroupBox.Controls.Add(this.PredictionErrorRadioButton);
            this.ErrorImageGroupBox.Location = new System.Drawing.Point(287, 285);
            this.ErrorImageGroupBox.Name = "ErrorImageGroupBox";
            this.ErrorImageGroupBox.Size = new System.Drawing.Size(175, 66);
            this.ErrorImageGroupBox.TabIndex = 14;
            this.ErrorImageGroupBox.TabStop = false;
            this.ErrorImageGroupBox.Text = "Error Image Selector";
            // 
            // QuantizedPredictionErrorRadioButton
            // 
            this.QuantizedPredictionErrorRadioButton.AutoSize = true;
            this.QuantizedPredictionErrorRadioButton.Location = new System.Drawing.Point(6, 43);
            this.QuantizedPredictionErrorRadioButton.Name = "QuantizedPredictionErrorRadioButton";
            this.QuantizedPredictionErrorRadioButton.Size = new System.Drawing.Size(148, 17);
            this.QuantizedPredictionErrorRadioButton.TabIndex = 16;
            this.QuantizedPredictionErrorRadioButton.Text = "Quantized Prediction Error";
            this.QuantizedPredictionErrorRadioButton.UseVisualStyleBackColor = true;
            // 
            // PredictionErrorRadioButton
            // 
            this.PredictionErrorRadioButton.AutoSize = true;
            this.PredictionErrorRadioButton.Checked = true;
            this.PredictionErrorRadioButton.Location = new System.Drawing.Point(6, 20);
            this.PredictionErrorRadioButton.Name = "PredictionErrorRadioButton";
            this.PredictionErrorRadioButton.Size = new System.Drawing.Size(97, 17);
            this.PredictionErrorRadioButton.TabIndex = 15;
            this.PredictionErrorRadioButton.TabStop = true;
            this.PredictionErrorRadioButton.Text = "Prediction Error";
            this.PredictionErrorRadioButton.UseVisualStyleBackColor = true;
            // 
            // contrastTextBox
            // 
            this.contrastTextBox.Location = new System.Drawing.Point(468, 298);
            this.contrastTextBox.Name = "contrastTextBox";
            this.contrastTextBox.Size = new System.Drawing.Size(75, 20);
            this.contrastTextBox.TabIndex = 15;
            this.contrastTextBox.Text = "1";
            this.contrastTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastLabel.Location = new System.Drawing.Point(468, 282);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(58, 13);
            this.contrastLabel.TabIndex = 16;
            this.contrastLabel.Text = "Contrast:";
            // 
            // saveModeGroupBox
            // 
            this.saveModeGroupBox.Controls.Add(this.radioButton12);
            this.saveModeGroupBox.Controls.Add(this.radioButton11);
            this.saveModeGroupBox.Controls.Add(this.radioButton10);
            this.saveModeGroupBox.Location = new System.Drawing.Point(11, 528);
            this.saveModeGroupBox.Name = "saveModeGroupBox";
            this.saveModeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.saveModeGroupBox.TabIndex = 17;
            this.saveModeGroupBox.TabStop = false;
            this.saveModeGroupBox.Text = "Save Mode";
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 65);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(71, 17);
            this.radioButton12.TabIndex = 20;
            this.radioButton12.Text = "Arithmetic";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 42);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(52, 17);
            this.radioButton11.TabIndex = 19;
            this.radioButton11.Text = "Table";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 19);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(84, 17);
            this.radioButton10.TabIndex = 18;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Fixed (9 bits)";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // PredictiveCodingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.saveModeGroupBox);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.contrastTextBox);
            this.Controls.Add(this.ErrorImageGroupBox);
            this.Controls.Add(this.MaxErrorLabel);
            this.Controls.Add(this.MinErrorLabel);
            this.Controls.Add(this.ComputeErrorButton);
            this.Controls.Add(this.ErrorImageRefreshButton);
            this.Controls.Add(this.kValueLabel);
            this.Controls.Add(this.kSelectorNumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CoderSaveButton);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.ErrorImageLabel);
            this.Controls.Add(this.OriginalImageLabel);
            this.Controls.Add(this.ErrorImagePictureBox);
            this.Controls.Add(this.CoderLoadButton);
            this.Controls.Add(this.originalImagePictureBox);
            this.Name = "PredictiveCodingForm";
            this.Text = "Predictive Coding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originalImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kSelectorNumericUpDown)).EndInit();
            this.ErrorImageGroupBox.ResumeLayout(false);
            this.ErrorImageGroupBox.PerformLayout();
            this.saveModeGroupBox.ResumeLayout(false);
            this.saveModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImagePictureBox;
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
        private System.Windows.Forms.Button ErrorImageRefreshButton;
        private System.Windows.Forms.Button ComputeErrorButton;
        private System.Windows.Forms.Label MinErrorLabel;
        private System.Windows.Forms.Label MaxErrorLabel;
        private System.Windows.Forms.GroupBox ErrorImageGroupBox;
        private System.Windows.Forms.RadioButton QuantizedPredictionErrorRadioButton;
        private System.Windows.Forms.RadioButton PredictionErrorRadioButton;
        private System.Windows.Forms.TextBox contrastTextBox;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.GroupBox saveModeGroupBox;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
    }
}

