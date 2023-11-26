using pr1f.Services;
using pr1f.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace pr1f.Forms
{
    public partial class ArrayToFileForm : Form
    {
        private readonly IFileReader<int[]> _reader;
        private readonly IFileWriter<int[]> _writer;
        private readonly ArrayService _arrayService;
        private int[] array;

        private string path = string.Empty;

        public ArrayToFileForm()
        {
            _reader = new FileService<int[]>();
            _writer = new FileService<int[]>();
            _arrayService = new ArrayService();
            array = new int[0];

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                array = _reader.ReadFromFile(path);
                Output.Text = string.Join(",", array);
            }
        }

        private void ArrayToFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            array = _arrayService.Calculate(array);
            Output.Text = string.Join(",", array);
            _writer.WriteToFile(path, array);            
        }
    }
}
