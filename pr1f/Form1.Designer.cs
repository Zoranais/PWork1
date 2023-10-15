namespace pr1f
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xn_input = new System.Windows.Forms.TextBox();
            this.xk_input = new System.Windows.Forms.TextBox();
            this.h_input = new System.Windows.Forms.TextBox();
            this.a_input = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(451, 209);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(632, 493);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(433, 493);
            this.dataGridView1.TabIndex = 1;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 9;
            this.x.Name = "x";
            this.x.Width = 175;
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 9;
            this.y.Name = "y";
            this.y.Width = 175;
            // 
            // xn_input
            // 
            this.xn_input.Location = new System.Drawing.Point(12, 94);
            this.xn_input.Name = "xn_input";
            this.xn_input.Size = new System.Drawing.Size(100, 29);
            this.xn_input.TabIndex = 2;
            this.xn_input.Text = "-4.2";
            // 
            // xk_input
            // 
            this.xk_input.Location = new System.Drawing.Point(155, 94);
            this.xk_input.Name = "xk_input";
            this.xk_input.Size = new System.Drawing.Size(100, 29);
            this.xk_input.TabIndex = 3;
            this.xk_input.Text = "28.1";
            // 
            // h_input
            // 
            this.h_input.Location = new System.Drawing.Point(298, 94);
            this.h_input.Name = "h_input";
            this.h_input.Size = new System.Drawing.Size(100, 29);
            this.h_input.TabIndex = 4;
            this.h_input.Text = "0.1";
            // 
            // a_input
            // 
            this.a_input.Location = new System.Drawing.Point(427, 94);
            this.a_input.Name = "a_input";
            this.a_input.Size = new System.Drawing.Size(100, 29);
            this.a_input.TabIndex = 5;
            this.a_input.Text = "0.5";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submit.Location = new System.Drawing.Point(577, 12);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(211, 105);
            this.submit.TabIndex = 6;
            this.submit.Text = "Обчислити";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "xn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "xk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 714);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.a_input);
            this.Controls.Add(this.h_input);
            this.Controls.Add(this.xk_input);
            this.Controls.Add(this.xn_input);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.TextBox xn_input;
        private System.Windows.Forms.TextBox xk_input;
        private System.Windows.Forms.TextBox h_input;
        private System.Windows.Forms.TextBox a_input;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

