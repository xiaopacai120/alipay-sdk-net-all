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
    public interface IAlipayMarketingCardActivateformApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 查询用户提交的会员卡表单信息
        /// </summary>
        /// <remarks>
        /// 会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="bizType">开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional)</param>
        /// <param name="templateId">会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional)</param>
        /// <param name="requestId">查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardActivateformQueryResponseModel</returns>
        AlipayMarketingCardActivateformQueryResponseModel Query(string authToken = default(string), string bizType = default(string), string templateId = default(string), string requestId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询用户提交的会员卡表单信息
        /// </summary>
        /// <remarks>
        /// 会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="bizType">开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional)</param>
        /// <param name="templateId">会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional)</param>
        /// <param name="requestId">查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardActivateformQueryResponseModel</returns>
        ApiResponse<AlipayMarketingCardActivateformQueryResponseModel> QueryWithHttpInfo(string authToken = default(string), string bizType = default(string), string templateId = default(string), string requestId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayMarketingCardActivateformApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 查询用户提交的会员卡表单信息
        /// </summary>
        /// <remarks>
        /// 会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="bizType">开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional)</param>
        /// <param name="templateId">会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional)</param>
        /// <param name="requestId">查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayMarketingCardActivateformQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayMarketingCardActivateformQueryResponseModel> QueryAsync(string authToken = default(string), string bizType = default(string), string templateId = default(string), string requestId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询用户提交的会员卡表单信息
        /// </summary>
        /// <remarks>
        /// 会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="bizType">开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional)</param>
        /// <param name="templateId">会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional)</param>
        /// <param name="requestId">查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayMarketingCardActivateformQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayMarketingCardActivateformQueryResponseModel>> QueryWithHttpInfoAsync(string authToken = default(string), string bizType = default(string), string templateId = default(string), string requestId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayMarketingCardActivateformApi : IAlipayMarketingCardActivateformApiSync, IAlipayMarketingCardActivateformApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayMarketingCardActivateformApi : IAlipayMarketingCardActivateformApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardActivateformApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingCardActivateformApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardActivateformApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingCardActivateformApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayMarketingCardActivateformApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayMarketingCardActivateformApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayMarketingCardActivateformApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayMarketingCardActivateformApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 查询用户提交的会员卡表单信息 会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="bizType">开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional)</param>
        /// <param name="templateId">会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional)</param>
        /// <param name="requestId">查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardActivateformQueryResponseModel</returns>
        public AlipayMarketingCardActivateformQueryResponseModel Query(string authToken = default(string), string bizType = default(string), string templateId = default(string), string requestId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardActivateformQueryResponseModel> localVarResponse = QueryWithHttpInfo(authToken, bizType, templateId, requestId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询用户提交的会员卡表单信息 会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="bizType">开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional)</param>
        /// <param name="templateId">会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional)</param>
        /// <param name="requestId">查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardActivateformQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardActivateformQueryResponseModel> QueryWithHttpInfo(string authToken = default(string), string bizType = default(string), string templateId = default(string), string requestId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (authToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "auth_token", authToken));
            }
            if (bizType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_type", bizType));
            }
            if (templateId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "template_id", templateId));
            }
            if (requestId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "request_id", requestId));
            }

            localVarRequestOptions.Operation = "AlipayMarketingCardActivateformApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayMarketingCardActivateformQueryResponseModel>("/v3/alipay/marketing/card/activateform/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingCardActivateformQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询用户提交的会员卡表单信息 会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="bizType">开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional)</param>
        /// <param name="templateId">会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional)</param>
        /// <param name="requestId">查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayMarketingCardActivateformQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayMarketingCardActivateformQueryResponseModel> QueryAsync(string authToken = default(string), string bizType = default(string), string templateId = default(string), string requestId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardActivateformQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(authToken, bizType, templateId, requestId, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询用户提交的会员卡表单信息 会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="bizType">开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional)</param>
        /// <param name="templateId">会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional)</param>
        /// <param name="requestId">查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayMarketingCardActivateformQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardActivateformQueryResponseModel>> QueryWithHttpInfoAsync(string authToken = default(string), string bizType = default(string), string templateId = default(string), string requestId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (authToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "auth_token", authToken));
            }
            if (bizType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_type", bizType));
            }
            if (templateId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "template_id", templateId));
            }
            if (requestId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "request_id", requestId));
            }

            localVarRequestOptions.Operation = "AlipayMarketingCardActivateformApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayMarketingCardActivateformQueryResponseModel>("/v3/alipay/marketing/card/activateform/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
