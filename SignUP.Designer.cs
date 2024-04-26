namespace User
{
    partial class SignUP
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
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(212, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 0;
            label1.Text = "Sign UP";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(age);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(surname);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(127, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 420);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(154, 374);
            button1.Name = "button1";
            button1.Size = new Size(193, 43);
            button1.TabIndex = 11;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // age
            // 
            age.Location = new Point(104, 329);
            age.Name = "age";
            age.Size = new Size(308, 27);
            age.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(104, 304);
            label6.Name = "label6";
            label6.Size = new Size(40, 22);
            label6.TabIndex = 9;
            label6.Text = "Age";
            // 
            // surname
            // 
            surname.Location = new Point(104, 142);
            surname.Name = "surname";
            surname.Size = new Size(308, 27);
            surname.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(104, 117);
            label5.Name = "label5";
            label5.Size = new Size(79, 22);
            label5.TabIndex = 7;
            label5.Text = "Surname";
            label5.Click += label5_Click;
            // 
            // password
            // 
            password.Location = new Point(104, 266);
            password.Name = "password";
            password.Size = new Size(308, 27);
            password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(104, 180);
            label4.Name = "label4";
            label4.Size = new Size(52, 22);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(104, 205);
            email.Name = "email";
            email.Size = new Size(308, 27);
            email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 241);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 3;
            label3.Text = "Passwords";
            // 
            // name
            // 
            name.Location = new Point(104, 82);
            name.Name = "name";
            name.Size = new Size(308, 27);
            name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 57);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // SignUP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
            Controls.Add(panel1);
            Name = "SignUP";
            Text = "SignUP";
            FormClosed += SignUP_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox name;
        private Label label2;
        private TextBox surname;
        private Label label5;
        private TextBox password;
        private Label label4;
        private TextBox email;
        private Label label3;
        private Button button1;
        private TextBox age;
        private Label label6;
    }
}