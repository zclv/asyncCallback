namespace asyncApp
{
    partial class FrmAsync
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
            this.lblCount1 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.btnExectue1 = new System.Windows.Forms.Button();
            this.btnExecute2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Location = new System.Drawing.Point(79, 60);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(11, 12);
            this.lblCount1.TabIndex = 0;
            this.lblCount1.Text = "0";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Location = new System.Drawing.Point(79, 94);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(11, 12);
            this.lblCount2.TabIndex = 1;
            this.lblCount2.Text = "0";
            // 
            // btnExectue1
            // 
            this.btnExectue1.Location = new System.Drawing.Point(81, 158);
            this.btnExectue1.Name = "btnExectue1";
            this.btnExectue1.Size = new System.Drawing.Size(75, 23);
            this.btnExectue1.TabIndex = 2;
            this.btnExectue1.Text = "同步执行";
            this.btnExectue1.UseVisualStyleBackColor = true;
            this.btnExectue1.Click += new System.EventHandler(this.btnExectue1_Click);
            // 
            // btnExecute2
            // 
            this.btnExecute2.Location = new System.Drawing.Point(241, 158);
            this.btnExecute2.Name = "btnExecute2";
            this.btnExecute2.Size = new System.Drawing.Size(75, 23);
            this.btnExecute2.TabIndex = 3;
            this.btnExecute2.Text = "异步执行";
            this.btnExecute2.UseVisualStyleBackColor = true;
            this.btnExecute2.Click += new System.EventHandler(this.btnExecute2_Click);
            // 
            // FrmAsync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 277);
            this.Controls.Add(this.btnExecute2);
            this.Controls.Add(this.btnExectue1);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.lblCount1);
            this.Name = "FrmAsync";
            this.Text = "同步执行&异步执行";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Button btnExectue1;
        private System.Windows.Forms.Button btnExecute2;
    }
}

