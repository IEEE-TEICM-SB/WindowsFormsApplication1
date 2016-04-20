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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            string name = "Paylos";
//            int number=100;
//            double akeraios = 100.12;
//            bool papoytsi = true;
//            object MyObject=true;
//            MessageBox.Show(name,"Αυτο ειναι το ονομα μου");
//            MessageBox.Show(number.ToString(),"Αυτο ειναι το ονομα μου");
//            MessageBox.Show(papoytsi.ToString(),"Αυτο ειναι το ονομα μου");
//            MessageBox.Show(MyObject.ToString(),"Αυτο ειναι το ονομα μου");
//            button1.Text = "Paylos";
//            button1.Enabled = false;
//            button1.Height = 60;
//            button1.Width = 100;
//            textBox1.Text = "Paylos";
//            textBox1.Enabled = false;
//            textBox1.MaxLength = 2;
            switch (textBox1.Text)
            {
                case "daidalos":
                {
                    MessageBox.Show("hell");
                    break;
                }
                case "alekos":
                {
                    MessageBox.Show("Hallo aleko");
                    break;
                }
                default:
                {
                    MessageBox.Show("Your name is not inportant");
                        break;
                }              




            }
            string[] names1=new string[10];
            string[] names =
            {
                "pavlos", "basilis"
            };

            MessageBox.Show(names[1]);
            MessageBox.Show(names1[1]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

namespace TextHello
{
    class Greetings
    {
         
    }

}