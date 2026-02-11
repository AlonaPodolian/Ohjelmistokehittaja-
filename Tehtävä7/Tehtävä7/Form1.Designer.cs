namespace Tehtävä7
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            vastausLB = new Label();
            lainanTB = new TextBox();
            nesteetTB = new TextBox();
            vakuukuksetTB = new TextBox();
            muutTB = new TextBox();
            polttonesteTB = new TextBox();
            pesutTB = new TextBox();
            huollotTB = new TextBox();
            renkaatTB = new TextBox();
            kilometriCB = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 35);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Auton kustannuslaskuri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 106);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 1;
            label2.Text = "Lainan tyhennys korkoineen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 146);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 2;
            label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 190);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 3;
            label4.Text = "Vakuutusmaksut:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 235);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 4;
            label5.Text = "Muut kulut:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 273);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 5;
            label6.Text = "Polttoneste:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 106);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 6;
            label7.Text = "Pesut:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(489, 146);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 7;
            label8.Text = "Huollot:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(489, 190);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 8;
            label9.Text = "Renkaat:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(489, 235);
            label10.Name = "label10";
            label10.Size = new Size(154, 25);
            label10.TabIndex = 9;
            label10.Text = "Kilometriä / vuosi:";
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(56, 325);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(69, 25);
            vastausLB.TabIndex = 10;
            vastausLB.Text = "label11";
            vastausLB.Visible = false;
            //vastausLB.Click += vastausLB_Click;
            // 
            // lainanTB
            // 
            lainanTB.Location = new Point(301, 107);
            lainanTB.Name = "lainanTB";
            lainanTB.Size = new Size(150, 31);
            lainanTB.TabIndex = 11;
            // 
            // nesteetTB
            // 
            nesteetTB.Location = new Point(301, 144);
            nesteetTB.Name = "nesteetTB";
            nesteetTB.Size = new Size(150, 31);
            nesteetTB.TabIndex = 12;
            // 
            // vakuukuksetTB
            // 
            vakuukuksetTB.Location = new Point(301, 184);
            vakuukuksetTB.Name = "vakuukuksetTB";
            vakuukuksetTB.Size = new Size(150, 31);
            vakuukuksetTB.TabIndex = 13;
            // 
            // muutTB
            // 
            muutTB.Location = new Point(301, 229);
            muutTB.Name = "muutTB";
            muutTB.Size = new Size(150, 31);
            muutTB.TabIndex = 14;
            // 
            // polttonesteTB
            // 
            polttonesteTB.Location = new Point(299, 270);
            polttonesteTB.Name = "polttonesteTB";
            polttonesteTB.Size = new Size(150, 31);
            polttonesteTB.TabIndex = 15;
            // 
            // pesutTB
            // 
            pesutTB.Location = new Point(663, 105);
            pesutTB.Name = "pesutTB";
            pesutTB.Size = new Size(150, 31);
            pesutTB.TabIndex = 16;
            // 
            // huollotTB
            // 
            huollotTB.Location = new Point(663, 146);
            huollotTB.Name = "huollotTB";
            huollotTB.Size = new Size(150, 31);
            huollotTB.TabIndex = 17;
            // 
            // renkaatTB
            // 
            renkaatTB.Location = new Point(663, 187);
            renkaatTB.Name = "renkaatTB";
            renkaatTB.Size = new Size(150, 31);
            renkaatTB.TabIndex = 18;
            //renkaatTB.TextChanged += renkaatTB_TextChanged;
            // 
            // kilometriCB
            // 
            kilometriCB.FormattingEnabled = true;
            kilometriCB.Items.AddRange(new object[] { "10000", "15000", "20000", "25000", "30000" });
            kilometriCB.Location = new Point(665, 232);
            kilometriCB.Name = "kilometriCB";
            kilometriCB.Size = new Size(148, 33);
            kilometriCB.TabIndex = 19;
            kilometriCB.SelectedIndexChanged += kilometriCB_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 544);
            Controls.Add(kilometriCB);
            Controls.Add(renkaatTB);
            Controls.Add(huollotTB);
            Controls.Add(pesutTB);
            Controls.Add(polttonesteTB);
            Controls.Add(muutTB);
            Controls.Add(vakuukuksetTB);
            Controls.Add(nesteetTB);
            Controls.Add(lainanTB);
            Controls.Add(vastausLB);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Autokululaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label vastausLB;
        private TextBox lainanTB;
        private TextBox nesteetTB;
        private TextBox vakuukuksetTB;
        private TextBox muutTB;
        private TextBox polttonesteTB;
        private TextBox pesutTB;
        private TextBox huollotTB;
        private TextBox renkaatTB;
        private ComboBox kilometriCB;
    }
}
