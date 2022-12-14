using System.Collections.Generic;
using System.Drawing;
using static laba3.HelperClass;

namespace laba3
{
    class MedianFilter
    {
        public int _windowSize;

        public MedianFilter(int windowSize)
        {
            _windowSize = windowSize;
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
                    List<int> rList = new List<int>();
                    List<int> gList = new List<int>();
                    List<int> bList = new List<int>();

                    for (int wi = -halfOfWindow; wi <= halfOfWindow; wi++)
                    {
                        for (int hw = -halfOfWindow; hw <= halfOfWindow; hw++)
                        {
                            Color sourcePixel = sourcePicture.GetPixel(CheckRange(i + hw, width - 1), CheckRange(j + wi, height - 1));
                            rList.Add(sourcePixel.R);
                            gList.Add(sourcePixel.G);
                            bList.Add(sourcePixel.B);
                        }
                    }



                    rList.Sort();
                    gList.Sort();
                    bList.Sort();
                    int R = rList[(rList.Count / 2)];
                    int G = gList[(rList.Count / 2)];
                    int B = bList[(rList.Count / 2)];
                    outputPicture.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return outputPicture;
        }

    }
}
