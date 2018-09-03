namespace WindowsFormsApp8
{
    partial class frmSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJ = new System.Windows.Forms.TextBox();
            this.btnSetJ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.btnP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.btnPName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "设置面板：可以设置怪物数量，人物血条等等";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "怪物数量";
            // 
            // txtJ
            // 
            this.txtJ.Location = new System.Drawing.Point(71, 127);
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(60, 21);
            this.txtJ.TabIndex = 2;
            // 
            // btnSetJ
            // 
            this.btnSetJ.Location = new System.Drawing.Point(138, 124);
            this.btnSetJ.Name = "btnSetJ";
            this.btnSetJ.Size = new System.Drawing.Size(75, 23);
            this.btnSetJ.TabIndex = 3;
            this.btnSetJ.Text = "确定";
            this.btnSetJ.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "人物血量";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(71, 100);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(60, 21);
            this.txtP.TabIndex = 2;
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(138, 97);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 3;
            this.btnP.Text = "确定";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "人物名称";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(72, 73);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(60, 21);
            this.txtPName.TabIndex = 2;
            // 
            // btnPName
            // 
            this.btnPName.Location = new System.Drawing.Point(139, 70);
            this.btnPName.Name = "btnPName";
            this.btnPName.Size = new System.Drawing.Size(75, 23);
            this.btnPName.TabIndex = 3;
            this.btnPName.Text = "确定";
            this.btnPName.UseVisualStyleBackColor = true;
            this.btnPName.Click += new System.EventHandler(this.btnPName_Click);
            // 
            // frmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.btnPName);
            this.Controls.Add(this.btnSetJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSet";
            this.Text = "frmSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJ;
        private System.Windows.Forms.Button btnSetJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Button btnPName;
    }
}