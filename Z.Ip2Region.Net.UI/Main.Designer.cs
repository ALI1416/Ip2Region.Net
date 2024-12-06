namespace Z.Ip2Region.Net.UI
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.initGroupBox = new System.Windows.Forms.GroupBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlLoadBtn = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.fileLoadBtn = new System.Windows.Forms.Button();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.initGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(200, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(182, 27);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "IP地址转区域";
            // 
            // initGroupBox
            // 
            this.initGroupBox.Controls.Add(this.urlTextBox);
            this.initGroupBox.Controls.Add(this.urlLabel);
            this.initGroupBox.Controls.Add(this.urlLoadBtn);
            this.initGroupBox.Controls.Add(this.fileTextBox);
            this.initGroupBox.Controls.Add(this.fileLabel);
            this.initGroupBox.Controls.Add(this.fileSelectBtn);
            this.initGroupBox.Controls.Add(this.fileLoadBtn);
            this.initGroupBox.Location = new System.Drawing.Point(5, 40);
            this.initGroupBox.Name = "initGroupBox";
            this.initGroupBox.Size = new System.Drawing.Size(590, 80);
            this.initGroupBox.TabIndex = 0;
            this.initGroupBox.TabStop = false;
            this.initGroupBox.Text = "初始化";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(45, 20);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(440, 21);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.Text = "https://www.404z.cn/files/ip2region/v3.0.0/data/ip2region.zdb";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(5, 24);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(35, 12);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "URL：";
            // 
            // urlLoadBtn
            // 
            this.urlLoadBtn.Location = new System.Drawing.Point(500, 20);
            this.urlLoadBtn.Name = "urlLoadBtn";
            this.urlLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.urlLoadBtn.TabIndex = 2;
            this.urlLoadBtn.Text = "加载";
            this.urlLoadBtn.UseVisualStyleBackColor = true;
            this.urlLoadBtn.Click += new System.EventHandler(this.UrlLoadBtn_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(45, 50);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(350, 21);
            this.fileTextBox.TabIndex = 3;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(5, 54);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(41, 12);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "文件：";
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(410, 50);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.fileSelectBtn.TabIndex = 4;
            this.fileSelectBtn.Text = "选择文件";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.FileSelectBtn_Click);
            // 
            // fileLoadBtn
            // 
            this.fileLoadBtn.Location = new System.Drawing.Point(500, 50);
            this.fileLoadBtn.Name = "fileLoadBtn";
            this.fileLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.fileLoadBtn.TabIndex = 5;
            this.fileLoadBtn.Text = "加载";
            this.fileLoadBtn.UseVisualStyleBackColor = true;
            this.fileLoadBtn.Click += new System.EventHandler(this.FileLoadBtn_Click);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.ipLabel.Location = new System.Drawing.Point(45, 136);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(98, 27);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP地址";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.ipTextBox.Location = new System.Drawing.Point(160, 130);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(240, 38);
            this.ipTextBox.TabIndex = 6;
            // 
            // queryBtn
            // 
            this.queryBtn.Enabled = false;
            this.queryBtn.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.queryBtn.Location = new System.Drawing.Point(425, 130);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(120, 40);
            this.queryBtn.TabIndex = 7;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.resultTextBox.Location = new System.Drawing.Point(10, 175);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(580, 90);
            this.resultTextBox.TabIndex = 8;
            this.resultTextBox.Text = "国家\t省份\t城市\tISP";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 270);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.initGroupBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP地址转区域";
            this.initGroupBox.ResumeLayout(false);
            this.initGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// 标题Label
        /// </summary>
        private System.Windows.Forms.Label titleLabel;
        /// <summary>
        /// 初始化GroupBox
        /// </summary>
        private System.Windows.Forms.GroupBox initGroupBox;
        /// <summary>
        /// URL Label
        /// </summary>
        private System.Windows.Forms.Label urlLabel;
        /// <summary>
        /// URL TextBox
        /// </summary>
        private System.Windows.Forms.TextBox urlTextBox;
        /// <summary>
        /// 加载URL Button
        /// </summary>
        private System.Windows.Forms.Button urlLoadBtn;
        /// <summary>
        /// 文件Label
        /// </summary>
        private System.Windows.Forms.Label fileLabel;
        /// <summary>
        /// 文件TextBox
        /// </summary>
        private System.Windows.Forms.TextBox fileTextBox;
        /// <summary>
        /// 选择文件Button
        /// </summary>
        private System.Windows.Forms.Button fileSelectBtn;
        /// <summary>
        /// 加载文件Button
        /// </summary>
        private System.Windows.Forms.Button fileLoadBtn;
        /// <summary>
        /// 手机号码Label
        /// </summary>
        private System.Windows.Forms.Label ipLabel;
        /// <summary>
        /// 手机号码TextBox
        /// </summary>
        private System.Windows.Forms.TextBox ipTextBox;
        /// <summary>
        /// 查询Button
        /// </summary>
        private System.Windows.Forms.Button queryBtn;
        /// <summary>
        /// 结果TextBox
        /// </summary>
        private System.Windows.Forms.TextBox resultTextBox;

    }
}
