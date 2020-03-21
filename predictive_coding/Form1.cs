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
            coder = new Coder();
            coder.Init();
        }

        private void CoderLoadButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\School";
                openFileDialog.Filter = "BMP FIles (*.bmp)|*.BMP";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    coder.ParseImage(openFileDialog.FileName);
                    using (var bmpTemp = new Bitmap(filePath))
                    {
                        originalImagePictureBox.Image = new Bitmap(bmpTemp);
                    }
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
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

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            coder.Encode();
        }

        private void kSelectorNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            coder.k = Convert.ToInt32(kSelectorNumericUpDown.Value);
        }
    }
}
