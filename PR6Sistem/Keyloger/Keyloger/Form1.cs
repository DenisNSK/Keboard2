using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyloger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = "Down";
        }

        private async void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //label2.Text += e.KeyChar.ToString();

            //if (label2.Text.Length > 10)
            //{
                //File.WriteAllText(@"C:\Users\Lenovo\Desktop\Практические 3 курс 2 полугодие\1.txt", label2.Text, Encoding.Default);
            //}
            //File.WriteAllText(@"C:\Users\Lenovo\Desktop\Практические 3 курс 2 полугодие\1.txt", label2.Text, Encoding.Default);
            ///
            label3.Text = "Press";
            label2.Text += e.KeyChar.ToString();
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Lenovo\Desktop\Практические 3 курс 2 полугодие\1.txt", true))
            {
                if (label2.Text.Length == 10)
                {
                    await writer.WriteLineAsync(label2.Text);
                    label2.Text = "";
                }
            }



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label3.Text = "Up";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
