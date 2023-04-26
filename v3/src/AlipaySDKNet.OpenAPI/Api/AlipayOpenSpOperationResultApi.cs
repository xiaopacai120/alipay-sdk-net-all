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
    public interface IAlipayOpenSpOperationResultApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 查询服务商代运营操作结果
        /// </summary>
        /// <remarks>
        /// 查询服务商代运营操作（代运营授权或者账号绑定）结果。提供两种查询方式： 方式一：operate_type + batch_no，提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 方式一查询方式优先级更高。 方式二：operate_type + access_product_code + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中。 方式三：operate_type + isv_scene_permissions + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中（仅支持查询授权结果）。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operateType">代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。 (optional)</param>
        /// <param name="batchNo">支付宝操作批次号。 batch_no提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 注意： 1.access_product_code、merchant_no、alipay_account三个参数组合与传入 batch_no 为两种查询方式，不可同时为空且以 batch_no 优先。 2.access_product_code、merchant_no、alipay_account三个参数组合可以查询最终代运营操作结果。 (optional)</param>
        /// <param name="accessProductCode">接入的产品编号。未传batch_no时必填，枚举如下： OPENAPI_BIND_DEFAULT：操作类型为账号绑定； OPENAPI_AUTH_DEFAULT：操作类型为代运营授权。 (optional)</param>
        /// <param name="merchantNo">支付宝商户号。支持间连、直连商户，值为2088开头。 未传batch_no时需注意： 若查询间连商户则 merchant_no 必填；  若查询直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="alipayAccount">支付宝登录账号，通常为手机号或者邮箱。未传batch_no时需注意： 1.当查询merchant_no为间连商户时：   * 若 operate_type&#x3D;ACCOUNT_BIND，则alipay_account必填。   * 若 operate_type&#x3D;OPERATION_AUTH，则alipay_account无需传入。 2.当查询merchant_no为直连商户时：   * merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="isvScenePermissions">场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayOpenSpOperationResultQueryResponseModel</returns>
        AlipayOpenSpOperationResultQueryResponseModel Query(string operateType = default(string), string batchNo = default(string), string accessProductCode = default(string), string merchantNo = default(string), string alipayAccount = default(string), string isvScenePermissions = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询服务商代运营操作结果
        /// </summary>
        /// <remarks>
        /// 查询服务商代运营操作（代运营授权或者账号绑定）结果。提供两种查询方式： 方式一：operate_type + batch_no，提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 方式一查询方式优先级更高。 方式二：operate_type + access_product_code + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中。 方式三：operate_type + isv_scene_permissions + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中（仅支持查询授权结果）。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operateType">代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。 (optional)</param>
        /// <param name="batchNo">支付宝操作批次号。 batch_no提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 注意： 1.access_product_code、merchant_no、alipay_account三个参数组合与传入 batch_no 为两种查询方式，不可同时为空且以 batch_no 优先。 2.access_product_code、merchant_no、alipay_account三个参数组合可以查询最终代运营操作结果。 (optional)</param>
        /// <param name="accessProductCode">接入的产品编号。未传batch_no时必填，枚举如下： OPENAPI_BIND_DEFAULT：操作类型为账号绑定； OPENAPI_AUTH_DEFAULT：操作类型为代运营授权。 (optional)</param>
        /// <param name="merchantNo">支付宝商户号。支持间连、直连商户，值为2088开头。 未传batch_no时需注意： 若查询间连商户则 merchant_no 必填；  若查询直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="alipayAccount">支付宝登录账号，通常为手机号或者邮箱。未传batch_no时需注意： 1.当查询merchant_no为间连商户时：   * 若 operate_type&#x3D;ACCOUNT_BIND，则alipay_account必填。   * 若 operate_type&#x3D;OPERATION_AUTH，则alipay_account无需传入。 2.当查询merchant_no为直连商户时：   * merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="isvScenePermissions">场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayOpenSpOperationResultQueryResponseModel</returns>
        ApiResponse<AlipayOpenSpOperationResultQueryResponseModel> QueryWithHttpInfo(string operateType = default(string), string batchNo = default(string), string accessProductCode = default(string), string merchantNo = default(string), string alipayAccount = default(string), string isvScenePermissions = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayOpenSpOperationResultApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 查询服务商代运营操作结果
        /// </summary>
        /// <remarks>
        /// 查询服务商代运营操作（代运营授权或者账号绑定）结果。提供两种查询方式： 方式一：operate_type + batch_no，提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 方式一查询方式优先级更高。 方式二：operate_type + access_product_code + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中。 方式三：operate_type + isv_scene_permissions + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中（仅支持查询授权结果）。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operateType">代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。 (optional)</param>
        /// <param name="batchNo">支付宝操作批次号。 batch_no提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 注意： 1.access_product_code、merchant_no、alipay_account三个参数组合与传入 batch_no 为两种查询方式，不可同时为空且以 batch_no 优先。 2.access_product_code、merchant_no、alipay_account三个参数组合可以查询最终代运营操作结果。 (optional)</param>
        /// <param name="accessProductCode">接入的产品编号。未传batch_no时必填，枚举如下： OPENAPI_BIND_DEFAULT：操作类型为账号绑定； OPENAPI_AUTH_DEFAULT：操作类型为代运营授权。 (optional)</param>
        /// <param name="merchantNo">支付宝商户号。支持间连、直连商户，值为2088开头。 未传batch_no时需注意： 若查询间连商户则 merchant_no 必填；  若查询直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="alipayAccount">支付宝登录账号，通常为手机号或者邮箱。未传batch_no时需注意： 1.当查询merchant_no为间连商户时：   * 若 operate_type&#x3D;ACCOUNT_BIND，则alipay_account必填。   * 若 operate_type&#x3D;OPERATION_AUTH，则alipay_account无需传入。 2.当查询merchant_no为直连商户时：   * merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="isvScenePermissions">场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayOpenSpOperationResultQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayOpenSpOperationResultQueryResponseModel> QueryAsync(string operateType = default(string), string batchNo = default(string), string accessProductCode = default(string), string merchantNo = default(string), string alipayAccount = default(string), string isvScenePermissions = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询服务商代运营操作结果
        /// </summary>
        /// <remarks>
        /// 查询服务商代运营操作（代运营授权或者账号绑定）结果。提供两种查询方式： 方式一：operate_type + batch_no，提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 方式一查询方式优先级更高。 方式二：operate_type + access_product_code + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中。 方式三：operate_type + isv_scene_permissions + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中（仅支持查询授权结果）。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operateType">代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。 (optional)</param>
        /// <param name="batchNo">支付宝操作批次号。 batch_no提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 注意： 1.access_product_code、merchant_no、alipay_account三个参数组合与传入 batch_no 为两种查询方式，不可同时为空且以 batch_no 优先。 2.access_product_code、merchant_no、alipay_account三个参数组合可以查询最终代运营操作结果。 (optional)</param>
        /// <param name="accessProductCode">接入的产品编号。未传batch_no时必填，枚举如下： OPENAPI_BIND_DEFAULT：操作类型为账号绑定； OPENAPI_AUTH_DEFAULT：操作类型为代运营授权。 (optional)</param>
        /// <param name="merchantNo">支付宝商户号。支持间连、直连商户，值为2088开头。 未传batch_no时需注意： 若查询间连商户则 merchant_no 必填；  若查询直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="alipayAccount">支付宝登录账号，通常为手机号或者邮箱。未传batch_no时需注意： 1.当查询merchant_no为间连商户时：   * 若 operate_type&#x3D;ACCOUNT_BIND，则alipay_account必填。   * 若 operate_type&#x3D;OPERATION_AUTH，则alipay_account无需传入。 2.当查询merchant_no为直连商户时：   * merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="isvScenePermissions">场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayOpenSpOperationResultQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayOpenSpOperationResultQueryResponseModel>> QueryWithHttpInfoAsync(string operateType = default(string), string batchNo = default(string), string accessProductCode = default(string), string merchantNo = default(string), string alipayAccount = default(string), string isvScenePermissions = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayOpenSpOperationResultApi : IAlipayOpenSpOperationResultApiSync, IAlipayOpenSpOperationResultApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayOpenSpOperationResultApi : IAlipayOpenSpOperationResultApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpOperationResultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenSpOperationResultApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpOperationResultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenSpOperationResultApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayOpenSpOperationResultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayOpenSpOperationResultApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayOpenSpOperationResultApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayOpenSpOperationResultApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 查询服务商代运营操作结果 查询服务商代运营操作（代运营授权或者账号绑定）结果。提供两种查询方式： 方式一：operate_type + batch_no，提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 方式一查询方式优先级更高。 方式二：operate_type + access_product_code + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中。 方式三：operate_type + isv_scene_permissions + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中（仅支持查询授权结果）。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operateType">代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。 (optional)</param>
        /// <param name="batchNo">支付宝操作批次号。 batch_no提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 注意： 1.access_product_code、merchant_no、alipay_account三个参数组合与传入 batch_no 为两种查询方式，不可同时为空且以 batch_no 优先。 2.access_product_code、merchant_no、alipay_account三个参数组合可以查询最终代运营操作结果。 (optional)</param>
        /// <param name="accessProductCode">接入的产品编号。未传batch_no时必填，枚举如下： OPENAPI_BIND_DEFAULT：操作类型为账号绑定； OPENAPI_AUTH_DEFAULT：操作类型为代运营授权。 (optional)</param>
        /// <param name="merchantNo">支付宝商户号。支持间连、直连商户，值为2088开头。 未传batch_no时需注意： 若查询间连商户则 merchant_no 必填；  若查询直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="alipayAccount">支付宝登录账号，通常为手机号或者邮箱。未传batch_no时需注意： 1.当查询merchant_no为间连商户时：   * 若 operate_type&#x3D;ACCOUNT_BIND，则alipay_account必填。   * 若 operate_type&#x3D;OPERATION_AUTH，则alipay_account无需传入。 2.当查询merchant_no为直连商户时：   * merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="isvScenePermissions">场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayOpenSpOperationResultQueryResponseModel</returns>
        public AlipayOpenSpOperationResultQueryResponseModel Query(string operateType = default(string), string batchNo = default(string), string accessProductCode = default(string), string merchantNo = default(string), string alipayAccount = default(string), string isvScenePermissions = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenSpOperationResultQueryResponseModel> localVarResponse = QueryWithHttpInfo(operateType, batchNo, accessProductCode, merchantNo, alipayAccount, isvScenePermissions, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询服务商代运营操作结果 查询服务商代运营操作（代运营授权或者账号绑定）结果。提供两种查询方式： 方式一：operate_type + batch_no，提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 方式一查询方式优先级更高。 方式二：operate_type + access_product_code + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中。 方式三：operate_type + isv_scene_permissions + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中（仅支持查询授权结果）。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operateType">代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。 (optional)</param>
        /// <param name="batchNo">支付宝操作批次号。 batch_no提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 注意： 1.access_product_code、merchant_no、alipay_account三个参数组合与传入 batch_no 为两种查询方式，不可同时为空且以 batch_no 优先。 2.access_product_code、merchant_no、alipay_account三个参数组合可以查询最终代运营操作结果。 (optional)</param>
        /// <param name="accessProductCode">接入的产品编号。未传batch_no时必填，枚举如下： OPENAPI_BIND_DEFAULT：操作类型为账号绑定； OPENAPI_AUTH_DEFAULT：操作类型为代运营授权。 (optional)</param>
        /// <param name="merchantNo">支付宝商户号。支持间连、直连商户，值为2088开头。 未传batch_no时需注意： 若查询间连商户则 merchant_no 必填；  若查询直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="alipayAccount">支付宝登录账号，通常为手机号或者邮箱。未传batch_no时需注意： 1.当查询merchant_no为间连商户时：   * 若 operate_type&#x3D;ACCOUNT_BIND，则alipay_account必填。   * 若 operate_type&#x3D;OPERATION_AUTH，则alipay_account无需传入。 2.当查询merchant_no为直连商户时：   * merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="isvScenePermissions">场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayOpenSpOperationResultQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenSpOperationResultQueryResponseModel> QueryWithHttpInfo(string operateType = default(string), string batchNo = default(string), string accessProductCode = default(string), string merchantNo = default(string), string alipayAccount = default(string), string isvScenePermissions = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (operateType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "operate_type", operateType));
            }
            if (batchNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "batch_no", batchNo));
            }
            if (accessProductCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "access_product_code", accessProductCode));
            }
            if (merchantNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_no", merchantNo));
            }
            if (alipayAccount != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "alipay_account", alipayAccount));
            }
            if (isvScenePermissions != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "isv_scene_permissions", isvScenePermissions));
            }

            localVarRequestOptions.Operation = "AlipayOpenSpOperationResultApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayOpenSpOperationResultQueryResponseModel>("/v3/alipay/open/sp/operation/result/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayOpenSpOperationResultQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询服务商代运营操作结果 查询服务商代运营操作（代运营授权或者账号绑定）结果。提供两种查询方式： 方式一：operate_type + batch_no，提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 方式一查询方式优先级更高。 方式二：operate_type + access_product_code + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中。 方式三：operate_type + isv_scene_permissions + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中（仅支持查询授权结果）。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operateType">代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。 (optional)</param>
        /// <param name="batchNo">支付宝操作批次号。 batch_no提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 注意： 1.access_product_code、merchant_no、alipay_account三个参数组合与传入 batch_no 为两种查询方式，不可同时为空且以 batch_no 优先。 2.access_product_code、merchant_no、alipay_account三个参数组合可以查询最终代运营操作结果。 (optional)</param>
        /// <param name="accessProductCode">接入的产品编号。未传batch_no时必填，枚举如下： OPENAPI_BIND_DEFAULT：操作类型为账号绑定； OPENAPI_AUTH_DEFAULT：操作类型为代运营授权。 (optional)</param>
        /// <param name="merchantNo">支付宝商户号。支持间连、直连商户，值为2088开头。 未传batch_no时需注意： 若查询间连商户则 merchant_no 必填；  若查询直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="alipayAccount">支付宝登录账号，通常为手机号或者邮箱。未传batch_no时需注意： 1.当查询merchant_no为间连商户时：   * 若 operate_type&#x3D;ACCOUNT_BIND，则alipay_account必填。   * 若 operate_type&#x3D;OPERATION_AUTH，则alipay_account无需传入。 2.当查询merchant_no为直连商户时：   * merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="isvScenePermissions">场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayOpenSpOperationResultQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayOpenSpOperationResultQueryResponseModel> QueryAsync(string operateType = default(string), string batchNo = default(string), string accessProductCode = default(string), string merchantNo = default(string), string alipayAccount = default(string), string isvScenePermissions = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenSpOperationResultQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(operateType, batchNo, accessProductCode, merchantNo, alipayAccount, isvScenePermissions, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询服务商代运营操作结果 查询服务商代运营操作（代运营授权或者账号绑定）结果。提供两种查询方式： 方式一：operate_type + batch_no，提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 方式一查询方式优先级更高。 方式二：operate_type + access_product_code + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中。 方式三：operate_type + isv_scene_permissions + merchant_no + alipay_account 参数组合，可以查询代运营操作最终结果，任意一个操作批次成功都会体现在最终结果中（仅支持查询授权结果）。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operateType">代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。 (optional)</param>
        /// <param name="batchNo">支付宝操作批次号。 batch_no提供基于操作批次的精确查询，只查询本操作批次的代运营操作结果，不反映最终代运营操作结果。 注意： 1.access_product_code、merchant_no、alipay_account三个参数组合与传入 batch_no 为两种查询方式，不可同时为空且以 batch_no 优先。 2.access_product_code、merchant_no、alipay_account三个参数组合可以查询最终代运营操作结果。 (optional)</param>
        /// <param name="accessProductCode">接入的产品编号。未传batch_no时必填，枚举如下： OPENAPI_BIND_DEFAULT：操作类型为账号绑定； OPENAPI_AUTH_DEFAULT：操作类型为代运营授权。 (optional)</param>
        /// <param name="merchantNo">支付宝商户号。支持间连、直连商户，值为2088开头。 未传batch_no时需注意： 若查询间连商户则 merchant_no 必填；  若查询直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="alipayAccount">支付宝登录账号，通常为手机号或者邮箱。未传batch_no时需注意： 1.当查询merchant_no为间连商户时：   * 若 operate_type&#x3D;ACCOUNT_BIND，则alipay_account必填。   * 若 operate_type&#x3D;OPERATION_AUTH，则alipay_account无需传入。 2.当查询merchant_no为直连商户时：   * merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。 (optional)</param>
        /// <param name="isvScenePermissions">场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayOpenSpOperationResultQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenSpOperationResultQueryResponseModel>> QueryWithHttpInfoAsync(string operateType = default(string), string batchNo = default(string), string accessProductCode = default(string), string merchantNo = default(string), string alipayAccount = default(string), string isvScenePermissions = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (operateType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "operate_type", operateType));
            }
            if (batchNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "batch_no", batchNo));
            }
            if (accessProductCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "access_product_code", accessProductCode));
            }
            if (merchantNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_no", merchantNo));
            }
            if (alipayAccount != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "alipay_account", alipayAccount));
            }
            if (isvScenePermissions != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "isv_scene_permissions", isvScenePermissions));
            }

            localVarRequestOptions.Operation = "AlipayOpenSpOperationResultApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayOpenSpOperationResultQueryResponseModel>("/v3/alipay/open/sp/operation/result/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
