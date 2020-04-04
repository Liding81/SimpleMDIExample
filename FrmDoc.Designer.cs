namespace SimpleMDIExample
{
   
    partial class FrmDoc
    {
        private int _Num = 1;
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
            this.rTBDoc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTBDoc
            // 
            this.rTBDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBDoc.Location = new System.Drawing.Point(0, 0);
            this.rTBDoc.Name = "rTBDoc";
            this.rTBDoc.Size = new System.Drawing.Size(800, 450);
            this.rTBDoc.TabIndex = 0;
            this.rTBDoc.Text = "";
            // 
            // FrmDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTBDoc);
            this.Name = "FrmDoc";
            this.Text = "FrmDoc";
            this.Load += new System.EventHandler(this.FrmDoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rTBDoc;
    }
}