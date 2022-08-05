using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilterApp
{
    public class Filters
    {
        public static int[,] MedianFilter(MyImage Img)
        {
            int xInc = Img.XInc;
            int yInc = Img.YInc;
            int height = Img.MaskHeight;
            int width = Img.MaskWidth;
            int yRes = Img.YRes;
            int xRes = Img.XRes;

            int[,] outArr = new int[((xRes  - width) / xInc) + 1 , ((yRes - height) / yInc) + 1];
            int outX = 0;
            int outY = 0;

            for (int maskPosY = 0; maskPosY + height < yRes; maskPosY += yInc)
            {
                for (int maskPosX = 0; maskPosX + width < xRes; maskPosX += xInc)
                {
                    int[,] maskArr = Img.Mask(width, height, maskPosX, maskPosY);

                    outArr[outX, outY] = GetMedian(maskArr);
                    outX++;
                }
                outX = 0;
                outY++;
            }
            return outArr;
        }

        public static int GetMedian(int[,] maskArr)
        {
            int total = 0;

            foreach (int value in maskArr)
            {
                total += value;
            }
            int median = total / (maskArr.GetLength(0) * maskArr.GetLength(1));
            return median;
        }

        public static int[,] MultiplyFilter(MyImage Img, MaskGrid maskGrid)
        {
            int xInc = Img.XInc;
            int yInc = Img.YInc;
            int xRes = Img.XRes;
            int yRes = Img.YRes;
            int width = Img.MaskWidth;
            int height = Img.MaskHeight;
            int[,] outArr = new int[xRes, yRes];
            //int[,] valueArr = new int[width, height];
            int[,] valueArr = maskGrid.GetGridValues(width, height);
            //int[,] valueArr = { { 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1 }, { 0, 1, 3, 5, 7 }, { 0, 1, 5, 7, 9 }, { 0, 1, 7, 9, 9 } };


            for (int maskPosY = 0; maskPosY + height < yRes; maskPosY += yInc)
            {
                for (int maskPosX = 0; maskPosX + width < xRes; maskPosX += xInc)
                {
                    int[,] maskArr = Img.Mask(width, height, maskPosX, maskPosY);
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            maskArr[x, y] = valueArr[x, y] * maskArr[x, y];
                        }
                    }
                    outArr[maskPosX + (width / 2) - xInc, maskPosY + (height / 2) - yInc] = GetMedian(maskArr);
                }
            }
            return outArr;
        }
    }
}
