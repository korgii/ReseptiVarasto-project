namespace Reseptivarasto
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiReseptiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaReseptiäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selaaReseptejäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiReseptiToolStripMenuItem,
            this.muokkaaReseptiäToolStripMenuItem,
            this.selaaReseptejäToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiReseptiToolStripMenuItem
            // 
            this.uusiReseptiToolStripMenuItem.Name = "uusiReseptiToolStripMenuItem";
            this.uusiReseptiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.uusiReseptiToolStripMenuItem.Text = "Uusi resepti";
            this.uusiReseptiToolStripMenuItem.Click += new System.EventHandler(this.uusiReseptiToolStripMenuItem_Click);
            // 
            // muokkaaReseptiäToolStripMenuItem
            // 
            this.muokkaaReseptiäToolStripMenuItem.Name = "muokkaaReseptiäToolStripMenuItem";
            this.muokkaaReseptiäToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.muokkaaReseptiäToolStripMenuItem.Text = "Muokkaa reseptiä";
            this.muokkaaReseptiäToolStripMenuItem.Click += new System.EventHandler(this.muokkaaReseptiäToolStripMenuItem_Click);
            // 
            // selaaReseptejäToolStripMenuItem
            // 
            this.selaaReseptejäToolStripMenuItem.Name = "selaaReseptejäToolStripMenuItem";
            this.selaaReseptejäToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.selaaReseptejäToolStripMenuItem.Text = "Selaa reseptejä";
            this.selaaReseptejäToolStripMenuItem.Click += new System.EventHandler(this.selaaReseptejäToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 407);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(392, 407);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(604, 464);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reseptivarasto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muokkaaReseptiäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selaaReseptejäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiReseptiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

