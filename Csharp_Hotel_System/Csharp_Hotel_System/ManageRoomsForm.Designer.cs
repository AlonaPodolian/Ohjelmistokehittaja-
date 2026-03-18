namespace Csharp_Hotel_System
{
    partial class ManageRoomsForm
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
            panel5 = new Panel();
            panel1 = new Panel();
            radioButtonNO = new RadioButton();
            radioButtonYES = new RadioButton();
            label1 = new Label();
            comboBoxRoomType = new ComboBox();
            buttonClear = new Button();
            buttonRemoveRoom = new Button();
            buttonEditRoom = new Button();
            buttonAddRoom = new Button();
            dataGridView1 = new DataGridView();
            textBoxPhone = new TextBox();
            label9 = new Label();
            label7 = new Label();
            textBoxNumber = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 102, 0);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(comboBoxRoomType);
            panel5.Controls.Add(buttonClear);
            panel5.Controls.Add(buttonRemoveRoom);
            panel5.Controls.Add(buttonEditRoom);
            panel5.Controls.Add(buttonAddRoom);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(textBoxPhone);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(textBoxNumber);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1115, 615);
            panel5.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(radioButtonNO);
            panel1.Controls.Add(radioButtonYES);
            panel1.Location = new Point(208, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 48);
            panel1.TabIndex = 19;
            // 
            // radioButtonNO
            // 
            radioButtonNO.AutoSize = true;
            radioButtonNO.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonNO.ForeColor = Color.Red;
            radioButtonNO.Location = new Point(117, 0);
            radioButtonNO.Name = "radioButtonNO";
            radioButtonNO.Size = new Size(85, 42);
            radioButtonNO.TabIndex = 1;
            radioButtonNO.Text = "NO";
            radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonYES
            // 
            radioButtonYES.AutoSize = true;
            radioButtonYES.Checked = true;
            radioButtonYES.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonYES.ForeColor = Color.Green;
            radioButtonYES.Location = new Point(6, 0);
            radioButtonYES.Name = "radioButtonYES";
            radioButtonYES.Size = new Size(90, 42);
            radioButtonYES.TabIndex = 0;
            radioButtonYES.TabStop = true;
            radioButtonYES.Text = "YES";
            radioButtonYES.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.Location = new Point(122, 350);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 17;
            label1.Text = "Free:";
            label1.Click += label1_Click;
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Location = new Point(208, 198);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(254, 46);
            comboBoxRoomType.TabIndex = 16;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(12, 530);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(450, 57);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear Fields";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonRemoveRoom
            // 
            buttonRemoveRoom.Font = new Font("Segoe UI", 12F);
            buttonRemoveRoom.Location = new Point(334, 460);
            buttonRemoveRoom.Name = "buttonRemoveRoom";
            buttonRemoveRoom.Size = new Size(128, 51);
            buttonRemoveRoom.TabIndex = 14;
            buttonRemoveRoom.Text = "Remove";
            buttonRemoveRoom.UseVisualStyleBackColor = true;
            buttonRemoveRoom.Click += buttonRemoveRoom_Click;
            // 
            // buttonEditRoom
            // 
            buttonEditRoom.Font = new Font("Segoe UI", 12F);
            buttonEditRoom.Location = new Point(214, 460);
            buttonEditRoom.Name = "buttonEditRoom";
            buttonEditRoom.Size = new Size(114, 51);
            buttonEditRoom.TabIndex = 13;
            buttonEditRoom.Text = "Edit";
            buttonEditRoom.UseVisualStyleBackColor = true;
            buttonEditRoom.Click += buttonEditRoom_Click;
            // 
            // buttonAddRoom
            // 
            buttonAddRoom.Font = new Font("Segoe UI", 12F);
            buttonAddRoom.Location = new Point(12, 460);
            buttonAddRoom.Name = "buttonAddRoom";
            buttonAddRoom.Size = new Size(196, 51);
            buttonAddRoom.TabIndex = 12;
            buttonAddRoom.Text = "Add New Room";
            buttonAddRoom.UseVisualStyleBackColor = true;
            buttonAddRoom.Click += buttonAddRoom_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(508, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(580, 458);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Microsoft Sans Serif", 14F);
            textBoxPhone.Location = new Point(208, 271);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(254, 39);
            textBoxPhone.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F);
            label9.Location = new Point(97, 274);
            label9.Name = "label9";
            label9.Size = new Size(105, 32);
            label9.TabIndex = 7;
            label9.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F);
            label7.Location = new Point(35, 206);
            label7.Name = "label7";
            label7.Size = new Size(167, 32);
            label7.TabIndex = 3;
            label7.Text = "Room Type:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Font = new Font("Microsoft Sans Serif", 14F);
            textBoxNumber.Location = new Point(208, 130);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(254, 39);
            textBoxNumber.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F);
            label5.Location = new Point(78, 137);
            label5.Name = "label5";
            label5.Size = new Size(124, 32);
            label5.TabIndex = 1;
            label5.Text = "Room N:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(142, 68, 173);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1115, 94);
            panel6.TabIndex = 0;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Arial Narrow", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(1115, 94);
            label6.TabIndex = 0;
            label6.Text = "Manage Rooms";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageRoomsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 615);
            Controls.Add(panel5);
            Name = "ManageRoomsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageRoomsForm";
            Load += ManageRoomsForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button buttonClear;
        private Button buttonRemoveRoom;
        private Button buttonEditRoom;
        private Button buttonAddRoom;
        private DataGridView dataGridView1;
        private TextBox textBoxCountry;
        private Label label10;
        private TextBox textBoxPhone;
        private Label label9;
        private TextBox textBoxLastName;
        private Label label8;
        private Label label7;
        private TextBox textBoxNumber;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Label label1;
        private ComboBox comboBoxRoomType;
        private Panel panel1;
        private RadioButton radioButtonYES;
        private RadioButton radioButtonNO;
    }
}