using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Çağırma
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(textBox1.Text);
            if (yas >= 18)
            {
                label2.Text = "Ehliyet Alabilir";
            }
            else
            {
                label2.Text = "Ehliyet Alamaz, Yaşı tutmuyor ";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox2.Text);               
                while (sayi >= 0){
                    listBox1.Items.Add(sayi);
                    sayi--;       
            }
        }
    }
}
