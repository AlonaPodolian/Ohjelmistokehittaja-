namespace Csharp_Hotel_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            LoginBT = new Button();
            PasswordTB = new TextBox();
            label3 = new Label();
            UsernameTB = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 11);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 201);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 61);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(442, 61);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LoginBT);
            groupBox1.Controls.Add(PasswordTB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(UsernameTB);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 266);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // LoginBT
            // 
            LoginBT.BackColor = Color.FromArgb(232, 86, 42);
            LoginBT.Cursor = Cursors.Hand;
            LoginBT.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBT.ForeColor = Color.White;
            LoginBT.Location = new Point(6, 188);
            LoginBT.Name = "LoginBT";
            LoginBT.Size = new Size(431, 60);
            LoginBT.TabIndex = 4;
            LoginBT.Text = "Login";
            LoginBT.UseVisualStyleBackColor = false;
            LoginBT.Click += LoginBT_Click;
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTB.Location = new Point(174, 111);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(263, 44);
            PasswordTB.TabIndex = 3;
            PasswordTB.Text = "admin";
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 111);
            label3.Name = "label3";
            label3.Size = new Size(167, 37);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // UsernameTB
            // 
            UsernameTB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTB.Location = new Point(174, 47);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(263, 44);
            UsernameTB.TabIndex = 1;
            UsernameTB.Text = "admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(173, 37);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(468, 546);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 2, 4, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox UsernameTB;
        private Label label2;
        private Button LoginBT;
        private TextBox PasswordTB;
        private Label label3;
    }
}