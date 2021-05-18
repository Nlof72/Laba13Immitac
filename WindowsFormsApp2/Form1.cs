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
        const int numOfNums = 5;
        float[] prob = new float[numOfNums];
        float p0;
        int n;
        float krit = 9.488f;

        public Form1()
        {
            InitializeComponent();

        }
        void InitProbGeom()
        {
            float sum = 0;
            for (int i = 0; i < numOfNums - 1; i++)
            {
                prob[i] = (float)(p0 * Math.Pow((1 - p0), i));
                //Console.WriteLine(p * Math.Pow((1 - p), i));
                sum += prob[i];
                //Console.WriteLine(sum);
            }
            prob[numOfNums - 1] = 1 - sum;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Random rnd = new Random();
            p0 = (float)Pprob.Value;
            InitProbGeom();

            float q;
            
            n = (int)NumberOfExper.Value;
            int[] mass = new int[numOfNums];
            for (int i = 0; i< n; i++)
            {
                int x = (int)(Math.Log(rnd.NextDouble()) / Math.Log(1 - p0));
                if (x > prob.Length - 1) { mass[prob.Length - 1]++; }
                else
                {
                    mass[x]++;
                }
            }
            float[] prob1 = new float[mass.Length];
            float chiSquare = 0;
            for(int i = 0; i< mass.Length; i++)
            {
                prob1[i] = (float)mass[i] / n;
                //chiSquare += (float)Math.Pow(prob[i]*n-prob1[i]*n,2)/(prob1[i]*n);
                chiSquare += (float)Math.Pow(mass[i],2)/(prob[i]*n);
                Console.WriteLine(chiSquare);
                chart1.Series[0].Points.AddXY(i+1, (float)mass[i] / n);
            }
            chiSquare -= n;
            Console.WriteLine(chiSquare);

            float me1 = 0;
            float me2 = 0;
            float de1 = 0;
            float de2 = 0;
            for(int i = 0; i< prob1.Length; i++)
            {
                me1 += (i + 1) * prob[i];
                me2 += (i + 1) * prob1[i];
                de1 += (float)Math.Pow((i + 1),2) * prob[i];
                de2 += (float)Math.Pow((i + 1),2) * prob1[i];
            }
            de1 -= (float)Math.Pow(me1, 2);
            de2 -= (float)Math.Pow(me2, 2);
            RelAver.Text = $"{me2} (error = {Math.Round(Math.Abs(me2-me1)/Math.Abs(me2)*100)}%)";
            RelVariance.Text = $"{de2} (errors = {Math.Round(Math.Abs(de2 - de1) / Math.Abs(de2)*100,2)}%)";
            if ( chiSquare < krit )
            {
                ResChi.Text = $"{chiSquare} < {krit}  is {false}";
            }
            else
            {
                ResChi.Text = $"{chiSquare} > {krit}  is {true}";
            }
        }
    }
}
