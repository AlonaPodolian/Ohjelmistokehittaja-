namespace Pizza_Ordering_System
{
    partial class Billing
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label2 = new Label();
            panel2 = new Panel();
            ExtraLargeBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            LargeBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            MediumBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            SmallBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            label1 = new Label();
            OrderBtn = new Button();
            BillDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            QtyTb = new TextBox();
            label3 = new Label();
            PrintBtn = new Button();
            GrdTotalLbl = new Label();
            SettingsBtn = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 930);
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(204, 46);
            label2.Name = "label2";
            label2.Size = new Size(447, 33);
            label2.TabIndex = 5;
            label2.Text = "Pizza Ordering Management System";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(ExtraLargeBtn);
            panel2.Controls.Add(LargeBtn);
            panel2.Controls.Add(MediumBtn);
            panel2.Controls.Add(SmallBtn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(170, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 447);
            panel2.TabIndex = 6;
            // 
            // ExtraLargeBtn
            // 
            ExtraLargeBtn.AutoSize = true;
            ExtraLargeBtn.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ExtraLargeBtn.CheckedState.BorderThickness = 0;
            ExtraLargeBtn.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ExtraLargeBtn.CheckedState.InnerColor = Color.White;
            ExtraLargeBtn.CheckedState.InnerOffset = -4;
            ExtraLargeBtn.Location = new Point(131, 258);
            ExtraLargeBtn.Name = "ExtraLargeBtn";
            ExtraLargeBtn.Size = new Size(161, 33);
            ExtraLargeBtn.TabIndex = 4;
            ExtraLargeBtn.Text = "Extra Large";
            ExtraLargeBtn.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ExtraLargeBtn.UncheckedState.BorderThickness = 2;
            ExtraLargeBtn.UncheckedState.FillColor = Color.Transparent;
            ExtraLargeBtn.UncheckedState.InnerColor = Color.Transparent;
            // 
            // LargeBtn
            // 
            LargeBtn.AutoSize = true;
            LargeBtn.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            LargeBtn.CheckedState.BorderThickness = 0;
            LargeBtn.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            LargeBtn.CheckedState.InnerColor = Color.White;
            LargeBtn.CheckedState.InnerOffset = -4;
            LargeBtn.Location = new Point(131, 208);
            LargeBtn.Name = "LargeBtn";
            LargeBtn.Size = new Size(97, 33);
            LargeBtn.TabIndex = 3;
            LargeBtn.Text = "Large";
            LargeBtn.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            LargeBtn.UncheckedState.BorderThickness = 2;
            LargeBtn.UncheckedState.FillColor = Color.Transparent;
            LargeBtn.UncheckedState.InnerColor = Color.Transparent;
            // 
            // MediumBtn
            // 
            MediumBtn.AutoSize = true;
            MediumBtn.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            MediumBtn.CheckedState.BorderThickness = 0;
            MediumBtn.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            MediumBtn.CheckedState.InnerColor = Color.White;
            MediumBtn.CheckedState.InnerOffset = -4;
            MediumBtn.Location = new Point(131, 154);
            MediumBtn.Name = "MediumBtn";
            MediumBtn.Size = new Size(121, 33);
            MediumBtn.TabIndex = 2;
            MediumBtn.Text = "Medium";
            MediumBtn.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            MediumBtn.UncheckedState.BorderThickness = 2;
            MediumBtn.UncheckedState.FillColor = Color.Transparent;
            MediumBtn.UncheckedState.InnerColor = Color.Transparent;
            // 
            // SmallBtn
            // 
            SmallBtn.AutoSize = true;
            SmallBtn.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            SmallBtn.CheckedState.BorderThickness = 0;
            SmallBtn.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            SmallBtn.CheckedState.InnerColor = Color.White;
            SmallBtn.CheckedState.InnerOffset = -4;
            SmallBtn.Location = new Point(131, 98);
            SmallBtn.Name = "SmallBtn";
            SmallBtn.Size = new Size(97, 33);
            SmallBtn.TabIndex = 1;
            SmallBtn.Text = "Small";
            SmallBtn.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            SmallBtn.UncheckedState.BorderThickness = 2;
            SmallBtn.UncheckedState.FillColor = Color.Transparent;
            SmallBtn.UncheckedState.InnerColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(121, 45);
            label1.Name = "label1";
            label1.Size = new Size(255, 29);
            label1.TabIndex = 0;
            label1.Text = "Please Select  A Pizza";
            // 
            // OrderBtn
            // 
            OrderBtn.BackColor = Color.Green;
            OrderBtn.ForeColor = Color.White;
            OrderBtn.Location = new Point(316, 713);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(256, 64);
            OrderBtn.TabIndex = 8;
            OrderBtn.Text = "Add To Your Order";
            OrderBtn.UseVisualStyleBackColor = false;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // BillDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Green;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BillDGV.ColumnHeadersHeight = 40;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BillDGV.DefaultCellStyle = dataGridViewCellStyle3;
            BillDGV.GridColor = Color.FromArgb(231, 229, 255);
            BillDGV.Location = new Point(822, 121);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersVisible = false;
            BillDGV.RowHeadersWidth = 62;
            BillDGV.Size = new Size(720, 687);
            BillDGV.TabIndex = 9;
            BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BillDGV.ThemeStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BillDGV.ThemeStyle.HeaderStyle.BackColor = Color.Green;
            BillDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BillDGV.ThemeStyle.HeaderStyle.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BillDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillDGV.ThemeStyle.HeaderStyle.Height = 40;
            BillDGV.ThemeStyle.ReadOnly = false;
            BillDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BillDGV.ThemeStyle.RowsStyle.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BillDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BillDGV.ThemeStyle.RowsStyle.Height = 33;
            BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Item";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(1585, 37);
            label4.Name = "label4";
            label4.Size = new Size(41, 44);
            label4.TabIndex = 10;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(368, 661);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(187, 35);
            QtyTb.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14F);
            label3.Location = new Point(358, 622);
            label3.Name = "label3";
            label3.Size = new Size(123, 36);
            label3.TabIndex = 12;
            label3.Text = "Quantity";
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.Green;
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(1136, 824);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(256, 64);
            PrintBtn.TabIndex = 13;
            PrintBtn.Text = "Print Your Order";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // GrdTotalLbl
            // 
            GrdTotalLbl.AutoSize = true;
            GrdTotalLbl.Font = new Font("Trebuchet MS", 14F);
            GrdTotalLbl.Location = new Point(1191, 772);
            GrdTotalLbl.Name = "GrdTotalLbl";
            GrdTotalLbl.Size = new Size(161, 36);
            GrdTotalLbl.TabIndex = 14;
            GrdTotalLbl.Text = "GrdTotalLbl";
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackColor = Color.LightGreen;
            SettingsBtn.ForeColor = Color.Black;
            SettingsBtn.Location = new Point(235, 842);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(232, 46);
            SettingsBtn.TabIndex = 15;
            SettingsBtn.Text = "Set The Prices";
            SettingsBtn.UseVisualStyleBackColor = false;
            SettingsBtn.Click += button3_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(498, 842);
            button1.Name = "button1";
            button1.Size = new Size(229, 46);
            button1.TabIndex = 16;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(204, 842);
            button2.Name = "button2";
            button2.Size = new Size(232, 46);
            button2.TabIndex = 15;
            button2.Text = "Set The Prices";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.ForeColor = Color.White;
            button3.Location = new Point(464, 842);
            button3.Name = "button3";
            button3.Size = new Size(232, 46);
            button3.TabIndex = 16;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1660, 930);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(SettingsBtn);
            Controls.Add(GrdTotalLbl);
            Controls.Add(PrintBtn);
            Controls.Add(label3);
            Controls.Add(QtyTb);
            Controls.Add(label4);
            Controls.Add(BillDGV);
            Controls.Add(OrderBtn);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label2;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2RadioButton MediumBtn;
        private Guna.UI2.WinForms.Guna2RadioButton SmallBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton ExtraLargeBtn;
        private Guna.UI2.WinForms.Guna2RadioButton LargeBtn;
        private Button OrderBtn;
        private Guna.UI2.WinForms.Guna2DataGridView BillDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label4;
        private TextBox QtyTb;
        private Label label3;
        private Button PrintBtn;
        private Label GrdTotalLbl;
        private Button SettingsBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}