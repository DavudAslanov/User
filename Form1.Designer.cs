namespace User
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            pass = new TextBox();
            user = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(user);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(219, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 445);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(232, 327);
            button2.Name = "button2";
            button2.Size = new Size(156, 54);
            button2.TabIndex = 6;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(70, 327);
            button1.Name = "button1";
            button1.Size = new Size(156, 54);
            button1.TabIndex = 5;
            button1.Text = "Sign IN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pass
            // 
            pass.Location = new Point(70, 244);
            pass.Name = "pass";
            pass.Size = new Size(323, 27);
            pass.TabIndex = 4;
            // 
            // user
            // 
            user.Location = new Point(70, 117);
            user.Name = "user";
            user.Size = new Size(323, 27);
            user.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 219);
            label3.Name = "label3";
            label3.Size = new Size(84, 22);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 82);
            label2.Name = "label2";
            label2.Size = new Size(45, 22);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 0;
            label1.Text = "Sig IN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 490);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox pass;
        private TextBox user;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
