using System;

namespace Z.Ip2Region.Net.Test
{

    /// <summary>
    /// 程序入口
    /// </summary>
    public class Program
    {

        private static readonly string path = "D:/ip2region.zdb";
        private static readonly string url = "https://www.404z.cn/files/ip2region/v3.0.0/data/ip2region.zdb";
        private static readonly string ip = "123.132.0.0";

        /// <summary>
        /// 启动类
        /// </summary>
        /// <param name="args">参数</param>
        public static void Main(string[] args)
        {
            //TestByUrl();
            TestByFile();
            //TestUtils();
        }

        /// <summary>
        /// 通过URL初始化
        /// </summary>
        public static void TestByUrl()
        {
            Ip2Region.initByUrl(url);
            Region region = Ip2Region.parse(ip);
            Console.WriteLine(region.country + " " + region.province + " " + region.city + " " + region.isp);
        }

        /// <summary>
        /// 通过文件初始化
        /// </summary>
        public static void TestByFile()
        {
            Ip2Region.initByFile(path);
            Region region = Ip2Region.parse(ip);
            Console.WriteLine(region.country + " " + region.province + " " + region.city + " " + region.isp);
        }

        /// <summary>
        /// 工具
        /// </summary>
        public static void TestUtils()
        {
            Console.WriteLine(Ip2Region.ip2uint(ip));
            Console.WriteLine(Ip2Region.uint2ip(2072248320));
            Console.WriteLine(Ip2Region.isValidIp(ip));
        }

    }
}
