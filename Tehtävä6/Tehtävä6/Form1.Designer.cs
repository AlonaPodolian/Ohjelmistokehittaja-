namespace Tehtävä6
{
    partial class salasanaFM
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
            salasanaPL = new Panel();
            virheViestiLB = new Label();
            TarkistaBT = new Button();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            salasanaLB = new Label();
            label1 = new Label();
            salasanaOikeinPL = new Panel();
            label3 = new Label();
            salasanaPL.SuspendLayout();
            salasanaOikeinPL.SuspendLayout();
            SuspendLayout();
            // 
            // salasanaPL
            // 
            salasanaPL.BackColor = Color.MediumSlateBlue;
            salasanaPL.Controls.Add(virheViestiLB);
            salasanaPL.Controls.Add(TarkistaBT);
            salasanaPL.Controls.Add(SalasanaTB);
            salasanaPL.Controls.Add(KayttajaTB);
            salasanaPL.Controls.Add(salasanaLB);
            salasanaPL.Controls.Add(label1);
            salasanaPL.Dock = DockStyle.Fill;
            salasanaPL.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salasanaPL.Location = new Point(0, 0);
            salasanaPL.Name = "salasanaPL";
            salasanaPL.Size = new Size(1188, 493);
            salasanaPL.TabIndex = 0;
            // 
            // virheViestiLB
            // 
            virheViestiLB.AutoSize = true;
            virheViestiLB.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            virheViestiLB.ForeColor = Color.Gold;
            virheViestiLB.Location = new Point(195, 137);
            virheViestiLB.Name = "virheViestiLB";
            virheViestiLB.Size = new Size(123, 63);
            virheViestiLB.TabIndex = 5;
            virheViestiLB.Text = "Virhe";
            virheViestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            TarkistaBT.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(717, 143);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(189, 58);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaTB
            // 
            SalasanaTB.ForeColor = SystemColors.InactiveCaptionText;
            SalasanaTB.Location = new Point(385, 82);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(521, 55);
            SalasanaTB.TabIndex = 3;
            SalasanaTB.TextChanged += SalasanaTB_TextChanged;
            // 
            // KayttajaTB
            // 
            KayttajaTB.ForeColor = SystemColors.InactiveCaptionText;
            KayttajaTB.Location = new Point(388, 21);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(518, 55);
            KayttajaTB.TabIndex = 2;
            KayttajaTB.TextChanged += KayttajaTB_TextChanged;
            // 
            // salasanaLB
            // 
            salasanaLB.AutoSize = true;
            salasanaLB.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salasanaLB.ForeColor = Color.Gold;
            salasanaLB.Location = new Point(140, 74);
            salasanaLB.Name = "salasanaLB";
            salasanaLB.Size = new Size(194, 63);
            salasanaLB.TabIndex = 1;
            salasanaLB.Text = "Salasana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(333, 63);
            label1.TabIndex = 0;
            label1.Text = "Käyttäjätunnus: ";
            // 
            // salasanaOikeinPL
            // 
            salasanaOikeinPL.BackColor = Color.DarkRed;
            salasanaOikeinPL.Controls.Add(salasanaPL);
            salasanaOikeinPL.Controls.Add(label3);
            salasanaOikeinPL.Dock = DockStyle.Fill;
            salasanaOikeinPL.Font = new Font("Segoe Script", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            salasanaOikeinPL.ForeColor = Color.Snow;
            salasanaOikeinPL.Location = new Point(0, 0);
            salasanaOikeinPL.Name = "salasanaOikeinPL";
            salasanaOikeinPL.Size = new Size(1188, 493);
            salasanaOikeinPL.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 70);
            label3.Name = "label3";
            label3.Size = new Size(860, 114);
            label3.TabIndex = 0;
            label3.Text = "Tervetuloa sivuilleni";
            // 
            // salasanaFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 493);
            Controls.Add(salasanaOikeinPL);
            Name = "salasanaFM";
            Text = "salasananTarkistus";
            salasanaPL.ResumeLayout(false);
            salasanaPL.PerformLayout();
            salasanaOikeinPL.ResumeLayout(false);
            salasanaOikeinPL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel salasanaPL;
        private Panel salasanaOikeinPL;
        private Label salasanaLB;
        private Label label1;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label virheViestiLB;
        private Button TarkistaBT;
        private Label label3;
    }
}
