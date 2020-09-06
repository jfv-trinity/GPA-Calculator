namespace GPACalculator_
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCourses = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelGPA = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.labelInstructions1 = new System.Windows.Forms.Label();
            this.labelInstructions2 = new System.Windows.Forms.Label();
            this.labelInstuctions3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPoints);
            this.panel1.Controls.Add(this.txtCredits);
            this.panel1.Controls.Add(this.labelPoints);
            this.panel1.Controls.Add(this.labelCredits);
            this.panel1.Controls.Add(this.labelInstuctions3);
            this.panel1.Controls.Add(this.labelInstructions2);
            this.panel1.Controls.Add(this.labelInstructions1);
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Controls.Add(this.labelGPA);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 244);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddCourses
            // 
            this.btnAddCourses.Location = new System.Drawing.Point(145, 292);
            this.btnAddCourses.Name = "btnAddCourses";
            this.btnAddCourses.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourses.TabIndex = 1;
            this.btnAddCourses.Text = "Add More Courses";
            this.btnAddCourses.UseVisualStyleBackColor = true;
            this.btnAddCourses.Click += new System.EventHandler(this.btnAddCourses_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(241, 292);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Location = new System.Drawing.Point(318, 105);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(32, 13);
            this.labelGPA.TabIndex = 0;
            this.labelGPA.Text = "GPA:";
            this.labelGPA.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(358, 98);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(76, 20);
            this.txtSum.TabIndex = 1;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // labelInstructions1
            // 
            this.labelInstructions1.AutoSize = true;
            this.labelInstructions1.Location = new System.Drawing.Point(30, 6);
            this.labelInstructions1.Name = "labelInstructions1";
            this.labelInstructions1.Size = new System.Drawing.Size(43, 13);
            this.labelInstructions1.TabIndex = 2;
            this.labelInstructions1.Text = "Course:";
            this.labelInstructions1.Click += new System.EventHandler(this.labelInstructions_Click);
            // 
            // labelInstructions2
            // 
            this.labelInstructions2.AutoSize = true;
            this.labelInstructions2.Location = new System.Drawing.Point(97, 6);
            this.labelInstructions2.Name = "labelInstructions2";
            this.labelInstructions2.Size = new System.Drawing.Size(37, 13);
            this.labelInstructions2.TabIndex = 3;
            this.labelInstructions2.Text = "Credit:";
            this.labelInstructions2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelInstuctions3
            // 
            this.labelInstuctions3.AutoSize = true;
            this.labelInstuctions3.Location = new System.Drawing.Point(140, 6);
            this.labelInstuctions3.Name = "labelInstuctions3";
            this.labelInstuctions3.Size = new System.Drawing.Size(44, 13);
            this.labelInstuctions3.TabIndex = 4;
            this.labelInstuctions3.Text = "Grades:";
            this.labelInstuctions3.Click += new System.EventHandler(this.labelInstuctions3_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(200, 250);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(72, 13);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Error Identifier";
            this.labelError.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(100, 266);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(262, 20);
            this.txtError.TabIndex = 6;
            this.txtError.Text = "No Errors Currently";
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtError.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Location = new System.Drawing.Point(283, 25);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(69, 13);
            this.labelCredits.TabIndex = 7;
            this.labelCredits.Text = "Total Credits:";
            this.labelCredits.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(286, 65);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(66, 13);
            this.labelPoints.TabIndex = 8;
            this.labelPoints.Text = "Total Points:";
            this.labelPoints.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(358, 18);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.ReadOnly = true;
            this.txtCredits.Size = new System.Drawing.Size(76, 20);
            this.txtCredits.TabIndex = 9;
            this.txtCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCredits.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(358, 58);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(76, 20);
            this.txtPoints.TabIndex = 10;
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPoints.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 322);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnAddCourses);
            this.Controls.Add(this.txtError);
            this.Name = "Form1";
            this.Text = "GPA Calculator - JFV - 301118010";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCourses;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelGPA;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label labelInstructions1;
        private System.Windows.Forms.Label labelInstuctions3;
        private System.Windows.Forms.Label labelInstructions2;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelCredits;
    }
}

