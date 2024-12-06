namespace Z.Ip2Region.Net.UI.Net8.Win
{

    /// <summary>
    /// 主界面
    /// </summary>
    public partial class Main : Form
    {

        /// <summary>
        /// 主程序
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置加载状态
        /// </summary>
        /// <param name="status">true开始加载 false加载失败</param>
        private void SetLoadStatus(bool status)
        {
            if (status)
            {
                urlTextBox.ReadOnly = true;
                urlLoadBtn.Enabled = false;
                fileTextBox.ReadOnly = true;
                fileSelectBtn.Enabled = false;
                fileLoadBtn.Enabled = false;
            }
            else
            {
                urlTextBox.ReadOnly = false;
                urlLoadBtn.Enabled = true;
                fileTextBox.ReadOnly = false;
                fileSelectBtn.Enabled = true;
                fileLoadBtn.Enabled = true;
            }
        }

        /// <summary>
        /// 点击加载URL按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UrlLoadBtn_Click(object sender, EventArgs e)
        {
            SetLoadStatus(true);
            try
            {
                Ip2Region.initByUrl(urlTextBox.Text);
            }
            catch (Ip2RegionException e1)
            {
                MessageBox.Show(e1.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetLoadStatus(false);
                return;
            }
            urlLoadBtn.Text = "加载成功";
            queryBtn.Enabled = true;
        }

        /// <summary>
        /// 点击选择文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSelectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// 点击加载文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileLoadBtn_Click(object sender, EventArgs e)
        {
            SetLoadStatus(true);
            try
            {
                Ip2Region.initByFile(fileTextBox.Text);
            }
            catch (Ip2RegionException e1)
            {
                MessageBox.Show(e1.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetLoadStatus(false);
                return;
            }
            fileLoadBtn.Text = "加载成功";
            queryBtn.Enabled = true;
        }

        /// <summary>
        /// 点击查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Region region = Ip2Region.parse(ipTextBox.Text);
                if (region == null)
                {
                    resultTextBox.Text = "未找到";
                }
                else
                {
                    resultTextBox.Text = "国家\t省份\t城市\tISP\r\n" + region.country + "\t" + region.province + "\t" + region.city + "\t" + region.isp;
                }
            }
            catch (Ip2RegionException e1)
            {
                MessageBox.Show(e1.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
