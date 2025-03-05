using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora__
{
    public partial class Form1: Form
    {
        double num1, num2, resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void TravaBt()
        {
            btIgual.Enabled =
                !((lblOp.Text == btDiv.Text && numOper_2.Value == 0)|| lblOp.Text == "...");
        }
        void AddOper(string oper)
        {
            lblOp.Text = oper;
        }
        private void label1_Click(object sender, EventArgs e)
        {
               
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddOper(btMult.Text);
        }

        private void numOper_1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbl_Result.Text= "";
            lblOp.Text = ". . .";
            numOper_1.Value = 0;
            numOper_2.Value = 0;
        }

        private void btMais_Click(object sender, EventArgs e)
        {
            AddOper(btMais.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            TravaBt();
            AddOper(btDiv.Text);
        }

        private void btSegue_Click(object sender, EventArgs e)
        {
            numOper_1.Text = lbl_Result.Text;
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AddOper(btSub.Text);
        }

        private void btIgual_Click(object sender, EventArgs e)
        { 
            num1 = (double)numOper_1.Value;
            num2 = (double)numOper_2.Value;

            if (lblOp.Text == btMais.Text)
                resultado = num1 + num2;
            else if (lblOp.Text == btSub.Text)
                resultado = num1 - num2;
            else if (lblOp.Text == btMult.Text)
                resultado = num1 * num2;
            else if (lblOp.Text == btDiv.Text)
                resultado = num1 / num2;

            lbl_Result.Text = resultado.ToString();
           
        }
    }
}
