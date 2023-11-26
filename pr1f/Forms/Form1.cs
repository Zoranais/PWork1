using pr1f.Forms;
using pr1f.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pr1f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Tabul tabul = new Tabul();

            double xn = 0, xk = 0, h = 0, a = 0;
            try
            {
                xn = Convert.ToDouble(xn_input.Text);
                xk = Convert.ToDouble(xk_input.Text);
                h = Convert.ToDouble(h_input.Text);
                a = Convert.ToDouble(a_input.Text);
            }
            catch
            {
                return;
            }

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.Tab(xn, xk, h, a);

            for (int i = 0; i < tabul.N; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul.Xy[i, 0], 2), Math.Round(tabul.Xy[i, 1], 3));
                chart1.Series[0].Points.AddXY(tabul.Xy[i, 0], tabul.Xy[i, 1]);
            }
        }

        private void ArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ArrayForm();
            form.Show();
            this.Hide();
        }

        private void TwoDimensionalArraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TwoDimmensionalArrayForm();
            form.Show();
            this.Hide();
        }

        private void unitTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UnitTestForm();
            form.Show();
            this.Hide();
        }

        private void sOLIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ArrayToFileForm();
            form.Show();
            this.Hide();
        }

        private void interfacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DefaultInterfacesForm();
            form.Show();
            this.Hide();
        }
    }
}
