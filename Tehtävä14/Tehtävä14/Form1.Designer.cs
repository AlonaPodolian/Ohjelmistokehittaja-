namespace Tehtävä14
{
    partial class PaivakirjaFM
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
            paivakirjaTB = new TextBox();
            lisaaBT = new Button();
            SuspendLayout();
            // 
            // paivakirjaTB
            // 
            paivakirjaTB.Location = new Point(12, 12);
            paivakirjaTB.Multiline = true;
            paivakirjaTB.Name = "paivakirjaTB";
            paivakirjaTB.Size = new Size(776, 306);
            paivakirjaTB.TabIndex = 0;
            // 
            // lisaaBT
            // 
            lisaaBT.Location = new Point(12, 340);
            lisaaBT.Name = "lisaaBT";
            lisaaBT.Size = new Size(776, 34);
            lisaaBT.TabIndex = 1;
            lisaaBT.Text = "Lisää päiväkirjaan";
            lisaaBT.UseVisualStyleBackColor = true;
            lisaaBT.Click += lisaaBT_Click;
            // 
            // PaivakirjaFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lisaaBT);
            Controls.Add(paivakirjaTB);
            Name = "PaivakirjaFM";
            Text = "Päiväkirjä";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox paivakirjaTB;
        private Button lisaaBT;
    }
}
