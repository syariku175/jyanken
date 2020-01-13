using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyanken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comphand = this.Getcomphand();

            this.Hantei("グー", comphand);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string comphand = this.Getcomphand();

            this.Hantei("チョキ", comphand);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string comphand = this.Getcomphand();

            this.Hantei("パー", comphand);

        }

        private string Getcomphand()
        {
            Random rand = new Random();

            int result = rand.Next(3);

            string resultstring = "";

            switch (result)
            {
                case 0:

                    label1.Text = "コンピューターはグー";

                    pictureBox1.ImageLocation = "image/g.png";

                    resultstring = "グー";

                    break;

                case 1:

                    label1.Text = "コンピューターはチョキ";

                    pictureBox1.ImageLocation = "image/c.png";

                    resultstring = "チョキ";


                    break;

                case 2:

                    label1.Text = "コンピューターはパー";

                    pictureBox1.ImageLocation = "image/p.png";

                    resultstring = "パー";

                    break;

            }

            return resultstring;

        }

        private void Hantei(string myhand, string comphand)
        {

            if (myhand == comphand)
            {
                label1.Text += " / 引き分けです";

            }

            else if(myhand == "グー" && comphand == "チョキ" ||
                    myhand == "チョキ" && comphand == "パー" ||
                    myhand == "パー" && comphand == "グー"
                )
            {
                label1.Text += "/ 勝ちました";
            }

            else
            {
                label1.Text += " / 負けました";
            }
        }

    }
}
