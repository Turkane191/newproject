using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            
            int cutcem = 0;
            int tekcem = 0;
            for (int i = a; i < b; i++)
                  
            {
                if (i % 2 == 0) 

                {
                    cutcem=cutcem+i;
                }
                else
                {
                    tekcem+=i;
                }
            }
            label1.Text = cutcem.ToString();
            label2.Text = tekcem.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            int cutsay = 0;
            int teksay = 0;

            for (int i = a; i < b; i++)
            {
                if (i%2==0)
                {
                    cutsay++;
                }
                else
                {
                    teksay++;
                }
                label1.Text = cutsay.ToString();
                label2.Text = teksay.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            int bolcem = 0;
            int bolsay = 0;

            for (int i = a; i <=b; i++)
            {
                if (i%3==0||i%4==0)
                {
                    bolcem += i;
                    
                }
                else
                {
                    bolsay++;
                }
                label1.Text = bolcem.ToString();
                label2.Text = bolsay.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

           int bolcem = 0;
           int bolsay = 0;

            for (int i = a; i < b; i++)
            {
                if (i%4==0&&i%6==0)
                {
                    bolcem += i;
                    bolsay++;
                }
                
                label1.Text = bolcem.ToString();
                label2.Text = bolsay.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);

            int fakt = 1;

            for (int i = 1; i <=a; i++)
            {
                fakt = fakt * i;
            }
            label1.Text = fakt.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int esas = Convert.ToInt32(textBox1.Text);
            int quvvet = Convert.ToInt32(textBox2.Text);

            int netice = 1;
            for (int i = 1; i <=quvvet; i++)
            {
                netice = netice * esas;
            }
            label1.Text = netice.ToString();
        }
    }
}
