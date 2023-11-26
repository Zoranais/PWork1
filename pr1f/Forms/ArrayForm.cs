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
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ArrayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var values = Input.Text.Split(',');
            if(values.Length < 5) 
            {
                MessageBox.Show("Enter 5 or more values");
                return;
            }

            try
            {
                var solver = new ArraySolver(values);

                Result.Text = string.Join(" ", solver.GetPows());
                ResultSqrt.Text = string.Join(" ", solver.GetSqrts()).Replace("NaN", "Від'ємне значення");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
