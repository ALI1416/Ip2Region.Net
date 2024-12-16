using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;

namespace Z.Ip2Region.Net
{

    /// <summary>
    /// IP地址转区域
    /// <para>@createDate 2024/12/06 11:11:11</para>
    /// <para>@author ALI[ali-k@foxmail.com]</para>
    /// <para>@since 1.0.0</para>
    /// </summary>
    public class Ip2Region
    {

        /// <summary>
        /// 已初始化
        /// </summary>
        private static bool isInit = false;
        /// <summary>
        /// 数据
        /// </summary>
        private static BinaryReader buffer;
        /// <summary>
        /// 二级索引区指针
        /// </summary>
        private static int vector2AreaPtr;
        /// <summary>
        /// 一级索引区指针
        /// </summary>
        private static int vectorAreaPtr;

        /// <summary>
        /// 是否已经初始化
        /// </summary>
        /// <returns>是否已经初始化</returns>
        public static bool initialized()
        {
            return isInit;
        }

        /// <summary>
        /// 通过文件初始化实例
        /// </summary>
        /// <param name="path">文件路径</param>
        public static void initByFile(string path)
        {
            if (isInit)
            {
                throw new Ip2RegionException("已经初始化过了，不可重复初始化！");
            }
            //Console.WriteLine("IP地址转区域初始化：文件路径LOCAL_PATH " + path);
            try
            {
                init(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read));
            }
            catch (Exception e)
            {
                throw new Ip2RegionException("初始化文件异常！", e);
            }
        }

        /// <summary>
        /// 通过URL初始化实例
        /// <para>例如：<code>https://www.404z.cn/files/ip2region/v3.0.0/data/ip2region.zdb</code></para>
        /// </summary>
        /// <param name="url">URL</param>
        public static void initByUrl(string url)
        {
            if (isInit)
            {
                throw new Ip2RegionException("已经初始化过了，不可重复初始化！");
            }
            //Console.WriteLine("IP地址转区域初始化：URL路径URL_PATH " + url);
            try
            {
                init(HttpWebRequest.Create(url).GetResponse().GetResponseStream());
            }
            catch (Exception e)
            {
                throw new Ip2RegionException("初始化文件异常！", e);
            }
        }

        /// <summary>
        /// 初始化实例
        /// </summary>
        /// <param name="stream">压缩的zdb流</param>
        public static void init(Stream stream)
        {
            if (isInit)
            {
                throw new Ip2RegionException("已经初始化过了，不可重复初始化！");
            }
            if (stream == null)
            {
                throw new Ip2RegionException("数据文件为空！");
            }
            try
            {
                // 解压
                ZipArchiveEntry entry = new ZipArchive(stream).Entries[0];
                // 数据
                MemoryStream memoryStream = new MemoryStream();
                ((DeflateStream)entry.Open()).CopyTo(memoryStream);
                memoryStream.Position = 0;
                buffer = new BinaryReader(memoryStream);
                uint crc32OriginValue = buffer.ReadUInt32();
                byte[] bufferCrc32 = new byte[memoryStream.Length - 4];
                buffer.Read(bufferCrc32, 0, bufferCrc32.Length);
                if (crc32OriginValue != Crc32.crc32(bufferCrc32))
                {
                    throw new Ip2RegionException("数据文件校验错误！");
                }
                buffer.BaseStream.Position = 4;
                int version = buffer.ReadInt32();
                buffer.BaseStream.Position = 12;
                vector2AreaPtr = buffer.ReadInt32();
                vectorAreaPtr = buffer.ReadInt32();
                //Console.WriteLine("数据加载成功：版本号VERSION " + version + " ，校验码CRC32 " + crc32OriginValue.ToString("X8"));
                isInit = true;
            }
            catch (Exception e)
            {
                throw new Ip2RegionException("初始化异常！", e);
            }
        }

        /// <summary>
        /// 解析IP地址的区域
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <returns>Region</returns>
        public static Region parse(string ip)
        {
            return parse(ip2uint(ip));
        }

        /// <summary>
        /// 解析IP地址的区域
        /// </summary>
        /// <param name="ip">unit型IP地址</param>
        /// <returns>Region</returns>
        public static Region parse(uint ip)
        {
            if (!isInit)
            {
                throw new Ip2RegionException("未初始化！");
            }

            // 二级索引区
            buffer.BaseStream.Position = vector2AreaPtr + ((ip >> 16) << 2);
            int left = buffer.ReadInt32();
            int right = buffer.ReadInt32();

            // 一级索引区
            if (left == right || left == right - 8)
            {
                buffer.BaseStream.Position = left + 4;
            }
            else
            {
                right -= 8;
                // 二分查找
                uint ipSegments = ip & 0xFFFF;
                while (left <= right)
                {
                    int mid = align((left + right) / 2);
                    // 查找是否匹配到
                    buffer.BaseStream.Position = mid;
                    uint startAndEnd = buffer.ReadUInt32();
                    uint ipSegmentsStart = startAndEnd & 0xFFFF;
                    uint ipSegmentsEnd = startAndEnd >> 16;
                    if (ipSegments < ipSegmentsStart)
                    {
                        right = mid - 8;
                    }
                    else if (ipSegments > ipSegmentsEnd)
                    {
                        left = mid + 8;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // 记录区
            buffer.BaseStream.Position = buffer.ReadInt32();
            byte[] recordValue = buffer.ReadBytes(buffer.ReadByte());
            return new Region(Encoding.UTF8.GetString(recordValue));
        }

        /// <summary>
        /// 字节对齐
        /// </summary>
        /// <param name="pos">位置</param>
        /// <returns>对齐后的位置</returns>
        private static int align(int pos)
        {
            int remain = (pos - vectorAreaPtr) % 8;
            if (pos - vectorAreaPtr < 8)
            {
                return pos - remain;
            }
            else if (remain != 0)
            {
                return pos + 8 - remain;
            }
            else
            {
                return pos;
            }
        }

        /// <summary>
        /// IP地址转uint
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <returns>uint型IP地址</returns>
        public static uint ip2uint(string ip)
        {
            if (ip == null || ip.Length == 0)
            {
                throw new Ip2RegionException("IP地址不能为空！");
            }
            string[] s = ip.Split('.');
            if (s.Length != 4)
            {
                throw new Ip2RegionException("IP地址 " + ip + " 不合法！");
            }
            uint address = 0;
            for (int i = 0; i < 4; i++)
            {
                uint v = uint.Parse(s[i]);
                if (v < 0 || v > 255)
                {
                    throw new Ip2RegionException("IP地址 " + ip + " 不合法！");
                }
                address |= (v << 8 * (3 - i));
            }
            return address;
        }

        /// <summary>
        /// uint转IP地址
        /// </summary>
        /// <param name="ip">uint型IP地址</param>
        /// <returns>IP地址</returns>
        public static string uint2ip(uint ip)
        {
            return ((ip >> 24) & 0xFF) + "." + ((ip >> 16) & 0xFF) + "." + ((ip >> 8) & 0xFF) + "." + (ip & 0xFF);
        }

        /// <summary>
        /// 是合法的IP地址
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <returns>是否合法</returns>
        public static bool isValidIp(string ip)
        {
            if (ip == null || ip.Length == 0)
            {
                return false;
            }
            string[] s = ip.Split('.');
            if (s.Length != 4)
            {
                return false;
            }
            for (int i = 0; i < 4; i++)
            {
                int v = int.Parse(s[i]);
                if (v < 0 || v > 255)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
