using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            int N = (int)NumExperiments.Value;
            decimal Prob5Value = N - (Prob1.Value + Prob2.Value + Prob3.Value + Prob4.Value);

            decimal n1 = Prob1.Value;
            decimal n2 = Prob2.Value;
            decimal n3 = Prob3.Value;
            decimal n4 = Prob4.Value;
            decimal n5 = Prob5Value;

            double Rf_p1 = (double)n1 / N;
            double Rf_p2 = (double)n2 / N;
            double Rf_p3 = (double)n3 / N;
            double Rf_p4 = (double)n4 / N;
            double Rf_p5 = (double)n5 / N;

            chart1.Series[0].Points.AddXY(1, Rf_p1);
            chart1.Series[0].Points.AddXY(2, Rf_p2);
            chart1.Series[0].Points.AddXY(3, Rf_p3);
            chart1.Series[0].Points.AddXY(4, Rf_p4);
            chart1.Series[0].Points.AddXY(5, Rf_p5);

            double p1 = 0.125;
            double p2 = 0.225;
            double p3 = 0.375;
            double p4 = 0.155;
            double p5 = 0.120;

            double Ex = p1 * 1 + p2 * 2 + p3 * 3 + p4 * 4 + p5 * 5;
            //double Dx = (p1 * 1 * 1 - (Ex * Ex)) + (p2 * 2 * 2 - (Ex * Ex)) + (p3 * 3 * 3 - (Ex * Ex)) + (p4 * 4 * 4 - (Ex * Ex)) + (p5 * 5 * 5 - (Ex * Ex));
            double Dx = p1 * 1 * 1 + p2 * 2 * 2 + p3 * 3 * 3 + p4 * 4 * 4 + p5 * 5 * 5 - (Ex * Ex);

            double Average_Ex = Rf_p1 * 1 + Rf_p2 * 2 + Rf_p3 * 3 + Rf_p4 * 4 + Rf_p5 * 5;
            //double Variance_Dx = (Rf_p1 * 1 * 1 - (Average_Ex * Average_Ex)) + (Rf_p2 * 2 * 2 - (Average_Ex * Average_Ex)) + (Rf_p3 * 3 * 3 - (Average_Ex * Average_Ex)) + (Rf_p4 * 4 * 4 - (Average_Ex * Average_Ex)) + (Rf_p5 * 5 * 5 - (Average_Ex * Average_Ex));
            double Variance_Dx = Rf_p1 * 1 * 1 + Rf_p2 * 2 * 2 + Rf_p3 * 3 * 3 + Rf_p4 * 4 * 4 + Rf_p5 * 5 * 5 - (Average_Ex * Average_Ex);

            double Ae_E = Math.Abs(Average_Ex - Ex);
            double Ae_D = Math.Abs(Variance_Dx - Dx);

            double Re_E = Ae_E / (Math.Abs(Ex));
            double Re_D = Ae_D / (Math.Abs(Dx));

            //double Chi = (((double)(n1 * n1) / (N * p1)) - N) + (((double)(n2 * n2) / (N * p2)) - N) + (((double)(n3 * n3) / (N * p3)) - N) + (((double)(n4 * n4) / (N * p4)) - N) + (((double)(n5 * n5) / (N * p5)) - N);
            double Chi = ((double)(n1 * n1) / (N * p1)) + ((double)(n2 * n2) / (N * p2)) + ((double)(n3 * n3) / (N * p3)) + ((double)(n4 * n4) / (N * p4)) + ((double)(n5 * n5) / (N * p5)) - N;

            Average.Text = Average_Ex + "(error = " + (Re_E * 100) + "%)";
            Variance.Text = Variance_Dx + "(error = " + (Re_D * 100) + "%)";
            ChiSquared.Text = Chi + "";
        }
    }
}
