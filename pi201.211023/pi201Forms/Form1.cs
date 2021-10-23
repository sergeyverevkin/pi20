using pi201.a211023;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi201Forms
{
    public partial class Form1 : Form
    {
        private CCalculator m_pClass;

        public Form1()
        {
            m_pClass = new CCalculator();
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            m_pClass.CurrentOperation = EOperation.Plus;
            m_pClass.Arg1 = Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            m_pClass.CurrentOperation = EOperation.Minus;
            m_pClass.Arg1 = Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            m_pClass.Arg2 = Double.Parse(textBox1.Text);
            textBox1.Text = m_pClass.Calculate().ToString();
        }
    }
}
