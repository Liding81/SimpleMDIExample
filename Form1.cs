using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace SimpleMDIExample
{
    public partial class Form1 : Form
    {
        public PrintDocument printDocument { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void 粗体ToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRtbFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Bold);
        }

        private void 下划线ToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRtbFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Underline);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            foreach (FontFamily ff in ffs)

                LayoutMdi(MdiLayout.Cascade);
            Text = "多文档文本编辑器";
            WindowState = FormWindowState.Maximized;
        }

        private void 窗口层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            this.窗口层叠ToolStripMenuItem.Checked = true;
            this.水平平铺ToolStripMenuItem.Checked = true;
            this.垂直平铺ToolStripMenuItem.Checked = true;

        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = true;
            this.垂直平铺ToolStripMenuItem.Checked = false;
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = true;
        }

        private void NewDoc()
        {
            FrmDoc fd = new FrmDoc();
            fd.MdiParent = this;
            fd.Text = "文档" + _Num;
            fd.WindowState = FormWindowState.Maximized;
            fd.Show();
            fd.Activate();
            _Num++;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "RTF格式（*.rtf）|*.rtf|文本文件（*.txt）|*.txt|所有文件（*.*）|*.*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;
                    if (openfiledialog1.FilterIndex == 1)
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.RichText);
                    else
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                    ((FrmDoc)this.ActiveMdiChild).Text = openfiledialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            openfiledialog1.Dispose();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                SaveFileDialog savefiledialog1 = new SaveFileDialog();
                savefiledialog1.Filter = "RTF格式(*.rtf)|*.rtf|文本文件(*.txt)|*.txt";
                if (savefiledialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (savefiledialog1.FilterIndex == 1)
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.RichText);
                        else
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile
                                (savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                savefiledialog1.Dispose();
            }

        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (MessageBox.Show("确定要关闭当前文档吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    ((FrmDoc)this.ActiveMdiChild).Close();
            }
        }



        private void 斜体ToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRtbFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Italic);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                foreach (FrmDoc fd in this.MdiChildren)
                    fd.Close();
                Application.Exit();
            }
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                SaveFileDialog savefiledialog1 = new SaveFileDialog();
                savefiledialog1.Filter = "RTF格式(*.rtf)|*.rtf|文本文件(*.txt)|*.txt";
                if (savefiledialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (savefiledialog1.FilterIndex == 1)
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.RichText);
                        else
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile
                                (savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                savefiledialog1.Dispose();
            }
        }

        private void 新建NToolStripButton_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void TSCbBoxFontName_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont = this.fontDialog1.Font;

            }
        }


        private void 复制_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedText != "")
                {
                    ((FrmDoc)this.ActiveMdiChild).rTBDoc.Copy();

                }
            }
        }

        private void 粘贴_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.Paste();
        }

        private void 居中_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void 右侧_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void 左侧_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "RTF格式（*.rtf）|*.rtf|文本文件（*.txt）|*.txt|所有文件（*.*）|*.*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;
                    if (openfiledialog1.FilterIndex == 1)
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.RichText);
                    else
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                    ((FrmDoc)this.ActiveMdiChild).Text = openfiledialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            openfiledialog1.Dispose();
        }

        private void 剪切_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedText != "")
                {
                    ((FrmDoc)this.ActiveMdiChild).rTBDoc.Cut();

                }
            }
        }


        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            RichTextBox rtbInfo = ((FrmDoc)this.ActiveMdiChild).rTBDoc;
            rtbInfo.Undo();
        }



        private void TSCbBoxFontName_Click_1(object sender, EventArgs e)
        {
            try
            {
                FontDialog fd = new FontDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    FrmDoc f = (FrmDoc)this.ActiveMdiChild;
                    f.rTBDoc.SelectionFont = fd.Font;
                }
            }
            catch { }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectAll();
        }

        private void 颜色_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionColor = colorDialog1.Color;
        }
        private void ChangeRtbFontStyle(RichTextBox rtb, FontStyle style)
        {
            if (style != FontStyle.Bold && style != FontStyle.Italic && style != FontStyle.Underline)
                throw new System.InvalidProgramException("字体格式错误");
            RichTextBox tempRTB = new RichTextBox();
            int curRtbStart = rtb.SelectionStart;
            int len = rtb.SelectionLength;
            int tempRtbsTart = 0;
            Font font = rtb.SelectionFont;
            if (len <= 0 && font != null)
            {
                if (style == FontStyle.Bold && font.Bold || style == FontStyle.Italic && font.Italic || style == FontStyle.Underline && font.Underline)
                    rtb.Font = new Font(font, font.Style ^ style);
                return;
            }
            tempRTB.Rtf = rtb.SelectedRtf;
            tempRTB.Select(len - 1, 1);
            Font tempFont = (Font)tempRTB.SelectionFont.Clone();
            for (int i = 0; i < len; i++)
            {
                tempRTB.Select(tempRtbsTart + i, 1);
                if (style == FontStyle.Bold && tempFont.Bold || style == FontStyle.Italic && tempFont.Italic || style == FontStyle.Underline && tempFont.Underline)
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style ^ style);
                else

                if (style == FontStyle.Bold && !tempFont.Bold || style == FontStyle.Italic && !tempFont.Italic || style == FontStyle.Underline && !tempFont.Underline)
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style | style);

            }
            tempRTB.Select(tempRtbsTart, len);
            rtb.SelectedRtf = tempRTB.SelectedRtf;
            rtb.Select(curRtbStart, len);
            rtb.Focus();
            tempRTB.Dispose();
        }
        int FindPostion;
        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search cc = new Search();
            this.AddOwnedForm(cc);
            cc.Show();
        }
        FrmDoc doc;
        public void FindRichTextBoxString(string FindString, bool b)
        {
            FindPostion = 0;
            try
            {
                doc = (FrmDoc)this.ActiveMdiChild;
                if (FindPostion >= doc.rTBDoc.Text.Length)//已查到文本底部
                {
                    MessageBox.Show("已搜索完毕。", "提示", MessageBoxButtons.OK);
                    FindPostion = 0;

                    return;
                }//下边语句进行查找，返回找到的位置，返回-1，表示未找到，参数1是要找的字符串
                //参数2是查找的开始位置，参数3是查找的一些选项，如大小写是否匹配，查找方向等
                if (b)
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.None);

                }
                else
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.MatchCase);
                }
                if (FindPostion == -1)//如果未找到
                {
                    MessageBox.Show("已到文本底部,再次查找将从文本开始处查找",
                "提示", MessageBoxButtons.OK);
                    FindPostion = 0;//下次查找的开始位置
                                    // return false;
                }
                else//已找到
                {
                    doc.rTBDoc.Focus();//主窗体成为注视窗口
                    FindPostion += FindString.Length;
                }//下次查找的开始位置在此次找到字符串之后
            }
            catch { }
        }


 
        public void replacertbs(string FindString, string repstring, bool b)
        {
            doc = (FrmDoc)this.ActiveMdiChild;
            if ((FindString != "") == (doc.rTBDoc.SelectedText != ""))
            {
                doc.rTBDoc.SelectedText = repstring;
            }
            else
            {
                if (FindPostion >= doc.rTBDoc.Text.Length)//已查到文本底部
                {
                    MessageBox.Show("已搜索完毕。", "提示", MessageBoxButtons.OK);
                    FindPostion = 0;
                    return;
                }//下边语句进行查找，返回找到的位置，返回-1，表示未找到，参数1是要找的字符串
                //参数2是查找的开始位置，参数3是查找的一些选项，如大小写是否匹配，查找方向等
                if (b)
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.None);

                }
                else
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.MatchCase);
                }
                if (FindPostion == -1)//如果未找到
                {
                    MessageBox.Show("搜索完毕。",
                "提示", MessageBoxButtons.OK);
                    FindPostion = 0;//下次查找的开始位置
                }
                else//已找到
                {
                    doc.rTBDoc.Focus();
                    doc.rTBDoc.SelectedText = repstring;//主窗体成为注视窗口
                    FindPostion += FindString.Length;
                }//下次查找的开始位置在此次找到字符串之后
            }
        }


    }

}
