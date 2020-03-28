using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace predictive_coding
{
    public partial class PredictiveCodingForm : Form
    {
        string imagePath = null;
        const int PREDICTION_ERROR_IMAGE = 0;
        const int QUANTIZED_PREDICITON_ERROR_IMAGE = 1;
        int selectedErrorImage = PREDICTION_ERROR_IMAGE;
        Coder coder;
        public PredictiveCodingForm()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);
            radioButton8.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);
            radioButton9.CheckedChanged += new EventHandler(PredictorRadioButton_CheckedChanged);

            PredictionErrorRadioButton.CheckedChanged += new EventHandler(SelectedErrorImageRadioButton_CheckedChanged);
            QuantizedPredictionErrorRadioButton.CheckedChanged += new EventHandler(SelectedErrorImageRadioButton_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coder = new Coder();
            coder.Init();
        }

        private void CoderLoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\School";
                openFileDialog.Filter = "BMP FIles (*.bmp)|*.BMP";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    coder.ParseImage(openFileDialog.FileName);
                    using (var bmpTemp = new Bitmap(imagePath))
                    {
                        originalImagePictureBox.Image = new Bitmap(bmpTemp);
                    }
                }
            }
        }

        private void SelectedErrorImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PredictionErrorRadioButton.Checked)
            {
                selectedErrorImage = PREDICTION_ERROR_IMAGE;
            }
            if (QuantizedPredictionErrorRadioButton.Checked)
            {
                selectedErrorImage = QUANTIZED_PREDICITON_ERROR_IMAGE;
            }
        }

        private void PredictorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                coder.predictor = 0;
            }
            else if (radioButton2.Checked)
            {
                coder.predictor = 1;
            }
            else if (radioButton3.Checked)
            {
                coder.predictor = 2;
            }
            else if (radioButton4.Checked)
            {
                coder.predictor = 3;
            }
            else if (radioButton5.Checked)
            {
                coder.predictor = 4;
            }
            else if (radioButton6.Checked)
            {
                coder.predictor = 5;
            }
            else if (radioButton7.Checked)
            {
                coder.predictor = 6;
            }
            else if (radioButton8.Checked)
            {
                coder.predictor = 7;
            }
            else
            {
                coder.predictor = 8;
            }
        }

        private void SaveModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                coder.saveMode = "F";
            }
            else if (radioButton11.Checked)
            {
                coder.saveMode = "F";   // THIS MUST BE CHANGED
            }
            else if (radioButton12.Checked)
            {
                coder.saveMode = "F"; // THIS MUST BE CHANGED
            }
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            coder.Encode();
        }

        private void KSelectorNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            coder.k = Convert.ToInt32(kSelectorNumericUpDown.Value);
        }

        private void ErrorImageRefreshButton_Click(object sender, EventArgs e)
        {
            double contrast;
            if(!Double.TryParse(contrastTextBox.Text, out contrast))
            {
                string message = "The contrast value should be numeric!";
                string title = "Error";
                MessageBox.Show(message, title);
                return;
            }
            if (contrast < 0)
            {
                string message = "The contrast value should be greater or equal to 0!";
                string title = "Error";
                MessageBox.Show(message, title);
                return;
            }
            Bitmap bitmap = new Bitmap(256, 256);
            for(int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    int value;
                    if (selectedErrorImage == PREDICTION_ERROR_IMAGE)
                    {
                        value =(int)(contrast * coder.predictionError[i, j] + 128);
                    }
                    else
                    {
                        value = (int)(contrast * coder.quantizedPredictionError[i, j] + 128);
                    }
                    byte normalizedValue = Normalize(value);
                    bitmap.SetPixel(j, i, Color.FromArgb(normalizedValue, normalizedValue, normalizedValue));
                }
            }
            ErrorImagePictureBox.Image = bitmap;
        }

        private byte Normalize(int value)
        {
            if (value > 255)
            {
                value = 255;
            }
            if (value < 0)
            {
                value = 0;
            }
            return (byte)value;
        }

        private void ComputeErrorButton_Click(object sender, EventArgs e)
        {
            MinErrorLabel.Text = "Min Error: " + coder.GetMinimumError();
            MaxErrorLabel.Text = "Max Error: " + coder.GetMaximumError();
        }

        private void CoderSaveButton_Click(object sender, EventArgs e)
        {
            coder.Save(imagePath);
        }
    }
}
