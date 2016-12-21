﻿using System;
using System.Threading.Tasks;
using NewLife.Log;

namespace NewLife.Remoting
{
    /// <summary>应用接口客户端接口</summary>
    public interface IApiClient
    {
        /// <summary>服务提供者</summary>
        IServiceProvider Provider { get; set; }

        /// <summary>初始化</summary>
        /// <param name="config"></param>
        /// <returns></returns>
        bool Init(object config);

        /// <summary>打开</summary>
        void Open();

        /// <summary>关闭</summary>
        void Close();

        /// <summary>发送数据</summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<byte[]> SendAsync(byte[] data);

        /// <summary>日志</summary>
        ILog Log { get; set; }
    }
}