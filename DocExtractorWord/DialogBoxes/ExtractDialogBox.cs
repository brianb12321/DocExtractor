using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Point = System.Drawing.Point;

namespace DocExtractorWord.DialogBoxes
{
    public partial class ExtractDialogBox : Form
    {
        //private class StyleOption
        //{
        //    public Style Style { get; }
        //    private string LocalizedName => Style.NameLocal;

        //    public StyleOption(Style style)
        //    {
        //        Style = style;
        //    }

        //    public override string ToString()
        //    {
        //        return LocalizedName;
        //    }
        //}

        private StringBuilder _textBuilder;
        public ExtractDialogBox()
        {
            InitializeComponent();
        }

        private void btn_fileSelect_Click(object sender, EventArgs e)
        {
            Point screenPoint = btn_fileSelect.PointToScreen(new Point(btn_fileSelect.Left, btn_fileSelect.Bottom));
            if (screenPoint.Y + ctm_fileOptions.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                ctm_fileOptions.Show(btn_fileSelect, new Point(0, -ctm_fileOptions.Size.Height));
            }
            else
            {
                ctm_fileOptions.Show(btn_fileSelect, new Point(0, btn_fileSelect.Height));
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExtractDialogBox_Load(object sender, EventArgs e)
        {
            _textBuilder = new StringBuilder();
            updateStyleBox();
            rtb_stats.AppendText($"Current Default: {Environment.CurrentDirectory}");
        }

        private void updateStyleBox()
        {
            styleBox.Items.Clear();
            rtb_preview.Text = getText();
            foreach (Style style in Globals.ThisAddIn.Application.ActiveDocument.Styles)
            {
                if (style.Type == WdStyleType.wdStyleTypeParagraph || cb_paragraph.Checked)
                {
                    ListViewItem item = new ListViewItem();
                    item.Group = styleBox.Groups[$"group_{Enum.GetName(typeof(WdStyleType), style.Type)}"];
                    item.Text = style.NameLocal;
                    item.Tag = style;
                    styleBox.Items.Add(item);
                }
            }

            btn_extract.Enabled = false;
        }
        private string getText()
        {
            _textBuilder.Clear();
            if (styleBox.CheckedItems.Count > 0)
            {
                foreach (Paragraph paragraph in Globals.ThisAddIn.Application.ActiveDocument.Paragraphs)
                {
                    Style paragraphStyle = paragraph.get_Style();
                    if (paragraphStyle != null)
                    {
                        foreach (ListViewItem styleItem in styleBox.CheckedItems)
                        {
                            if (paragraphStyle.NameLocal.Equals(styleItem.Text))
                            {
                                _textBuilder.Append(paragraph.Range.Text + "\n");
                                break;
                            }
                        }
                    }
                }
            }
            
            return _textBuilder.ToString();
        }

        private void btn_extract_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(tb_chosenPath.Text, false);
                writer.Write(getText());
                writer.Flush();
                writer.Close();
                MessageBox.Show("Extraction Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Extraction Failed: {exception.Message}", "Failure", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cb_paragraph_CheckedChanged(object sender, EventArgs e)
        {
            updateStyleBox();
        }

        private void styleBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (styleBox.CheckedItems.Count == 0 && e.NewValue == CheckState.Checked)
            {
                btn_extract.Enabled = true;
            }
            else if (styleBox.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked)
            {
                btn_extract.Enabled = false;
            }
            //Delay execution of code
            this.BeginInvoke((MethodInvoker)delegate {
                rtb_preview.Text = getText();
            });
            
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = Properties.Resources.extractFilter;
            dialog.Title = @"Save Extracted File As";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tb_chosenPath.Text = dialog.FileName;
            }
        }

        private void toggleFileInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_chosenPath.Enabled = !tb_chosenPath.Enabled;
        }
    }
}