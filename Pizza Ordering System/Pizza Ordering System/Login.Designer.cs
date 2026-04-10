namespace Pizza_Ordering_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UnameTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordTb = new TextBox();
            LoginBtn = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 15;
            guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 15;
            guna2Elipse4.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 655);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(443, 42);
            label1.Name = "label1";
            label1.Size = new Size(307, 36);
            label1.TabIndex = 1;
            label1.Text = "Pizza Ordering System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(505, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.Location = new Point(443, 289);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(335, 40);
            UnameTb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 246);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 356);
            label3.Name = "label3";
            label3.Size = new Size(111, 29);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(443, 399);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(335, 40);
            PasswordTb.TabIndex = 5;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Green;
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(522, 495);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(256, 64);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = " Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(910, 9);
            label4.Name = "label4";
            label4.Size = new Size(41, 44);
            label4.TabIndex = 8;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(958, 655);
            Controls.Add(label4);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(PasswordTb);
            Controls.Add(label2);
            Controls.Add(UnameTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox PasswordTb;
        private Label label2;
        private TextBox UnameTb;
        private Button LoginBtn;
        private Label label4;
    }
}
