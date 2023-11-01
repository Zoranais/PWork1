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
    public partial class TwoDimmensionalArrayForm : Form
    {
        public TwoDimmensionalArrayForm()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            int x = 4;
            int y = 3;
            for (int i = 0; i < x; i++)
            {
                Data.Columns.Add(new DataGridViewTextBoxColumn());
            }
            for (int j = 0; j < y; j++)
            {
                Data.Rows.Add();
            }
        }

        private string[,] RetrieveData()
        {
            var x = Data.Columns.Count;
            var y = Data.Rows.Count;

            var data = new string[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    data[i, j] = Data.Rows[j].Cells[i].Value.ToString();
                }
            }

            return data;
        }

        private void TwoDimmensionalArrayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                var solver = new TwoDimensionalArraySolver(RetrieveData());

                var result = solver.GetPows();
                for (int i = 0; i < result.GetLength(0); i++) 
                {
                    for(int j = 0;j < result.GetLength(1); j++)
                    {
                        Data.Rows[j].Cells[i].Value = result[i, j].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
