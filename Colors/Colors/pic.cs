using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Colors
{
    public partial class pic : Form
    {
        

         private int startY;
        private int startX;
        private int endX;
        private int endY;

        Size size;

        bool leftBDwon = false;

        //public Image tempImage;
       

      
        public pic()
        {
            
            InitializeComponent();

           // this.MouseDown += new MouseEventHandler(img_MouseDown);
            //this.MouseUp += new MouseEventHandler(img_MouseUp);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Rectangle r = Screen.PrimaryScreen.Bounds;
            Image captureImg = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(captureImg);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), r.Size);

            this.Width = r.Width;
            this.Height = r.Height;
            this.Left = 0;
            this.Top = 0;


            pictureBox1.Width = r.Width;
            pictureBox1.Height = r.Height;
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);
           
            pictureBox1.Image = captureImg;


           
        }

        void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            leftBDwon = false;

            Bitmap tempImage = new Bitmap(pictureBox1.Image);

           int width= Math.Abs(endX - startX);
           int height = Math.Abs(endY - startY);

            Form1.img = tempImage.Clone(new Rectangle(startX, startY, width, height), PixelFormat.Undefined);
           
          
            tempImage.Dispose();

            this.Hide();
        }




        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftBDwon)
            {
                pictureBox1.Refresh();
                endX = e.X;
                endY = e.Y;
                Graphics g = pictureBox1.CreateGraphics();
                Pen p = new Pen(Color.Red,1);



                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                size = new Size(Math.Abs(endX - startX), Math.Abs(endY - startY));
                Rectangle rect = new Rectangle(new Point(startX, startY), size);
                g.DrawRectangle(p, rect);
                
                g.Dispose();
            }
        }

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            leftBDwon = true;
        }
    }
}
