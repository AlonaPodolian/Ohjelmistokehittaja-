namespace Csharp_Hotel_System
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            menuStrip1 = new MenuStrip();
            manageClientsToolStripMenuItem = new ToolStripMenuItem();
            manageRoomsToolStripMenuItem = new ToolStripMenuItem();
            manageReservationToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageClientsToolStripMenuItem, manageRoomsToolStripMenuItem, manageReservationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(889, 36);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageClientsToolStripMenuItem
            // 
            manageClientsToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageClientsToolStripMenuItem.Name = "manageClientsToolStripMenuItem";
            manageClientsToolStripMenuItem.Size = new Size(162, 32);
            manageClientsToolStripMenuItem.Text = "Manage Clients";
            manageClientsToolStripMenuItem.Click += manageClientsToolStripMenuItem_Click;
            // 
            // manageRoomsToolStripMenuItem
            // 
            manageRoomsToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            manageRoomsToolStripMenuItem.Size = new Size(164, 32);
            manageRoomsToolStripMenuItem.Text = "Manage Rooms";
            manageRoomsToolStripMenuItem.Click += manageRoomsToolStripMenuItem_Click;
            // 
            // manageReservationToolStripMenuItem
            // 
            manageReservationToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            manageReservationToolStripMenuItem.Size = new Size(205, 32);
            manageReservationToolStripMenuItem.Text = "Manage Reservation";
            manageReservationToolStripMenuItem.Click += manageReservationToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(889, 553);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGoldenrod;
            label1.Font = new Font("Linux Biolinum G", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(59, 89);
            label1.Name = "label1";
            label1.Size = new Size(475, 138);
            label1.TabIndex = 4;
            label1.Text = "Welcom to the hotel app.\r\nSelect what you want to\r\ndo from the manu.\r\n";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 589);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Main_Form";
            Text = "Main_Form";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_Form_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageClientsToolStripMenuItem;
        private ToolStripMenuItem manageReservationToolStripMenuItem;
        private ToolStripMenuItem manageRoomsToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
    }
}