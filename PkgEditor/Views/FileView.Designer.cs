﻿namespace PkgEditor.Views
{
  partial class FileView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileView));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.directoryTreeView = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.currentFolderListView = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.imageList2 = new System.Windows.Forms.ImageList(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.directoryTreeView);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.currentFolderListView);
      this.splitContainer1.Size = new System.Drawing.Size(479, 382);
      this.splitContainer1.SplitterDistance = 159;
      this.splitContainer1.TabIndex = 0;
      // 
      // directoryTreeView
      // 
      this.directoryTreeView.ContextMenuStrip = this.contextMenuStrip1;
      this.directoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.directoryTreeView.HideSelection = false;
      this.directoryTreeView.ImageIndex = 1;
      this.directoryTreeView.ImageList = this.imageList1;
      this.directoryTreeView.Location = new System.Drawing.Point(0, 0);
      this.directoryTreeView.Name = "directoryTreeView";
      this.directoryTreeView.SelectedImageIndex = 1;
      this.directoryTreeView.Size = new System.Drawing.Size(159, 382);
      this.directoryTreeView.TabIndex = 0;
      this.directoryTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.DirectoryTreeView_BeforeExpand);
      this.directoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DirectoryTreeView_AfterSelect);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "File_small.png");
      this.imageList1.Images.SetKeyName(1, "Folder_small.png");
      // 
      // currentFolderListView
      // 
      this.currentFolderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.currentFolderListView.ContextMenuStrip = this.contextMenuStrip1;
      this.currentFolderListView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.currentFolderListView.LargeImageList = this.imageList2;
      this.currentFolderListView.Location = new System.Drawing.Point(0, 0);
      this.currentFolderListView.Name = "currentFolderListView";
      this.currentFolderListView.Size = new System.Drawing.Size(316, 382);
      this.currentFolderListView.SmallImageList = this.imageList1;
      this.currentFolderListView.TabIndex = 0;
      this.currentFolderListView.UseCompatibleStateImageBehavior = false;
      this.currentFolderListView.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 200;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Size";
      // 
      // imageList2
      // 
      this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
      this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList2.Images.SetKeyName(0, "File_large.png");
      this.imageList2.Images.SetKeyName(1, "Folder_large.png");
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
      // 
      // extractToolStripMenuItem
      // 
      this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
      this.extractToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.extractToolStripMenuItem.Text = "Extract";
      this.extractToolStripMenuItem.Click += new System.EventHandler(this.ExtractToolStripMenuItem_Click);
      // 
      // FileView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "FileView";
      this.Size = new System.Drawing.Size(479, 382);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView directoryTreeView;
    private System.Windows.Forms.ListView currentFolderListView;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ImageList imageList2;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
  }
}
