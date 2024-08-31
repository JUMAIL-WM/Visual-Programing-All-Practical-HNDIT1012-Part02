using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonClick.Click += buttonClick_Click;
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            int number01 = int.Parse(textBox1.Text);
            //int number02 = int.Parse(textBox2.Text);

            if (number01 == 1)
            {
                label1.Text = number01.ToString();
             textBox2.BackColor = Color.Red;
                return;
            }
            if (number01 == 2)
            {
                textBox2.BackColor = Color.Green;
            }
        }

        
    }
}
