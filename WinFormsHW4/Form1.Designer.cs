namespace WinFormsHW4
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            toolTip1 = new ToolTip(components);
            Email = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            toolTip2 = new ToolTip(components);
            comboBox1 = new ComboBox();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 67);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Surename";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(69, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 4;
            toolTip1.SetToolTip(textBox3, "Enter your email");
            // 
            // toolTip1
            // 
            toolTip1.ShowAlways = true;
            toolTip1.Tag = "Enter your email";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(12, 105);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 5;
            Email.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(69, 148);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(181, 23);
            textBox4.TabIndex = 7;
            toolTip2.SetToolTip(textBox4, "Enter your phone");
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Webinar", "Conference", "Master-Class" });
            comboBox1.Location = new Point(69, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 186);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "Type";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(292, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(292, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(17, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Online/Offline";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 66);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Offline";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Online";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Reading", "Travelling", "Cooking" });
            checkedListBox1.Location = new Point(17, 354);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(200, 58);
            checkedListBox1.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 418);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add";
            // 
            // button2
            // 
            button2.Location = new Point(103, 57);
            button2.Name = "button2";
            button2.Size = new Size(82, 27);
            button2.TabIndex = 2;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Confirm all terms and rights";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(11, 57);
            button1.Name = "button1";
            button1.Size = new Size(79, 27);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(292, 441);
            button3.Name = "button3";
            button3.Size = new Size(164, 61);
            button3.TabIndex = 15;
            button3.Text = "Registration";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 558);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            toolTip1.SetToolTip(this, "Enter your email");
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private ToolTip toolTip1;
        private Label Email;
        private Label label3;
        private TextBox textBox4;
        private ToolTip toolTip2;
        private ComboBox comboBox1;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
