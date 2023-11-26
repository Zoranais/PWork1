namespace pr1f.Forms
{
    partial class ArrayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.ResultSqrt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elements";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(52, 104);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 29);
            this.Input.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Submit.Location = new System.Drawing.Point(522, 348);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(276, 98);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Calculate";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(46, 227);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 24);
            this.Result.TabIndex = 3;
            // 
            // ResultSqrt
            // 
            this.ResultSqrt.AutoSize = true;
            this.ResultSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultSqrt.Location = new System.Drawing.Point(46, 283);
            this.ResultSqrt.Name = "ResultSqrt";
            this.ResultSqrt.Size = new System.Drawing.Size(0, 24);
            this.ResultSqrt.TabIndex = 4;
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultSqrt);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Name = "ArrayForm";
            this.Text = "ArrayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArrayForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label ResultSqrt;
    }
}