using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personel_Çağırma
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] personel;
        int[] maas;
        int sayac = 0;
     
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            button4.BackColor = Color.Aqua;
            button5.BackColor = Color.Aqua;
            button8.BackColor = Color.Aqua;
            button6.BackColor = Color.Aqua;
            button3.BackColor = Color.Aqua;
            button2.BackColor = Color.Aqua; 
            button9.BackColor = Color.Aqua;
            button7.BackColor = Color.Aqua;
            personel = new string[] { "ALPER", "EMRE", "CEREN", "EMİNENUR" };
            maas = new int[] { 70000, 5000, 2500, 6520, };
            MessageBox.Show("Hos Geldiniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int maxmaas = maas[0];
            int maxindex = 0;
            for (int i = 0; i < maas.Length; i++)
            {
                if (maas[i] > maxmaas)
                {
                    maxmaas = maas[i];
                    maxindex = i;
                }
            }
            listBox1.Items.Add(maxmaas);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < personel.Length; i++)
            {
                listBox1.Items.Add(personel[i] + " >> " + maas[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < maas.Length; i++) 
            {
                if (maas[i] < 4500)
                {
                    listBox1.Items.Add(personel[i] + ">>" +  maas[i]);
                }
            }
              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            sayac = personel.Length;
            listBox1.Items.Add(sayac);
         

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayac = 0;
            for (int i = 0; i < maas.Length; i++)
            {
                if (maas[i]>=5000 && maas[i]<= 7000)
                {
                    sayac++;

                }
            }
            listBox1.Items.Add(sayac);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(maas[2] + 500);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(personel[3]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            int toplammaas = 0;
            for (int i = 0; i < maas.Length; i++)
            {
                toplammaas += maas[i];

            }
            listBox1.Items.Add(toplammaas);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int minmaas = maas[0];
            int minindex = 0;
            for (int i = 0; i < maas.Length; i++)
            {
                if (maas[i] < minmaas)
                {
                    minmaas = maas[i];
                    minindex = i;
                }
            }
            listBox1.Items.Add(minmaas);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       

        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Text = "Vize sınavı";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 7) 
                {
                    comboBox1.Items.Add(i);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2();
            frm2.Show();
                
        }
    }
}
