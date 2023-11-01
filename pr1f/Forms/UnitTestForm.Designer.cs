namespace pr1f.Forms
{
    partial class UnitTestForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Second = new System.Windows.Forms.TabPage();
            this.First = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.AInput = new System.Windows.Forms.TextBox();
            this.BInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstResult = new System.Windows.Forms.Label();
            this.SubmitFirst = new System.Windows.Forms.Button();
            this.SubmitSecond = new System.Windows.Forms.Button();
            this.SecondResult = new System.Windows.Forms.Label();
            this.BSecondInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ASecondInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Second.SuspendLayout();
            this.First.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.First);
            this.tabControl1.Controls.Add(this.Second);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // Second
            // 
            this.Second.Controls.Add(this.SubmitSecond);
            this.Second.Controls.Add(this.SecondResult);
            this.Second.Controls.Add(this.BSecondInput);
            this.Second.Controls.Add(this.label6);
            this.Second.Controls.Add(this.ASecondInput);
            this.Second.Controls.Add(this.label7);
            this.Second.Location = new System.Drawing.Point(4, 33);
            this.Second.Name = "Second";
            this.Second.Padding = new System.Windows.Forms.Padding(3);
            this.Second.Size = new System.Drawing.Size(768, 389);
            this.Second.TabIndex = 1;
            this.Second.Text = "Second";
            this.Second.UseVisualStyleBackColor = true;
            // 
            // First
            // 
            this.First.Controls.Add(this.SubmitFirst);
            this.First.Controls.Add(this.FirstResult);
            this.First.Controls.Add(this.CInput);
            this.First.Controls.Add(this.label3);
            this.First.Controls.Add(this.BInput);
            this.First.Controls.Add(this.label2);
            this.First.Controls.Add(this.AInput);
            this.First.Controls.Add(this.label1);
            this.First.Location = new System.Drawing.Point(4, 33);
            this.First.Name = "First";
            this.First.Padding = new System.Windows.Forms.Padding(3);
            this.First.Size = new System.Drawing.Size(768, 389);
            this.First.TabIndex = 0;
            this.First.Text = "First";
            this.First.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // AInput
            // 
            this.AInput.Location = new System.Drawing.Point(9, 54);
            this.AInput.Name = "AInput";
            this.AInput.Size = new System.Drawing.Size(100, 29);
            this.AInput.TabIndex = 1;
            // 
            // BInput
            // 
            this.BInput.Location = new System.Drawing.Point(11, 115);
            this.BInput.Name = "BInput";
            this.BInput.Size = new System.Drawing.Size(100, 29);
            this.BInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "B:";
            // 
            // CInput
            // 
            this.CInput.Location = new System.Drawing.Point(9, 176);
            this.CInput.Name = "CInput";
            this.CInput.Size = new System.Drawing.Size(100, 29);
            this.CInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "C:";
            // 
            // FirstResult
            // 
            this.FirstResult.AutoSize = true;
            this.FirstResult.Location = new System.Drawing.Point(368, 182);
            this.FirstResult.Name = "FirstResult";
            this.FirstResult.Size = new System.Drawing.Size(0, 25);
            this.FirstResult.TabIndex = 6;
            // 
            // SubmitFirst
            // 
            this.SubmitFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitFirst.Location = new System.Drawing.Point(489, 291);
            this.SubmitFirst.Name = "SubmitFirst";
            this.SubmitFirst.Size = new System.Drawing.Size(276, 98);
            this.SubmitFirst.TabIndex = 7;
            this.SubmitFirst.Text = "Calculate";
            this.SubmitFirst.UseVisualStyleBackColor = true;
            this.SubmitFirst.Click += new System.EventHandler(this.SubmitFirst_Click);
            // 
            // SubmitSecond
            // 
            this.SubmitSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitSecond.Location = new System.Drawing.Point(489, 278);
            this.SubmitSecond.Name = "SubmitSecond";
            this.SubmitSecond.Size = new System.Drawing.Size(276, 98);
            this.SubmitSecond.TabIndex = 15;
            this.SubmitSecond.Text = "Calculate";
            this.SubmitSecond.UseVisualStyleBackColor = true;
            this.SubmitSecond.Click += new System.EventHandler(this.SubmitSecond_Click);
            // 
            // SecondResult
            // 
            this.SecondResult.AutoSize = true;
            this.SecondResult.Location = new System.Drawing.Point(368, 169);
            this.SecondResult.Name = "SecondResult";
            this.SecondResult.Size = new System.Drawing.Size(0, 25);
            this.SecondResult.TabIndex = 14;
            // 
            // BSecondInput
            // 
            this.BSecondInput.Location = new System.Drawing.Point(11, 102);
            this.BSecondInput.Name = "BSecondInput";
            this.BSecondInput.Size = new System.Drawing.Size(100, 29);
            this.BSecondInput.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "B:";
            // 
            // ASecondInput
            // 
            this.ASecondInput.Location = new System.Drawing.Point(9, 41);
            this.ASecondInput.Name = "ASecondInput";
            this.ASecondInput.Size = new System.Drawing.Size(100, 29);
            this.ASecondInput.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "A:";
            // 
            // UnitTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UnitTestForm";
            this.Text = "UnitTestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnitTestForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.Second.ResumeLayout(false);
            this.Second.PerformLayout();
            this.First.ResumeLayout(false);
            this.First.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage First;
        private System.Windows.Forms.Label FirstResult;
        private System.Windows.Forms.TextBox CInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Second;
        private System.Windows.Forms.Button SubmitFirst;
        private System.Windows.Forms.Button SubmitSecond;
        private System.Windows.Forms.Label SecondResult;
        private System.Windows.Forms.TextBox BSecondInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ASecondInput;
        private System.Windows.Forms.Label label7;
    }
}