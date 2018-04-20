using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_graph
{
    public partial class Form1 : Form
    {
        Operation op;

        public Form1()
        {
            InitializeComponent();
            op = new Operation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_sign_Click(object sender, EventArgs e)
        {
            if (this.op.Step == 1)
            {
                this.op.Nbr1_sign = !this.op.Nbr1_sign;
                this.op.Nbr1 *= -1;
            }
            else if (this.op.Step == 3)
            {
                this.op.Nbr2_sign = !this.op.Nbr2_sign;
                this.op.Nbr2 *= -1;
            }
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (this.op.Step == 1)
                this.op.Nbr1 = (this.op.Nbr1 * 10) + 0;
            else if (this.op.Step == 3)
                this.op.Nbr2 = (this.op.Nbr2 * 10) + 0;
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button_point_Click(object sender, EventArgs e)
        {
            if (this.op.Step == 1)
            {
                this.op.Nbr1_is_point = true;
                this.op.Nbr1 += 0.0;
            }
            else if (this.op.Step == 3)
            {
                this.op.Nbr2_is_point = true;
                this.op.Nbr2 += 0.0;
            }
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button_equal_Click(object sender, EventArgs e)
        {
            this.op.Do_op[this.op.Op]();
            string rez = this.op.Nbr1.ToString();
            this.label1.Text = rez;
            this.op.Reset();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(1);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(2);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(3);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            if (this.op.Step == 3)
            {
                this.op.Do_op[this.op.Op]();
                this.op.Nbr2 = 0;
                this.op.Nbr2_sign = true;
                this.op.Nbr2_point = 0;
                this.op.Nbr2_is_point = false;
                this.op.Step = 1;
            }

            if (this.op.Step == 1)
            {
                this.op.Step = 2;
                this.op.Op = 0;
                this.label1.Text = this.op.Continuous_display(); ;
                this.op.Step = 3;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(4);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(5);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(6);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            if (this.op.Step == 3)
            {
                this.op.Do_op[this.op.Op]();
                this.op.Nbr2 = 0;
                this.op.Nbr2_sign = true;
                this.op.Step = 1;
            }

            if (this.op.Step == 1)
            {
                this.op.Step = 2;
                this.op.Op = 1;
                this.label1.Text = this.op.Continuous_display(); ;
                this.op.Step = 3;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(7);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(8);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.op.Number_button_click(9);
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button_mult_Click(object sender, EventArgs e)
        {
            if (this.op.Step == 3)
            {
                this.op.Do_op[this.op.Op]();
                this.op.Nbr2 = 0;
                this.op.Nbr2_sign = true;
                this.op.Step = 1;
            }

            if (this.op.Step == 1)
            {
                this.op.Step = 2;
                this.op.Op = 2;
                this.label1.Text = this.op.Continuous_display();
                this.op.Step = 3;
            }
        }

        private void Button_supr_Click(object sender, EventArgs e)
        {

        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            this.op.Reset();
            this.label1.Text = this.op.Continuous_display();
        }

        private void Button_modulo_Click(object sender, EventArgs e)
        {
            if (this.op.Step == 3)
            {
                this.op.Do_op[this.op.Op]();
                this.op.Nbr2 = 0;
                this.op.Nbr2_sign = true;
                this.op.Step = 1;
            }

            if (this.op.Step == 1)
            {
                this.op.Step = 2;
                this.op.Op = 4;
                this.label1.Text = this.op.Continuous_display(); ;
                this.op.Step = 3;
            }
        }

        private void Button_div_Click(object sender, EventArgs e)
        {
            if (this.op.Step == 3)
            {
                this.op.Do_op[this.op.Op]();
                this.op.Nbr2 = 0;
                this.op.Nbr2_sign = true;
                this.op.Step = 1;
            }

            if (this.op.Step == 1)
            {
                this.op.Step = 2;
                this.op.Op = 3;
                this.label1.Text = this.op.Continuous_display(); ;
                this.op.Step = 3;
            }
        }

     
    }
}
