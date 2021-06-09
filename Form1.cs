using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_
{
    public partial class Form1 : Form
    {
        double value = 0;
        string ops = "";
        bool op_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_click(object sender, EventArgs e)
        {
            if((hasil.Text == "0") || (op_pressed))
            {
                hasil.Clear();
            }
            Button b = (Button)sender;
            hasil.Text = hasil.Text + b.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            value = Double.Parse(hasil.Text);

            op_pressed = true;
        }

        private void hitung(object sender, EventArgs e)
        {
            switch (ops)
            { 
             case "+": hasil.Text = (value + double.Parse(hasil.Text)).ToString();
                break;
             case "-": hasil.Text = (value - Double.Parse(hasil.Text)).ToString();
                 break;
             case "*": hasil.Text = (value * double.Parse(hasil.Text)).ToString();
                    break;
             case "/": hasil.Text = (value / Double.Parse(hasil.Text)).ToString();
                 break;

            }
        }

        private void sqrt(object sender, EventArgs e)
        {
            hasil.Text = (Math.Sqrt(double.Parse(hasil.Text))).ToString();
        }

        private void Clear_1(object sender, EventArgs e)
        {
            hasil.Text = "0";
        }

        private void backspace(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text.Remove(hasil.Text.Length - 1, 1);
        }
    }
}
