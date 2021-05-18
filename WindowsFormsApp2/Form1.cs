using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        float[] values;
        float me;
        float de;
        int n;
        float[] krit = {7.8145f,14.057f,18.307f,22.362f };
        int stage;

        public Form1()
        {
            InitializeComponent();

        }

        private void Start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            Random rnd = new Random();
            me = (float)MeanValue.Value;
            de = (float)DispersValue.Value;

            n = Convert.ToInt32(NumberOfExper.Text);
            stage = NumberOfExper.SelectedIndex;
            values = new float[n];
            float me2 = 0;
            float de2 = 0;
            for (int i = 0; i< n; i++)
            {
                double a1 = rnd.NextDouble();
                double a2 = rnd.NextDouble();
                double kor = Math.Sqrt(-2 * Math.Log(a1));
                double cos = Math.Cos(2 * Math.PI * a2);
                double sin = Math.Sin(2 * Math.PI * a2);
                float x = (float)(kor * cos * Math.Sqrt(de) + me);
                values[i] = x;
                me2 += x;
                de2 += (float)Math.Pow(x, 2);
                //x = kor * sin * Math.Sqrt(de) + me;

            }
            me2 /= n;
            de2 /= n;
            de2 -= (float)Math.Pow(me2, 2);
            Stats(n, me2, de2);
        }



        void Stats(int numbers, float me2, float de2)
        {
            double min, max;
            min = max = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min) min = values[i];
                if (values[i] > max) max = values[i];
            }
            double smallKoef = (max - min) * 0.05;
            double interval = (max - min) + smallKoef;
            
            int k = (int)Math.Round( Math.Log(numbers)/Math.Log(2) + 1);
            double step = interval / k;

            double q = min - smallKoef / 2;
            int[] stat = new int[k];
            float chi = 0;

            for (int i = 0; i < k; i++)
            {
                stat[i] = Check(q, q + step);
                float p = (float)(q + step - q) * Density( (float)(q + step + q) / 2);
                chi += (float)Math.Pow(stat[i], 2) / (numbers * p);
                chart1.Series[1].Points.AddXY(q,Density((float)(q + step + q) / 2));
                chart1.Series[0].Points.AddXY(q, (double)stat[i]/numbers);
                q += step;
            }

            chi -= numbers;
            SetStatInfo(chi,me2,de2);

            foreach (var t in stat)
            {
                Console.WriteLine(t);

            }
            Console.WriteLine(chi);
            Console.WriteLine("--------------" + k + "------------------");
        }


        void SetStatInfo(float chi, float me2, float de2)
        {
            if (chi < krit[stage])
            {
                ResChi.Text = $"{chi} < {krit[stage]}  is {false}";
            }
            else
            {
                ResChi.Text = $"{chi} > {krit[stage]}  is {true}";
            }
            RelAver.Text = $"{me2} (error = {Math.Round(Math.Abs(me2 - me) / Math.Abs(me2) * 100)}%)";
            RelVariance.Text = $"{de2} (errors = {Math.Round(Math.Abs(de2 - de) / Math.Abs(de2) * 100, 2)}%)";
        }

        int Check(double a, double b )
        {
            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= a && values[i] < b) count++;
            }
            return count;
        }
        float Density( float x)
        {
            float value = (float)Math.Pow(Math.E,Math.Pow((x - me),2)/(-2*Math.Pow(de,2)));
            return (float)value/ (float)(de * Math.Sqrt(2*Math.PI));
        }
    }
}
