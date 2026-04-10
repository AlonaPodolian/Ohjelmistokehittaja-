namespace Pizza_Ordering_System
{
    partial class Settings
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
            components = new System.ComponentModel.Container();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            PizzaCb = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            PriceTb = new TextBox();
            SubmitBtn = new Button();
            BackLbl = new Label();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(113, 749);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(335, 39);
            label1.Name = "label1";
            label1.Size = new Size(307, 36);
            label1.TabIndex = 2;
            label1.Text = "Pizza Ordering System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(418, 84);
            label2.Name = "label2";
            label2.Size = new Size(118, 36);
            label2.TabIndex = 3;
            label2.Text = "Settings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(859, 22);
            label4.Name = "label4";
            label4.Size = new Size(41, 44);
            label4.TabIndex = 9;
            label4.Text = "X";
            // 
            // PizzaCb
            // 
            PizzaCb.FormattingEnabled = true;
            PizzaCb.Items.AddRange(new object[] { "Exstra Large", "Large", "Medium", "Small", "", "" });
            PizzaCb.Location = new Point(261, 250);
            PizzaCb.Name = "PizzaCb";
            PizzaCb.Size = new Size(480, 37);
            PizzaCb.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(250, 200);
            label3.Name = "label3";
            label3.Size = new Size(228, 36);
            label3.TabIndex = 11;
            label3.Text = "Select The Pizza";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(250, 351);
            label5.Name = "label5";
            label5.Size = new Size(221, 36);
            label5.TabIndex = 12;
            label5.Text = "Enter The Pizza";
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceTb.Location = new Point(261, 416);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(480, 40);
            PriceTb.TabIndex = 13;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.Green;
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(363, 530);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(256, 64);
            SubmitBtn.TabIndex = 14;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // BackLbl
            // 
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            BackLbl.ForeColor = Color.Green;
            BackLbl.Location = new Point(440, 665);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(76, 36);
            BackLbl.TabIndex = 15;
            BackLbl.Text = "Back";
            BackLbl.Click += label6_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(923, 749);
            Controls.Add(BackLbl);
            Controls.Add(SubmitBtn);
            Controls.Add(PriceTb);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(PizzaCb);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox PizzaCb;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox PriceTb;
        private Label BackLbl;
        private Button SubmitBtn;
    }
}