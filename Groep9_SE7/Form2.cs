using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groep9_SE7
{
    public partial class Form2 : Form
    {
        private OutdoorParadise context;

        public Form2(OutdoorParadise context)
        {
            InitializeComponent();
            comboBox1.Items.Add("ID");
            emp_txt.Hide();
            this.context = context;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            value_lbl.Text = "Enter " + comboBox1.SelectedItem.ToString() + ": ";
            emp_txt.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            if (emp_txt.Text.Length == 0)
            {
                MessageBox.Show("Text Field is empty!");
            }
            else if (!int.TryParse(emp_txt.Text, out int parsedValue))
            {
                MessageBox.Show("Enter Numbers!");
            }
            else if (comboBox1.SelectedItem.Equals("ID"))
            {
                SearchByID();
            }


        }

        private void SearchByID() {
            List<Employees> employees = context.Employees.ToList();
                      

            if (!employees.Exists(i => i.ID == Int32.Parse(emp_txt.Text)))
            {
                MessageBox.Show("ID does not exist!");
            } else
            {
                resultLabel.Text += "Employee:\n\n";

                resultLabel.Text += employees.Find(i => i.ID == Int32.Parse(emp_txt.Text)).ToString() + "\n";

                List<Training> trainingen = context.Training.ToList();

                List<Bonus> bonussen = context.Bonus.ToList();

                List<Training> finalT = trainingen.Where(eid => eid.Emp_ID == Int32.Parse(emp_txt.Text)).ToList();

                List<Bonus> finalB = bonussen.Where(eid => eid.Emp_ID == Int32.Parse(emp_txt.Text)).ToList();

                resultLabel.Text += "\n---------------------------------\n";

                resultLabel.Text += "\nTraining:\n\n";

                foreach (var t in finalT)
                {
                    resultLabel.Text += t.ToString() + "\n";
                }

                resultLabel.Text += "\n---------------------------------\n";

                resultLabel.Text += "\nBonuses:\n\n";

                foreach (var b in finalB)
                {
                    resultLabel.Text += b.ToString() + "\n";
                }
            }            
                       
        }

        private void value_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      

        private void emp_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void all_emp_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
