namespace Tehtävä12
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
            otsikLB = new Label();
            vastausGB = new GroupBox();
            nakymatonRB = new RadioButton();
            aRB = new RadioButton();
            bRB = new RadioButton();
            cRB = new RadioButton();
            dRB = new RadioButton();
            vastausLB = new Label();
            vastausGB.SuspendLayout();
            SuspendLayout();
            // 
            // otsikLB
            // 
            otsikLB.AutoSize = true;
            otsikLB.Location = new Point(49, 38);
            otsikLB.Name = "otsikLB";
            otsikLB.Size = new Size(201, 25);
            otsikLB.TabIndex = 0;
            otsikLB.Text = "Vastaus 1. kysymykseen";
            // 
            // vastausGB
            // 
            vastausGB.Controls.Add(dRB);
            vastausGB.Controls.Add(cRB);
            vastausGB.Controls.Add(bRB);
            vastausGB.Controls.Add(aRB);
            vastausGB.Controls.Add(nakymatonRB);
            vastausGB.Location = new Point(354, 40);
            vastausGB.Name = "vastausGB";
            vastausGB.Size = new Size(92, 223);
            vastausGB.TabIndex = 1;
            vastausGB.TabStop = false;
            vastausGB.Text = "Vastaus";
            // 
            // nakymatonRB
            // 
            nakymatonRB.AutoCheck = false;
            nakymatonRB.AutoSize = true;
            nakymatonRB.Location = new Point(9, 21);
            nakymatonRB.Name = "nakymatonRB";
            nakymatonRB.Size = new Size(21, 20);
            nakymatonRB.TabIndex = 0;
            nakymatonRB.TabStop = true;
            nakymatonRB.UseVisualStyleBackColor = true;
            nakymatonRB.Visible = false;
            // 
            // aRB
            // 
            aRB.AutoSize = true;
            aRB.Location = new Point(10, 47);
            aRB.Name = "aRB";
            aRB.Size = new Size(49, 29);
            aRB.TabIndex = 1;
            aRB.TabStop = true;
            aRB.Text = "A";
            aRB.UseVisualStyleBackColor = true;
            // 
            // bRB
            // 
            bRB.AutoSize = true;
            bRB.Location = new Point(10, 82);
            bRB.Name = "bRB";
            bRB.Size = new Size(47, 29);
            bRB.TabIndex = 2;
            bRB.TabStop = true;
            bRB.Text = "B";
            bRB.UseVisualStyleBackColor = true;
            // 
            // cRB
            // 
            cRB.AutoSize = true;
            cRB.Location = new Point(9, 117);
            cRB.Name = "cRB";
            cRB.Size = new Size(48, 29);
            cRB.TabIndex = 3;
            cRB.TabStop = true;
            cRB.Text = "C";
            cRB.UseVisualStyleBackColor = true;
            //cRB.CheckedChanged += cRB_CheckedChanged;
            // 
            // dRB
            // 
            dRB.AutoSize = true;
            dRB.Location = new Point(10, 152);
            dRB.Name = "dRB";
            dRB.Size = new Size(50, 29);
            dRB.TabIndex = 4;
            dRB.TabStop = true;
            dRB.Text = "D";
            dRB.UseVisualStyleBackColor = true;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(49, 238);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(72, 25);
            vastausLB.TabIndex = 2;
            vastausLB.Text = "Vastaus";
            vastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vastausLB);
            Controls.Add(vastausGB);
            Controls.Add(otsikLB);
            Name = "Form1";
            Text = "10 kysymystä";
            vastausGB.ResumeLayout(false);
            vastausGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label otsikLB;
        private GroupBox vastausGB;
        private RadioButton cRB;
        private RadioButton bRB;
        private RadioButton aRB;
        private RadioButton nakymatonRB;
        private RadioButton dRB;
        private Label vastausLB;
    }
}
