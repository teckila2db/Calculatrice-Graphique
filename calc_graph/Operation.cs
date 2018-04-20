using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_graph
{
    public class Operation
    {
         public struct Element
        {
            public bool is_nbr;
            public int nbr;
            public bool nbr_sign;
            public int op;
        }
        private List<Element> Elements;  
        private double nbr1;
        private bool nbr1_sign;
        private int nbr1_point;
        private bool nbr1_is_point;
        private double nbr2;
        private bool nbr2_sign;
        private int nbr2_point;
        private bool nbr2_is_point;
        private int op;
        private int step;
        private bool is_start;
        Action[] do_op;
        private string display;
        char[] operand;

        public Operation()
        {
            Nbr1 = 0;
            Nbr1_sign = true;
            Nbr1_point = 0;
            Nbr1_is_point = false;
            Nbr2 = 0;
            Nbr2_sign = true;
            Nbr2_point = 0;
            Nbr2_is_point = false;
            Op = 0;
            Step = 1;
            Is_start = true;

            List<Element> Elements = new List<Element>();

            Do_op = new Action[5];
            Do_op[0] = Add;
            Do_op[1] = Remove;
            Do_op[2] = Mult;
            Do_op[3] = Div;
            Do_op[4] = Modulo;

            Operand = new char[5];
            Operand[0] = '+';
            Operand[1] = '-';
            Operand[2] = 'x';
            Operand[3] = '/';
            Operand[4] = '%';

            Display = "0";
        }

        public double Nbr1 { get => nbr1; set => nbr1 = value; }
        public bool Nbr1_sign { get => nbr1_sign; set => nbr1_sign = value; }
        public double Nbr2 { get => nbr2; set => nbr2 = value; }
        public bool Nbr2_sign { get => nbr2_sign; set => nbr2_sign = value; }
        public int Op { get => op; set => op = value; }
        public int Step { get => step; set => step = value; }
        public Action[] Do_op { get => do_op; set => do_op = value; }
        public string Display { get => display; set => display = value; }
        public bool Is_start { get => is_start; set => is_start = value; }
        public char[] Operand { get => operand; set => operand = value; }
        public int Nbr1_point { get => nbr1_point; set => nbr1_point = value; }
        public int Nbr2_point { get => nbr2_point; set => nbr2_point = value; }
        public bool Nbr1_is_point { get => nbr1_is_point; set => nbr1_is_point = value; }
        public bool Nbr2_is_point { get => nbr2_is_point; set => nbr2_is_point = value; }

        public void Reset()
        {
            Nbr1 = 0;
            Nbr1_sign = true;
            Nbr1_point = 0;
            Nbr1_is_point = false;
            Nbr2 = 0;
            Nbr2_sign = true;
            Nbr2_point = 0;
            Nbr2_is_point = false;
            step = 1;
            op = 6;
            is_start = true;
        }

        public string Continuous_display()
        {
            string rez = "";
            if (this.step == 1)
                rez += this.nbr1.ToString();
            else if (this.step == 2)
            {
                rez = this.nbr1.ToString();
                rez += ' ';
                rez += Operand[op];
                rez += '\n';
            }
            else if (this.step == 3)
            {
                rez = this.nbr1.ToString();
                rez += ' ';
                rez += Operand[op];
                rez += ' ';
                rez += '\n';
                rez += this.nbr2.ToString();
            }
            return rez;
        }

        public void Number_button_click(double nbr)
        {
            if (this.Step == 1)
            {
                if (this.Nbr1_sign == true)
                {
                    if (this.Nbr1_is_point == false)
                        this.Nbr1 = (this.Nbr1 * 10) + nbr;
                    else
                    {
                        this.Nbr1_point++;
                        int i = 0;
                        while (i != this.Nbr1_point)
                        {
                            nbr = nbr / 10;
                            i++;
                        }
                        this.Nbr1 += nbr;
                    }
                }
                else if (this.Nbr1_sign == false)
                {
                    if (this.Nbr1_is_point == false)
                        this.Nbr1 = (this.Nbr1 * 10) - nbr;
                    else
                    {
                        this.Nbr1_point++;
                        int i = 0;
                        while (i != this.Nbr1_point)
                        {
                            nbr = nbr / 10;
                            i++;
                        }
                        this.Nbr1 -= nbr;
                    }
                }
            }
            else if (this.Step == 3)
            {
                if (this.Nbr2_sign == true)
                {
                    if (this.nbr2_is_point == false)
                        this.Nbr2 = (this.Nbr2 * 10) + nbr;
                    else
                    {
                        this.Nbr2_point++;
                        int i = 0;
                        while (i != this.Nbr2_point)
                        {
                            nbr = nbr / 10;
                            i++;
                        }
                        this.Nbr2 += nbr;
                    }
                }
                else if (this.Nbr2_sign == false)
                {
                    if (this.nbr2_is_point == false)
                        this.Nbr2 = (this.Nbr2 * 10) - nbr;
                    else
                    {
                        this.Nbr2_point++;
                        int i = 0;
                        while (i != this.Nbr2_point)
                        {
                            nbr = nbr / 10;
                            i++;
                        }
                        this.Nbr2 -= nbr;
                    }
                }
            }
        }

        public void Suppr()
        {
        }

        private void Add()
        {
            this.Nbr1 += this.Nbr2;
        }

        private void Remove()
        {
            this.Nbr1 -= this.Nbr2;
        }


        private void Mult()
        {
            this.Nbr1 *= this.Nbr2;
        }


        private void Div()
        {
            this.Nbr1 /= this.Nbr2;
        }


        private void Modulo()
        {
            this.Nbr1 %= this.Nbr2;
        }

    }

}
