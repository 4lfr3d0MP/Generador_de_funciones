using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generador_de_funciones_completo
{
    public partial class Form1 : Form
    { 
        private double x, y, xi, xf, yi, yf, h,t1,T1,A1,A2;

        private void lbFirma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPF_Mendoza.exe");
        }

        private void Amplitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPF_Mendoza.exe");
        }

        private int c, f, ci, cf, fi, ff, n, c1, f1, habilitar;
        
        public Form1()
        {
            habilitar = 1;
            t1 = 0; 
            InitializeComponent();
            A1 = 1;

        }
        
        public void Graficador(Graphics g1)
        {
            ci = 1;
            cf = grafica1.Width;
            fi = 1;
            ff = grafica1.Height;
            n = cf - ci;
            h = (xf - xi) / n;
           
            
            yi =-10;
            yf = 10;
            
            if (((yi) * (yf)) < 0)
            {
                y = 0;
                f = Fil();
                g1.DrawLine(Pens.LightGray, ci, f, cf, f);
            }
            if (((xi) * (xf)) < 0)
            {
                x = 0;
                c = Col();
                g1.DrawLine(Pens.LightGray, c, fi, c, ff);
            }

            string sx;
            Font drawFont = new Font("Arrow", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            int n2 = (int)xf;

            x = xi;
            
            string xs;
            string ys;
          
            for (int k2 = (int)xi; k2 <= n2; k2++)
            {
                y = 0;
                c = Col();
                f = Fil();
                xs = x.ToString();

                sx = xs;
                g1.DrawString(sx, drawFont, drawBrush, c, f);
                g1.DrawLine(Pens.LightGray, c, fi, c, ff);
               
                x = x + 1;
            }

            int n3 = (int)yf;

            y = (int)yi;

            for (int k3 = (int)yi; k3 <= n3; k3++)
            {
                x = 0;
                c = Col();
                f = Fil();
                ys = y.ToString();

                sx = ys;
                g1.DrawString(sx, drawFont, drawBrush, c, f);
                g1.DrawLine(Pens.LightGray, ci, f, cf, f);
                y = y + 1;
            }
            
            x = xi;
            c1 = Col();
            y = A2*fun1(x);

            f1 = Fil();
           
            for (int k = 1; k < n; k++)
            { 
                x = xi + k * h;
                y = A2 * fun1(x);
                c = Col();
                f = Fil();
                g1.DrawLine(Pens.Blue, c1, f1, c, f);
                c1 = c;
                f1 = f;
            }
            
        }
        public int Col()
        {
            int Co;
            Co = (int)(((x - xi) * cf) / (xf - xi) + ((xf - x) * ci) / (xf - xi));
            return (Co);
        }
        public int Fil()
        {
            int Fi;
            Fi = (int)(((y - yi) * (fi)) / (yf - yi) + ((yf - y) * ff) / (yf - yi));
            return (Fi);
        }
        public double fun1(double x)
        {
            int valorin = listBox1.SelectedIndex;
            string valorfu = listBox1.SelectedItem.ToString();           
            double fx = 0;
            double cons = 2 * Math.PI;
            T1 = cons;
            double aux = T1;
            while (x > T1)
            {
                T1 = T1 + cons;
            }
            
            if (x > (T1 - (cons)) && x < (T1 - (Math.PI)))
            {
                if (valorin == 0)
                   fx = -Math.Sin(x);
                if (valorin == 1)
                    fx = Math.Sin(x) + 1;
                if (valorin == 2)
                    fx = 1;
                if (valorin == 3)
                 fx = Math.Sin(x);
                if (valorin == 4)
                    fx =  (x-(T1-cons))/((T1 - (Math.PI))-(T1 - (cons)));
                if (valorin == 5)
                    fx = (x - (T1 - cons)) / ((T1 - (Math.PI)) - (T1 - (cons)));
                if (valorin == 6)
                    fx = ((x - (T1 - cons)) / ((T1 - (Math.PI)) - (T1 - (cons))));
                if (valorin == 7)
                    fx =.1* Math.Tan(x);
                if (valorin == 8)
                    fx =  Math.Sin(x);
                if (valorin == 9)
                    fx = Math.Cos(x);
                if (valorin == 10)
                    fx = Math.Sin(x);
                if (valorin == 11)
                    fx = 1;
                if (valorin == 12)
                    fx = (x - (T1)) / ((T1 - (Math.PI)) - T1)-1;
                if (valorin == 13)
                    fx = (x - (T1)) / ((T1 - (Math.PI)) - T1) - 1;
                if (valorin == 14)
                    fx = 0;
            }
            if (x >(T1 - (Math.PI)) && x < T1)
            {
                if (valorin == 0)
                    fx = -Math.Sin(x - Math.PI);
                if (valorin == 1)
                fx = Math.Sin(x) + 1;
                if (valorin == 2 || valorin == 3)
                fx = 0;
                if (valorin == 4)
                    fx = (x - (T1 )) / ((T1 - (Math.PI)) - T1);
                if (valorin == 5)
                    fx = -(x - (T1)) / ((T1 - (Math.PI)) - T1);
                if (valorin == 6)
                    fx = (-(x - (T1)) / ((T1 - (Math.PI)) - T1))+1;
                if (valorin == 7)
                fx = .1*Math.Tan(x);
                if (valorin == 8)
                    fx = Math.Sin(x);
                if (valorin == 9)
                    fx = Math.Cos(x);
                if (valorin == 10)
                    fx = Math.Sin(x - Math.PI);
                if (valorin == 11)
                    fx = -1;
                if (valorin == 12)
                    fx = (x - (T1)) / ((T1 - (Math.PI)) - T1) - 1;
                if (valorin == 13)
                    fx = (x - (T1)) / ((T1 - (Math.PI)) - T1) ;
                if (valorin == 14)
                    fx = 1;   
            }

            return (fx);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (habilitar)
            {
                case 1:
                    timer1.Enabled = true;
                    habilitar = 2;
                    button1.Text = "Detener";                 
                    break;

                case 2:
                    timer1.Enabled = false;
                    habilitar = 1;
                    button1.Text = "Iniciar";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1 = 0;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            grafica1.Refresh();
            Graphics g1 = grafica1.CreateGraphics();

            xi = 0;
            xf = trackBar1.Value + 0.5;
            xi = xi + t1;
            xf = xf + t1;
            A2 = trackBar2.Value + 0.5;
            Graficador(g1);
            t1 = t1 + 0.5;
        }     
    }
}
