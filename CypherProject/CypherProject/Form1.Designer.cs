namespace CypherProject
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playfairAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cypherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDFGVXAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cypherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homophoniscAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cypherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aCAHomophonicAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cypherToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enigmaAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playfairAlgorithmToolStripMenuItem,
            this.aDFGVXAlgorithmToolStripMenuItem,
            this.homophoniscAlgorithmToolStripMenuItem,
            this.aCAHomophonicAlgorithmToolStripMenuItem,
            this.enigmaAlgorithmToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // playfairAlgorithmToolStripMenuItem
            // 
            this.playfairAlgorithmToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.playfairAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cypherToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.playfairAlgorithmToolStripMenuItem.Name = "playfairAlgorithmToolStripMenuItem";
            this.playfairAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.playfairAlgorithmToolStripMenuItem.Text = "Playfair algorithm";
            // 
            // cypherToolStripMenuItem
            // 
            this.cypherToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.cypherToolStripMenuItem.Name = "cypherToolStripMenuItem";
            this.cypherToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cypherToolStripMenuItem.Text = "Cypher";
            this.cypherToolStripMenuItem.Click += new System.EventHandler(this.cypherToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // aDFGVXAlgorithmToolStripMenuItem
            // 
            this.aDFGVXAlgorithmToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.aDFGVXAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cypherToolStripMenuItem1,
            this.decryptToolStripMenuItem1});
            this.aDFGVXAlgorithmToolStripMenuItem.Name = "aDFGVXAlgorithmToolStripMenuItem";
            this.aDFGVXAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.aDFGVXAlgorithmToolStripMenuItem.Text = "ADFGVX algorithm";
            // 
            // cypherToolStripMenuItem1
            // 
            this.cypherToolStripMenuItem1.BackColor = System.Drawing.Color.LightSlateGray;
            this.cypherToolStripMenuItem1.Name = "cypherToolStripMenuItem1";
            this.cypherToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.cypherToolStripMenuItem1.Text = "Cypher";
            this.cypherToolStripMenuItem1.Click += new System.EventHandler(this.cypherToolStripMenuItem1_Click);
            // 
            // decryptToolStripMenuItem1
            // 
            this.decryptToolStripMenuItem1.BackColor = System.Drawing.Color.LightSlateGray;
            this.decryptToolStripMenuItem1.Name = "decryptToolStripMenuItem1";
            this.decryptToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.decryptToolStripMenuItem1.Text = "Decrypt";
            this.decryptToolStripMenuItem1.Click += new System.EventHandler(this.decryptToolStripMenuItem1_Click);
            // 
            // homophoniscAlgorithmToolStripMenuItem
            // 
            this.homophoniscAlgorithmToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.homophoniscAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cypherToolStripMenuItem2,
            this.decryptToolStripMenuItem2});
            this.homophoniscAlgorithmToolStripMenuItem.Name = "homophoniscAlgorithmToolStripMenuItem";
            this.homophoniscAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.homophoniscAlgorithmToolStripMenuItem.Text = "Homophonic algorithm";
            // 
            // cypherToolStripMenuItem2
            // 
            this.cypherToolStripMenuItem2.BackColor = System.Drawing.Color.LightSlateGray;
            this.cypherToolStripMenuItem2.Name = "cypherToolStripMenuItem2";
            this.cypherToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.cypherToolStripMenuItem2.Text = "Cypher";
            this.cypherToolStripMenuItem2.Click += new System.EventHandler(this.cypherToolStripMenuItem2_Click);
            // 
            // decryptToolStripMenuItem2
            // 
            this.decryptToolStripMenuItem2.BackColor = System.Drawing.Color.LightSlateGray;
            this.decryptToolStripMenuItem2.Name = "decryptToolStripMenuItem2";
            this.decryptToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.decryptToolStripMenuItem2.Text = "Decrypt";
            this.decryptToolStripMenuItem2.Click += new System.EventHandler(this.decryptToolStripMenuItem2_Click);
            // 
            // aCAHomophonicAlgorithmToolStripMenuItem
            // 
            this.aCAHomophonicAlgorithmToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.aCAHomophonicAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cypherToolStripMenuItem3,
            this.decryptToolStripMenuItem3});
            this.aCAHomophonicAlgorithmToolStripMenuItem.Name = "aCAHomophonicAlgorithmToolStripMenuItem";
            this.aCAHomophonicAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.aCAHomophonicAlgorithmToolStripMenuItem.Text = "ACA Homophonic algorithm";
            // 
            // cypherToolStripMenuItem3
            // 
            this.cypherToolStripMenuItem3.BackColor = System.Drawing.Color.LightSlateGray;
            this.cypherToolStripMenuItem3.Name = "cypherToolStripMenuItem3";
            this.cypherToolStripMenuItem3.Size = new System.Drawing.Size(216, 26);
            this.cypherToolStripMenuItem3.Text = "Cypher";
            this.cypherToolStripMenuItem3.Click += new System.EventHandler(this.cypherToolStripMenuItem3_Click);
            // 
            // decryptToolStripMenuItem3
            // 
            this.decryptToolStripMenuItem3.BackColor = System.Drawing.Color.LightSlateGray;
            this.decryptToolStripMenuItem3.Name = "decryptToolStripMenuItem3";
            this.decryptToolStripMenuItem3.Size = new System.Drawing.Size(216, 26);
            this.decryptToolStripMenuItem3.Text = "Decrypt";
            this.decryptToolStripMenuItem3.Click += new System.EventHandler(this.decryptToolStripMenuItem3_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // enigmaAlgorithmToolStripMenuItem
            // 
            this.enigmaAlgorithmToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.enigmaAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem});
            this.enigmaAlgorithmToolStripMenuItem.Name = "enigmaAlgorithmToolStripMenuItem";
            this.enigmaAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.enigmaAlgorithmToolStripMenuItem.Text = "Enigma algorithm";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CypherProject.Properties.Resources.programmer_desktop_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 511);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playfairAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cypherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDFGVXAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cypherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homophoniscAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cypherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aCAHomophonicAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cypherToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enigmaAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
    }
}

