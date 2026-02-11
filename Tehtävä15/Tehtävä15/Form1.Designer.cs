namespace Tehtävä15
{
    partial class form
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
            components = new System.ComponentModel.Container();
            aikaLB = new Label();
            startBT = new Button();
            stopBT = new Button();
            resetB = new Button();
            ajastinTR = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // aikaLB
            // 
            aikaLB.AutoSize = true;
            aikaLB.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aikaLB.Location = new Point(35, 25);
            aikaLB.Name = "aikaLB";
            aikaLB.Size = new Size(875, 191);
            aikaLB.TabIndex = 0;
            aikaLB.Text = "00:00:00.000";
            // 
            // startBT
            // 
            startBT.Location = new Point(76, 251);
            startBT.Name = "startBT";
            startBT.Size = new Size(152, 66);
            startBT.TabIndex = 1;
            startBT.Text = "Start";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += startBT_Click;
            // 
            // stopBT
            // 
            stopBT.Location = new Point(395, 251);
            stopBT.Name = "stopBT";
            stopBT.Size = new Size(152, 66);
            stopBT.TabIndex = 2;
            stopBT.Text = "Stop";
            stopBT.UseVisualStyleBackColor = true;
            stopBT.Click += stopBT_Click;
            // 
            // resetB
            // 
            resetB.Location = new Point(705, 251);
            resetB.Name = "resetB";
            resetB.Size = new Size(152, 66);
            resetB.TabIndex = 3;
            resetB.Text = "Reset";
            resetB.UseVisualStyleBackColor = true;
            resetB.Click += resetB_Click;
            // 
            // ajastinTR
            // 
            ajastinTR.Enabled = true;
            ajastinTR.Tick += ajastinTR_Tick;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(resetB);
            Controls.Add(stopBT);
            Controls.Add(startBT);
            Controls.Add(aikaLB);
            Name = "form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aikaLB;
        private Button startBT;
        private Button stopBT;
        private Button resetB;
        private System.Windows.Forms.Timer ajastinTR;
    }
}
