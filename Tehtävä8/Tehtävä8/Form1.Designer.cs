namespace Tehtävä8
{
    partial class RoomalaisiksiForm
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
            label1 = new Label();
            label2 = new Label();
            tekstiTB = new TextBox();
            vastausLB = new Label();
            muutaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(1010, 135);
            label1.TabIndex = 0;
            label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 167);
            label2.Name = "label2";
            label2.Size = new Size(834, 39);
            label2.TabIndex = 1;
            label2.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // tekstiTB
            // 
            tekstiTB.Location = new Point(920, 164);
            tekstiTB.Name = "tekstiTB";
            tekstiTB.Size = new Size(150, 47);
            tekstiTB.TabIndex = 2;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Font = new Font("Comic Sans MS", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vastausLB.Location = new Point(60, 225);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(242, 78);
            vastausLB.TabIndex = 3;
            vastausLB.Text = "Vastaus";
            vastausLB.Visible = false;
            // 
            // muutaBT
            // 
            muutaBT.Location = new Point(920, 248);
            muutaBT.Name = "muutaBT";
            muutaBT.Size = new Size(150, 54);
            muutaBT.TabIndex = 4;
            muutaBT.Text = "Muuta";
            muutaBT.UseVisualStyleBackColor = true;
            muutaBT.Click += muutaBT_Click;
            // 
            // RoomalaisiksiForm
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.clock2;
            ClientSize = new Size(1139, 334);
            Controls.Add(muutaBT);
            Controls.Add(vastausLB);
            Controls.Add(tekstiTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RoomalaisiksiForm";
            Text = "Numeroiden muutos arabialaisista roomalaisiksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tekstiTB;
        private Label vastausLB;
        private Button muutaBT;
    }
}
