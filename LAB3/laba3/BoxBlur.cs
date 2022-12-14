using System.Drawing;
using static laba3.HelperClass;

namespace laba3
{
    class BoxBlur
    {
        private readonly int _windowSize;
        readonly int _windowCellsCount;
        public BoxBlur(int windowSize)
        {
            _windowSize = windowSize;
            if (_windowSize % 2 == 0)
            {
                _windowSize++;
            }
            _windowCellsCount = _windowSize * _windowSize;
        }

        public Bitmap Filter(Bitmap sourcePicture)
        {
            Bitmap outputPicture = new Bitmap(sourcePicture);
            int halfOfWindow = (_windowSize - 1) / 2;
            int width = sourcePicture.Width;
            int height = sourcePicture.Height;
            for (int i = 0; i < width - 1; i++)
            {
                for (int j = 0; j < height - 1; j++)
                {
                    int R = 0;
                    int G = 0;
                    int B = 0;

                    for (int wi = -halfOfWindow; wi <= halfOfWindow; wi++)
                    {
                        for (int hw = -halfOfWindow; hw <= halfOfWindow; hw++)
                        {
                            Color sourcePixel = sourcePicture.GetPixel(CheckRange(i + hw, width - 1), CheckRange(j + wi, height - 1));
                            R += sourcePixel.R;
                            G += sourcePixel.G;
                            B += sourcePixel.B;
                        }
                    }
                    outputPicture.SetPixel(i, j, Color.FromArgb(R / _windowCellsCount, G / _windowCellsCount, B / _windowCellsCount));
                }
            }

            return outputPicture;
        }

    }
}
