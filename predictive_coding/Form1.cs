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
        const int ORIGINAL = 0;
        const int PREDICTION_ERROR = 1;
        const int QUANTIZED_PREDICITON_ERROR = 2;
        const int DECODED = 3;
        int selectedErrorImage = PREDICTION_ERROR_IMAGE;
        int selectedHistogram = ORIGINAL;
        Coder coder;
        Decoder decoder;
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

            radioButton13.CheckedChanged += new EventHandler(SelectedHistograRadioButton_CheckedChanged);
            radioButton14.CheckedChanged += new EventHandler(SelectedHistograRadioButton_CheckedChanged);
            radioButton15.CheckedChanged += new EventHandler(SelectedHistograRadioButton_CheckedChanged);
            radioButton16.CheckedChanged += new EventHandler(SelectedHistograRadioButton_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coder = new Coder();
            coder.Init();
            decoder = new Decoder();
            decoder.Init();
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

        private void SelectedHistograRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                selectedHistogram = ORIGINAL;
            }
            if (radioButton14.Checked)
            {
                selectedHistogram = PREDICTION_ERROR;
            }
            if (radioButton15.Checked)
            {
                selectedHistogram = QUANTIZED_PREDICITON_ERROR;
            }
            if (radioButton16.Checked)
            {
                selectedHistogram = DECODED;
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

        private void histogramRefreshButton_Click(object sender, EventArgs e)
        {
            double scale;
            if (!Double.TryParse(scaleTextBox.Text, out scale))
            {
                string message = "The scale value should be numeric!";
                string title = "Error";
                MessageBox.Show(message, title);
                return;
            }
            if (scale < 0)
            {
                string message = "The scale value should be greater or equal to 0!";
                string title = "Error";
                MessageBox.Show(message, title);
                return;
            }
            Bitmap bitmap = new Bitmap(512, histogramPictureBox.Height);
            int[] histogram = null;

            if (selectedHistogram == ORIGINAL)
            {
                int[,] original = TransformByteMatrixToIntMatrix(coder.original);
                histogram = GetHistogram(original);
            }
            if (selectedHistogram == PREDICTION_ERROR)
            {
                histogram = GetHistogram(coder.predictionError);
            }
            if (selectedHistogram == QUANTIZED_PREDICITON_ERROR)
            {
                histogram = GetHistogram(coder.quantizedPredictionError);
            }
            if (selectedHistogram == DECODED)
            {
                int[,] decoded = TransformByteMatrixToIntMatrix(coder.decoded);
                histogram = GetHistogram(decoded);
            }
            DrawHistogram(histogram, bitmap, scale);
            histogramPictureBox.Image = bitmap;

        }

        private void DrawHistogram(int[] histogram, Bitmap bitmap, double scale)
        {
            int height = bitmap.Height;
            for(int i = 0; i < 512; i++)
            {
                int barLength = histogram[i];
                barLength = (int)(barLength * scale);
                barLength = barLength < bitmap.Height ? barLength : bitmap.Height;
                for(int j = bitmap.Height - 1; j > bitmap.Height - 1 - barLength; j--)
                {
                    bitmap.SetPixel(i, j, Color.FromArgb(255, 0, 0));
                }
            }
        }

        private int[] GetHistogram(int[,] matrix)
        {
            int[] result = new int[512];
            for (int i = 0; i < 512; i++)
            {
                result[i] = 0;
            }
            for (int i = 0; i < 256; i++)
            {
                for(int j = 0; j < 256; j++)
                {
                    result[matrix[i, j] + 255]++;
                }
            }
            return result;
        }

        int[,] TransformByteMatrixToIntMatrix(byte[,] input)
        {
            int[,] result = new int[256, 256];
            for(int i = 0; i < 256; i++)
            {
                for(int j = 0; j < 256; j++)
                {
                    result[i, j] = input[i, j];
                }
            }
            return result;
        }

        private void loadDecoded_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\School";
                openFileDialog.Filter = "Near Lossless Prediction (*.nlp)|*.nlp";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    decoder.codedImagePath = openFileDialog.FileName;
                }
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            decoder.Decode();

            for(int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    if (coder.decoded[i, j] != decoder.decoded[i, j])
                    {
                        return;
                    }
                }
            }

            Bitmap bitmap = new Bitmap(256, 256);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    int color = decoder.decoded[i, j];
                    bitmap.SetPixel(j, i, Color.FromArgb(color, color, color));
                }
            }
            decodedImagePictureBox.Image = bitmap;
        }

        private void decoderSaveButton_Click(object sender, EventArgs e)
        {
            decoder.Save();
        }
    }
}
