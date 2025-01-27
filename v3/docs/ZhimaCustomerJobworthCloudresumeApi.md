# AlipaySDKNet.OpenAPI.Api.ZhimaCustomerJobworthCloudresumeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](ZhimaCustomerJobworthCloudresumeApi.md#query) | **GET** /v3/zhima/customer/jobworth/cloudresume/query | 智能简历基本数据查询


<a name="query"></a>
# **Query**
> ZhimaCustomerJobworthCloudresumeQueryResponseModel Query (string connKey = null, string onceToken = null)

智能简历基本数据查询

用于查询工作证基本信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AlipaySDKNet.OpenAPI.Api;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace Example
{
    public class QueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZhimaCustomerJobworthCloudresumeApi(config);

            // 设置alipayConfig参数
            AlipayConfig alipayConfig = new AlipayConfig();
            alipayConfig.AppId = "app_id";
            alipayConfig.PrivateKey = "private_key";
            // 密钥模式
            alipayConfig.AlipayPublicKey = "alipay_public_key";
            // 证书模式
            // alipayConfig.AppCertPath = "../appCertPublicKey.crt";
            // alipayConfig.AlipayPublicCertPath = "../alipayCertPublicKey_RSA2.crt";
            // alipayConfig.RootCertPath = "../alipayRootCert.crt";
            alipayConfig.EncryptKey = "encrypt_key";
            AlipayConfigUtil alipayConfigUtil = new AlipayConfigUtil(alipayConfig);
            apiInstance.Client.SetAlipayConfigUtil(alipayConfigUtil);

            var connKey = uuid;  // string | 长效的认证令牌 (optional) 
            var onceToken = uuid;  // string | 交换云简历的单次token (optional) 

            try
            {
                // 智能简历基本数据查询
                ZhimaCustomerJobworthCloudresumeQueryResponseModel result = apiInstance.Query(connKey, onceToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCustomerJobworthCloudresumeApi.Query: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connKey** | **string**| 长效的认证令牌 | [optional] 
 **onceToken** | **string**| 交换云简历的单次token | [optional] 

### Return type

**ZhimaCustomerJobworthCloudresumeQueryResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

