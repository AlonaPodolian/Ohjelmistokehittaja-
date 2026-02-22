namespace Tehtävä16
{
    partial class stopBT
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
            minuutitLB = new Label();
            sekuunnitLB = new Label();
            minuuttitCB = new ComboBox();
            sekunnitCB = new ComboBox();
            aikaLB = new Label();
            startBT = new Button();
            Stop1BT = new Button();
            ajastinTR = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // minuutitLB
            // 
            minuutitLB.AutoSize = true;
            minuutitLB.Location = new Point(50, 36);
            minuutitLB.Name = "minuutitLB";
            minuutitLB.Size = new Size(78, 25);
            minuutitLB.TabIndex = 0;
            minuutitLB.Text = "minuutit";
            // 
            // sekuunnitLB
            // 
            sekuunnitLB.AutoSize = true;
            sekuunnitLB.Location = new Point(170, 36);
            sekuunnitLB.Name = "sekuunnitLB";
            sekuunnitLB.Size = new Size(78, 25);
            sekuunnitLB.TabIndex = 1;
            sekuunnitLB.Text = "sekunnit";
            // 
            // minuuttitCB
            // 
            minuuttitCB.FormattingEnabled = true;
            minuuttitCB.Location = new Point(55, 69);
            minuuttitCB.Name = "minuuttitCB";
            minuuttitCB.Size = new Size(73, 33);
            minuuttitCB.TabIndex = 2;
            // 
            // sekunnitCB
            // 
            sekunnitCB.FormattingEnabled = true;
            sekunnitCB.Location = new Point(175, 69);
            sekunnitCB.Name = "sekunnitCB";
            sekunnitCB.Size = new Size(73, 33);
            sekunnitCB.TabIndex = 3;
            // 
            // aikaLB
            // 
            aikaLB.AutoSize = true;
            aikaLB.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aikaLB.Location = new Point(50, 121);
            aikaLB.Name = "aikaLB";
            aikaLB.Size = new Size(212, 96);
            aikaLB.TabIndex = 4;
            aikaLB.Text = "00:00";
            // 
            // startBT
            // 
            startBT.Location = new Point(55, 238);
            startBT.Name = "startBT";
            startBT.Size = new Size(74, 34);
            startBT.TabIndex = 5;
            startBT.Text = "start";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += startBT_Click;
            // 
            // Stop1BT
            // 
            Stop1BT.Location = new Point(157, 238);
            Stop1BT.Name = "Stop1BT";
            Stop1BT.Size = new Size(74, 34);
            Stop1BT.TabIndex = 6;
            Stop1BT.Text = "stop";
            Stop1BT.UseVisualStyleBackColor = true;
            Stop1BT.Click += Stop1BT_Click;
            // 
            // ajastinTR
            // 
            ajastinTR.Interval = 1000;
            ajastinTR.Tick += ajastinTR_Tick;
            // 
            // stopBT
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 461);
            Controls.Add(Stop1BT);
            Controls.Add(startBT);
            Controls.Add(aikaLB);
            Controls.Add(sekunnitCB);
            Controls.Add(minuuttitCB);
            Controls.Add(sekuunnitLB);
            Controls.Add(minuutitLB);
            Name = "stopBT";
            Text = "stop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label minuutitLB;
        private Label sekuunnitLB;
        private ComboBox minuuttitCB;
        private ComboBox sekunnitCB;
        private Label aikaLB;
        private Button startBT;
        private Button Stop1BT;
        private System.Windows.Forms.Timer ajastinTR;
    }
}
