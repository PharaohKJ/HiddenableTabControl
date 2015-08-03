namespace Sample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.hiddenableTabControl1 = new PhalanXware.HiddenableTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hiddenableTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiddenableTabControl1
            // 
            this.hiddenableTabControl1.Controls.Add(this.tabPage1);
            this.hiddenableTabControl1.Controls.Add(this.tabPage2);
            this.hiddenableTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hiddenableTabControl1.HiddenTab = true;
            this.hiddenableTabControl1.Location = new System.Drawing.Point(0, 0);
            this.hiddenableTabControl1.Name = "hiddenableTabControl1";
            this.hiddenableTabControl1.SelectedIndex = 0;
            this.hiddenableTabControl1.Size = new System.Drawing.Size(282, 253);
            this.hiddenableTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(274, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.hiddenableTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.hiddenableTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PhalanXware.HiddenableTabControl hiddenableTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

