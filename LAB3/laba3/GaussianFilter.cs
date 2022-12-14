using System;
using System.Drawing;
using static laba3.HelperClass;

namespace laba3
{
    class GaussianFilter
    {
        private readonly double _sigma;
        int _halfOfWindowSize;
        public GaussianFilter(double sigma)
        {
            _sigma = sigma;
        }



        public Bitmap Filter (Bitmap sourcePicture)
        {
            Bitmap outputPicture = new Bitmap(sourcePicture);
            int windowSize = (int)Math.Ceiling((2 * 3 * _sigma) + 1); //32:11 in video 3*sigma = halfOfWindowSize-1 ->3*sigma*2+1 = size
                                                                      //it so long(((((
            double[,] window = new double[windowSize, windowSize];
            _halfOfWindowSize = (windowSize - 1) / 2;
            CreateWindowWithWeights(window, windowSize);

            double R, G, B;
            int width = sourcePicture.Width;
            int height = sourcePicture.Height;
            for (int i = 0; i < width - 1; i++)
            {
                for (int j = 0; j < height - 1; j++)
                {
                    R = 0;
                    G = 0;
                    B = 0;
                    for (int wi = -_halfOfWindowSize; wi <= _halfOfWindowSize; wi++)
                    {
                        for (int hw = -_halfOfWindowSize; hw <= _halfOfWindowSize; hw++)
                        {
                            Color sourcePixel = sourcePicture.GetPixel(CheckRange(i + hw, width - 1), CheckRange(j + wi, height - 1));
                            R += window[wi + _halfOfWindowSize, hw + _halfOfWindowSize] * sourcePixel.R;
                            G += window[wi + _halfOfWindowSize, hw + _halfOfWindowSize] * sourcePixel.G;
                            B += window[wi + _halfOfWindowSize, hw + _halfOfWindowSize] * sourcePixel.B;
                        }
                    }

                    outputPicture.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            return outputPicture;
        }
        private void CreateWindowWithWeights(double[,] window, int windowSize)
        {
            double kernelSum = 0;
            double constant = 1d / (2 * Math.PI * _sigma * _sigma);

            for (int y = -_halfOfWindowSize; y <= _halfOfWindowSize; y++)
            {
                for (int x = -_halfOfWindowSize; x <= _halfOfWindowSize; x++)
                {
                    window[y + _halfOfWindowSize, x + _halfOfWindowSize] = constant * Math.Exp(((y * y) + (x * x)) / (-2 * _sigma * _sigma));
                    kernelSum += window[y + _halfOfWindowSize, x + _halfOfWindowSize];
                }
            }

            for (int y = 0; y < windowSize; y++)
            {
                for (int x = 0; x < windowSize; x++)
                {
                    window[y, x] = window[y, x] / kernelSum;
                }
            }
        }

    }
}
