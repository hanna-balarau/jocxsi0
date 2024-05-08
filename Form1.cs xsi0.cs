    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace jocxsi0
    {

        public partial class Form1 : Form
        {
            int i = 0;
            int uu=-1, ud=-1, ut=-1, du=-1, dd=-1, dt=-1, tu=-1, td=-1, tt=-1;

            public Form1()
            {
                InitializeComponent();
            }

            public void castigat()
            {
                if (uu == ud && ud == ut && ud!=-1) MessageBox.Show("Ai castigat");
                else if(du==dd && dd==dt && dd!=-1 ) MessageBox.Show("Ai castigat");
                else if(tu == td && td ==tt && td!=-1) MessageBox.Show("Ai castigat");
                else if(uu==du && du==tu && du!=-1) MessageBox.Show("Ai castigat");
                else if (ud==dd && dd ==td&&dd!=-1) MessageBox.Show("Ai castigat");
                else if(ut==dt && ut==tt && ut!=-1) MessageBox.Show("Ai castigat");
                else if(uu==dd && uu==tt && dd !=-1) MessageBox.Show("Ai castigat");
                else if(ut==dd && ut==tu && dd!=-1) MessageBox.Show("Ai castigat");
            }
            private void button1_Click(object sender, EventArgs e)
            {
                if (pictureBox1.Image == null) { 
                    if (i == 0)
                {
                   Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");

                    pictureBox1.Image = im;
                    i = 1;
                    uu = 1;
                
                }
                else
                {

                    Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");
                    pictureBox1.Image = im;
                    uu = 0;
                    i= 0;
                
                }}
                castigat();
            }
        

            private void pictureBox2_Click(object sender, EventArgs e)
            {

            }

       

            private void button2_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Image == null)
                {
                    if (i == 0)
                    {
                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");
                        pictureBox2.Image = im;
                        ud = 1;
                        i = 1;

                    }
                    else
                    {

                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");
                        pictureBox2.Image = im;
                        ud = 0;
                        i = 0;

                    }
                }
                castigat();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                if (pictureBox3.Image == null) { 
                if (i == 0)
                {
                    Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");
                    pictureBox3.Image = im;
                    ut = 1;
                        i = 1;
                
                }
                else
                {

                    Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");
                    pictureBox3.Image = im;
                    ut = 0;
                        i = 0;
                
                }}
                castigat();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                if (pictureBox4.Image == null)
                {
                    if (i == 0)
                    {
                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");
                        pictureBox4.Image = im;
                        du = 1;
                        i = 1;
                    }
                    else
                    {

                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");
                        pictureBox4.Image = im;
                        du = 0;
                        i = 0;
                    }
                }
                castigat();
            }

            private void button5_Click(object sender, EventArgs e)
            {
                if (pictureBox5.Image == null)
                {
                    if (i == 0)
                    {
                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");
                        pictureBox5.Image = im;
                        dd = 1;
                        i = 1;
                    }
                    else
                    {

                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");
                        pictureBox5.Image = im;
                        dd = 0;
                        i = 0;
                    }
                }
                castigat();
            }

            private void button6_Click(object sender, EventArgs e)
            {
                if (pictureBox6.Image == null)
                {
                    if (i == 0)
                    {
                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");
                        pictureBox6.Image = im;
                        dt = 1;
                        i = 1;
                    }
                    else
                    {

                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");
                        pictureBox6.Image = im;
                        dt = 0;
                        i = 0;
                    }
                }
                castigat();
            }

            private void button7_Click(object sender, EventArgs e)
            {
                if (pictureBox7.Image == null)
                {

                    if (i == 0)
                    {
                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");
                        pictureBox7.Image = im;
                        tu = 1;
                        i = 1;
                    }
                    else
                    {

                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");
                        pictureBox7.Image = im;
                        tu = 0;
                        i = 0;
                    }
                }
                castigat();
            }

            private void button8_Click(object sender, EventArgs e)
            {
                if (pictureBox8.Image == null)
                {
                    if (i == 0)
                    {
                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");
                        pictureBox8.Image = im;
                        td = 1;
                        i = 1;
                    }
                    else
                    {

                        Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");

                        pictureBox8.Image = im;
                        td = 0;
                        i = 0;
                    }
                }
                castigat();
            }

            private void button9_Click(object sender, EventArgs e)
            {
                if (pictureBox9.Image == null) { 
                    if (i == 0)
                {
                    Image im = Image.FromFile(@"C:\Users\elev\Desktop\x.png");
                    pictureBox9.Image = im;
                    tt = 1;
                    i = 1;
                }
                else
                {

                    Image im = Image.FromFile(@"C:\Users\elev\Desktop\0.png");
                    pictureBox9.Image = im;
                    tt = 0;
                    i = 0;
                }}
            

                castigat();
            
            }
            private void textBox1_TextChanged(object sender, EventArgs e)
            {
            


            }
        }
    }
