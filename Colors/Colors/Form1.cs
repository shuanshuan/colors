using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Colors
{
    public partial class Form1 : Form
    {

        public static Image img = null;

        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.MouseClick += pictureBox1_MouseClick;
        }

        void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Image img = this.pictureBox1.Image;

            if (img != null)
            {
                Bitmap bm = img as Bitmap;

                int x = e.Location.X;
                int y = e.Location.Y;

                if (y <= bm.Height && x <= bm.Width)
                {
                    Color c = bm.GetPixel(x, y);
                    lInfor.Text = string.Format("X:{0}, Y:{1}", x, y);
                    setARGB(c);
                    SetNameAndHex(c);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            Color pColor = this.colorDialog1.Color;
            pColor = setARGB(pColor);

            SetNameAndHex(pColor);

            this.pictureBox1.BackColor = pColor;

        }

        private Color setARGB(Color pColor)
        {
            this.tbR.Text = pColor.R.ToString();
            this.tbG.Text = pColor.G.ToString();
            this.tbB.Text = pColor.B.ToString();
            this.tbA.Text = pColor.A.ToString();
            return pColor;
        }

        private Color SetNameAndHex(Color pColor)
        {
            this.tbName.Text = pColor.Name;
            this.tbColor.Text = string.Format("#{0:X2}{1:X2}{2:X2}", pColor.R,
                                               pColor.G, pColor.B);
            return pColor;
        }

        private void btARGB_Click(object sender, EventArgs e)
        {
            try
            {

                int A = int.Parse(this.tbA.Text);
                int R = int.Parse(this.tbR.Text);
                int G = int.Parse(this.tbG.Text);
                int B = int.Parse(this.tbB.Text);
                Color argb = Color.FromArgb(A, R, G, B);
                SetNameAndHex(argb);
                this.pictureBox1.BackColor = argb;
            }
            catch (Exception ex)
            {

            }


        }

        private void btHTML_Click(object sender, EventArgs e)
        {
            Color color = ColorTranslator.FromHtml(this.tbColor.Text);
            SetNameAndHex(color);
            setARGB(color);
            this.pictureBox1.BackColor = color;
        }

        private void btSnip_Click(object sender, EventArgs e)
        {

            this.Hide();
            Thread.Sleep(200);
            pic im = new pic();
            im.ShowDialog();
            im.Dispose();
            im.Close();

            this.Show();
            pictureBox1.Image = img;

        }
    }
}
