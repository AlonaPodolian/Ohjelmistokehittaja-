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
            menuStrip1 = new MenuStrip();
            manageClientsToolStripMenuItem = new ToolStripMenuItem();
            manageRoomsToolStripMenuItem = new ToolStripMenuItem();
            manageReservationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageClientsToolStripMenuItem, manageRoomsToolStripMenuItem, manageReservationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(889, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageClientsToolStripMenuItem
            // 
            manageClientsToolStripMenuItem.Name = "manageClientsToolStripMenuItem";
            manageClientsToolStripMenuItem.Size = new Size(149, 29);
            manageClientsToolStripMenuItem.Text = "Manage Clients";
            manageClientsToolStripMenuItem.Click += manageClientsToolStripMenuItem_Click;
            // 
            // manageRoomsToolStripMenuItem
            // 
            manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            manageRoomsToolStripMenuItem.Size = new Size(153, 29);
            manageRoomsToolStripMenuItem.Text = "Manage Rooms";
            manageRoomsToolStripMenuItem.Click += manageRoomsToolStripMenuItem_Click;
            // 
            // manageReservationToolStripMenuItem
            // 
            manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            manageReservationToolStripMenuItem.Size = new Size(188, 29);
            manageReservationToolStripMenuItem.Text = "Manage Reservation";
            manageReservationToolStripMenuItem.Click += manageReservationToolStripMenuItem_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 589);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Main_Form";
            Text = "Main_Form";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_Form_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageClientsToolStripMenuItem;
        private ToolStripMenuItem manageReservationToolStripMenuItem;
        private ToolStripMenuItem manageRoomsToolStripMenuItem;
    }
}