using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamol_00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool t = false, t1 = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "Xato qilish imkomiyatlar soni = 3";
            Random son = new Random();
            double a, b, x, y, z;int c;
            a = son.Next(1, 100);
            b = son.Next(1, 100);
            c = son.Next(1, 5);
            switch (c)
            {
                case 1:
                    {
                        x = a + b;;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100);t1 = true;
                            label1.Text = a.ToString() + " + " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                            t = true;
                            label1.Text = a.ToString() + " + " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
                case 2:
                    {
                        x = a - b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " - " + b.ToString() + " = " + z.ToString();
                        }
                        else
                        {
                           t = true;
                            label1.Text = a.ToString() + " - " + b.ToString() + " = " + x.ToString();
                        }
                      
                    }; break;
                case 3:
                    {
                        x = a / b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " / " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                             t = true;
                            label1.Text = a.ToString() + " / " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
                case 4:
                    {
                        x = a * b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " * " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                             t = true;
                            label1.Text = a.ToString() + " * " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
            }
        }


        int javob = 0, xato = 0, xx = 3;
 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t1 && !t)
            {
                javob++;
                label2.Text = " \r " + javob.ToString();t1 = false;t = false;   
            }
            else
            {
                xato++;
                if (xato == 3) {
                    xx--;
                    label4.Text = "Xato qilish imkomiyatlar soni = " + xx.ToString();
                    MessageBox.Show("Siz uchta xato qildingiz ","Oddiy Matematika");
                    Close();
                }
                else
                {
                    xx--;
                    label4.Text = "Xato qilish imkomiyatlar soni = " + xx.ToString();
                }
                t = false;t1 = false;
            }
            Random son = new Random();
            double a, b, x, y, z;
            int c;
            a = son.Next(1, 100);
            b = son.Next(1, 100);
            c = son.Next(1, 5);
            switch (c)
            {
                case 1:
                    {
                        x = a + b;
                        c = son.Next(2);
                        if (c == 0)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " + " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                             t = true;
                            label1.Text = a.ToString() + " + " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
                case 2:
                    {
                        x = a - b;
                        c = son.Next(2);
                        if (c == 0)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " - " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                             t = true;
                            label1.Text = a.ToString() + " - " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
                case 3:
                    {
                        x = a / b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " / " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                             t = true;
                            label1.Text = a.ToString() + " / " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
                case 4:
                    {
                        x = a * b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " * " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                             t = true;
                            label1.Text = a.ToString() + " * " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t && !t1) {
                javob++;
            label2.Text=" \r "+javob.ToString();
                t = false;t1 = false;
            }
            else
            {
                xato++;
                if (xato == 3)
                {
                    xx--;
                    label4.Text = "Xato qilish imkomiyatlar soni = " + xx.ToString();
                    MessageBox.Show("Siz uchta xtao qildingiz ", "Oddiy Matematika");
                    Close();
                }
                else
                {
                    xx--;
                    label4.Text = "Xato qilish imkomiyatlar soni = " + xx.ToString();
                }

                t = false; t1 = false;
            }
            Random son = new Random();
            int a, b, c, x, y, z;
            a = son.Next(1, 100);
            b = son.Next(1, 100);
            c = son.Next(1, 5);
            switch (c)
            {
                case 1: {
                        x = a + b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " + " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                            t = true;
                            label1.Text = a.ToString() + " + " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
                case 2: {
                        x = a - b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " - " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                            t = true;
                            label1.Text = a.ToString() + " - " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
                case 3: {
                        x = a / b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " / " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                             t = true;
                            label1.Text = a.ToString() + " / " + b.ToString() + " = " + x.ToString();
                        }
                    }; break;
                case 4: {
                        x = a * b;
                        c = son.Next(2);
                        if (c == 1)
                        {
                            z = son.Next(1, 100); t1 = true;
                            label1.Text = a.ToString() + " * " + b.ToString() + " = " + z.ToString();
                        }
                        else 
                        {
                              t = true;
                            label1.Text = a.ToString() + " * " + b.ToString() + " = " + x.ToString();
                        }
                      
                    }; break;
            }
        }
    }
}