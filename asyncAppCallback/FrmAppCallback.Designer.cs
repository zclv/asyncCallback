namespace asyncAppCallback
{
    partial class FrmAppCallback
    {
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
            this.btnExecu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecu
            // 
            this.btnExecu.Location = new System.Drawing.Point(65, 106);
            this.btnExecu.Name = "btnExecu";
            this.btnExecu.Size = new System.Drawing.Size(235, 100);
            this.btnExecu.TabIndex = 0;
            this.btnExecu.Text = "同步执行多个任务";
            this.btnExecu.UseVisualStyleBackColor = true;
            this.btnExecu.Click += new System.EventHandler(this.btnExecu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 271);
            this.Controls.Add(this.btnExecu);
            this.Name = "Form1";
            this.Text = "异步回调";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecu;
    }
}

