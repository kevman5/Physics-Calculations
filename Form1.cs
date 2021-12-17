using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CalcpythagTheoreom()
        {
            int a2, b2, c2;
            a2 = int.Parse(tb_1.Text);
            b2 = int.Parse(tb_2.Text);
            c2 = (a2 * a2) + (b2 * b2);
            tb_ans1.Text = c2.ToString();
        }
        public void CalcPower()
        {
            int power, time, work;
            work = int.Parse(tb_3.Text);
            time = int.Parse(tb_4.Text);
            power = work / time;

            tb_ans2.Text = power.ToString();
        }
        public void CalcTensileStress()
        {
            int stress1, force1, area1;
            force1 = int.Parse(tb_1.Text);
            area1 = int.Parse(tb_2.Text);
            stress1 = force1 / area1;

            tb_ans1.Text = stress1.ToString();
        }
        public void CalcTangVeloc()
        {
            double rad1, angv1, tang1;
            rad1 = double.Parse(tb_3.Text);
            angv1 = double.Parse(tb_4.Text);
            tang1 = rad1 * angv1;

            tb_ans2.Text = tang1.ToString();
        }
        public void CalcWeight()
        {
            double mass1, grav1, weight1;
            mass1 = double.Parse(tb_1.Text);
            grav1 = double.Parse(tb_2.Text);
            weight1 = mass1 * grav1;
            tb_ans1.Text = weight1.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CalcpythagTheoreom();
            
            // Make sure to update label names if you change methods!!

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcTangVeloc();
            // Make sure to update label names if you change methods!!
        }
    }
}
