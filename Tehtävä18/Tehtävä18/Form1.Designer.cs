namespace Tehtävä18
{
    partial class AvainhenkilotForm
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
            oppilaitosCB = new ComboBox();
            vastuuhloCB = new ComboBox();
            label3 = new Label();
            OsoiteLB = new Label();
            PostinumeroLB = new Label();
            PostitoimipaikkaLB = new Label();
            PuhelinLB = new Label();
            PuhLB = new Label();
            EmailLB = new Label();
            OsastoLB = new Label();
            TitteliLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(908, 96);
            label1.TabIndex = 0;
            label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 153);
            label2.Name = "label2";
            label2.Size = new Size(230, 38);
            label2.TabIndex = 1;
            label2.Text = "Valitse oppilaitos:";
            // 
            // oppilaitosCB
            // 
            oppilaitosCB.FormattingEnabled = true;
            oppilaitosCB.Location = new Point(65, 200);
            oppilaitosCB.Name = "oppilaitosCB";
            oppilaitosCB.Size = new Size(230, 46);
            oppilaitosCB.TabIndex = 2;
            oppilaitosCB.SelectedIndexChanged += oppilaitosCB_SelectedIndexChanged;
            // 
            // vastuuhloCB
            // 
            vastuuhloCB.FormattingEnabled = true;
            vastuuhloCB.Location = new Point(594, 200);
            vastuuhloCB.Name = "vastuuhloCB";
            vastuuhloCB.Size = new Size(333, 46);
            vastuuhloCB.TabIndex = 4;
            vastuuhloCB.SelectedIndexChanged += oppilaitosCB_SelectedIndexChanged;
            vastuuhloCB.TextChanged += vastuuhloCB_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 153);
            label3.Name = "label3";
            label3.Size = new Size(281, 38);
            label3.TabIndex = 3;
            label3.Text = "Valitse vastuuhenkilö:";
            // 
            // OsoiteLB
            // 
            OsoiteLB.AutoSize = true;
            OsoiteLB.Location = new Point(67, 255);
            OsoiteLB.Name = "OsoiteLB";
            OsoiteLB.Size = new Size(97, 38);
            OsoiteLB.TabIndex = 5;
            OsoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            PostinumeroLB.AutoSize = true;
            PostinumeroLB.Location = new Point(65, 302);
            PostinumeroLB.Name = "PostinumeroLB";
            PostinumeroLB.Size = new Size(173, 38);
            PostinumeroLB.TabIndex = 6;
            PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            PostitoimipaikkaLB.AutoSize = true;
            PostitoimipaikkaLB.Location = new Point(65, 349);
            PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            PostitoimipaikkaLB.Size = new Size(218, 38);
            PostitoimipaikkaLB.TabIndex = 7;
            PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            PuhelinLB.AutoSize = true;
            PuhelinLB.Location = new Point(67, 396);
            PuhelinLB.Name = "PuhelinLB";
            PuhelinLB.Size = new Size(110, 38);
            PuhelinLB.TabIndex = 8;
            PuhelinLB.Text = "Puhelin";
            // 
            // PuhLB
            // 
            PuhLB.AutoSize = true;
            PuhLB.Location = new Point(596, 396);
            PuhLB.Name = "PuhLB";
            PuhLB.Size = new Size(110, 38);
            PuhLB.TabIndex = 12;
            PuhLB.Text = "Puhelin";
            // 
            // EmailLB
            // 
            EmailLB.AutoSize = true;
            EmailLB.Location = new Point(594, 349);
            EmailLB.Name = "EmailLB";
            EmailLB.Size = new Size(152, 38);
            EmailLB.TabIndex = 11;
            EmailLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            OsastoLB.AutoSize = true;
            OsastoLB.Location = new Point(594, 302);
            OsastoLB.Name = "OsastoLB";
            OsastoLB.Size = new Size(101, 38);
            OsastoLB.TabIndex = 10;
            OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            TitteliLB.AutoSize = true;
            TitteliLB.Location = new Point(596, 255);
            TitteliLB.Name = "TitteliLB";
            TitteliLB.Size = new Size(86, 38);
            TitteliLB.TabIndex = 9;
            TitteliLB.Text = "Titteli";
            // 
            // AvainhenkilotForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 481);
            Controls.Add(PuhLB);
            Controls.Add(EmailLB);
            Controls.Add(OsastoLB);
            Controls.Add(TitteliLB);
            Controls.Add(PuhelinLB);
            Controls.Add(PostitoimipaikkaLB);
            Controls.Add(PostinumeroLB);
            Controls.Add(OsoiteLB);
            Controls.Add(vastuuhloCB);
            Controls.Add(label3);
            Controls.Add(oppilaitosCB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AvainhenkilotForm";
            Text = "Oppilaitosten avainhenkilöt";
            Load += AvainhenkilotForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox oppilaitosCB;
        private ComboBox vastuuhloCB;
        private Label label3;
        private Label OsoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label PuhLB;
        private Label EmailLB;
        private Label OsastoLB;
        private Label TitteliLB;
    }
}
