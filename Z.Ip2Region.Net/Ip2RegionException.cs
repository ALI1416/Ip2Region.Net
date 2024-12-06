using System;
using System.Runtime.Serialization;

namespace Z.Ip2Region.Net
{

    /// <summary>
    /// Ip2Region异常
    /// <para>@createDate 2024/12/06 11:11:11</para>
    /// <para>@author ALI[ali-k@foxmail.com]</para>
    /// <para>@since 1.0.0</para>
    /// </summary>
    public class Ip2RegionException : Exception
    {

        /// <summary>
        /// Ip2Region异常
        /// </summary>
        public Ip2RegionException() : base() { }
        /// <summary>
        /// Ip2Region异常
        /// </summary>
        /// <param name="message">详细信息</param>
        public Ip2RegionException(string message) : base(message) { }
        /// <summary>
        /// Ip2Region异常
        /// </summary>
        /// <param name="message">详细信息</param>
        /// <param name="innerException">内部异常</param>
        public Ip2RegionException(string message, Exception innerException) : base(message, innerException) { }
        /// <summary>
        /// Ip2Region异常
        /// </summary>
        /// <param name="info">序列化信息</param>
        /// <param name="context">流上下文</param>
        protected Ip2RegionException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
