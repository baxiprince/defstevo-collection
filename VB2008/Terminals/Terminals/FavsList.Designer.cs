﻿namespace Terminals
{
    partial class FavsList
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FavsTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forcedConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traceRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.rebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.computerManagementMMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableRDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FavsTree
            // 
            this.FavsTree.CausesValidation = false;
            this.FavsTree.ContextMenuStrip = this.contextMenuStrip1;
            this.FavsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavsTree.HideSelection = false;
            this.FavsTree.Location = new System.Drawing.Point(0, 0);
            this.FavsTree.Name = "FavsTree";
            this.FavsTree.Size = new System.Drawing.Size(150, 150);
            this.FavsTree.TabIndex = 0;
            this.FavsTree.DoubleClick += new System.EventHandler(this.FavsTree_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.connectToAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.pingToolStripMenuItem,
            this.dNSToolStripMenuItem,
            this.traceRouteToolStripMenuItem,
            this.tSAdminToolStripMenuItem,
            this.toolStripMenuItem1,
            this.rebootToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.toolStripMenuItem4,
            this.computerManagementMMCToolStripMenuItem,
            this.systemInformationToolStripMenuItem,
            this.enableRDPToolStripMenuItem,
            this.toolStripMenuItem3,
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 314);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forcedConsoleToolStripMenuItem,
            this.newWindowToolStripMenuItem1});
            this.connectToolStripMenuItem.Image = global::Terminals.Properties.Resources.application_lightning;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // forcedConsoleToolStripMenuItem
            // 
            this.forcedConsoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem});
            this.forcedConsoleToolStripMenuItem.Name = "forcedConsoleToolStripMenuItem";
            this.forcedConsoleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.forcedConsoleToolStripMenuItem.Text = "Console";
            this.forcedConsoleToolStripMenuItem.Click += new System.EventHandler(this.forcedConsoleToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem1
            // 
            this.newWindowToolStripMenuItem1.Name = "newWindowToolStripMenuItem1";
            this.newWindowToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.newWindowToolStripMenuItem1.Text = "New Window";
            this.newWindowToolStripMenuItem1.Click += new System.EventHandler(this.newWindowToolStripMenuItem1_Click);
            // 
            // connectToAllToolStripMenuItem
            // 
            this.connectToAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem,
            this.newWindowToolStripMenuItem3});
            this.connectToAllToolStripMenuItem.Image = global::Terminals.Properties.Resources.application_lightning;
            this.connectToAllToolStripMenuItem.Name = "connectToAllToolStripMenuItem";
            this.connectToAllToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.connectToAllToolStripMenuItem.Text = "Connect to All";
            this.connectToAllToolStripMenuItem.Click += new System.EventHandler(this.connectToAllToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem2});
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem2
            // 
            this.newWindowToolStripMenuItem2.Name = "newWindowToolStripMenuItem2";
            this.newWindowToolStripMenuItem2.Size = new System.Drawing.Size(147, 22);
            this.newWindowToolStripMenuItem2.Text = "New Window";
            this.newWindowToolStripMenuItem2.Click += new System.EventHandler(this.newWindowToolStripMenuItem2_Click);
            // 
            // newWindowToolStripMenuItem3
            // 
            this.newWindowToolStripMenuItem3.Name = "newWindowToolStripMenuItem3";
            this.newWindowToolStripMenuItem3.Size = new System.Drawing.Size(147, 22);
            this.newWindowToolStripMenuItem3.Text = "New Window";
            this.newWindowToolStripMenuItem3.Click += new System.EventHandler(this.newWindowToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
            // 
            // dNSToolStripMenuItem
            // 
            this.dNSToolStripMenuItem.Name = "dNSToolStripMenuItem";
            this.dNSToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.dNSToolStripMenuItem.Text = "DNS";
            this.dNSToolStripMenuItem.Click += new System.EventHandler(this.dNSToolStripMenuItem_Click);
            // 
            // traceRouteToolStripMenuItem
            // 
            this.traceRouteToolStripMenuItem.Name = "traceRouteToolStripMenuItem";
            this.traceRouteToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.traceRouteToolStripMenuItem.Text = "Trace Route";
            this.traceRouteToolStripMenuItem.Click += new System.EventHandler(this.traceRouteToolStripMenuItem_Click);
            // 
            // tSAdminToolStripMenuItem
            // 
            this.tSAdminToolStripMenuItem.Name = "tSAdminToolStripMenuItem";
            this.tSAdminToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.tSAdminToolStripMenuItem.Text = "TS Admin";
            this.tSAdminToolStripMenuItem.Click += new System.EventHandler(this.tSAdminToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // rebootToolStripMenuItem
            // 
            this.rebootToolStripMenuItem.Name = "rebootToolStripMenuItem";
            this.rebootToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.rebootToolStripMenuItem.Text = "Reboot";
            this.rebootToolStripMenuItem.Click += new System.EventHandler(this.rebootToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(228, 6);
            // 
            // computerManagementMMCToolStripMenuItem
            // 
            this.computerManagementMMCToolStripMenuItem.Name = "computerManagementMMCToolStripMenuItem";
            this.computerManagementMMCToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.computerManagementMMCToolStripMenuItem.Text = "Computer Management (MMC)";
            this.computerManagementMMCToolStripMenuItem.Click += new System.EventHandler(this.computerManagementMMCToolStripMenuItem_Click);
            // 
            // enableRDPToolStripMenuItem
            // 
            this.enableRDPToolStripMenuItem.Name = "enableRDPToolStripMenuItem";
            this.enableRDPToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.enableRDPToolStripMenuItem.Text = "Enable RDP";
            this.enableRDPToolStripMenuItem.Click += new System.EventHandler(this.enableRDPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(228, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // systemInformationToolStripMenuItem
            // 
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.systemInformationToolStripMenuItem.Text = "System Information";
            this.systemInformationToolStripMenuItem.Click += new System.EventHandler(this.systemInformationToolStripMenuItem_Click);
            // 
            // FavsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FavsTree);
            this.Name = "FavsList";
            this.Load += new System.EventHandler(this.FavsList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FavsTree;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traceRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem enableRDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forcedConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem computerManagementMMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem systemInformationToolStripMenuItem;
    }
}
