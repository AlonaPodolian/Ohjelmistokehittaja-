namespace Tehtävä9
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
            label1 = new Label();
            asteetTB = new TextBox();
            muuntoGP = new GroupBox();
            fahrenheitRB = new RadioButton();
            celsiusRB = new RadioButton();
            muunnaBT = new Button();
            vastausLB = new Label();
            muuntoGP.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 52);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna asteet";
            // 
            // asteetTB
            // 
            asteetTB.Location = new Point(159, 55);
            asteetTB.Name = "asteetTB";
            asteetTB.Size = new Size(150, 31);
            asteetTB.TabIndex = 1;
            asteetTB.TextChanged += asteetTB_TextChanged;
            // 
            // muuntoGP
            // 
            muuntoGP.Controls.Add(fahrenheitRB);
            muuntoGP.Controls.Add(celsiusRB);
            muuntoGP.Location = new Point(341, 34);
            muuntoGP.Name = "muuntoGP";
            muuntoGP.Size = new Size(300, 150);
            muuntoGP.TabIndex = 2;
            muuntoGP.TabStop = false;
            muuntoGP.Text = "Miten muunnat?";
            // 
            // fahrenheitRB
            // 
            fahrenheitRB.AutoSize = true;
            fahrenheitRB.Location = new Point(8, 83);
            fahrenheitRB.Name = "fahrenheitRB";
            fahrenheitRB.Size = new Size(118, 29);
            fahrenheitRB.TabIndex = 1;
            fahrenheitRB.TabStop = true;
            fahrenheitRB.Text = "Fahrenheit";
            fahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // celsiusRB
            // 
            celsiusRB.AutoSize = true;
            celsiusRB.Location = new Point(8, 48);
            celsiusRB.Name = "celsiusRB";
            celsiusRB.Size = new Size(91, 29);
            celsiusRB.TabIndex = 0;
            celsiusRB.TabStop = true;
            celsiusRB.Text = "Celsius";
            celsiusRB.UseVisualStyleBackColor = true;
            // 
            // muunnaBT
            // 
            muunnaBT.Location = new Point(702, 82);
            muunnaBT.Name = "muunnaBT";
            muunnaBT.Size = new Size(112, 34);
            muunnaBT.TabIndex = 3;
            muunnaBT.Text = "Muunna";
            muunnaBT.UseVisualStyleBackColor = true;
            muunnaBT.Click += muunnaBT_Click;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(48, 100);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(59, 25);
            vastausLB.TabIndex = 4;
            vastausLB.Text = "label2";
            vastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 268);
            Controls.Add(vastausLB);
            Controls.Add(muunnaBT);
            Controls.Add(muuntoGP);
            Controls.Add(asteetTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            muuntoGP.ResumeLayout(false);
            muuntoGP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox asteetTB;
        private GroupBox muuntoGP;
        private RadioButton fahrenheitRB;
        private RadioButton celsiusRB;
        private Button muunnaBT;
        private Label vastausLB;
    }
}
