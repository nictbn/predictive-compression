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
        int selectedPredictor;
        Coder coder;
        public PredictiveCodingForm()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton8.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton9.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectedPredictor = 0;
            coder = new Coder();
            coder.Init();
        }

        private void CoderLoadButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            Bitmap bitmapImage = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\School";
                openFileDialog.Filter = "BMP FIles (*.bmp)|*.BMP";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    coder.ParseImage(openFileDialog.FileName);

                    bitmapImage = new Bitmap(filePath);
                    OriginalImagePictureBox.Image = bitmapImage;

                    ErrorImagePictureBox.Image = new Bitmap(256, 256);
                    for (int i = 0; i < 256; i++)
                    {
                        for (int j = 0; j < 256; j++)
                        {
                            byte color = coder.original[i, j];
                            ((Bitmap)ErrorImagePictureBox.Image).SetPixel(j, i, Color.FromArgb(color, color, color));
                        }
                    }

                    ErrorImagePictureBox.Refresh();
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectedPredictor = 0;
            }
            else if (radioButton2.Checked)
            {
                selectedPredictor = 1;
            }
            else if (radioButton3.Checked)
            {
                selectedPredictor = 2;
            }
            else if (radioButton4.Checked)
            {
                selectedPredictor = 3;
            }
            else if (radioButton5.Checked)
            {
                selectedPredictor = 4;
            }
            else if (radioButton6.Checked)
            {
                selectedPredictor = 5;
            }
            else if (radioButton7.Checked)
            {
                selectedPredictor = 6;
            }
            else if (radioButton8.Checked)
            {
                selectedPredictor = 7;
            }
            else (radioButton9.Checked)
            {
                selectedPredictor = 8;
            }
        }
    }
}
