namespace BMI_Calculator
{
    partial class BmiCalculator
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
            this.ResultextBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Height = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultextBox
            // 
            this.ResultextBox.Location = new System.Drawing.Point(23, 219);
            this.ResultextBox.Multiline = true;
            this.ResultextBox.Name = "ResultextBox";
            this.ResultextBox.Size = new System.Drawing.Size(241, 54);
            this.ResultextBox.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(16, 301);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(123, 69);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(153, 301);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(111, 69);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Height
            // 
            this.Height.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(3, 3);
            this.Height.Multiline = true;
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(114, 28);
            this.Height.TabIndex = 0;
            this.Height.Text = "Height";
            this.Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(123, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 28);
            this.textBox2.TabIndex = 1;
            // 
            // Weight
            // 
            this.Weight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(3, 37);
            this.Weight.Multiline = true;
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(114, 28);
            this.Weight.TabIndex = 2;
            this.Weight.Text = "Weight";
            this.Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(123, 37);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 28);
            this.textBox4.TabIndex = 3;
            // 
            // Age
            // 
            this.Age.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(3, 71);
            this.Age.Multiline = true;
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(114, 33);
            this.Age.TabIndex = 4;
            this.Age.Text = "Age ";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(123, 71);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(115, 33);
            this.textBox6.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Age, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Weight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Height, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Imperial, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Metric, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imperial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Imperial.Location = new System.Drawing.Point(3, 110);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(113, 29);
            this.Imperial.TabIndex = 6;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metric.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Metric.Location = new System.Drawing.Point(123, 110);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(95, 29);
            this.Metric.TabIndex = 7;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(211, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 31);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "inches";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(211, 61);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 31);
            this.textBox3.TabIndex = 9;
            // 
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(284, 372);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ResultextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BmiCalculator";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ResultextBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

