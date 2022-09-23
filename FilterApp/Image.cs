using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApp
{
    public class Image
    {
        const String defaultImgPath = "a.raw";

        public string ImgPath { get; set; }
        public int XRes { get; set; }
        public int YRes { get; set; }
        public int[,] Arr { get; set; }
        public int XInc { get; set; }
        public int YInc { get; set; }
        public int MaskWidth { get; set; }
        public int MaskHeight { get; set; }
        public int[,] ?FilteredArr { get; set; }


        public Image(String? ImgPath, int XRes, int YRes, int XInc, int YInc, int MaskWidth, int MaskHeight)
        {
            this.XRes = XRes;
            this.YRes = YRes;
            this.XInc = XInc;
            this.YInc = YInc;
            this.ImgPath = ImgPath;
            this.MaskWidth = MaskWidth;
            this.MaskHeight = MaskHeight;


            if (this.ImgPath == null)
            {
                this.ImgPath = defaultImgPath;
                MessageBox.Show("Image Path is set to \"./a.raw\" as default.");
            }
            else if (XInc < 0 || YInc < 0)
            {
                MessageBox.Show("Incrementation numbers can't be 0.");
            }
            else if (XRes < 0 || YRes < 0)
            {
                MessageBox.Show("Resolution can't be 0.");
            }
                Arr = new int[XRes, YRes];
                FilteredArr = new int[XRes, YRes];
            try
            {
                FileStream Img = File.OpenRead(ImgPath);
                for (int j = 0; j < this.YRes; j++)
                {
                    for (int i = 0; i < this.XRes; i++)
                    {
                        Arr[i, j] = Img.ReadByte();
                    }
                }
                Arr = FilteredArr;
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException)
                {
                    MessageBox.Show("File could not found.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public int[,] Mask(int width, int height, int xCoord, int yCoord)
        {
            int[,] mask = new int[width, height];

            for (int y = yCoord; y < yCoord + height && y < YRes; y++)
            {
                for (int x = xCoord; x < xCoord + width && x < XRes; x++)
                {
                    mask[x - xCoord, y - yCoord] = this.Arr[x, y];
                }
            }
            return mask;
        }
    }
}
