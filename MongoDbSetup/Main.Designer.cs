namespace MongoDbSetup
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbSetup = new System.Windows.Forms.ProgressBar();
            this.lb_del_mysql = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbSetup);
            this.groupBox1.Controls.Add(this.lb_del_mysql);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSetup);
            this.groupBox1.Controls.Add(this.lbPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(357, 242);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "安装数据库";
            // 
            // pbSetup
            // 
            this.pbSetup.Location = new System.Drawing.Point(7, 194);
            this.pbSetup.Name = "pbSetup";
            this.pbSetup.Size = new System.Drawing.Size(333, 23);
            this.pbSetup.TabIndex = 8;
            // 
            // lb_del_mysql
            // 
            this.lb_del_mysql.AutoSize = true;
            this.lb_del_mysql.Location = new System.Drawing.Point(249, 114);
            this.lb_del_mysql.Name = "lb_del_mysql";
            this.lb_del_mysql.Size = new System.Drawing.Size(71, 12);
            this.lb_del_mysql.TabIndex = 7;
            this.lb_del_mysql.TabStop = true;
            this.lb_del_mysql.Text = "卸载MongoDb";
            this.lb_del_mysql.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_del_mysql_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(5, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "注:安装前确认当前目录存在db的数据库源目录，且不要带中文";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(53, 97);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(146, 47);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "开始安装";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(15, 24);
            this.lbPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(53, 12);
            this.lbPath.TabIndex = 5;
            this.lbPath.Text = "当前目录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(53, 58);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "27017";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Mongodb秒装器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbSetup;
        private System.Windows.Forms.LinkLabel lb_del_mysql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
    }
}

