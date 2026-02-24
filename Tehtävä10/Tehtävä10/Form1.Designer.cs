namespace Tehtävä10
{
    partial class BMIForm
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
            painoTB = new TextBox();
            pituusTB = new TextBox();
            laskeBT = new Button();
            vastausLB = new Label();
            kuvausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(164, 38);
            label1.TabIndex = 0;
            label1.Text = "Anna paino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(171, 38);
            label2.TabIndex = 1;
            label2.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            painoTB.Location = new Point(207, 31);
            painoTB.Name = "painoTB";
            painoTB.Size = new Size(150, 45);
            painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            pituusTB.Location = new Point(207, 83);
            pituusTB.Name = "pituusTB";
            pituusTB.Size = new Size(150, 45);
            pituusTB.TabIndex = 3;
            // 
            // laskeBT
            // 
            laskeBT.Location = new Point(26, 155);
            laskeBT.Name = "laskeBT";
            laskeBT.Size = new Size(323, 60);
            laskeBT.TabIndex = 4;
            laskeBT.Text = "Laske painoindeksi";
            laskeBT.UseVisualStyleBackColor = true;
            laskeBT.Click += laskeBT_Click;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(26, 227);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(109, 38);
            vastausLB.TabIndex = 5;
            vastausLB.Text = "Vastaus";
            vastausLB.Visible = false;
            // 
            // kuvausLB
            // 
            kuvausLB.AutoSize = true;
            kuvausLB.Location = new Point(26, 265);
            kuvausLB.Name = "kuvausLB";
            kuvausLB.Size = new Size(104, 38);
            kuvausLB.TabIndex = 6;
            kuvausLB.Text = "Kuvaus";
            kuvausLB.Visible = false;
            // 
            // BMIForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 324);
            Controls.Add(kuvausLB);
            Controls.Add(vastausLB);
            Controls.Add(laskeBT);
            Controls.Add(pituusTB);
            Controls.Add(painoTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BMIForm";
            Text = "Painoindeksilaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button laskeBT;
        private Label vastausLB;
        private Label kuvausLB;
    }
}
