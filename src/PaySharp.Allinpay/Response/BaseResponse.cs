﻿using System;
using PaySharp.Core;
using PaySharp.Core.Request;
using PaySharp.Core.Response;

namespace PaySharp.Allinpay.Response
{
    public abstract class BaseResponse : IResponse
    {
        /// <summary>
        /// 应用编号
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [ReName(Name = "cusid")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户交易单号
        /// </summary>
        [ReName(Name = "reqsn")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [ReName(Name = "trxid")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 渠道平台交易单号
        /// </summary>
        [ReName(Name = "chnltrxid")]
        public string ChannelTradeNo { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [ReName(Name = "randomstr")]
        public string NonceStr { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        /// <remarks>交易的状态,对于刷卡支付，该状态表示实际的支付结果，其他为下单状态</remarks>
        [ReName(Name = "trxstatus")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [ReName(Name = "fintime")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 支付信息
        /// </summary>
        /// <remarks>扫码支付则返回二维码串，js支付则返回json字符串
        /// QQ钱包及云闪付的JS支付返回支付的链接,商户只需跳转到此链接即可完成支付
        /// 支付宝App支付返回支付信息串</remarks>
        public string PayInfo { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// 返回状态码
        /// </summary>
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 错误代码描述
        /// </summary>
        public string ErrMsg { get; set; }

        /// <summary>
        /// 原始值
        /// </summary>
        public string Raw { get; set; }

        internal GatewayData GatewayData { get; set; }

        internal abstract void Execute<TModel, TResponse>(Merchant merchant, Request<TModel, TResponse> request) where TResponse : IResponse;
    }
}
