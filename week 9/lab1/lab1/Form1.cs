using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string l;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            l = textBox1.Text;
        }
        int z;
        public bool IsPrime(int x)
        {
            for(int i=2; i<x; ++i)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            z = int.Parse(l);
            if (IsPrime(z))
                textBox2.Text = "YES";
            else
                textBox2.Text = "NO";
        }

    }
}
