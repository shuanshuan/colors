namespace Colors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.btARGB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btHTML = new System.Windows.Forms.Button();
            this.btSnip = new System.Windows.Forms.Button();
            this.lInfor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ColorPicker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(45, 45);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(100, 20);
            this.tbColor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "B";
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(97, 19);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(39, 20);
            this.tbG.TabIndex = 4;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(31, 45);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(40, 20);
            this.tbB.TabIndex = 4;
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(31, 19);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(39, 20);
            this.tbR.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hex";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(45, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "A";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(96, 45);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(40, 20);
            this.tbA.TabIndex = 4;
            // 
            // btARGB
            // 
            this.btARGB.Location = new System.Drawing.Point(95, 71);
            this.btARGB.Name = "btARGB";
            this.btARGB.Size = new System.Drawing.Size(41, 23);
            this.btARGB.TabIndex = 7;
            this.btARGB.Text = "Set";
            this.btARGB.UseVisualStyleBackColor = true;
            this.btARGB.Click += new System.EventHandler(this.btARGB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbR);
            this.groupBox1.Controls.Add(this.btARGB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbG);
            this.groupBox1.Controls.Add(this.tbA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbB);
            this.groupBox1.Location = new System.Drawing.Point(21, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "aRGB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(228, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 187);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btHTML);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.tbColor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTML";
            // 
            // btHTML
            // 
            this.btHTML.Location = new System.Drawing.Point(106, 71);
            this.btHTML.Name = "btHTML";
            this.btHTML.Size = new System.Drawing.Size(39, 23);
            this.btHTML.TabIndex = 6;
            this.btHTML.Text = "Set";
            this.btHTML.UseVisualStyleBackColor = true;
            this.btHTML.Click += new System.EventHandler(this.btHTML_Click);
            // 
            // btSnip
            // 
            this.btSnip.Location = new System.Drawing.Point(320, 31);
            this.btSnip.Name = "btSnip";
            this.btSnip.Size = new System.Drawing.Size(75, 23);
            this.btSnip.TabIndex = 11;
            this.btSnip.Text = "Snipping";
            this.btSnip.UseVisualStyleBackColor = true;
            this.btSnip.Click += new System.EventHandler(this.btSnip_Click);
            // 
            // lInfor
            // 
            this.lInfor.AutoSize = true;
            this.lInfor.Location = new System.Drawing.Point(21, 370);
            this.lInfor.Name = "lInfor";
            this.lInfor.Size = new System.Drawing.Size(0, 13);
            this.lInfor.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 453);
            this.Controls.Add(this.lInfor);
            this.Controls.Add(this.btSnip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Button btARGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btHTML;
        private System.Windows.Forms.Button btSnip;
        private System.Windows.Forms.Label lInfor;
    }
}

