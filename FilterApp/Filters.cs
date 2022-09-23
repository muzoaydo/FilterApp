using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilterApp
{
    public class Filters
    {
        public static int[,] MedianFilter(Image Img, int repeatNum)
        {
            int xInc = Img.XInc;
            int yInc = Img.YInc;
            int height = Img.MaskHeight;
            int width = Img.MaskWidth;
            int yRes = Img.YRes;
            int xRes = Img.XRes;

            Img.FilteredArr = new int[((xRes - width) / xInc) + 1, ((yRes - height) / yInc) + 1];
            int outX = 0;
            int outY = 0;

            for (int repeat = 0; repeat < repeatNum; repeat++)
            {
                for (int maskPosY = 0; maskPosY + height < yRes; maskPosY += yInc)
                {
                    for (int maskPosX = 0; maskPosX + width < xRes; maskPosX += xInc)
                    {
                        int[,] maskArr = Img.Mask(width, height, maskPosX, maskPosY);

                        Img.FilteredArr[outX, outY] = GetMedian(maskArr);

                        outX++;
                    }
                    outX = 0;
                    outY++;
                }
                outY = 0;
            }
            return Img.FilteredArr;
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

        public static int[,] MultiplyFilter(Image Img, MaskGrid maskGrid, int repeatNum)
        {
            int xInc = Img.XInc;
            int yInc = Img.YInc;
            int xRes = Img.XRes;
            int yRes = Img.YRes;
            int width = Img.MaskWidth;
            int height = Img.MaskHeight;
            Img.FilteredArr = new int[xRes, yRes];
            int[,] valueArr = maskGrid.GetGridValues(width, height);

            for (int repeat = 0; repeat < repeatNum; repeat++)
            {
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
                        Img.FilteredArr[maskPosX + (width / 2) - xInc, maskPosY + (height / 2) - yInc] = GetMedian(maskArr);
                    }
                }
            }
            return Img.FilteredArr;
        }

        public static void PowerFilter(Image Img, int power, int repeatNum)
        {
            for (int repeat = 0; repeat < repeatNum; repeat++)
            {
                for (int y = 0; y < Img.YRes; y++)
                {
                    for (int x = 0; x < Img.XRes; x++)
                    {
                        Math.Pow(x, power);
                        Img.FilteredArr[x,y] = (int) Math.Pow(Img.Arr[x,y],power);
                    }
                }
            }
        }
    }
}
