using pr1f.Services;
using pr1f.Services.Interfaces;
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
    public partial class DefaultInterfacesForm : Form
    {
        private List<Student> _students;
        private readonly IFileReader<ICollection<Student>> fileReader;
        private readonly IFileWriter<ICollection<Student>> fileWriter;

        public DefaultInterfacesForm()
        {
            _students = new List<Student>();
            fileWriter = new FileService<ICollection<Student>>();
            fileReader = new FileService<ICollection<Student>>();
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var name = Convert.ToString(NameInput.Text);
                var course = Convert.ToInt32(CourseInput.Text);
                var group = Convert.ToString(GroupInput.Text);
                var result = Convert.ToInt32(ResultInput.Text);

                var student = new Student(name, course, group, result);
                _students.Add(student);
                AddToGridView(student, Results);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void AddToGridView(Student student, DataGridView dataGrid)
        {
            dataGrid.Rows.Add(student.Name, student.Course, student.Group, student.Result);
        }

        private void DefaultInterfacesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var toDelete = new List<string>();
            var selected = Results.SelectedRows;
            for (int i = 0; i < selected.Count; i++)
            {
                toDelete.Add(selected[i].Cells[0].Value.ToString());
                Results.Rows.Remove(selected[i]);
            }

            _students = _students.Where(x => !toDelete.Contains(x.Name)).ToList();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                fileWriter.WriteToFile(saveFileDialog1.FileName, _students);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var loadedStudents = fileReader.ReadFromFile(openFileDialog1.FileName);
                _students = loadedStudents.ToList();
                ReinitGridView(_students, Results);
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            _students.Sort(new ByResultComparer());
            ReinitGridView(_students, Results);
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            var filtered = _students.OrderBy(x => x, new ByResultComparer()).Take(3);
            ReinitGridView(filtered.ToList(), FilteredResults);
        }

        private void ReinitGridView(List<Student> students, DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            foreach (var student in students)
            {
                AddToGridView(student, dataGrid);
            }
        }
    }
}
