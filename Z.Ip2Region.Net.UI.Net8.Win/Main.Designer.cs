namespace Z.Ip2Region.Net.UI.Net8.Win
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            initGroupBox = new GroupBox();
            urlTextBox = new TextBox();
            urlLabel = new Label();
            urlLoadBtn = new Button();
            fileTextBox = new TextBox();
            fileLabel = new Label();
            fileSelectBtn = new Button();
            fileLoadBtn = new Button();
            ipLabel = new Label();
            ipTextBox = new TextBox();
            queryBtn = new Button();
            resultTextBox = new TextBox();
            initGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft YaHei UI", 20F);
            titleLabel.Location = new Point(200, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(175, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "IP地址转区域";
            // 
            // initGroupBox
            // 
            initGroupBox.Controls.Add(urlTextBox);
            initGroupBox.Controls.Add(urlLabel);
            initGroupBox.Controls.Add(urlLoadBtn);
            initGroupBox.Controls.Add(fileTextBox);
            initGroupBox.Controls.Add(fileLabel);
            initGroupBox.Controls.Add(fileSelectBtn);
            initGroupBox.Controls.Add(fileLoadBtn);
            initGroupBox.Location = new Point(5, 40);
            initGroupBox.Name = "initGroupBox";
            initGroupBox.Size = new Size(590, 80);
            initGroupBox.TabIndex = 0;
            initGroupBox.TabStop = false;
            initGroupBox.Text = "初始化";
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(45, 20);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(440, 23);
            urlTextBox.TabIndex = 1;
            urlTextBox.Text = "https://www.404z.cn/files/ip2region/v3.0.0/data/ip2region.zdb";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(5, 24);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(43, 17);
            urlLabel.TabIndex = 0;
            urlLabel.Text = "URL：";
            // 
            // urlLoadBtn
            // 
            urlLoadBtn.Location = new Point(500, 20);
            urlLoadBtn.Name = "urlLoadBtn";
            urlLoadBtn.Size = new Size(75, 23);
            urlLoadBtn.TabIndex = 2;
            urlLoadBtn.Text = "加载";
            urlLoadBtn.UseVisualStyleBackColor = true;
            urlLoadBtn.Click += UrlLoadBtn_Click;
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(45, 50);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.Size = new Size(350, 23);
            fileTextBox.TabIndex = 3;
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new Point(5, 54);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(44, 17);
            fileLabel.TabIndex = 0;
            fileLabel.Text = "文件：";
            // 
            // fileSelectBtn
            // 
            fileSelectBtn.Location = new Point(410, 50);
            fileSelectBtn.Name = "fileSelectBtn";
            fileSelectBtn.Size = new Size(75, 23);
            fileSelectBtn.TabIndex = 4;
            fileSelectBtn.Text = "选择文件";
            fileSelectBtn.UseVisualStyleBackColor = true;
            fileSelectBtn.Click += FileSelectBtn_Click;
            // 
            // fileLoadBtn
            // 
            fileLoadBtn.Location = new Point(500, 50);
            fileLoadBtn.Name = "fileLoadBtn";
            fileLoadBtn.Size = new Size(75, 23);
            fileLoadBtn.TabIndex = 5;
            fileLoadBtn.Text = "加载";
            fileLoadBtn.UseVisualStyleBackColor = true;
            fileLoadBtn.Click += FileLoadBtn_Click;
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Font = new Font("Microsoft YaHei UI", 18F);
            ipLabel.Location = new Point(45, 136);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(84, 31);
            ipLabel.TabIndex = 0;
            ipLabel.Text = "IP地址";
            // 
            // ipTextBox
            // 
            ipTextBox.Font = new Font("宋体", 20F, FontStyle.Bold);
            ipTextBox.Location = new Point(160, 130);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(240, 38);
            ipTextBox.TabIndex = 6;
            // 
            // queryBtn
            // 
            queryBtn.Enabled = false;
            queryBtn.Font = new Font("Microsoft YaHei UI", 18F);
            queryBtn.Location = new Point(425, 130);
            queryBtn.Name = "queryBtn";
            queryBtn.Size = new Size(120, 40);
            queryBtn.TabIndex = 7;
            queryBtn.Text = "查询";
            queryBtn.UseVisualStyleBackColor = true;
            queryBtn.Click += QueryBtn_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultTextBox.Font = new Font("Microsoft YaHei UI", 18F);
            resultTextBox.Location = new Point(10, 175);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(580, 90);
            resultTextBox.TabIndex = 8;
            resultTextBox.Text = "国家\t省份\t城市\tISP";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 270);
            Controls.Add(titleLabel);
            Controls.Add(initGroupBox);
            Controls.Add(ipLabel);
            Controls.Add(ipTextBox);
            Controls.Add(queryBtn);
            Controls.Add(resultTextBox);
            Name = "Main";
            StartPosition = FormStartPosition.CenterParent;
            Text = "IP地址转区域";
            initGroupBox.ResumeLayout(false);
            initGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        /// IP地址Label
        /// </summary>
        private System.Windows.Forms.Label ipLabel;
        /// <summary>
        /// IP地址TextBox
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
