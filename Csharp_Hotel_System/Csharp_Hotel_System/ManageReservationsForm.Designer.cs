namespace Csharp_Hotel_System
{
    partial class ManageReservationsForm
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
            textBoxReservId = new TextBox();
            label5 = new Label();
            dateTimePickerOUT = new DateTimePicker();
            label4 = new Label();
            dateTimePickerIN = new DateTimePicker();
            label3 = new Label();
            comboBoxRoomNumber = new ComboBox();
            label2 = new Label();
            textBoxClientID = new TextBox();
            label1 = new Label();
            comboBoxRoomType = new ComboBox();
            buttonClear = new Button();
            buttonRemoveReserv = new Button();
            buttonEditReserv = new Button();
            buttonAddReserv = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 102, 0);
            panel5.Controls.Add(textBoxReservId);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(dateTimePickerOUT);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dateTimePickerIN);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(comboBoxRoomNumber);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textBoxClientID);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(comboBoxRoomType);
            panel5.Controls.Add(buttonClear);
            panel5.Controls.Add(buttonRemoveReserv);
            panel5.Controls.Add(buttonEditReserv);
            panel5.Controls.Add(buttonAddReserv);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1115, 615);
            panel5.TabIndex = 5;
            // 
            // textBoxReservId
            // 
            textBoxReservId.Font = new Font("Microsoft Sans Serif", 14F);
            textBoxReservId.Location = new Point(214, 129);
            textBoxReservId.Name = "textBoxReservId";
            textBoxReservId.Size = new Size(254, 39);
            textBoxReservId.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F);
            label5.Location = new Point(63, 132);
            label5.Name = "label5";
            label5.Size = new Size(145, 32);
            label5.TabIndex = 25;
            label5.Text = "Reserv ID:";
            // 
            // dateTimePickerOUT
            // 
            dateTimePickerOUT.CustomFormat = "dd/MM/yyyy";
            dateTimePickerOUT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerOUT.Format = DateTimePickerFormat.Custom;
            dateTimePickerOUT.Location = new Point(214, 368);
            dateTimePickerOUT.Name = "dateTimePickerOUT";
            dateTimePickerOUT.Size = new Size(254, 39);
            dateTimePickerOUT.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F);
            label4.Location = new Point(73, 373);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 23;
            label4.Text = "Date Out:";
            // 
            // dateTimePickerIN
            // 
            dateTimePickerIN.CustomFormat = "dd/MM/yyyy";
            dateTimePickerIN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerIN.Format = DateTimePickerFormat.Custom;
            dateTimePickerIN.Location = new Point(214, 323);
            dateTimePickerIN.Name = "dateTimePickerIN";
            dateTimePickerIN.Size = new Size(254, 39);
            dateTimePickerIN.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.Location = new Point(92, 328);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 21;
            label3.Text = "Date IN:";
            // 
            // comboBoxRoomNumber
            // 
            comboBoxRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomNumber.FormattingEnabled = true;
            comboBoxRoomNumber.Location = new Point(214, 271);
            comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            comboBoxRoomNumber.Size = new Size(254, 46);
            comboBoxRoomNumber.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.Location = new Point(4, 279);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 19;
            label2.Text = "Room Number:";
            // 
            // textBoxClientID
            // 
            textBoxClientID.Font = new Font("Microsoft Sans Serif", 14F);
            textBoxClientID.Location = new Point(214, 174);
            textBoxClientID.Name = "textBoxClientID";
            textBoxClientID.Size = new Size(254, 39);
            textBoxClientID.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.Location = new Point(78, 181);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 17;
            label1.Text = "Client ID:";
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Location = new Point(214, 219);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(254, 46);
            comboBoxRoomType.TabIndex = 16;
            comboBoxRoomType.SelectedIndexChanged += comboBoxRoomType_SelectedIndexChanged;
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
            // buttonRemoveReserv
            // 
            buttonRemoveReserv.Font = new Font("Segoe UI", 12F);
            buttonRemoveReserv.Location = new Point(334, 473);
            buttonRemoveReserv.Name = "buttonRemoveReserv";
            buttonRemoveReserv.Size = new Size(128, 51);
            buttonRemoveReserv.TabIndex = 14;
            buttonRemoveReserv.Text = "Remove";
            buttonRemoveReserv.UseVisualStyleBackColor = true;
            buttonRemoveReserv.Click += buttonRemoveReserv_Click;
            // 
            // buttonEditReserv
            // 
            buttonEditReserv.Font = new Font("Segoe UI", 12F);
            buttonEditReserv.Location = new Point(214, 473);
            buttonEditReserv.Name = "buttonEditReserv";
            buttonEditReserv.Size = new Size(114, 51);
            buttonEditReserv.TabIndex = 13;
            buttonEditReserv.Text = "Edit";
            buttonEditReserv.UseVisualStyleBackColor = true;
            buttonEditReserv.Click += buttonEditReserv_Click;
            // 
            // buttonAddReserv
            // 
            buttonAddReserv.Font = new Font("Segoe UI", 12F);
            buttonAddReserv.Location = new Point(12, 473);
            buttonAddReserv.Name = "buttonAddReserv";
            buttonAddReserv.Size = new Size(196, 51);
            buttonAddReserv.TabIndex = 12;
            buttonAddReserv.Text = "Add Reservation";
            buttonAddReserv.UseVisualStyleBackColor = true;
            buttonAddReserv.Click += buttonAddReserv_Click;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F);
            label7.Location = new Point(41, 227);
            label7.Name = "label7";
            label7.Size = new Size(167, 32);
            label7.TabIndex = 3;
            label7.Text = "Room Type:";
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
            label6.Text = "Manage Reservations";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageReservationsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 615);
            Controls.Add(panel5);
            Name = "ManageReservationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageReservationsForm";
            Load += ManageReservationsForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private ComboBox comboBoxRoomType;
        private Button buttonClear;
        private Button buttonRemoveReserv;
        private Button buttonEditReserv;
        private Button buttonAddReserv;
        private DataGridView dataGridView1;
        private Label label7;
        private Panel panel6;
        private Label label6;
        private TextBox textBoxClientID;
        private Label label1;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePickerIN;
        private ComboBox comboBoxRoomNumber;
        private DateTimePicker dateTimePickerOUT;
        private Label label4;
        private TextBox textBoxReservId;
        private Label label5;
    }
}