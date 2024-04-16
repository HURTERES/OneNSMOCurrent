using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnoVse
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        private void OutputInfo(double Intensiv, int CountKanal, double Nu = 0, double Toch = 0)
        {
            double Ro = 0;
            double Potk = 0;
            double Q = 0;
            double A = 0;
            double K = 0;
            bool Flag = false;
            // вычисляем Ro
            if (Toch != 0)
            {
                Ro = Intensiv * Toch;
                Nu = Intensiv / Toch; // если Ню неизвестно, то находим его по формуле
            }
            else
            {
                Flag = true;
                Ro = Intensiv / Nu;
            }

            LblNagruzKanal.Text = $"ρ: {(Ro):F3}"; // выводим Ro
            double P0 = PredelVerP0(Ro, CountKanal);
            LblP0.Text = $"P0: {P0:F3} {PredelVerPn(Ro, CountKanal, P0)}";

            if (Ro < 1) // если Ro меньше 1
            {
                Potk = 0;
                Q = 1;
                A = Intensiv;
            }
            else
            {
                Potk = (Math.Pow(Ro, CountKanal) / Factorial(CountKanal)) * P0;
                Q = 1 - Potk;
                A = Intensiv * Q;
                K = Ro;
            }

            LblPotk.Text = $"Pотк: {Potk:f3}";
            LblQ.Text = $"Q: {Q:F3}";
            LblA.Text = $"A: {A:F3}";
            LblK.Text = $"k: {Ro:f3}";

            double Poch = (Math.Pow(Ro, CountKanal + 1) / (Factorial(CountKanal) * (CountKanal - Ro))) * P0;
            double Loch = (Math.Pow(Ro, CountKanal + 1) * P0) / (CountKanal * Factorial(CountKanal) * Math.Pow(1 - (Ro / CountKanal), 2));
            double Lsist = Loch + Ro;

            LblPoch.Text = $"Pоч: {Poch:f3}";
            LblLoch.Text = $"Lоч: {Loch:f3}";
            LblSist.Text = $"Lсист: {Lsist:f3}";

            double Lob = Lsist + Loch;
            double Tsist = (1 / Intensiv) * Lsist;

            if (Flag == true)
            {
                Toch = (1 / Intensiv) * Loch;
            }

            LblLob.Text = $"Lоб: {Lob:f3}";
            LblTsist.Text = $"Tсист: {Tsist:f3} мин.";
            LblToch.Text = $"Tоч: {Toch:f3} мин.";

        }

        private static double PredelVerP0(double Ro, int CountCanal) // расчитыает P0
        {
            double Sum = 1;
            for (int i = 0; i < CountCanal; i++)
            {
                Sum += Math.Pow(Ro, i + 1) / Factorial(i + 1);
            }
            Sum += Math.Pow(Ro, CountCanal + 1) / (Factorial(CountCanal) * (CountCanal - Ro));
            return Math.Pow(Sum, -1);
        }

        private static string PredelVerPn(double Ro, int CountCanal, double P0) // расчитывает P1, P2,... Pn
        {
            string ReadyText = "";
            for (int i = 0; i < CountCanal; i++)
            {
                ReadyText += $" P{i + 1}: {((Math.Pow(Ro, i + 1) / Factorial(i + 1)) * P0):f3}";
            }
            return ReadyText;
        }

        private static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            LblIntensivn.Text = Form1.ListIntens.Count.ToString()+" чел/ч";
            double Intensiv = double.Parse((LblIntensivn.Text).ToString().Split(' ')[0]);

            // если среднее время пребывания заявки нету, то используется значение Ню
            double Toch = 0;
            double Nu = 0;

            Nu = double.Parse(LblIntensObsluz.Text.Split(' ')[0]); // Ню

            //  среднее время пребывания заявки в очереди
            int CountKanals = int.Parse(LblCanal.Text.Trim()); // кол-во каналов в СМО

            OutputInfo(Intensiv, CountKanals, Nu, Toch);
        }

        private void TbnFormulas_Click(object sender, EventArgs e)
        {
            if (TbxFormulas.Text == "Используемые формулы")
            {
                LblNagruzKanal.Text = $"ρ= λ/μ";

                LblP0.Text = $"p0= μ/λ+μ   p1=λ/λ+μ";

                LblPotk.Text = $"Po= p^n+1/n!*p0";

                LblQ.Text = $"Q= 1 - Po";

                LblA.Text = $"A= λ * Q";

                LblK.Text = $"k= ρ";

                LblPoch.Text = $"Pоч= ρ^n+1/n!*(n - ρ)*p0";

                LblLoch.Text = $"Lоч= ρ^n+1 * p0 / (n * n! * (1 - (ρ / n)^2";

                LblSist.Text = $"Lсист: Lоч*ρ";

                LblLob.Text = $"Lоб= Lсист + Lоч";

                LblTsist.Text = $"Tсист= (1 / λ) * Lсист";

                LblToch.Text = $"Tоч= (1 / λ) * Lоч";
                TbxFormulas.Text = "Скрыть";
            }
            else
            {
                TbxFormulas.Text = "Используемые формулы";
                LblIntensivn.Text = Form1.ListIntens.Count.ToString();
                double Intensiv = 1;
                double Toch = 0;
                double Nu = 0;

                Nu = double.Parse(LblIntensObsluz.Text.Split(' ')[0]);
                int CountKanals = int.Parse(LblCanal.Text.Trim());

                OutputInfo(Intensiv, CountKanals, Nu, Toch);
            }

        }
    }
}
