namespace WinFormsApp2
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
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Proof" }, -1, SystemColors.HotTrack, Color.Empty, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TreeNode treeNode2 = new TreeNode("Nodo0");
            btn1 = new Button();
            checkBox1 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            listView1 = new ListView();
            maskedTextBox1 = new MaskedTextBox();
            monthCalendar1 = new MonthCalendar();
            notifyIcon1 = new NotifyIcon(components);
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.IndianRed;
            btn1.Location = new Point(60, 26);
            btn1.Name = "btn1";
            btn1.Size = new Size(200, 23);
            btn1.TabIndex = 0;
            btn1.Text = "BUTTON";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.IndianRed;
            checkBox1.Location = new Point(60, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(48, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Task";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Method", "Variable", "Builder", "Class" });
            checkedListBox1.Location = new Point(60, 90);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(200, 76);
            checkedListBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mexico", "USA", "France", "England" });
            comboBox1.Location = new Point(60, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Choose a country:";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(60, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Location = new Point(60, 261);
            label1.MaximumSize = new Size(0, 20);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Computing";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.IndianRed;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(30, 292);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(277, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.youtube.com/watch?v=ZE_BCBckcCY";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Archive", "Edit", "Project", "Compile" });
            listBox1.Location = new Point(60, 319);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 64);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.ForeColor = SystemColors.InactiveCaption;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem6 });
            listView1.Location = new Point(60, 406);
            listView1.Name = "listView1";
            listView1.Size = new Size(200, 53);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.ForeColor = Color.Red;
            maskedTextBox1.Location = new Point(313, 26);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(146, 23);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.Text = "HI!";
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(313, 65);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.ForeColor = Color.Red;
            numericUpDown1.Location = new Point(313, 253);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(146, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(313, 292);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 167);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.AccessibleDescription = "";
            progressBar1.BackColor = Color.IndianRed;
            progressBar1.Location = new Point(591, 26);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(205, 23);
            progressBar1.TabIndex = 13;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.IndianRed;
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(591, 65);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.Text = "Analyze";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.IndianRed;
            richTextBox1.ForeColor = Color.WhiteSmoke;
            richTextBox1.Location = new Point(591, 103);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(205, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "RICH TEXT";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.IndianRed;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(591, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 16;
            textBox1.Text = "TEXT BOX";
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.IndianRed;
            treeView1.LineColor = Color.White;
            treeView1.Location = new Point(591, 292);
            treeView1.Name = "treeView1";
            treeNode2.Name = "Nodo0";
            treeNode2.Text = "Nodo0";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2 });
            treeView1.Size = new Size(205, 97);
            treeView1.TabIndex = 17;
            treeView1.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(938, 471);
            Controls.Add(treeView1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(monthCalendar1);
            Controls.Add(maskedTextBox1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private ListView listView1;
        private MaskedTextBox maskedTextBox1;
        private MonthCalendar monthCalendar1;
        private NotifyIcon notifyIcon1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private TreeView treeView1;
    }
}