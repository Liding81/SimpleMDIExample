using System;

namespace SimpleMDIExample

{
    partial class Form1
    {
        private int _Num = 1;

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分割线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.页面属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新建NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.打开OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSCbBoxFontName = new System.Windows.Forms.ToolStripButton();
            this.颜色 = new System.Windows.Forms.ToolStripButton();
            this.粗体ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.斜体ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.下划线ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.左侧 = new System.Windows.Forms.ToolStripButton();
            this.居中 = new System.Windows.Forms.ToolStripButton();
            this.右侧 = new System.Windows.Forms.ToolStripButton();
            this.复制 = new System.Windows.Forms.ToolStripButton();
            this.粘贴 = new System.Windows.Forms.ToolStripButton();
            this.剪切 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.全选ToolStripMenuItem,
            this.查找ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.页面属性ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.分割线ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 分割线ToolStripMenuItem
            // 
            this.分割线ToolStripMenuItem.Name = "分割线ToolStripMenuItem";
            this.分割线ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.分割线ToolStripMenuItem.Text = "—————";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口层叠ToolStripMenuItem,
            this.水平平铺ToolStripMenuItem,
            this.垂直平铺ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 窗口层叠ToolStripMenuItem
            // 
            this.窗口层叠ToolStripMenuItem.Name = "窗口层叠ToolStripMenuItem";
            this.窗口层叠ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.窗口层叠ToolStripMenuItem.Text = "窗口层叠";
            this.窗口层叠ToolStripMenuItem.Click += new System.EventHandler(this.窗口层叠ToolStripMenuItem_Click);
            // 
            // 水平平铺ToolStripMenuItem
            // 
            this.水平平铺ToolStripMenuItem.Name = "水平平铺ToolStripMenuItem";
            this.水平平铺ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.水平平铺ToolStripMenuItem.Text = "水平平铺";
            this.水平平铺ToolStripMenuItem.Click += new System.EventHandler(this.水平平铺ToolStripMenuItem_Click);
            // 
            // 垂直平铺ToolStripMenuItem
            // 
            this.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem";
            this.垂直平铺ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.垂直平铺ToolStripMenuItem.Text = "垂直平铺";
            this.垂直平铺ToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 页面属性ToolStripMenuItem
            // 
            this.页面属性ToolStripMenuItem.Name = "页面属性ToolStripMenuItem";
            this.页面属性ToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripButton,
            this.打开OToolStripButton,
            this.保存SToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.tSCbBoxFontName,
            this.颜色,
            this.粗体ToolStripButton,
            this.斜体ToolStripButton,
            this.下划线ToolStripButton,
            this.左侧,
            this.居中,
            this.右侧,
            this.复制,
            this.粘贴,
            this.剪切,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 新建NToolStripButton
            // 
            this.新建NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新建NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripButton.Image")));
            this.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripButton.Name = "新建NToolStripButton";
            this.新建NToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.新建NToolStripButton.Text = "新建(&N)";
            this.新建NToolStripButton.Click += new System.EventHandler(this.新建NToolStripButton_Click);
            // 
            // 打开OToolStripButton
            // 
            this.打开OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripButton.Image")));
            this.打开OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripButton.Name = "打开OToolStripButton";
            this.打开OToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.打开OToolStripButton.Text = "打开(&O)";
            this.打开OToolStripButton.Click += new System.EventHandler(this.打开OToolStripButton_Click);
            // 
            // 保存SToolStripButton
            // 
            this.保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripButton.Image")));
            this.保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripButton.Name = "保存SToolStripButton";
            this.保存SToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.保存SToolStripButton.Text = "保存(&S)";
            this.保存SToolStripButton.Click += new System.EventHandler(this.保存SToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tSCbBoxFontName
            // 
            this.tSCbBoxFontName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSCbBoxFontName.Image = ((System.Drawing.Image)(resources.GetObject("tSCbBoxFontName.Image")));
            this.tSCbBoxFontName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSCbBoxFontName.Name = "tSCbBoxFontName";
            this.tSCbBoxFontName.Size = new System.Drawing.Size(29, 24);
            this.tSCbBoxFontName.Text = "字体";
            this.tSCbBoxFontName.Click += new System.EventHandler(this.TSCbBoxFontName_Click_1);
            // 
            // 颜色
            // 
            this.颜色.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.颜色.Image = ((System.Drawing.Image)(resources.GetObject("颜色.Image")));
            this.颜色.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.颜色.Name = "颜色";
            this.颜色.Size = new System.Drawing.Size(29, 24);
            this.颜色.Text = "颜色";
            this.颜色.Click += new System.EventHandler(this.颜色_Click);
            // 
            // 粗体ToolStripButton
            // 
            this.粗体ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粗体ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粗体ToolStripButton.Image")));
            this.粗体ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粗体ToolStripButton.Name = "粗体ToolStripButton";
            this.粗体ToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.粗体ToolStripButton.Text = "toolStripButton1";
            this.粗体ToolStripButton.ToolTipText = "加粗";
            this.粗体ToolStripButton.Click += new System.EventHandler(this.粗体ToolStripButton_Click);
            // 
            // 斜体ToolStripButton
            // 
            this.斜体ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.斜体ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("斜体ToolStripButton.Image")));
            this.斜体ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.斜体ToolStripButton.Name = "斜体ToolStripButton";
            this.斜体ToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.斜体ToolStripButton.Text = "toolStripButton2";
            this.斜体ToolStripButton.ToolTipText = "斜体";
            this.斜体ToolStripButton.Click += new System.EventHandler(this.斜体ToolStripButton_Click);
            // 
            // 下划线ToolStripButton
            // 
            this.下划线ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.下划线ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("下划线ToolStripButton.Image")));
            this.下划线ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.下划线ToolStripButton.Name = "下划线ToolStripButton";
            this.下划线ToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.下划线ToolStripButton.Text = "toolStripButton3";
            this.下划线ToolStripButton.ToolTipText = "下划线";
            this.下划线ToolStripButton.Click += new System.EventHandler(this.下划线ToolStripButton_Click);
            // 
            // 左侧
            // 
            this.左侧.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.左侧.Image = ((System.Drawing.Image)(resources.GetObject("左侧.Image")));
            this.左侧.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.左侧.Name = "左侧";
            this.左侧.Size = new System.Drawing.Size(29, 24);
            this.左侧.Text = "左对齐";
            this.左侧.Click += new System.EventHandler(this.左侧_Click);
            // 
            // 居中
            // 
            this.居中.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.居中.Image = ((System.Drawing.Image)(resources.GetObject("居中.Image")));
            this.居中.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.居中.Name = "居中";
            this.居中.Size = new System.Drawing.Size(29, 24);
            this.居中.Text = "居中";
            this.居中.Click += new System.EventHandler(this.居中_Click);
            // 
            // 右侧
            // 
            this.右侧.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.右侧.Image = ((System.Drawing.Image)(resources.GetObject("右侧.Image")));
            this.右侧.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.右侧.Name = "右侧";
            this.右侧.Size = new System.Drawing.Size(29, 24);
            this.右侧.Text = "右对齐";
            this.右侧.Click += new System.EventHandler(this.右侧_Click);
            // 
            // 复制
            // 
            this.复制.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制.Image = ((System.Drawing.Image)(resources.GetObject("复制.Image")));
            this.复制.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制.Name = "复制";
            this.复制.Size = new System.Drawing.Size(29, 24);
            this.复制.Text = "复制";
            this.复制.Click += new System.EventHandler(this.复制_Click);
            // 
            // 粘贴
            // 
            this.粘贴.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粘贴.Image = ((System.Drawing.Image)(resources.GetObject("粘贴.Image")));
            this.粘贴.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴.Name = "粘贴";
            this.粘贴.Size = new System.Drawing.Size(29, 24);
            this.粘贴.Text = "粘贴";
            this.粘贴.Click += new System.EventHandler(this.粘贴_Click);
            // 
            // 剪切
            // 
            this.剪切.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪切.Image = ((System.Drawing.Image)(resources.GetObject("剪切.Image")));
            this.剪切.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切.Name = "剪切";
            this.剪切.Size = new System.Drawing.Size(29, 24);
            this.剪切.Text = "剪切";
            this.剪切.Click += new System.EventHandler(this.剪切_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "撤销";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.查找ToolStripMenuItem.Text = "查找替换";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 476);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "简单多文档文本编译器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 新建NToolStripButton;
        private System.Windows.Forms.ToolStripButton 打开OToolStripButton;
        private System.Windows.Forms.ToolStripButton 保存SToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 粗体ToolStripButton;
        private System.Windows.Forms.ToolStripButton 斜体ToolStripButton;
        private System.Windows.Forms.ToolStripButton 下划线ToolStripButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分割线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口层叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton 复制;
        private System.Windows.Forms.ToolStripButton 粘贴;
        private System.Windows.Forms.ToolStripButton 居中;
        private System.Windows.Forms.ToolStripButton 右侧;
        private System.Windows.Forms.ToolStripButton 左侧;
        private System.Windows.Forms.ToolStripButton 剪切;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tSCbBoxFontName;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripButton 颜色;
        private System.Windows.Forms.ToolStripMenuItem 页面属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
    }
}

