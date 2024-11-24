namespace WinFormsHW4
{
    public partial class Form1 : Form
    {
        Label label = new Label();
        Label time = new Label();
        string text1 = "Webinar";
        string text2 = "Conference";
        string text3 = "Master-Class";
        List<RadioButton> radioButtons = new List<RadioButton>() { };



        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButtons.Add(radioButton1);
            radioButtons.Add(radioButton2);
            time.Text = DateTime.Now.ToString("HH:mm:ss");



            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    label.Text = radioButton.Text;

                }


            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Please confrim all rights and terms", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(checkedListBox1.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(label.Text))
            {
                MessageBox.Show("Please enter all lines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Information confirmed\nName: {label.Text}\nSurename: {textBox2.Text}\nEmail: {textBox3.Text}\nPhone: {textBox4.Text}\nType: {comboBox1.Text}\nOnline/Offline: {label.Text}\nTheme: {checkedListBox1.Text}" +
                    $"\nDate: {dateTimePicker1.Text}\nTime: {time.Text}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButtons.Add(radioButton1);
            radioButtons.Add(radioButton2);
            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.Checked = false;
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            comboBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            checkBox1.Checked = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
