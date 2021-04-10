using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework06
{
    public partial class Form1 : Form
    {
        private BasicData _data;
        public Form1()
        {
            InitializeComponent();
            _data = new BasicData();
        }
        private void Calculate(bool _result)
        {
            _data.item = int.Parse(textBox1.Text);
            if(_result)
                label1.Text = _data.ModeI();
            else
                label1.Text = _data.ModeII();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
