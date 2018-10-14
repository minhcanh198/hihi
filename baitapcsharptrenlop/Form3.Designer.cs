namespace baitapcsharptrenlop
{
    partial class Form3
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
            this.tonGiao1 = new baitapcsharptrenlop.TonGiao();
            this.danToc1 = new baitapcsharptrenlop.DanToc();
            this.SuspendLayout();
            // 
            // tonGiao1
            // 
            this.tonGiao1.Location = new System.Drawing.Point(-4, 134);
            this.tonGiao1.Name = "tonGiao1";
            this.tonGiao1.Size = new System.Drawing.Size(207, 63);
            this.tonGiao1.TabIndex = 1;
            // 
            // danToc1
            // 
            this.danToc1.Location = new System.Drawing.Point(12, 23);
            this.danToc1.Name = "danToc1";
            this.danToc1.Size = new System.Drawing.Size(175, 105);
            this.danToc1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 304);
            this.Controls.Add(this.tonGiao1);
            this.Controls.Add(this.danToc1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private DanToc danToc1;
        private TonGiao tonGiao1;
    }
}