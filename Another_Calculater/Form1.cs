using System;
using System.Windows.Forms;

namespace Another_Calculater
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        public double Result1, Result2, Sum, Mul, Min, Div;

        Boolean OPMul, OPSum, OPMin, OPDiv;

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "4";
        }

       
        private void Btn_5_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "6";
        }

      
        private void Btn_7_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "7";
        }


        private void Btn_8_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "9";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Txt_Result.Text + "0";
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = "";
        }

        private void Btn_Sum_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text != "")
            {
                Result1 = double.Parse(Txt_Result.Text);
                Txt_Result.Text = "";
                OPSum = true;
            }
        }
        
        private void Btn_Min_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text != "")
            {
                Result1 = double.Parse(Txt_Result.Text);
                Txt_Result.Text = "";
                OPMin = true;
            }
        }

         private void Btn_Mul_Click(object sender, EventArgs e)
         {
            Result1 = double.Parse(Txt_Result.Text);
            Txt_Result.Text = "";
            OPMul = true;
         }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            Result1 = double.Parse(Txt_Result.Text);
            Txt_Result.Text = "";
            OPDiv = true;
        }


        private void Btn_Equ_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text != "")
            {
                Result2 = double.Parse(Txt_Result.Text);
                if (OPSum == true)
                {
                    Sum = Result1 + Result2;
                    Txt_Result.Text = Sum.ToString();
                    OPSum = false;
                }
                else if (OPMin == true)
                {
                    Min = Result1 - Result2;
                    Txt_Result.Text = Min.ToString();
                    OPMin = false;
                }
                else if (OPMul == true)
                {
                    Mul = (Result1 * Result2);
                    Txt_Result.Text = Mul.ToString();
                    OPMul = false;
                }
                else if (OPDiv == true)
                {
                    Div = Result1 / Result2;
                    Txt_Result.Text = Div.ToString();
                    OPDiv = false;
                }
            }
        }
    }
}
