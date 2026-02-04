namespace test
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
            tekstiLB = new Label();
            tekstiBT = new Button();
            SuspendLayout();
            // 
            // tekstiLB
            // 
            tekstiLB.AutoSize = true;
            tekstiLB.Location = new Point(30, 9);
            tekstiLB.Name = "tekstiLB";
            tekstiLB.Size = new Size(72, 25);
            tekstiLB.TabIndex = 0;
            tekstiLB.Text = "tekstiLB";
            tekstiLB.Visible = false;
            // 
            // tekstiBT
            // 
            tekstiBT.Location = new Point(30, 37);
            tekstiBT.Name = "tekstiBT";
            tekstiBT.Size = new Size(112, 34);
            tekstiBT.TabIndex = 1;
            tekstiBT.Text = "Paina";
            tekstiBT.UseVisualStyleBackColor = true;
            tekstiBT.Click += tekstiBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tekstiBT);
            Controls.Add(tekstiLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tekstiLB;
        private Button tekstiBT;
    }
}
