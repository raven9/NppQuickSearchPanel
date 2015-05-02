﻿namespace NppQuickSearchPanel
{
    partial class frmQuickSearch
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
            this.tlpDlg = new System.Windows.Forms.TableLayoutPanel();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.flpMatchOption = new System.Windows.Forms.FlowLayoutPanel();
            this.chkMatchWord = new System.Windows.Forms.CheckBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkWrap = new System.Windows.Forms.CheckBox();
            this.lblSepLine2 = new System.Windows.Forms.Label();
            this.flpSearchMode = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnNromal = new System.Windows.Forms.RadioButton();
            this.rbtnRegExp = new System.Windows.Forms.RadioButton();
            this.lstEntry = new System.Windows.Forms.ListBox();
            this.tsListMgmt = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveDown = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tlpDlg.SuspendLayout();
            this.flpMatchOption.SuspendLayout();
            this.flpSearchMode.SuspendLayout();
            this.tsListMgmt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDlg
            // 
            this.tlpDlg.ColumnCount = 1;
            this.tlpDlg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDlg.Controls.Add(this.txtKeywords, 0, 2);
            this.tlpDlg.Controls.Add(this.flpMatchOption, 0, 0);
            this.tlpDlg.Controls.Add(this.lblSepLine2, 0, 1);
            this.tlpDlg.Controls.Add(this.flpSearchMode, 0, 3);
            this.tlpDlg.Controls.Add(this.lstEntry, 0, 5);
            this.tlpDlg.Controls.Add(this.tsListMgmt, 0, 4);
            this.tlpDlg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDlg.Location = new System.Drawing.Point(0, 0);
            this.tlpDlg.Name = "tlpDlg";
            this.tlpDlg.RowCount = 6;
            this.tlpDlg.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDlg.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDlg.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDlg.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDlg.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDlg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDlg.Size = new System.Drawing.Size(402, 497);
            this.tlpDlg.TabIndex = 0;
            // 
            // txtKeywords
            // 
            this.txtKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeywords.Location = new System.Drawing.Point(3, 33);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(396, 21);
            this.txtKeywords.TabIndex = 1;
            // 
            // flpMatchOption
            // 
            this.flpMatchOption.AutoSize = true;
            this.flpMatchOption.Controls.Add(this.chkMatchWord);
            this.flpMatchOption.Controls.Add(this.chkMatchCase);
            this.flpMatchOption.Controls.Add(this.chkWrap);
            this.flpMatchOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMatchOption.Location = new System.Drawing.Point(3, 3);
            this.flpMatchOption.Name = "flpMatchOption";
            this.flpMatchOption.Size = new System.Drawing.Size(396, 22);
            this.flpMatchOption.TabIndex = 2;
            // 
            // chkMatchWord
            // 
            this.chkMatchWord.AutoSize = true;
            this.chkMatchWord.Location = new System.Drawing.Point(3, 3);
            this.chkMatchWord.Name = "chkMatchWord";
            this.chkMatchWord.Size = new System.Drawing.Size(84, 16);
            this.chkMatchWord.TabIndex = 0;
            this.chkMatchWord.Text = "Match Word";
            this.chkMatchWord.UseVisualStyleBackColor = true;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(93, 3);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(84, 16);
            this.chkMatchCase.TabIndex = 1;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkWrap
            // 
            this.chkWrap.AutoSize = true;
            this.chkWrap.Checked = true;
            this.chkWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWrap.Location = new System.Drawing.Point(183, 3);
            this.chkWrap.Name = "chkWrap";
            this.chkWrap.Size = new System.Drawing.Size(90, 16);
            this.chkWrap.TabIndex = 2;
            this.chkWrap.Text = "Wrap Search";
            this.chkWrap.UseVisualStyleBackColor = true;
            // 
            // lblSepLine2
            // 
            this.lblSepLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSepLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSepLine2.Location = new System.Drawing.Point(3, 28);
            this.lblSepLine2.Name = "lblSepLine2";
            this.lblSepLine2.Size = new System.Drawing.Size(396, 2);
            this.lblSepLine2.TabIndex = 3;
            // 
            // flpSearchMode
            // 
            this.flpSearchMode.AutoSize = true;
            this.flpSearchMode.Controls.Add(this.rbtnNromal);
            this.flpSearchMode.Controls.Add(this.rbtnRegExp);
            this.flpSearchMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSearchMode.Location = new System.Drawing.Point(3, 60);
            this.flpSearchMode.Name = "flpSearchMode";
            this.flpSearchMode.Size = new System.Drawing.Size(396, 22);
            this.flpSearchMode.TabIndex = 4;
            // 
            // rbtnNromal
            // 
            this.rbtnNromal.AutoSize = true;
            this.rbtnNromal.Checked = true;
            this.rbtnNromal.Location = new System.Drawing.Point(3, 3);
            this.rbtnNromal.Name = "rbtnNromal";
            this.rbtnNromal.Size = new System.Drawing.Size(59, 16);
            this.rbtnNromal.TabIndex = 0;
            this.rbtnNromal.TabStop = true;
            this.rbtnNromal.Text = "Normal";
            this.rbtnNromal.UseVisualStyleBackColor = true;
            // 
            // rbtnRegExp
            // 
            this.rbtnRegExp.AutoSize = true;
            this.rbtnRegExp.Location = new System.Drawing.Point(68, 3);
            this.rbtnRegExp.Name = "rbtnRegExp";
            this.rbtnRegExp.Size = new System.Drawing.Size(131, 16);
            this.rbtnRegExp.TabIndex = 1;
            this.rbtnRegExp.Text = "Regular Expression";
            this.rbtnRegExp.UseVisualStyleBackColor = true;
            // 
            // lstEntry
            // 
            this.lstEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEntry.FormattingEnabled = true;
            this.lstEntry.HorizontalScrollbar = true;
            this.lstEntry.ItemHeight = 12;
            this.lstEntry.Location = new System.Drawing.Point(3, 113);
            this.lstEntry.Name = "lstEntry";
            this.lstEntry.Size = new System.Drawing.Size(396, 381);
            this.lstEntry.TabIndex = 8;
            this.lstEntry.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstEntry_DrawItem);
            this.lstEntry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstEntry_MouseDown);
            // 
            // tsListMgmt
            // 
            this.tsListMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsListMgmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbRemove,
            this.tsbMoveUp,
            this.tsbMoveDown,
            this.tsbImport,
            this.tsbExport});
            this.tsListMgmt.Location = new System.Drawing.Point(0, 85);
            this.tsListMgmt.Name = "tsListMgmt";
            this.tsListMgmt.Size = new System.Drawing.Size(402, 25);
            this.tsListMgmt.TabIndex = 9;
            this.tsListMgmt.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::NppQuickSearchPanel.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "toolStripButton1";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = global::NppQuickSearchPanel.Properties.Resources.delete;
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(23, 22);
            this.tsbRemove.Text = "toolStripButton2";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // tsbMoveUp
            // 
            this.tsbMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveUp.Image = global::NppQuickSearchPanel.Properties.Resources.arrow_down;
            this.tsbMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveUp.Name = "tsbMoveUp";
            this.tsbMoveUp.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveUp.Text = "toolStripButton3";
            this.tsbMoveUp.Click += new System.EventHandler(this.tsbMoveUp_Click);
            // 
            // tsbMoveDown
            // 
            this.tsbMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveDown.Image = global::NppQuickSearchPanel.Properties.Resources.arrow_up;
            this.tsbMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveDown.Name = "tsbMoveDown";
            this.tsbMoveDown.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveDown.Text = "toolStripButton4";
            this.tsbMoveDown.Click += new System.EventHandler(this.tsbMoveDown_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Image = global::NppQuickSearchPanel.Properties.Resources.folder_page_white;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(23, 22);
            this.tsbImport.Text = "toolStripButton5";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = global::NppQuickSearchPanel.Properties.Resources.disk;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(23, 22);
            this.tsbExport.Text = "toolStripButton6";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // frmQuickSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 497);
            this.Controls.Add(this.tlpDlg);
            this.Name = "frmQuickSearch";
            this.Text = "Quick Search Panel";
            this.tlpDlg.ResumeLayout(false);
            this.tlpDlg.PerformLayout();
            this.flpMatchOption.ResumeLayout(false);
            this.flpMatchOption.PerformLayout();
            this.flpSearchMode.ResumeLayout(false);
            this.flpSearchMode.PerformLayout();
            this.tsListMgmt.ResumeLayout(false);
            this.tsListMgmt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDlg;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.FlowLayoutPanel flpMatchOption;
        private System.Windows.Forms.CheckBox chkMatchWord;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkWrap;
        private System.Windows.Forms.Label lblSepLine2;
        private System.Windows.Forms.FlowLayoutPanel flpSearchMode;
        private System.Windows.Forms.RadioButton rbtnNromal;
        private System.Windows.Forms.RadioButton rbtnRegExp;
        private System.Windows.Forms.ListBox lstEntry;
        private System.Windows.Forms.ToolStrip tsListMgmt;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripButton tsbMoveUp;
        private System.Windows.Forms.ToolStripButton tsbMoveDown;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbExport;

    }
}