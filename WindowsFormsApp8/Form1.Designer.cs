namespace WindowsFormsApp8
{
    partial class Form1
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
            this.btnP = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(118, 10);
            this.btnP.Margin = new System.Windows.Forms.Padding(2);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(70, 50);
            this.btnP.TabIndex = 0;
            this.btnP.Text = "怪兽";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(9, 10);
            this.btnJ.Margin = new System.Windows.Forms.Padding(2);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(105, 72);
            this.btnJ.TabIndex = 1;
            this.btnJ.Text = "奥特曼";
            this.btnJ.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("宋体", 22F);
            this.btnPlay.Location = new System.Drawing.Point(118, 300);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(546, 170);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "开始游戏";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(697, 10);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSet;
    }
}

