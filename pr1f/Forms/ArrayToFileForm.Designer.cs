namespace pr1f.Forms
{
    partial class ArrayToFileForm
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
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Submit.Location = new System.Drawing.Point(500, 313);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(276, 98);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Calculate";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elements";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(500, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 98);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFile";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(25, 93);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 25);
            this.Output.TabIndex = 6;
            // 
            // ArrayToFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Name = "ArrayToFileForm";
            this.Text = "ArrayToFileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArrayToFileForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Output;
    }
}