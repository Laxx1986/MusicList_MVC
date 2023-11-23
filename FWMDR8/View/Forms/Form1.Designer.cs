namespace FWMDR8
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
            menuStrip1 = new MenuStrip();
            newMusicToolStripMenuItem = new ToolStripMenuItem();
            browsingToolStripMenuItem = new ToolStripMenuItem();
            böngészésToolStripMenuItem = new ToolStripMenuItem();
            zeneMódosításaToolStripMenuItem = new ToolStripMenuItem();
            musicGridView = new DataGridView();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)musicGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newMusicToolStripMenuItem, browsingToolStripMenuItem, böngészésToolStripMenuItem, zeneMódosításaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(537, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newMusicToolStripMenuItem
            // 
            newMusicToolStripMenuItem.Name = "newMusicToolStripMenuItem";
            newMusicToolStripMenuItem.Size = new Size(78, 20);
            newMusicToolStripMenuItem.Text = "New music";
            newMusicToolStripMenuItem.Click += újZeneHozzáadásaToolStripMenuItem_Click;
            // 
            // browsingToolStripMenuItem
            // 
            browsingToolStripMenuItem.Name = "browsingToolStripMenuItem";
            browsingToolStripMenuItem.Size = new Size(68, 20);
            browsingToolStripMenuItem.Text = "Browsing";
            browsingToolStripMenuItem.Click += browsingToolStripMenuItem_Click;
            // 
            // böngészésToolStripMenuItem
            // 
            böngészésToolStripMenuItem.Name = "böngészésToolStripMenuItem";
            böngészésToolStripMenuItem.Size = new Size(12, 20);
            // 
            // zeneMódosításaToolStripMenuItem
            // 
            zeneMódosításaToolStripMenuItem.Name = "zeneMódosításaToolStripMenuItem";
            zeneMódosításaToolStripMenuItem.Size = new Size(12, 20);
            // 
            // musicGridView
            // 
            musicGridView.AllowUserToAddRows = false;
            musicGridView.AllowUserToDeleteRows = false;
            musicGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            musicGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            musicGridView.Location = new Point(58, 42);
            musicGridView.Name = "musicGridView";
            musicGridView.ReadOnly = true;
            musicGridView.RowTemplate.Height = 25;
            musicGridView.Size = new Size(448, 385);
            musicGridView.TabIndex = 1;
            musicGridView.Visible = false;
            musicGridView.CellContentClick += musicGridView_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(431, 451);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Hide";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 572);
            Controls.Add(button1);
            Controls.Add(musicGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Music";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)musicGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem böngészésToolStripMenuItem;
        private ToolStripMenuItem zeneMódosításaToolStripMenuItem;
        private ToolStripMenuItem newMusicToolStripMenuItem;
        private ToolStripMenuItem browsingToolStripMenuItem;
        private DataGridView musicGridView;
        private Button button1;
    }
}