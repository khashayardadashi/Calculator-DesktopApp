using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycalculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private string _op;

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "*";
            _op = _op +"*";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "1";
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "6";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "+";
            _op = _op + "+";
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "8";
        }

        private void btnmines_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "-";
            _op =_op + "-";
        }

        private void btndivid_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "/";
            _op = _op+ "/";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (_op.Count() >= 2)
            {
                MessageBox.Show("your operator is invalid !");
                txtbox.Text = "";
                _op="";
            }
            else
            {
                char p = Convert.ToChar(_op);
                string[] result = txtbox.Text.Split(p);
                Int64 num1 = Convert.ToInt64(result[0]);
                Int64 num2 = Convert.ToInt64(result[1]);

                if (_op == "+")
                {
                    txtbox.Text = Convert.ToString(num1 + num2);
                }
                else if (_op == "-")
                {
                    txtbox.Text = Convert.ToString(num1 - num2);
                }
                else if (_op == "*")
                {
                    txtbox.Text = Convert.ToString(num1 * num2);
                }
                else if (_op == "/")
                {
                    txtbox.Text = Convert.ToString( num1 / num2);
                }
                _op = "";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { txtbox.Text = txtbox.Text.Remove(txtbox.Text.Length - 1); }
            catch { txtbox.Text = ""; }
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "0";
        }
    }
}
