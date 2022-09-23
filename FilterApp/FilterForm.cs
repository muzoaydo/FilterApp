



namespace FilterApp
{
    public partial class FilterForm : Form
    {
        public MaskGrid maskGrid;
        Image originalImage;


        public FilterForm()
        {
            InitializeComponent();
            InitializeMaskGrid(); 
        }

        public void InitializeMaskGrid()
        {
            int height = Int32.Parse(height_txt.Text);
            int width = Int32.Parse(width_txt.Text);
            maskGrid = new MaskGrid(height, width);
            maskGrid.Show();
            maskGrid.Visible = false;
            ReAdjustMaskGrid(width, height);
        }

        private void ReAdjustMaskGrid(int width, int height)
        {
            maskGrid.AdjustTxtBoxes(width, height);
        }

        private void ApplyMedianFilter_Click(object sender, EventArgs e)
        {
            int XRes = Int32.Parse(XRes_txt.Text);
            int YRes = Int32.Parse(YRes_txt.Text);
            int XInc = Int32.Parse(XInc_txt.Text);
            int YInc = Int32.Parse(YInc_txt.Text);
            int maskWidth = Int32.Parse(width_txt.Text);
            int maskHeight = Int32.Parse(height_txt.Text);
            int repeatNum = Int32.Parse(MedianFilterUD.Text);

            originalImage = new Image(ImgPath_txt.Text, XRes, YRes, XInc, YInc, maskWidth, maskHeight);

            int[,] outArr = Filters.MedianFilter(originalImage, repeatNum);

            string outPath = originalImage.ImgPath.Replace(".raw", ".csv");
            Output.DumpArray(outArr, outPath, XRes, YRes);
        }

        private void ApplyMultiplyFilter_Click(object sender, EventArgs e)
        {
            int XRes = Int32.Parse(XRes_txt.Text);
            int YRes = Int32.Parse(YRes_txt.Text);
            int XInc = Int32.Parse(XInc_txt.Text);
            int YInc = Int32.Parse(YInc_txt.Text);
            int maskWidth = Int32.Parse(width_txt.Text);
            int maskHeight = Int32.Parse(height_txt.Text);
            int repeatNum = Int32.Parse(MedianFilterUD.Text);


            originalImage = new Image(ImgPath_txt.Text, XRes, YRes, XInc, YInc, maskWidth, maskHeight);

            //int[,] OrArr = image.ReadFileToArr(ImgPath_txt.Text, XRes, YRes, XInc, YInc, maskWidth, maskHeight);
            int[,] outArr = Filters.MultiplyFilter(originalImage, maskGrid, repeatNum);

            string outPath = originalImage.ImgPath.Replace(".raw", ".csv");
            Output.DumpArray(outArr, outPath, XRes, YRes);
        }

        private void btn_ParseImage_Click(object sender, EventArgs e)
        {

            if(maskGrid.IsDisposed == true)
            {
                InitializeMaskGrid();
            }
            maskGrid.Location = new Point(this.Location.X + 805, this.Location.Y );
            maskGrid.Visible = !maskGrid.Visible;
            //MessageBox.Show(maskGrid.Visible.ToString());
        }


        private void width_txt_TextChanged(object sender, EventArgs e)
        {
            if(maskGrid != null)
            {
                try
                {
                    int height = Int32.Parse(height_txt.Text);
                    int width = Int32.Parse(width_txt.Text);
                    ReAdjustMaskGrid(width, height);
                    height_txt.ForeColor = TextBox.DefaultForeColor;
                }
                catch (Exception ex)
                {
                    height_txt.ForeColor = Color.Red;
                    return;
                }
            }
        }

        private void height_txt_TextChanged(object sender, EventArgs e)
        {
            if(maskGrid != null)
            {
                try
                {
                    int height = Int32.Parse(height_txt.Text);
                    int width = Int32.Parse(width_txt.Text);
                    ReAdjustMaskGrid(width, height);
                    height_txt.ForeColor = TextBox.DefaultForeColor;
                }
                catch (Exception ex)
                {
                    height_txt.ForeColor = Color.Red;
                    return;
                }
            }
        }

        private void ImgPath_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void height_txt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_PowerFilter_Click(object sender, EventArgs e)
        {
            int XRes = Int32.Parse(XRes_txt.Text);
            int YRes = Int32.Parse(YRes_txt.Text);
            int XInc = Int32.Parse(XInc_txt.Text);
            int YInc = Int32.Parse(YInc_txt.Text);
            int maskWidth = Int32.Parse(width_txt.Text);
            int maskHeight = Int32.Parse(height_txt.Text);
            int repeatNum = Int32.Parse(UD_powerFilter.Text);
            int power = Int32.Parse(UD_Power.Text);


            originalImage = new Image(ImgPath_txt.Text, XRes, YRes, XInc, YInc, maskWidth, maskHeight);

            //int[,] OrArr = image.ReadFileToArr(ImgPath_txt.Text, XRes, YRes, XInc, YInc, maskWidth, maskHeight);
            Filters.PowerFilter(originalImage, power, repeatNum);

            string outPath = originalImage.ImgPath.Replace(".raw", ".csv");
            Output.DumpArray(originalImage.FilteredArr, outPath, XRes, YRes);
        }
    }
}