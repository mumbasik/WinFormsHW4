using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW4
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            if (radioButton1.Checked)
            {
                comboBox1.Text = string.Empty;
                comboBox1.Enabled = false;
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            Label label2 = new Label();

            
            List<RadioButton> radioButtons = new List<RadioButton>() { radioButton1, radioButton2 };
            List<CheckBox> checkBoxes = new List<CheckBox>() { checkBox1, checkBox2, checkBox3 };

          
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    label.Text = radioButton.Text;
                    break; 
                }
            }

           
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    label2.Text += $"{checkBox.Text} ";
                }
            }

           
            if (string.IsNullOrEmpty(label.Text) || string.IsNullOrEmpty(label2.Text) || (!radioButton1.Checked && string.IsNullOrEmpty(comboBox1.Text)))
            {
                MessageBox.Show("Please enter all lines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                MessageBox.Show($"Date: {dateTimePicker1.Value:dd/MM/yyyy HH:mm}\nType: {label.Text}\nAdditional: {label2.Text}\nThemes: {comboBox1.Text}");
            }
        }

    }
}
