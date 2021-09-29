using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int baslangic = 1, tahminet=0,sonuc1=1, start2= 61, start3 = 0, basla=60;
        int[] tahmin = new int[6];
        int[] tutulan = new int[6];
        void yenioyun()
        {
            textBox1.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;
            textBox4.ForeColor = Color.White;
            textBox5.ForeColor = Color.White;
            textBox6.ForeColor = Color.White;
            basla -= 6;
            for(int i = 0; i < 6; i++)
            {
                toplam = toplam.Where(val => val != tutulan[i]).ToArray();
            }
            
            for(int i = 0; i < basla-1; i++)
            {
                Console.WriteLine("TOPLAM ARRAY: " + toplam[i]);
            }
            button2.Visible = true;
            button3.Visible = false;
            baslangic = 1;
            tahminet = 0;
            sonuc1 = 1;
            start2 = 61;
            start3 = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            tahmin1.Text = "";
            tahmin2.Text = "";
            tahmin3.Text = "";
            tahmin4.Text = "";
            tahmin5.Text = "";
            tahmin6.Text = "";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yenioyun();
        }

        int[] toplam = new int[60];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 60; i++)
            {
                toplam[i] = i + 1;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(textBox7.Text) > 60 && Convert.ToInt32(textBox7.Text) > 1)
            {
                MessageBox.Show("You cannot type a number higher than 60 or lower than 1.");
            }
            else if(Convert.ToInt32(textBox7.Text) < 60 && Convert.ToInt32(textBox7.Text) > 1)
            {
                if (baslangic == 1)
                {

                    baslangic += 1;
                    tahmin[0] = Convert.ToInt32(textBox7.Text);
                    tahmin1.Text = textBox7.Text;
                }
                else if (baslangic == 2)
                {
                    baslangic += 1;
                    tahmin[1] = Convert.ToInt32(textBox7.Text);
                    tahmin2.Text = textBox7.Text;
                }
                else if (baslangic == 3)
                {
                    baslangic += 1;
                    tahmin[2] = Convert.ToInt32(textBox7.Text);
                    tahmin3.Text = textBox7.Text;
                }
                else if (baslangic == 4)
                {
                    baslangic += 1;
                    tahmin[3] = Convert.ToInt32(textBox7.Text);
                    tahmin4.Text = textBox7.Text;
                }
                else if (baslangic == 5)
                {
                    baslangic += 1;
                    tahmin[4] = Convert.ToInt32(textBox7.Text);
                    tahmin5.Text = textBox7.Text;
                }
                else if (baslangic == 6)
                {
                    baslangic += 1;
                    tahmin[5] = Convert.ToInt32(textBox7.Text);
                    tahmin6.Text = textBox7.Text;
                    button1.Visible = true;
                    button2.Visible = false;
                }
                label2.Text = Convert.ToString(baslangic);
            }
            else
            {
                MessageBox.Show("Enter only numbers!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int a = i+1; a < 6; a++)
                {
                    Console.WriteLine("TAHMIN[i] == " + tahmin[i]);
                    Console.WriteLine("TAHMIN[a] == " + tahmin[a]);
                    if (tahmin[i] == tahmin[a])
                    {
                        MessageBox.Show("You typed same numbers. Thats not allowed.");
                        Application.Restart();
                        
                    }
                }
            }
            int tempe;
            for (int j = 0; j <= tahmin.Length - 2; j++)
            {
                for (int i = 0; i <= tahmin.Length - 2; i++)
                {
                    if (tahmin[i] > tahmin[i + 1])
                    {
                        tempe = tahmin[i + 1];
                        tutulan[i + 1] = tahmin[i];
                        tutulan[i] = tempe;
                    }
                }
            }
            sonuc1 += 1;
            Random rand = new Random();
            List<int> listNumbers = new List<int>();
            int number;
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    number = rand.Next(0, basla);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
            }
            tutulan=listNumbers.ToArray();

            int temp;
            for (int j = 0; j <= tutulan.Length - 2; j++)
            {
                for (int i = 0; i <= tutulan.Length - 2; i++)
                {
                    if (tutulan[i] > tutulan[i + 1])
                    {
                        temp = tutulan[i + 1];
                        tutulan[i + 1] = tutulan[i];
                        tutulan[i] = temp;
                    }
                }
            }
            for (int i = 0; i <6;i++)
            {
                if (i == 0)
                {
                    textBox1.Text = Convert.ToString(tutulan[i]);
                }
                else if (i == 1)
                {
                    textBox2.Text = Convert.ToString(tutulan[i]);
                }
                else if (i == 2)
                {
                    textBox3.Text = Convert.ToString(tutulan[2]);
                }
                else if (i == 3)
                {
                    textBox4.Text = Convert.ToString(tutulan[3]);
                }
                else if (i == 4)
                {
                    textBox5.Text = Convert.ToString(tutulan[4]);
                }
                else if (i == 5)
                {
                    textBox6.Text = Convert.ToString(tutulan[5]);
                }
            }
            button3.Visible = true;
            button1.Visible = false;

            Dogruluk();

        }
        void Dogruluk()
        {
            int sayi = 0;
            for(int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 6; a++)
                {
                    if(tahmin[i] == tutulan[a])
                    {
                        sayi += 1;
                        Console.Write(a);
                        if(a == 0)
                        {
                            textBox1.BackColor = Color.Green;
                        }
                        else if (a == 1)
                        {
                            textBox2.BackColor = Color.Green;
                        }
                        else if (a == 2)
                        {
                            textBox3.BackColor = Color.Green;
                        }
                        else if (a == 3)
                        {
                            textBox4.BackColor = Color.Green;
                        }
                        else if (a == 4)
                        {
                            textBox5.BackColor = Color.Green;
                        }
                        else if (a == 5)
                        {
                            textBox6.BackColor = Color.Green;
                        }

                    }
                }
            }

            label2.Text = sayi + " : Correct ";
        }
    }
}
