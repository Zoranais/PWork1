namespace pr1f.Forms
{
    partial class DefaultInterfacesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Results = new System.Windows.Forms.DataGridView();
            this.FilteredResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.CourseInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.wdwName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredResults)).BeginInit();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wdwName,
            this.Course,
            this.Group,
            this.Result});
            this.Results.Location = new System.Drawing.Point(12, 12);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.RowHeadersWidth = 72;
            this.Results.RowTemplate.Height = 31;
            this.Results.Size = new System.Drawing.Size(776, 828);
            this.Results.TabIndex = 0;
            // 
            // FilteredResults
            // 
            this.FilteredResults.AllowUserToAddRows = false;
            this.FilteredResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilteredResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.FilteredResults.Location = new System.Drawing.Point(1039, 12);
            this.FilteredResults.Name = "FilteredResults";
            this.FilteredResults.ReadOnly = true;
            this.FilteredResults.RowHeadersWidth = 72;
            this.FilteredResults.RowTemplate.Height = 31;
            this.FilteredResults.Size = new System.Drawing.Size(353, 426);
            this.FilteredResults.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Course";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Group";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Result";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.Location = new System.Drawing.Point(814, 268);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(191, 51);
            this.Filter.TabIndex = 2;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Sort
            // 
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort.Location = new System.Drawing.Point(814, 143);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(191, 119);
            this.Sort.TabIndex = 3;
            this.Sort.Text = "Sort by results";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Load.Location = new System.Drawing.Point(814, 88);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(191, 49);
            this.Load.TabIndex = 5;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(814, 33);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(191, 49);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(814, 782);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(191, 49);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(814, 727);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(191, 49);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1034, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(1039, 504);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(344, 29);
            this.NameInput.TabIndex = 10;
            // 
            // CourseInput
            // 
            this.CourseInput.Location = new System.Drawing.Point(1039, 561);
            this.CourseInput.Name = "CourseInput";
            this.CourseInput.Size = new System.Drawing.Size(344, 29);
            this.CourseInput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1034, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Course";
            // 
            // GroupInput
            // 
            this.GroupInput.Location = new System.Drawing.Point(1039, 618);
            this.GroupInput.Name = "GroupInput";
            this.GroupInput.Size = new System.Drawing.Size(344, 29);
            this.GroupInput.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1034, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Group";
            // 
            // ResultInput
            // 
            this.ResultInput.Location = new System.Drawing.Point(1039, 676);
            this.ResultInput.Name = "ResultInput";
            this.ResultInput.Size = new System.Drawing.Size(344, 29);
            this.ResultInput.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1034, 647);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Result";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // wdwName
            // 
            this.wdwName.HeaderText = "Name";
            this.wdwName.MinimumWidth = 9;
            this.wdwName.Name = "wdwName";
            this.wdwName.ReadOnly = true;
            this.wdwName.Width = 175;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 9;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.Width = 175;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.MinimumWidth = 9;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 175;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 9;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 175;
            // 
            // DefaultInterfacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 852);
            this.Controls.Add(this.ResultInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GroupInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CourseInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.FilteredResults);
            this.Controls.Add(this.Results);
            this.Name = "DefaultInterfacesForm";
            this.Text = "DefaultInterfacesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DefaultInterfacesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridView FilteredResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox CourseInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GroupInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn aName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wdwName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}