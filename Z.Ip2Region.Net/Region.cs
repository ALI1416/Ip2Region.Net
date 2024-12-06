namespace Z.Ip2Region.Net
{

    /// <summary>
    /// 区域
    /// <para>@createDate 2024/12/06 11:11:11</para>
    /// <para>@author ALI[ali-k@foxmail.com]</para>
    /// <para>@since 1.0.0</para>
    /// </summary>
    public class Region
    {

        /// <summary>
        /// 国家
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// ISP
        /// </summary>
        public string isp { get; set; }

        /// <summary>
        /// 构造区域
        /// </summary>
        public Region() { }

        /// <summary>
        /// 构造区域
        /// </summary>
        /// <param name="region">区域字符串</param>
        public Region(string region)
        {
            // 国家|省份|城市|ISP
            string[] s = region.Split('|');
            if (s.Length == 4)
            {
                country = s[0];
                province = s[1];
                city = s[2];
                isp = s[3];
            }
        }

    }
}
