namespace User
{
    partial class AdminPanel
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
            dataGridView1 = new DataGridView();
            age = new TextBox();
            label6 = new Label();
            surname = new TextBox();
            label5 = new Label();
            password = new TextBox();
            label4 = new Label();
            email = new TextBox();
            label3 = new Label();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(985, 167);
            dataGridView1.TabIndex = 0;
            // 
            // age
            // 
            age.Location = new Point(0, 284);
            age.Name = "age";
            age.Size = new Size(308, 27);
            age.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 259);
            label6.Name = "label6";
            label6.Size = new Size(40, 22);
            label6.TabIndex = 20;
            label6.Text = "Age";
            // 
            // surname
            // 
            surname.Location = new Point(0, 97);
            surname.Name = "surname";
            surname.Size = new Size(308, 27);
            surname.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 72);
            label5.Name = "label5";
            label5.Size = new Size(79, 22);
            label5.TabIndex = 18;
            label5.Text = "Surname";
            // 
            // password
            // 
            password.Location = new Point(0, 221);
            password.Name = "password";
            password.Size = new Size(308, 27);
            password.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 135);
            label4.Name = "label4";
            label4.Size = new Size(52, 22);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(0, 160);
            email.Name = "email";
            email.Size = new Size(308, 27);
            email.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 196);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 14;
            label3.Text = "Passwords";
            // 
            // name
            // 
            name.Location = new Point(0, 37);
            name.Name = "name";
            name.Size = new Size(308, 27);
            name.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 12);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 2);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 11;
            label1.Text = "Sign UP";
            // 
            // button1
            // 
            button1.Location = new Point(0, 317);
            button1.Name = "button1";
            button1.Size = new Size(146, 35);
            button1.TabIndex = 22;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 317);
            button2.Name = "button2";
            button2.Size = new Size(146, 35);
            button2.TabIndex = 23;
            button2.Text = "GetList";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(304, 317);
            button3.Name = "button3";
            button3.Size = new Size(146, 35);
            button3.TabIndex = 24;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(456, 317);
            button4.Name = "button4";
            button4.Size = new Size(146, 35);
            button4.TabIndex = 25;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(850, 9);
            label7.Name = "label7";
            label7.Size = new Size(52, 22);
            label7.TabIndex = 26;
            label7.Text = "Roles";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 525);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(age);
            Controls.Add(label6);
            Controls.Add(surname);
            Controls.Add(label5);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(email);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            FormClosed += AdminPanel_FormClosed;
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox age;
        private Label label6;
        private TextBox surname;
        private Label label5;
        private TextBox password;
        private Label label4;
        private TextBox email;
        private Label label3;
        private TextBox name;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
    }
}