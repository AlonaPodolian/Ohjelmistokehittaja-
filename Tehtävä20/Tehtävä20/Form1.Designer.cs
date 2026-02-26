namespace Tehtävä20
{
    partial class YllapitoForm
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
            label3 = new Label();
            IdTB = new TextBox();
            EnimiTB = new TextBox();
            SnimiTB = new TextBox();
            ONroTB = new TextBox();
            EmailTB = new TextBox();
            PuhTB = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TyhjennaBT = new Button();
            TallennaBT = new Button();
            PoistaBT = new Button();
            PaivitaBT = new Button();
            TietotauluDG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TietotauluDG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 41);
            label1.Name = "label1";
            label1.Size = new Size(55, 38);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 89);
            label2.Name = "label2";
            label2.Size = new Size(143, 38);
            label2.TabIndex = 1;
            label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 140);
            label3.Name = "label3";
            label3.Size = new Size(166, 38);
            label3.TabIndex = 2;
            label3.Text = "SUKUNIMI:";
            // 
            // IdTB
            // 
            IdTB.Enabled = false;
            IdTB.Location = new Point(218, 35);
            IdTB.Name = "IdTB";
            IdTB.Size = new Size(251, 45);
            IdTB.TabIndex = 3;
            // 
            // EnimiTB
            // 
            EnimiTB.Location = new Point(218, 86);
            EnimiTB.Name = "EnimiTB";
            EnimiTB.Size = new Size(251, 45);
            EnimiTB.TabIndex = 4;
            // 
            // SnimiTB
            // 
            SnimiTB.Location = new Point(218, 137);
            SnimiTB.Name = "SnimiTB";
            SnimiTB.Size = new Size(251, 45);
            SnimiTB.TabIndex = 5;
            // 
            // ONroTB
            // 
            ONroTB.Location = new Point(747, 144);
            ONroTB.Name = "ONroTB";
            ONroTB.Size = new Size(251, 45);
            ONroTB.TabIndex = 11;
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(747, 93);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(251, 45);
            EmailTB.TabIndex = 10;
            // 
            // PuhTB
            // 
            PuhTB.Location = new Point(747, 42);
            PuhTB.Name = "PuhTB";
            PuhTB.Size = new Size(251, 45);
            PuhTB.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 144);
            label4.Name = "label4";
            label4.Size = new Size(236, 38);
            label4.TabIndex = 8;
            label4.Text = "OPISKELIJANRO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 93);
            label5.Name = "label5";
            label5.Size = new Size(199, 38);
            label5.TabIndex = 7;
            label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 45);
            label6.Name = "label6";
            label6.Size = new Size(143, 38);
            label6.TabIndex = 6;
            label6.Text = "PUHELIN:";
            // 
            // TyhjennaBT
            // 
            TyhjennaBT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TyhjennaBT.Location = new Point(46, 208);
            TyhjennaBT.Name = "TyhjennaBT";
            TyhjennaBT.Size = new Size(185, 56);
            TyhjennaBT.TabIndex = 12;
            TyhjennaBT.Text = "TYHJENNÄ";
            TyhjennaBT.UseVisualStyleBackColor = true;
            TyhjennaBT.Click += TyhjennaBT_Click;
            // 
            // TallennaBT
            // 
            TallennaBT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TallennaBT.Location = new Point(284, 208);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(185, 56);
            TallennaBT.TabIndex = 13;
            TallennaBT.Text = "TALLENNA";
            TallennaBT.UseVisualStyleBackColor = true;
            TallennaBT.Click += TallennaBT_Click;
            // 
            // PoistaBT
            // 
            PoistaBT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PoistaBT.Location = new Point(813, 208);
            PoistaBT.Name = "PoistaBT";
            PoistaBT.Size = new Size(185, 56);
            PoistaBT.TabIndex = 15;
            PoistaBT.Text = "POISTA";
            PoistaBT.UseVisualStyleBackColor = true;
            PoistaBT.Click += PoistaBT_Click;
            // 
            // PaivitaBT
            // 
            PaivitaBT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaivitaBT.Location = new Point(547, 208);
            PaivitaBT.Name = "PaivitaBT";
            PaivitaBT.Size = new Size(185, 56);
            PaivitaBT.TabIndex = 16;
            PaivitaBT.Text = "PÄIVITÄ";
            PaivitaBT.UseVisualStyleBackColor = true;
            PaivitaBT.Click += PaivitaBT_Click_1;
            // 
            // TietotauluDG
            // 
            TietotauluDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TietotauluDG.Location = new Point(23, 291);
            TietotauluDG.Name = "TietotauluDG";
            TietotauluDG.RowHeadersWidth = 62;
            TietotauluDG.Size = new Size(1081, 297);
            TietotauluDG.TabIndex = 17;
            TietotauluDG.CellContentClick += TietotauluDG_CellContentClick;
            // 
            // YllapitoForm
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 629);
            Controls.Add(TietotauluDG);
            Controls.Add(PaivitaBT);
            Controls.Add(PoistaBT);
            Controls.Add(TallennaBT);
            Controls.Add(TyhjennaBT);
            Controls.Add(ONroTB);
            Controls.Add(EmailTB);
            Controls.Add(PuhTB);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(SnimiTB);
            Controls.Add(EnimiTB);
            Controls.Add(IdTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "YllapitoForm";
            Text = "Opiskelijarekisterin ylläpito";
            Load += YllapitoForm_Load;
            ((System.ComponentModel.ISupportInitialize)TietotauluDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IdTB;
        private TextBox EnimiTB;
        private TextBox SnimiTB;
        private TextBox ONroTB;
        private TextBox EmailTB;
        private TextBox PuhTB;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button TyhjennaBT;
        private Button TallennaBT;
        private Button PoistaBT;
        private Button PaivitaBT;
        private DataGridView TietotauluDG;
    }
}
