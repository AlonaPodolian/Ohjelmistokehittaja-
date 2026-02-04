namespace toinen_tehtava
{
    partial class Harjoitus2
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
            OtsikkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaLB = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OtsikkoLB.Location = new Point(0, 9);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(442, 51);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TulostusLB.Location = new Point(0, 63);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(111, 51);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViestiTB.Location = new Point(469, 12);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(569, 50);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaLB
            // 
            TulostaLB.ForeColor = SystemColors.ActiveCaptionText;
            TulostaLB.Location = new Point(877, 68);
            TulostaLB.Name = "TulostaLB";
            TulostaLB.Size = new Size(161, 46);
            TulostaLB.TabIndex = 3;
            TulostaLB.Text = "Tulosta teksti";
            TulostaLB.UseVisualStyleBackColor = true;
            TulostaLB.Click += TulostaBT_Click;
            // 
            // Harjoitus2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1187, 519);
            Controls.Add(TulostaLB);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Harjoitus2";
            Text = "Harjoitus 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaLB;
    }
}
