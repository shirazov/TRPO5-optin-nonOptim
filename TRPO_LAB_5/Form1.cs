using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_LAB_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void checking_for_a_fool(object sender, KeyPressEventArgs e)     //Проверка на дурака(вводимых символов)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            if (val_a.Text != "" && val_b.Text != "" && val_d.Text != "" && val_n.Text != "")
            {
                int a = Int32.Parse(val_a.Text.ToString());
                int b = Int32.Parse(val_b.Text.ToString());
                int d = Int32.Parse(val_d.Text.ToString());
                int n = Int32.Parse(val_n.Text.ToString());
                opt_1(a);
                neo_1(a);
                neo_2(a);
                neo_3(a);
                neo_4(a, b, d);
                neo_5(n);
                opt_2(a);
                opt_3(a);
                opt_4(a, b, d);
                opt_5(n);
            }
            else
                MessageBox.Show("Необходимо заполнить все поля!!!");
        }
        void neo_1(int a)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_neo_1 = a * 5;
            }
            myStopwatch.Stop();
            neo1.Text = myStopwatch.Elapsed.ToString();
        }
        void neo_2(int a)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_neo_2 = a / 5;
            }
            myStopwatch.Stop();
            neo2.Text = myStopwatch.Elapsed.ToString();
        }
        void neo_3(int a)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_neo_3 = Math.Pow(a, 2);
            }
            myStopwatch.Stop();
            neo3.Text = myStopwatch.Elapsed.ToString();
        }
        void neo_4(int a, int d, int b)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_neo_4 = a / d * b + d / (a * b) - Math.Abs(a / b * d);
            }
            myStopwatch.Stop();
            neo4.Text = myStopwatch.Elapsed.ToString();
        }
        void neo_5(int n)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_neo_5 = Math.Sin(n) + 3 / Math.Sin(n) - Math.Log10(Math.Sin(n));
            }
            myStopwatch.Stop();
            neo5.Text = myStopwatch.Elapsed.ToString();
        }
        void opt_1(int a)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_opt_1 = a + a + a + a + a;
            }
            myStopwatch.Stop();
            opt1.Text = myStopwatch.Elapsed.ToString();
        }
        void opt_2(int a)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_opt_2 = 0.2 * a;
            }
            myStopwatch.Stop();
            opt2.Text = myStopwatch.Elapsed.ToString();
        }
        void opt_3(int a)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_opt_3 = a * a * a * a * a;
            }
            myStopwatch.Stop();
            opt3.Text = myStopwatch.Elapsed.ToString();
        }
        void opt_4(int a, int b, int d)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_opt_4_1 = a / d * b;
                double res_opt_4 = res_opt_4_1 + 1 / res_opt_4_1 - Math.Abs(res_opt_4_1);
            }
            myStopwatch.Stop();
            opt4.Text = myStopwatch.Elapsed.ToString();
        }
        void opt_5(int n)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                double res_opt_5_1 = Math.Sin(n);
                double res_opt_5 = res_opt_5_1 + 3 / res_opt_5_1 - Math.Log10(res_opt_5_1);
            }
            myStopwatch.Stop();
            opt5.Text = myStopwatch.Elapsed.ToString();
        }

    }
}
