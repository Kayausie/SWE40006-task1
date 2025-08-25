using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdderLibrary;
using SubtractorLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            counter=AdderLibrary.Adder.Add(counter);
            label1.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter=SubtractorLibrary.Subtractor.Subtract(counter);
            label1.Text = counter.ToString();
        }
    }
}
