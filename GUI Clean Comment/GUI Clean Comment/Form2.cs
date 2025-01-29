using clean_comment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Clean_Comment
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

      

        private void Timer1_Tick(object sender, EventArgs e)
        {

            angle -= 20;
            Invalidate();
            
            
        }

        private readonly int cx = 15;
        private readonly int cy = 15;
        private readonly int rx = 25;
        private readonly int ry = 25;
        float angle;
        readonly Bitmap image = Properties.Resources.refresh1;

        private void Button1_Click(object sender, EventArgs e)
        {

            // llamar a la base de datos
            ArchivosPasados archivosPasados = new ArchivosPasados();
            ListHistorial.DataSource = archivosPasados.ListArchivos();
        }


        private void Button1_MouseEnter(object sender, EventArgs e)
        {
           
            
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
                ArchivosPasados archivosPasados = new ArchivosPasados();
                ListHistorial.DataSource = archivosPasados.ListArchivos();
            
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.RotateTransform(angle, System.Drawing.Drawing2D.MatrixOrder.Append);
            g.TranslateTransform(cx, cy, System.Drawing.Drawing2D.MatrixOrder.Append);
            g.DrawImage(image, -rx / 2, -ry / 2, rx, ry);
        }



 



    }
}
