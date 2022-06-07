namespace _3x_1Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStarting = new System.Windows.Forms.Label();
            this.textBoxStarting = new System.Windows.Forms.TextBox();
            this.buttonStarting = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.textBoxLow = new System.Windows.Forms.TextBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.label3xp1 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelFunction = new System.Windows.Forms.Label();
            this.labelFunction2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultText = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            this.labelDash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStarting
            // 
            this.labelStarting.AutoSize = true;
            this.labelStarting.Location = new System.Drawing.Point(12, 137);
            this.labelStarting.Name = "labelStarting";
            this.labelStarting.Size = new System.Drawing.Size(114, 20);
            this.labelStarting.TabIndex = 0;
            this.labelStarting.Text = "Starting x value:";
            this.labelStarting.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxStarting
            // 
            this.textBoxStarting.Location = new System.Drawing.Point(171, 134);
            this.textBoxStarting.Name = "textBoxStarting";
            this.textBoxStarting.Size = new System.Drawing.Size(125, 27);
            this.textBoxStarting.TabIndex = 1;
            this.textBoxStarting.TextChanged += new System.EventHandler(this.textBoxStarting_TextChanged);
            // 
            // buttonStarting
            // 
            this.buttonStarting.Location = new System.Drawing.Point(302, 134);
            this.buttonStarting.Name = "buttonStarting";
            this.buttonStarting.Size = new System.Drawing.Size(94, 29);
            this.buttonStarting.TabIndex = 2;
            this.buttonStarting.Text = "Calculate";
            this.buttonStarting.UseVisualStyleBackColor = true;
            this.buttonStarting.Click += new System.EventHandler(this.buttonStarting_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Location = new System.Drawing.Point(302, 255);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(94, 29);
            this.buttonRange.TabIndex = 5;
            this.buttonRange.Text = "Calculate";
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxLow
            // 
            this.textBoxLow.Location = new System.Drawing.Point(171, 221);
            this.textBoxLow.Name = "textBoxLow";
            this.textBoxLow.Size = new System.Drawing.Size(125, 27);
            this.textBoxLow.TabIndex = 4;
            this.textBoxLow.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(12, 225);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(83, 20);
            this.labelRange.TabIndex = 3;
            this.labelRange.Text = "Range of x:";
            // 
            // label3xp1
            // 
            this.label3xp1.AutoSize = true;
            this.label3xp1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3xp1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3xp1.Location = new System.Drawing.Point(71, 20);
            this.label3xp1.Name = "label3xp1";
            this.label3xp1.Size = new System.Drawing.Size(140, 67);
            this.label3xp1.TabIndex = 6;
            this.label3xp1.Text = "3x+1";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDescription.Location = new System.Drawing.Point(194, 41);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(732, 41);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Finding the highest value reached using the algorithm";
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFunction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFunction.Location = new System.Drawing.Point(514, 171);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(96, 41);
            this.labelFunction.TabIndex = 8;
            this.labelFunction.Text = "f(x) = ";
            // 
            // labelFunction2
            // 
            this.labelFunction2.AutoSize = true;
            this.labelFunction2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFunction2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFunction2.Location = new System.Drawing.Point(600, 153);
            this.labelFunction2.Name = "labelFunction2";
            this.labelFunction2.Size = new System.Drawing.Size(261, 41);
            this.labelFunction2.TabIndex = 9;
            this.labelFunction2.Text = "3x + 1    if x is odd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(600, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "x / 2       if x is even";
            // 
            // labelResultText
            // 
            this.labelResultText.AutoSize = true;
            this.labelResultText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultText.Location = new System.Drawing.Point(194, 412);
            this.labelResultText.Name = "labelResultText";
            this.labelResultText.Size = new System.Drawing.Size(345, 41);
            this.labelResultText.TabIndex = 11;
            this.labelResultText.Text = "Result:   Highest value = ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(545, 412);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 41);
            this.labelResult.TabIndex = 12;
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(171, 254);
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(125, 27);
            this.textBoxHigh.TabIndex = 13;
            // 
            // labelDash
            // 
            this.labelDash.AutoSize = true;
            this.labelDash.Location = new System.Drawing.Point(150, 257);
            this.labelDash.Name = "labelDash";
            this.labelDash.Size = new System.Drawing.Size(15, 20);
            this.labelDash.TabIndex = 14;
            this.labelDash.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 540);
            this.Controls.Add(this.labelDash);
            this.Controls.Add(this.textBoxHigh);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelResultText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFunction2);
            this.Controls.Add(this.labelFunction);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.label3xp1);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.textBoxLow);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.buttonStarting);
            this.Controls.Add(this.textBoxStarting);
            this.Controls.Add(this.labelStarting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStarting;
        private System.Windows.Forms.TextBox textBoxStarting;
        private System.Windows.Forms.Button buttonStarting;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.TextBox textBoxLow;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label label3xp1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label labelFunction2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultText;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxHigh;
        private System.Windows.Forms.Label labelDash;
    }
}
