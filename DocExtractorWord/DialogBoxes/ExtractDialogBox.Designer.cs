namespace DocExtractorWord.DialogBoxes
{
    partial class ExtractDialogBox
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Body Character", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("List", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Paragraph", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Paragraph Only", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Table", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fileSelect = new System.Windows.Forms.Button();
            this.btn_extract = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_chosenPath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtb_stats = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtb_preview = new System.Windows.Forms.RichTextBox();
            this.cb_paragraph = new System.Windows.Forms.CheckBox();
            this.styleBox = new System.Windows.Forms.ListView();
            this.ctm_styleBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.styleSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_fileOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleFileInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.col_styleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ctm_styleBox.SuspendLayout();
            this.ctm_fileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Style Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Location";
            // 
            // btn_fileSelect
            // 
            this.btn_fileSelect.Location = new System.Drawing.Point(293, 334);
            this.btn_fileSelect.Name = "btn_fileSelect";
            this.btn_fileSelect.Size = new System.Drawing.Size(35, 23);
            this.btn_fileSelect.TabIndex = 4;
            this.btn_fileSelect.Text = "...";
            this.btn_fileSelect.UseVisualStyleBackColor = true;
            this.btn_fileSelect.Click += new System.EventHandler(this.btn_fileSelect_Click);
            // 
            // btn_extract
            // 
            this.btn_extract.Enabled = false;
            this.btn_extract.Location = new System.Drawing.Point(172, 363);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(75, 23);
            this.btn_extract.TabIndex = 5;
            this.btn_extract.Text = "Extract";
            this.btn_extract.UseVisualStyleBackColor = true;
            this.btn_extract.Click += new System.EventHandler(this.btn_extract_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(253, 363);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_chosenPath
            // 
            this.tb_chosenPath.Location = new System.Drawing.Point(82, 336);
            this.tb_chosenPath.Name = "tb_chosenPath";
            this.tb_chosenPath.Size = new System.Drawing.Size(205, 20);
            this.tb_chosenPath.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 407);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 146);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb_stats);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(308, 120);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtb_stats
            // 
            this.rtb_stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_stats.Location = new System.Drawing.Point(3, 3);
            this.rtb_stats.Name = "rtb_stats";
            this.rtb_stats.ReadOnly = true;
            this.rtb_stats.Size = new System.Drawing.Size(302, 114);
            this.rtb_stats.TabIndex = 0;
            this.rtb_stats.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtb_preview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(308, 120);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtb_preview
            // 
            this.rtb_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_preview.Location = new System.Drawing.Point(3, 3);
            this.rtb_preview.Name = "rtb_preview";
            this.rtb_preview.ReadOnly = true;
            this.rtb_preview.Size = new System.Drawing.Size(302, 114);
            this.rtb_preview.TabIndex = 0;
            this.rtb_preview.Text = "";
            // 
            // cb_paragraph
            // 
            this.cb_paragraph.AutoSize = true;
            this.cb_paragraph.Location = new System.Drawing.Point(12, 313);
            this.cb_paragraph.Name = "cb_paragraph";
            this.cb_paragraph.Size = new System.Drawing.Size(161, 17);
            this.cb_paragraph.TabIndex = 9;
            this.cb_paragraph.Text = "Display non-paragraph styles";
            this.cb_paragraph.UseVisualStyleBackColor = true;
            this.cb_paragraph.CheckedChanged += new System.EventHandler(this.cb_paragraph_CheckedChanged);
            // 
            // styleBox
            // 
            this.styleBox.CheckBoxes = true;
            this.styleBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_styleName});
            this.styleBox.ContextMenuStrip = this.ctm_styleBox;
            listViewGroup1.Header = "Body Character";
            listViewGroup1.Name = "group_wdStyleTypeCharacter";
            listViewGroup2.Header = "List";
            listViewGroup2.Name = "group_wdStyleTypeList";
            listViewGroup3.Header = "Paragraph";
            listViewGroup3.Name = "group_wdStyleTypeParagraph";
            listViewGroup4.Header = "Paragraph Only";
            listViewGroup4.Name = "group_wdStyleTypeParagraphOnly";
            listViewGroup5.Header = "Table";
            listViewGroup5.Name = "group_wdStyleTypeTable";
            this.styleBox.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.styleBox.HideSelection = false;
            this.styleBox.Location = new System.Drawing.Point(12, 29);
            this.styleBox.MultiSelect = false;
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(319, 278);
            this.styleBox.TabIndex = 10;
            this.styleBox.UseCompatibleStateImageBehavior = false;
            this.styleBox.View = System.Windows.Forms.View.Details;
            this.styleBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.styleBox_ItemCheck);
            // 
            // ctm_styleBox
            // 
            this.ctm_styleBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleSettingsToolStripMenuItem});
            this.ctm_styleBox.Name = "ctm_styleBox";
            this.ctm_styleBox.Size = new System.Drawing.Size(145, 26);
            // 
            // styleSettingsToolStripMenuItem
            // 
            this.styleSettingsToolStripMenuItem.Name = "styleSettingsToolStripMenuItem";
            this.styleSettingsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.styleSettingsToolStripMenuItem.Text = "Style Settings";
            // 
            // ctm_fileOptions
            // 
            this.ctm_fileOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.toggleFileInputToolStripMenuItem});
            this.ctm_fileOptions.Name = "ctm_fileOptions";
            this.ctm_fileOptions.Size = new System.Drawing.Size(162, 48);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // toggleFileInputToolStripMenuItem
            // 
            this.toggleFileInputToolStripMenuItem.Name = "toggleFileInputToolStripMenuItem";
            this.toggleFileInputToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.toggleFileInputToolStripMenuItem.Text = "Toggle File Input";
            this.toggleFileInputToolStripMenuItem.Click += new System.EventHandler(this.toggleFileInputToolStripMenuItem_Click);
            // 
            // col_styleName
            // 
            this.col_styleName.Text = "Style Name";
            this.col_styleName.Width = 310;
            // 
            // ExtractDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 561);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.cb_paragraph);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_extract);
            this.Controls.Add(this.btn_fileSelect);
            this.Controls.Add(this.tb_chosenPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ExtractDialogBox";
            this.ShowIcon = false;
            this.Text = "Extract Document";
            this.Load += new System.EventHandler(this.ExtractDialogBox_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ctm_styleBox.ResumeLayout(false);
            this.ctm_fileOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fileSelect;
        private System.Windows.Forms.Button btn_extract;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_chosenPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtb_stats;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtb_preview;
        private System.Windows.Forms.CheckBox cb_paragraph;
        private System.Windows.Forms.ListView styleBox;
        private System.Windows.Forms.ContextMenuStrip ctm_styleBox;
        private System.Windows.Forms.ToolStripMenuItem styleSettingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctm_fileOptions;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleFileInputToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader col_styleName;
    }
}