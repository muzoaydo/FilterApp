using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterApp
{
    public partial class MaskGrid : Form
    {
        public TextBox[,] myBoxes;
        int height { get; set; }
        int width { get; set; } 

        public MaskGrid(int height, int width)
        {
            InitializeComponent();
            CreateGrid(width, height);
            AdjustTxtBoxes(width, height);
            this.height = height;
            this.width = width;
        }

        private void CreateGrid(int width, int height)
        {
            this.height = height;
            this.width = width;
            myBoxes = new TextBox[15, 15];
            this.SuspendLayout();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    myBoxes[i, j] = new TextBox();
                    myBoxes[i, j].Location = new System.Drawing.Point((12 + (i * 23)), (12 + (j * 23)));
                    myBoxes[i, j].MaxLength = 3;
                    myBoxes[i, j].Name = "gridBox" + "[" + i + "," + j + "]";
                    myBoxes[i, j].Size = new System.Drawing.Size(23, 23);
                    myBoxes[i, j].TabIndex = (j * 15) + (i);
                    myBoxes[i, j].Text = "1";
                    myBoxes[i, j].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    myBoxes[i, j].Visible = true;
                    this.Controls.Add(myBoxes[i, j]);

                    //box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                }

            }
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public int[,] GetGridValues(int width, int height)
        {
            int[,] outArr = new int[width,height]; 
            for (int j = 0; j < height; j++)
            {
                for(int i = 0; i < width; i++)
                {
                    outArr[i, j] = Int32.Parse(myBoxes[i, j].Text);   
                }
            }
            return outArr;
        }


        public void AdjustTxtBoxes(int width, int height)
        {
            this.height = height;
            this.width = width;
            this.SuspendLayout();

            if(myBoxes != null)
            {
                foreach (var box in myBoxes)
                {
                    if(box != null)
                    {
                        box.Visible = false;
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    myBoxes[i,j].Visible = true;
                }

            }
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MaskGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
