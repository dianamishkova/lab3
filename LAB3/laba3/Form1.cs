using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        private Bitmap _sourcePicture;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadPictureBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                _sourcePicture = new Bitmap(openFileDialog1.FileName);
                outputPictureBox.Image = _sourcePicture;
            }
        }

        private void BoxBlurBtn_Click(object sender, EventArgs e)
        {
            double windowSize = Convert.ToDouble(parameterTextBox.Text);
            BoxBlur boxBlur= new BoxBlur(Convert.ToInt32(windowSize));
            outputPictureBox.Image = boxBlur.Filter(_sourcePicture);
        }

        private void MedianFilterBtn_Click(object sender, EventArgs e)
        {
            double windowSize = Convert.ToDouble(parameterTextBox.Text);
            MedianFilter medianFilter = new MedianFilter(Convert.ToInt32(windowSize));
            outputPictureBox.Image = medianFilter.Filter(_sourcePicture);
        }

        private void GaussianFilterBtn_Click(object sender, EventArgs e)
        {
            double sigma = Convert.ToDouble(parameterTextBox.Text);
            GaussianFilter gaussianFilter = new GaussianFilter(sigma);
            outputPictureBox.Image = gaussianFilter.Filter(_sourcePicture);
        }

        private void outputPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
