/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-04-19
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace AlipaySDKNet.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayDataBillAccountlogApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 支付宝商家账户账务明细查询
        /// </summary>
        /// <remarks>
        /// 为支付宝商家提供支付宝账户的账务流水信息，供对账使用。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">账务流水创建时间的起始范围 (optional)</param>
        /// <param name="endTime">账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="alipayOrderNo">支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="merchantOrderNo">商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="transCode">账务的类型代码，特殊场景下使用 (optional)</param>
        /// <param name="agreementNo">协议授权码，特殊场景下使用 (optional)</param>
        /// <param name="agreementProductCode">协议产品码。特殊场景下使用 (optional)</param>
        /// <param name="billUserId">指定用户做账单查询 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayDataBillAccountlogQueryResponseModel</returns>
        AlipayDataBillAccountlogQueryResponseModel Query(string startTime = default(string), string endTime = default(string), string alipayOrderNo = default(string), string merchantOrderNo = default(string), string pageNo = default(string), string pageSize = default(string), string transCode = default(string), string agreementNo = default(string), string agreementProductCode = default(string), string billUserId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 支付宝商家账户账务明细查询
        /// </summary>
        /// <remarks>
        /// 为支付宝商家提供支付宝账户的账务流水信息，供对账使用。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">账务流水创建时间的起始范围 (optional)</param>
        /// <param name="endTime">账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="alipayOrderNo">支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="merchantOrderNo">商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="transCode">账务的类型代码，特殊场景下使用 (optional)</param>
        /// <param name="agreementNo">协议授权码，特殊场景下使用 (optional)</param>
        /// <param name="agreementProductCode">协议产品码。特殊场景下使用 (optional)</param>
        /// <param name="billUserId">指定用户做账单查询 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayDataBillAccountlogQueryResponseModel</returns>
        ApiResponse<AlipayDataBillAccountlogQueryResponseModel> QueryWithHttpInfo(string startTime = default(string), string endTime = default(string), string alipayOrderNo = default(string), string merchantOrderNo = default(string), string pageNo = default(string), string pageSize = default(string), string transCode = default(string), string agreementNo = default(string), string agreementProductCode = default(string), string billUserId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayDataBillAccountlogApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 支付宝商家账户账务明细查询
        /// </summary>
        /// <remarks>
        /// 为支付宝商家提供支付宝账户的账务流水信息，供对账使用。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">账务流水创建时间的起始范围 (optional)</param>
        /// <param name="endTime">账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="alipayOrderNo">支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="merchantOrderNo">商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="transCode">账务的类型代码，特殊场景下使用 (optional)</param>
        /// <param name="agreementNo">协议授权码，特殊场景下使用 (optional)</param>
        /// <param name="agreementProductCode">协议产品码。特殊场景下使用 (optional)</param>
        /// <param name="billUserId">指定用户做账单查询 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayDataBillAccountlogQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayDataBillAccountlogQueryResponseModel> QueryAsync(string startTime = default(string), string endTime = default(string), string alipayOrderNo = default(string), string merchantOrderNo = default(string), string pageNo = default(string), string pageSize = default(string), string transCode = default(string), string agreementNo = default(string), string agreementProductCode = default(string), string billUserId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 支付宝商家账户账务明细查询
        /// </summary>
        /// <remarks>
        /// 为支付宝商家提供支付宝账户的账务流水信息，供对账使用。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">账务流水创建时间的起始范围 (optional)</param>
        /// <param name="endTime">账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="alipayOrderNo">支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="merchantOrderNo">商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="transCode">账务的类型代码，特殊场景下使用 (optional)</param>
        /// <param name="agreementNo">协议授权码，特殊场景下使用 (optional)</param>
        /// <param name="agreementProductCode">协议产品码。特殊场景下使用 (optional)</param>
        /// <param name="billUserId">指定用户做账单查询 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayDataBillAccountlogQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayDataBillAccountlogQueryResponseModel>> QueryWithHttpInfoAsync(string startTime = default(string), string endTime = default(string), string alipayOrderNo = default(string), string merchantOrderNo = default(string), string pageNo = default(string), string pageSize = default(string), string transCode = default(string), string agreementNo = default(string), string agreementProductCode = default(string), string billUserId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayDataBillAccountlogApi : IAlipayDataBillAccountlogApiSync, IAlipayDataBillAccountlogApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayDataBillAccountlogApi : IAlipayDataBillAccountlogApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillAccountlogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayDataBillAccountlogApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillAccountlogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayDataBillAccountlogApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillAccountlogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayDataBillAccountlogApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillAccountlogApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayDataBillAccountlogApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AlipaySDKNet.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// 支付宝商家账户账务明细查询 为支付宝商家提供支付宝账户的账务流水信息，供对账使用。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">账务流水创建时间的起始范围 (optional)</param>
        /// <param name="endTime">账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="alipayOrderNo">支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="merchantOrderNo">商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="transCode">账务的类型代码，特殊场景下使用 (optional)</param>
        /// <param name="agreementNo">协议授权码，特殊场景下使用 (optional)</param>
        /// <param name="agreementProductCode">协议产品码。特殊场景下使用 (optional)</param>
        /// <param name="billUserId">指定用户做账单查询 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayDataBillAccountlogQueryResponseModel</returns>
        public AlipayDataBillAccountlogQueryResponseModel Query(string startTime = default(string), string endTime = default(string), string alipayOrderNo = default(string), string merchantOrderNo = default(string), string pageNo = default(string), string pageSize = default(string), string transCode = default(string), string agreementNo = default(string), string agreementProductCode = default(string), string billUserId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillAccountlogQueryResponseModel> localVarResponse = QueryWithHttpInfo(startTime, endTime, alipayOrderNo, merchantOrderNo, pageNo, pageSize, transCode, agreementNo, agreementProductCode, billUserId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 支付宝商家账户账务明细查询 为支付宝商家提供支付宝账户的账务流水信息，供对账使用。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">账务流水创建时间的起始范围 (optional)</param>
        /// <param name="endTime">账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="alipayOrderNo">支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="merchantOrderNo">商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="transCode">账务的类型代码，特殊场景下使用 (optional)</param>
        /// <param name="agreementNo">协议授权码，特殊场景下使用 (optional)</param>
        /// <param name="agreementProductCode">协议产品码。特殊场景下使用 (optional)</param>
        /// <param name="billUserId">指定用户做账单查询 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayDataBillAccountlogQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillAccountlogQueryResponseModel> QueryWithHttpInfo(string startTime = default(string), string endTime = default(string), string alipayOrderNo = default(string), string merchantOrderNo = default(string), string pageNo = default(string), string pageSize = default(string), string transCode = default(string), string agreementNo = default(string), string agreementProductCode = default(string), string billUserId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "start_time", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "end_time", endTime));
            }
            if (alipayOrderNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "alipay_order_no", alipayOrderNo));
            }
            if (merchantOrderNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_order_no", merchantOrderNo));
            }
            if (pageNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_no", pageNo));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (transCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "trans_code", transCode));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (agreementProductCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_product_code", agreementProductCode));
            }
            if (billUserId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "bill_user_id", billUserId));
            }

            localVarRequestOptions.Operation = "AlipayDataBillAccountlogApi.Query";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AlipayDataBillAccountlogQueryResponseModel>("/v3/alipay/data/bill/accountlog/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayDataBillAccountlogQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 支付宝商家账户账务明细查询 为支付宝商家提供支付宝账户的账务流水信息，供对账使用。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">账务流水创建时间的起始范围 (optional)</param>
        /// <param name="endTime">账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="alipayOrderNo">支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="merchantOrderNo">商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="transCode">账务的类型代码，特殊场景下使用 (optional)</param>
        /// <param name="agreementNo">协议授权码，特殊场景下使用 (optional)</param>
        /// <param name="agreementProductCode">协议产品码。特殊场景下使用 (optional)</param>
        /// <param name="billUserId">指定用户做账单查询 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayDataBillAccountlogQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayDataBillAccountlogQueryResponseModel> QueryAsync(string startTime = default(string), string endTime = default(string), string alipayOrderNo = default(string), string merchantOrderNo = default(string), string pageNo = default(string), string pageSize = default(string), string transCode = default(string), string agreementNo = default(string), string agreementProductCode = default(string), string billUserId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillAccountlogQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(startTime, endTime, alipayOrderNo, merchantOrderNo, pageNo, pageSize, transCode, agreementNo, agreementProductCode, billUserId, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 支付宝商家账户账务明细查询 为支付宝商家提供支付宝账户的账务流水信息，供对账使用。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">账务流水创建时间的起始范围 (optional)</param>
        /// <param name="endTime">账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="alipayOrderNo">支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="merchantOrderNo">商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="transCode">账务的类型代码，特殊场景下使用 (optional)</param>
        /// <param name="agreementNo">协议授权码，特殊场景下使用 (optional)</param>
        /// <param name="agreementProductCode">协议产品码。特殊场景下使用 (optional)</param>
        /// <param name="billUserId">指定用户做账单查询 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayDataBillAccountlogQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillAccountlogQueryResponseModel>> QueryWithHttpInfoAsync(string startTime = default(string), string endTime = default(string), string alipayOrderNo = default(string), string merchantOrderNo = default(string), string pageNo = default(string), string pageSize = default(string), string transCode = default(string), string agreementNo = default(string), string agreementProductCode = default(string), string billUserId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {

            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "start_time", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "end_time", endTime));
            }
            if (alipayOrderNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "alipay_order_no", alipayOrderNo));
            }
            if (merchantOrderNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_order_no", merchantOrderNo));
            }
            if (pageNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_no", pageNo));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (transCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "trans_code", transCode));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (agreementProductCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_product_code", agreementProductCode));
            }
            if (billUserId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "bill_user_id", billUserId));
            }

            localVarRequestOptions.Operation = "AlipayDataBillAccountlogApi.Query";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayDataBillAccountlogQueryResponseModel>("/v3/alipay/data/bill/accountlog/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
