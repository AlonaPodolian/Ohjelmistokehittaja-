namespace Tehtävä11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            noppa01PB = new PictureBox();
            noppa02PB = new PictureBox();
            heitoBT = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // noppa01PB
            // 
            noppa01PB.Image = (Image)resources.GetObject("noppa01PB.Image");
            noppa01PB.Location = new Point(74, 85);
            noppa01PB.Name = "noppa01PB";
            noppa01PB.Size = new Size(98, 95);
            noppa01PB.SizeMode = PictureBoxSizeMode.StretchImage;
            noppa01PB.TabIndex = 0;
            noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            noppa02PB.Image = Properties.Resources.rollingDice;
            noppa02PB.Location = new Point(206, 85);
            noppa02PB.Name = "noppa02PB";
            noppa02PB.Size = new Size(98, 95);
            noppa02PB.SizeMode = PictureBoxSizeMode.StretchImage;
            noppa02PB.TabIndex = 1;
            noppa02PB.TabStop = false;
            // 
            // heitoBT
            // 
            heitoBT.Location = new Point(74, 198);
            heitoBT.Name = "heitoBT";
            heitoBT.Size = new Size(230, 34);
            heitoBT.TabIndex = 2;
            heitoBT.Text = "Heitä";
            heitoBT.UseVisualStyleBackColor = true;
            heitoBT.Click += heitoBT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 23);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 3;
            label1.Text = "Nopan heitto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 292);
            Controls.Add(label1);
            Controls.Add(heitoBT);
            Controls.Add(noppa02PB);
            Controls.Add(noppa01PB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button heitoBT;
        private Label label1;
    }
}
