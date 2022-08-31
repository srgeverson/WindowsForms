namespace WindowsForms
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThhead = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCRUDNHibernateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCRUDEntityFrameworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCRUDSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ntiWindowsForms = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsWindowsForms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.cmsWindowsForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.fecharToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(737, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThhead,
            this.tsmiCRUDNHibernateToolStripMenuItem,
            this.tsmiCRUDEntityFrameworkToolStripMenuItem,
            this.tsmiCRUDSQLToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(59, 20);
            this.fileMenu.Text = "&Opções";
            // 
            // tsmiThhead
            // 
            this.tsmiThhead.Image = ((System.Drawing.Image)(resources.GetObject("tsmiThhead.Image")));
            this.tsmiThhead.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmiThhead.Name = "tsmiThhead";
            this.tsmiThhead.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiThhead.Size = new System.Drawing.Size(200, 22);
            this.tsmiThhead.Text = "THread";
            this.tsmiThhead.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // tsmiCRUDNHibernateToolStripMenuItem
            // 
            this.tsmiCRUDNHibernateToolStripMenuItem.Name = "tsmiCRUDNHibernateToolStripMenuItem";
            this.tsmiCRUDNHibernateToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tsmiCRUDNHibernateToolStripMenuItem.Text = "CRUD NHibernate";
            this.tsmiCRUDNHibernateToolStripMenuItem.Click += new System.EventHandler(this.consultaNHibernateToolStripMenuItem_Click);
            // 
            // tsmiCRUDEntityFrameworkToolStripMenuItem
            // 
            this.tsmiCRUDEntityFrameworkToolStripMenuItem.Name = "tsmiCRUDEntityFrameworkToolStripMenuItem";
            this.tsmiCRUDEntityFrameworkToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tsmiCRUDEntityFrameworkToolStripMenuItem.Text = "CRUD Entity Framework";
            this.tsmiCRUDEntityFrameworkToolStripMenuItem.Click += new System.EventHandler(this.tsmiCRUDEntityFrameworkToolStripMenuItem_Click);
            // 
            // tsmiCRUDSQLToolStripMenuItem
            // 
            this.tsmiCRUDSQLToolStripMenuItem.Name = "tsmiCRUDSQLToolStripMenuItem";
            this.tsmiCRUDSQLToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tsmiCRUDSQLToolStripMenuItem.Text = "CRUD SQL";
            this.tsmiCRUDSQLToolStripMenuItem.Click += new System.EventHandler(this.tsmiCRUDSQLToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(737, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // ntiWindowsForms
            // 
            this.ntiWindowsForms.ContextMenuStrip = this.cmsWindowsForms;
            this.ntiWindowsForms.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiWindowsForms.Icon")));
            this.ntiWindowsForms.Text = "WindowsForms";
            this.ntiWindowsForms.Visible = true;
            // 
            // cmsWindowsForms
            // 
            this.cmsWindowsForms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.cmsWindowsForms.Name = "cmsWindowsForms";
            this.cmsWindowsForms.Size = new System.Drawing.Size(101, 26);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPrincipal";
            this.Text = "Aplicação Windows Forms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.cmsWindowsForms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiThhead;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem tsmiCRUDNHibernateToolStripMenuItem;
        private ToolStripMenuItem tsmiCRUDEntityFrameworkToolStripMenuItem;
        private ToolStripMenuItem tsmiCRUDSQLToolStripMenuItem;
        private NotifyIcon ntiWindowsForms;
        private ContextMenuStrip cmsWindowsForms;
        private ToolStripMenuItem abrirToolStripMenuItem;
    }
}



