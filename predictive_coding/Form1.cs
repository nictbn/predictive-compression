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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                    for(int i = 0; i < 256; i++)
                    {
                        for (int j = 0; j < 256; j++)
                        {
                            byte color = coder.OriginalImage[i,j];
                            ((Bitmap)ErrorImagePictureBox.Image).SetPixel(j, i, Color.FromArgb(color, color, color));
                        }
                    }
                    
                    ErrorImagePictureBox.Refresh();
                }
            }
        }
    }
}
