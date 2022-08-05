namespace FilterApp
{
    partial class FilterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.ImgPath_txt = new System.Windows.Forms.TextBox();
            this.XRes_txt = new System.Windows.Forms.TextBox();
            this.YRes_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XInc_txt = new System.Windows.Forms.TextBox();
            this.YInc_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ParseImage = new System.Windows.Forms.Button();
            this.btn_grid = new System.Windows.Forms.Button();
            this.width_txt = new System.Windows.Forms.NumericUpDown();
            this.height_txt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.width_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ApplyFilter.Location = new System.Drawing.Point(664, 416);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(128, 23);
            this.ApplyFilter.TabIndex = 0;
            this.ApplyFilter.Text = "Apply Median Filter";
            this.ApplyFilter.UseVisualStyleBackColor = false;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyMedianFilter_Click);
            // 
            // ImgPath_txt
            // 
            this.ImgPath_txt.BackColor = System.Drawing.Color.MintCream;
            this.ImgPath_txt.Location = new System.Drawing.Point(99, 24);
            this.ImgPath_txt.Name = "ImgPath_txt";
            this.ImgPath_txt.Size = new System.Drawing.Size(242, 23);
            this.ImgPath_txt.TabIndex = 1;
            this.ImgPath_txt.Text = "a.raw";
            // 
            // XRes_txt
            // 
            this.XRes_txt.Location = new System.Drawing.Point(99, 53);
            this.XRes_txt.Name = "XRes_txt";
            this.XRes_txt.Size = new System.Drawing.Size(100, 23);
            this.XRes_txt.TabIndex = 2;
            this.XRes_txt.Text = "320";
            // 
            // YRes_txt
            // 
            this.YRes_txt.Location = new System.Drawing.Point(99, 82);
            this.YRes_txt.Name = "YRes_txt";
            this.YRes_txt.Size = new System.Drawing.Size(100, 23);
            this.YRes_txt.TabIndex = 3;
            this.YRes_txt.Text = "240";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ImgPath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "XRes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "YRes";
            // 
            // XInc_txt
            // 
            this.XInc_txt.Location = new System.Drawing.Point(99, 127);
            this.XInc_txt.Name = "XInc_txt";
            this.XInc_txt.Size = new System.Drawing.Size(48, 23);
            this.XInc_txt.TabIndex = 5;
            this.XInc_txt.Text = "1";
            // 
            // YInc_txt
            // 
            this.YInc_txt.Location = new System.Drawing.Point(99, 156);
            this.YInc_txt.Name = "YInc_txt";
            this.YInc_txt.Size = new System.Drawing.Size(48, 23);
            this.YInc_txt.TabIndex = 6;
            this.YInc_txt.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "X Increment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y Increment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Height";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(664, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apply Multiply Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ApplyMultiplyFilter_Click);
            // 
            // btn_ParseImage
            // 
            this.btn_ParseImage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_ParseImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ParseImage.Location = new System.Drawing.Point(347, 23);
            this.btn_ParseImage.Name = "btn_ParseImage";
            this.btn_ParseImage.Size = new System.Drawing.Size(75, 23);
            this.btn_ParseImage.TabIndex = 7;
            this.btn_ParseImage.Text = "Parse Image";
            this.btn_ParseImage.UseVisualStyleBackColor = false;
            this.btn_ParseImage.Click += new System.EventHandler(this.btn_ParseImage_Click);
            // 
            // btn_grid
            // 
            this.btn_grid.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_grid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_grid.Location = new System.Drawing.Point(153, 189);
            this.btn_grid.Name = "btn_grid";
            this.btn_grid.Size = new System.Drawing.Size(25, 23);
            this.btn_grid.TabIndex = 7;
            this.btn_grid.Text = "Parse Image";
            this.btn_grid.UseVisualStyleBackColor = false;
            this.btn_grid.Click += new System.EventHandler(this.btn_ParseImage_Click);
            // 
            // width_txt
            // 
            this.width_txt.Location = new System.Drawing.Point(99, 189);
            this.width_txt.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.width_txt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width_txt.Name = "width_txt";
            this.width_txt.Size = new System.Drawing.Size(48, 23);
            this.width_txt.TabIndex = 5;
            this.width_txt.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.width_txt.TextChanged += new System.EventHandler(this.width_txt_TextChanged);
            // 
            // height_txt
            // 
            this.height_txt.Location = new System.Drawing.Point(99, 218);
            this.height_txt.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.height_txt.Name = "height_txt";
            this.height_txt.Size = new System.Drawing.Size(48, 23);
            this.height_txt.TabIndex = 6;
            this.height_txt.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.height_txt.TextChanged += new System.EventHandler(this.height_txt_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(626, 387);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 23);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(626, 416);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(32, 23);
            this.numericUpDown2.TabIndex = 9;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_grid);
            this.Controls.Add(this.btn_ParseImage);
            this.Controls.Add(this.height_txt);
            this.Controls.Add(this.width_txt);
            this.Controls.Add(this.YInc_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.XInc_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YRes_txt);
            this.Controls.Add(this.XRes_txt);
            this.Controls.Add(this.ImgPath_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ApplyFilter);
            this.Name = "FilterForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.width_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ApplyFilter;
        private TextBox ImgPath_txt;
        private TextBox XRes_txt;
        private TextBox YRes_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox XInc_txt;
        private TextBox YInc_txt;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button btn_ParseImage;
        private Button btn_grid;
        private NumericUpDown width_txt;
        private NumericUpDown height_txt;
        private TextBox height_txt1;
        private TextBox width_txt1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}