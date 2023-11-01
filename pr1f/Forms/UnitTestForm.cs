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

namespace pr1f.Forms
{
    public partial class UnitTestForm : Form
    {
        public UnitTestForm()
        {
            InitializeComponent();
        }

        private void UnitTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
        }

        private void SubmitFirst_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToInt32(AInput.Text);
                var b = Convert.ToInt32(BInput.Text);
                var c = Convert.ToInt32(CInput.Text);

                var solver = new UnitTestsFirstTaskSolver(a, b, c);

                FirstResult.Text = solver.Calculate().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void SubmitSecond_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToInt32(ASecondInput.Text);
                var b = Convert.ToInt32(BSecondInput.Text);

                var solver = new UnitTestsSecondTaskSolver(a, b);

                SecondResult.Text = solver.Calculate().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
