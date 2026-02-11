namespace Tehtävä13
{
    partial class suosikitFM
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
            kysymysLB = new Label();
            nimiTB = new TextBox();
            vastausLB = new Label();
            tarkastaBT = new Button();
            SuspendLayout();
            // 
            // kysymysLB
            // 
            kysymysLB.AutoSize = true;
            kysymysLB.Location = new Point(36, 25);
            kysymysLB.Name = "kysymysLB";
            kysymysLB.Size = new Size(519, 25);
            kysymysLB.TabIndex = 0;
            kysymysLB.Text = "Onko nimesi, niin tarkastan, onko se 50 suosituimman joukossa:";
            // 
            // nimiTB
            // 
            nimiTB.Location = new Point(571, 25);
            nimiTB.Name = "nimiTB";
            nimiTB.Size = new Size(150, 31);
            nimiTB.TabIndex = 1;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(36, 68);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(59, 25);
            vastausLB.TabIndex = 2;
            vastausLB.Text = "label1";
            vastausLB.Visible = false;
            vastausLB.Click += label1_Click;
            // 
            // tarkastaBT
            // 
            tarkastaBT.Location = new Point(609, 68);
            tarkastaBT.Name = "tarkastaBT";
            tarkastaBT.Size = new Size(112, 34);
            tarkastaBT.TabIndex = 3;
            tarkastaBT.Text = "Tarkasta";
            tarkastaBT.UseVisualStyleBackColor = true;
            tarkastaBT.Click += tarkastaBT_Click;
            // 
            // suosikitFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tarkastaBT);
            Controls.Add(vastausLB);
            Controls.Add(nimiTB);
            Controls.Add(kysymysLB);
            Name = "suosikitFM";
            Text = "Onko nimesi suosittujen joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kysymysLB;
        private TextBox nimiTB;
        private Label vastausLB;
        private Button tarkastaBT;
    }
}
