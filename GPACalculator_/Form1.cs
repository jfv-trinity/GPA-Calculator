using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace GPACalculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            // Create the dynamic TextBox.
            TextBox textbox = new TextBox();
            int count = panel1.Controls.OfType<TextBox>().ToList().Count;
            textbox.Location = new System.Drawing.Point(10, 25 * count / 3);
            textbox.Size = new System.Drawing.Size(80, 20);
            textbox.Name = "txt_ID" + (count + 1);
            if (count < 20)
            {
                panel1.Controls.Add(textbox);
            }
        
           


            TextBox textboxCredit = new TextBox();
            //count = panel1.Controls.OfType<TextBox>().ToList().Count;
            textboxCredit.Location = new System.Drawing.Point(95, 25 * count / 3);
            textboxCredit.Size = new System.Drawing.Size(40, 20);
            textboxCredit.Name = "txt_Credit" + (count + 1);
            if (count < 20)
            {
                panel1.Controls.Add(textboxCredit);
            }
       
            

            TextBox textboxGrade = new TextBox();
            //count = panel1.Controls.OfType<TextBox>().ToList().Count;
            textboxGrade.Location = new System.Drawing.Point(140, 25 * count / 3);
            textboxGrade.Size = new System.Drawing.Size(40, 20);
            textboxGrade.Name = "txt_Grade" + (count + 1);
            if (count < 20)
            {
                panel1.Controls.Add(textboxGrade);
            }
           
           
            //Create the dynamic Button to remove the TextBox.
            Button button = new Button();
            button.Location = new System.Drawing.Point(185, 25 * count / 3);
            button.Size = new System.Drawing.Size(60, 20);
            button.Name = "btnDelete_" + (count + 1);
            button.Text = "Delete";
            button.Click += new System.EventHandler(this.btnDelete_Click);
            if(count < 20)
            {
                panel1.Controls.Add(button);
            }
           


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Reference the Button which was clicked.
            Button button = (sender as Button);

            //Determine the Index of the Button.
            int index = int.Parse(button.Name.Split('_')[1]);

            //Find the TextBox using Index and remove it.



            panel1.Controls.Remove(panel1.Controls.Find("txt_ID" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("txt_Grade" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("txt_Credit" + index, true)[0]);

            //Remove the Button.
            panel1.Controls.Remove(button);

            //Rearranging the Location controls.
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                int controlIndex = int.Parse(btn.Name.Split('_')[1]);
                if (controlIndex > index)
                {
                    TextBox txt = (TextBox)panel1.Controls.Find("txt_ID" + controlIndex, true)[0];
                    TextBox txtGrade = (TextBox)panel1.Controls.Find("txt_Grade" + controlIndex, true)[0];
                    TextBox txtCredit = (TextBox)panel1.Controls.Find("txt_Credit" + controlIndex, true)[0];
                    btn.Top = btn.Top - 25;
                    txt.Top = txt.Top - 25;
                    txtGrade.Top = txtGrade.Top - 25;
                    txtCredit.Top = txtCredit.Top - 25;

                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal points = 0;
            decimal credits = 0;

            bool isError = false;
            
            // For each row txt.grade
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {

                int index = int.Parse(btn.Name.Split('_')[1]);
                System.Type type = panel1.Controls.Find("txt_Grade" + index, true)[0].Text.GetType();

              
                double grade;
                double credit;
                bool isGradeNumeric = double.TryParse(panel1.Controls.Find("txt_Grade" + index, true)[0].Text, out grade);
                bool isCreditNumeric = double.TryParse(panel1.Controls.Find("txt_Credit" + index, true)[0].Text, out credit);


                if (isGradeNumeric && isCreditNumeric)
                {
                    decimal CP = Decimal.Parse(panel1.Controls.Find("txt_Credit" + index, true)[0].Text);
                    decimal GP = Decimal.Parse(panel1.Controls.Find("txt_Grade" + index, true)[0].Text);

                    credits += CP;
                    decimal sum = GP * CP;
                    points += sum;
                    Console.WriteLine(panel1.Controls.Find("txt_Grade" + index, true)[0].Text);
                    txtError.Text = ("No Errors");
                } 
                else if (panel1.Controls.Find("txt_Grade" + index, true)[0].Text != "" || (panel1.Controls.Find("txt_Credit" + index, true)[0].Text != ""))
                {
                    isError = true;
                    break;
                }


            }
            if(points > 0)
            {
                decimal GPA = points / credits;
                txtSum.Text = GPA.ToString("0.##");
                txtCredits.Text = credits.ToString("0.##");
                txtPoints.Text = points.ToString("0.##");

                if (isError)
                {
                    txtError.Text = ("Grades and Credits must be numbers");
                }
            }
           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelInstructions_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelInstuctions3_Click(object sender, EventArgs e)
        {

        }
    }
}
