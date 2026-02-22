namespace Tehtävä17
{
    partial class Tietoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AlonaLB = new Label();
            SuspendLayout();
            // 
            // AlonaLB
            // 
            AlonaLB.AutoSize = true;
            AlonaLB.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlonaLB.Location = new Point(207, 101);
            AlonaLB.Name = "AlonaLB";
            AlonaLB.Size = new Size(213, 87);
            AlonaLB.TabIndex = 0;
            AlonaLB.Text = "Alona";
            // 
            // Tietoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AlonaLB);
            Name = "Tietoa";
            Text = "Tietoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AlonaLB;
    }
}