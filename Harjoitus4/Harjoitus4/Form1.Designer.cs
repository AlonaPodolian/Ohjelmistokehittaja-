namespace Harjoitus4
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
            syntymaAikaDT = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            vuosinaLB = new Label();
            kuukausinaLB = new Label();
            paivinaLB = new Label();
            tunteinaLB = new Label();
            minuutteinaLB = new Label();
            sekunteinaLB = new Label();
            SuspendLayout();
            // 
            // syntymaAikaDT
            // 
            syntymaAikaDT.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            syntymaAikaDT.Location = new Point(29, 26);
            syntymaAikaDT.Name = "syntymaAikaDT";
            syntymaAikaDT.Size = new Size(420, 50);
            syntymaAikaDT.TabIndex = 0;
            syntymaAikaDT.ValueChanged += syntymaAikaDT_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(516, 21);
            button1.Name = "button1";
            button1.Size = new Size(138, 64);
            button1.TabIndex = 1;
            button1.Text = "Laske";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // vuosinaLB
            // 
            vuosinaLB.AutoSize = true;
            vuosinaLB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vuosinaLB.Location = new Point(43, 110);
            vuosinaLB.Name = "vuosinaLB";
            vuosinaLB.Size = new Size(81, 25);
            vuosinaLB.TabIndex = 3;
            vuosinaLB.Text = "Vuosissa";
            vuosinaLB.Visible = false;
            // 
            // kuukausinaLB
            // 
            kuukausinaLB.AutoSize = true;
            kuukausinaLB.Location = new Point(43, 144);
            kuukausinaLB.Name = "kuukausinaLB";
            kuukausinaLB.Size = new Size(107, 25);
            kuukausinaLB.TabIndex = 4;
            kuukausinaLB.Text = "Kuukausissa";
            kuukausinaLB.Visible = false;
            // 
            // paivinaLB
            // 
            paivinaLB.AutoSize = true;
            paivinaLB.Location = new Point(43, 184);
            paivinaLB.Name = "paivinaLB";
            paivinaLB.Size = new Size(72, 25);
            paivinaLB.TabIndex = 5;
            paivinaLB.Text = "Päivissä";
            paivinaLB.Visible = false;
            paivinaLB.Click += paivinaLB_Click;
            // 
            // tunteinaLB
            // 
            tunteinaLB.AutoSize = true;
            tunteinaLB.Location = new Point(223, 106);
            tunteinaLB.Name = "tunteinaLB";
            tunteinaLB.Size = new Size(89, 25);
            tunteinaLB.TabIndex = 6;
            tunteinaLB.Text = "Tunneissa";
            tunteinaLB.Visible = false;
            // 
            // minuutteinaLB
            // 
            minuutteinaLB.AutoSize = true;
            minuutteinaLB.Location = new Point(223, 144);
            minuutteinaLB.Name = "minuutteinaLB";
            minuutteinaLB.Size = new Size(106, 25);
            minuutteinaLB.TabIndex = 7;
            minuutteinaLB.Text = "Minuuteissa";
            minuutteinaLB.Visible = false;
            // 
            // sekunteinaLB
            // 
            sekunteinaLB.AutoSize = true;
            sekunteinaLB.Location = new Point(223, 184);
            sekunteinaLB.Name = "sekunteinaLB";
            sekunteinaLB.Size = new Size(108, 25);
            sekunteinaLB.TabIndex = 8;
            sekunteinaLB.Text = "Sekunneissa";
            sekunteinaLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 489);
            Controls.Add(sekunteinaLB);
            Controls.Add(minuutteinaLB);
            Controls.Add(tunteinaLB);
            Controls.Add(paivinaLB);
            Controls.Add(kuukausinaLB);
            Controls.Add(vuosinaLB);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(syntymaAikaDT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker syntymaAikaDT;
        private Button button1;
        private Label label1;
        private Label vuosinaLB;
        private Label kuukausinaLB;
        private Label paivinaLB;
        private Label tunteinaLB;
        private Label minuutteinaLB;
        private Label sekunteinaLB;
    }
}
