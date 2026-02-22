namespace Tehtävä17
{
    partial class MuistiFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuistiFM));
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            uusiToolStripMenuItem = new ToolStripMenuItem();
            avaaToolStripMenuItem = new ToolStripMenuItem();
            tallennaToolStripMenuItem = new ToolStripMenuItem();
            tallennaNimelläToolStripMenuItem = new ToolStripMenuItem();
            tulostuksenEsikatseluToolStripMenuItem = new ToolStripMenuItem();
            tulostaToolStripMenuItem = new ToolStripMenuItem();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            muokkaaToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            reToolStripMenuItem = new ToolStripMenuItem();
            kopioiToolStripMenuItem = new ToolStripMenuItem();
            leikkaaToolStripMenuItem = new ToolStripMenuItem();
            liitäToolStripMenuItem = new ToolStripMenuItem();
            poistaToolStripMenuItem = new ToolStripMenuItem();
            valitseKaikkiToolStripMenuItem = new ToolStripMenuItem();
            muotoileToolStripMenuItem = new ToolStripMenuItem();
            kirjasinToolStripMenuItem = new ToolStripMenuItem();
            tekstinKorostusToolStripMenuItem = new ToolStripMenuItem();
            tekstinRivittysToolStripMenuItem = new ToolStripMenuItem();
            apuaToolStripMenuItem = new ToolStripMenuItem();
            tietoaToolStripMenuItem = new ToolStripMenuItem();
            rikasTB = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, muokkaaToolStripMenuItem, muotoileToolStripMenuItem, apuaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1063, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uusiToolStripMenuItem, avaaToolStripMenuItem, tallennaToolStripMenuItem, tallennaNimelläToolStripMenuItem, tulostuksenEsikatseluToolStripMenuItem, tulostaToolStripMenuItem, poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(97, 29);
            tiedostoToolStripMenuItem.Text = "&Tiedosto";
            tiedostoToolStripMenuItem.Click += tiedostoToolStripMenuItem_Click;
            // 
            // uusiToolStripMenuItem
            // 
            uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            uusiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            uusiToolStripMenuItem.Size = new Size(289, 34);
            uusiToolStripMenuItem.Text = "Uusi";
            uusiToolStripMenuItem.Click += uusiToolStripMenuItem_Click;
            // 
            // avaaToolStripMenuItem
            // 
            avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            avaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            avaaToolStripMenuItem.Size = new Size(289, 34);
            avaaToolStripMenuItem.Text = "Avaa";
            avaaToolStripMenuItem.Click += avaaToolStripMenuItem_Click;
            // 
            // tallennaToolStripMenuItem
            // 
            tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            tallennaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            tallennaToolStripMenuItem.Size = new Size(289, 34);
            tallennaToolStripMenuItem.Text = "Tallenna";
            tallennaToolStripMenuItem.Click += tallennaToolStripMenuItem_Click;
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            tallennaNimelläToolStripMenuItem.Size = new Size(289, 34);
            tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä...";
            tallennaNimelläToolStripMenuItem.Click += tallennaNimelläToolStripMenuItem_Click;
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            tulostuksenEsikatseluToolStripMenuItem.Size = new Size(289, 34);
            tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            tulostuksenEsikatseluToolStripMenuItem.Click += tulostuksenEsikatseluToolStripMenuItem_Click;
            // 
            // tulostaToolStripMenuItem
            // 
            tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            tulostaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            tulostaToolStripMenuItem.Size = new Size(289, 34);
            tulostaToolStripMenuItem.Text = "Tulosta";
            tulostaToolStripMenuItem.Click += tulostaToolStripMenuItem_Click;
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            poistuToolStripMenuItem.Size = new Size(289, 34);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // muokkaaToolStripMenuItem
            // 
            muokkaaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, reToolStripMenuItem, kopioiToolStripMenuItem, leikkaaToolStripMenuItem, liitäToolStripMenuItem, poistaToolStripMenuItem, valitseKaikkiToolStripMenuItem });
            muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            muokkaaToolStripMenuItem.Size = new Size(101, 29);
            muokkaaToolStripMenuItem.Text = "&Muokkaa";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(276, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // reToolStripMenuItem
            // 
            reToolStripMenuItem.Name = "reToolStripMenuItem";
            reToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            reToolStripMenuItem.Size = new Size(276, 34);
            reToolStripMenuItem.Text = "Redo";
            reToolStripMenuItem.Click += reToolStripMenuItem_Click;
            // 
            // kopioiToolStripMenuItem
            // 
            kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            kopioiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopioiToolStripMenuItem.Size = new Size(276, 34);
            kopioiToolStripMenuItem.Text = "Kopioi";
            kopioiToolStripMenuItem.Click += kopioiToolStripMenuItem_Click;
            // 
            // leikkaaToolStripMenuItem
            // 
            leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            leikkaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            leikkaaToolStripMenuItem.Size = new Size(276, 34);
            leikkaaToolStripMenuItem.Text = "Leikkaa";
            leikkaaToolStripMenuItem.Click += leikkaaToolStripMenuItem_Click;
            // 
            // liitäToolStripMenuItem
            // 
            liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            liitäToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            liitäToolStripMenuItem.Size = new Size(276, 34);
            liitäToolStripMenuItem.Text = "Liitä";
            liitäToolStripMenuItem.Click += liitäToolStripMenuItem_Click;
            // 
            // poistaToolStripMenuItem
            // 
            poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            poistaToolStripMenuItem.Size = new Size(276, 34);
            poistaToolStripMenuItem.Text = "Poista";
            poistaToolStripMenuItem.Click += poistaToolStripMenuItem_Click;
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            valitseKaikkiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            valitseKaikkiToolStripMenuItem.Size = new Size(276, 34);
            valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            valitseKaikkiToolStripMenuItem.Click += valitseKaikkiToolStripMenuItem_Click;
            // 
            // muotoileToolStripMenuItem
            // 
            muotoileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kirjasinToolStripMenuItem, tekstinKorostusToolStripMenuItem, tekstinRivittysToolStripMenuItem });
            muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            muotoileToolStripMenuItem.Size = new Size(99, 29);
            muotoileToolStripMenuItem.Text = "M&uotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            kirjasinToolStripMenuItem.Size = new Size(241, 34);
            kirjasinToolStripMenuItem.Text = "Kirjasin";
            kirjasinToolStripMenuItem.Click += kirjasinToolStripMenuItem_Click;
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            tekstinKorostusToolStripMenuItem.Size = new Size(241, 34);
            tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            tekstinKorostusToolStripMenuItem.Click += tekstinKorostusToolStripMenuItem_Click;
            // 
            // tekstinRivittysToolStripMenuItem
            // 
            tekstinRivittysToolStripMenuItem.Name = "tekstinRivittysToolStripMenuItem";
            tekstinRivittysToolStripMenuItem.Size = new Size(241, 34);
            tekstinRivittysToolStripMenuItem.Text = "Tekstin rivittys";
            tekstinRivittysToolStripMenuItem.Click += tekstinRivittysToolStripMenuItem_Click;
            // 
            // apuaToolStripMenuItem
            // 
            apuaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tietoaToolStripMenuItem });
            apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            apuaToolStripMenuItem.Size = new Size(70, 29);
            apuaToolStripMenuItem.Text = "&Apua";
            apuaToolStripMenuItem.Click += apuaToolStripMenuItem_Click;
            // 
            // tietoaToolStripMenuItem
            // 
            tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            tietoaToolStripMenuItem.Size = new Size(270, 34);
            tietoaToolStripMenuItem.Text = "Tietoa";
            tietoaToolStripMenuItem.Click += tietoaToolStripMenuItem_Click;
            // 
            // rikasTB
            // 
            rikasTB.Dock = DockStyle.Fill;
            rikasTB.Location = new Point(0, 33);
            rikasTB.Name = "rikasTB";
            rikasTB.Size = new Size(1063, 654);
            rikasTB.TabIndex = 1;
            rikasTB.Text = "";
            rikasTB.TextChanged += rikasTB_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // MuistiFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1063, 687);
            Controls.Add(rikasTB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MuistiFM";
            Text = "Muistio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private ToolStripMenuItem tallennaToolStripMenuItem;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem muokkaaToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private RichTextBox rikasTB;
        private ToolStripMenuItem reToolStripMenuItem;
        private ToolStripMenuItem kopioiToolStripMenuItem;
        private ToolStripMenuItem leikkaaToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem poistaToolStripMenuItem;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem kirjasinToolStripMenuItem;
        private ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivittysToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripMenuItem tietoaToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private FontDialog fontDialog1;
    }
}
