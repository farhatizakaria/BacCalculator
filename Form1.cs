using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBoxNE.Text == "" || textBoxRE.Text == "" || textBoxCC.Text == "")
            {
                MessageBox.Show("Something is wrong, please fill all text boxes");
            }
            else
            {
                try
                {

                    double NE = double.Parse(textBoxNE.Text);
                    double RE = double.Parse(textBoxRE.Text);
                    double CC = double.Parse(textBoxCC.Text);
                    double R = ((NE * 0.5) + (RE * 0.25) + (CC * 0.25));
                    //R.ToString();
                    labelResult.Text = R.ToString();

                }

                catch (Exception)
                {

                    MessageBox.Show(" the user should write \",\" in place of \".");
                }
            }
        }

    }
}
